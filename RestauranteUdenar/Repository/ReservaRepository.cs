using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class ReservaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;
        public ReservaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        private void AgregarToken()
        {
            var token = TokenStorage.GetToken();
            if (!string.IsNullOrEmpty(token))
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        // GET todas las reservas (con filtros)
        public async Task<ApiResponse<List<Reserva>>> GetAllReservasAsync(string fecha = null, int? estado = null, int? comida = null)
        {
            try
            {
                AgregarToken();

                // Construir URL con query params
                var queryParams = new List< string > ();
                if (!string.IsNullOrEmpty(fecha)) queryParams.Add($"fecha={fecha}");
                if (estado.HasValue) queryParams.Add($"estado={estado.Value}");
                if (comida.HasValue) queryParams.Add($"comida={comida.Value}");

                string url = $"{_baseUrl}/reservas";
                if (queryParams.Count > 0)
                {
                    url += "?" + string.Join("&", queryParams);
                }

                var response = await _client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                return JsonConvert.DeserializeObject < ApiResponse < List < Reserva >>> (responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        // PUT confirmar
        public async Task<ApiResponse<Reserva>> ConfirmarReservaAsync(int reservaId)
        {
            try
            {
                AgregarToken();
                var response = await _client.PutAsync($"{_baseUrl}/reservas/{reservaId}/confirmar", null);
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject < ApiResponse < Reserva >> (content);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        // PUT cancelar
        public async Task<ApiResponse<Reserva>> CancelarReservaAsync(int reservaId)
        {
            try
            {
                AgregarToken();
                var response = await _client.PutAsync($"{_baseUrl}/reservas/{reservaId}/cancelar", null);
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject < ApiResponse < Reserva >> (content);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<Reserva>>> GetReservasByUsuarioYFechaAsync(int usuarioId, string fecha)
        {
            try
            {
                AgregarToken();

                var response = await _client.GetAsync($"{_baseUrl}/reservas/usuario/{usuarioId}/fecha/{fecha}");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("Token inválido o expirado.");
                    }
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                var apiResponse = JsonConvert.DeserializeObject < ApiResponse < List < Reserva >>> (responseContent);

                if (apiResponse == null)
                {
                    throw new Exception("La respuesta de la API no tiene el formato esperado.");
                }

                return apiResponse;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión: {ex.Message}");
            }
        }

        public async Task<ApiResponse<Reserva>> CrearReservaAsync(object reservaData)
        {
            try
            {
                AgregarToken();

                var json = JsonConvert.SerializeObject(reservaData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync($"{_baseUrl}/reserva", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("Token inválido o expirado. Debe iniciar sesión nuevamente.");
                    }
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                var apiResponse = JsonConvert.DeserializeObject <ApiResponse < Reserva >> (responseContent);

                if (apiResponse == null)
                {
                    throw new Exception("La respuesta de la API no tiene el formato esperado.");
                }

                return apiResponse;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"Error de conexión: {ex.Message}");
            }
        }

        public async Task<ApiResponse<Reserva>> MarcarAsistenciaAsync(string codigo)
        {
            try
            {
                AgregarToken();

                var body = new { codigo = codigo };
                var json = JsonConvert.SerializeObject(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync($"{_baseUrl}/reservas/asistencia", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                return JsonConvert.DeserializeObject < ApiResponse < Reserva >> (responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

    }
}
