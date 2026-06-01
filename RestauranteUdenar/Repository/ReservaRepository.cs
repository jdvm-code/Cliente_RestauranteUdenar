using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using System;
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

        private void SetAuthHeader()
        {
            var token = TokenStorage.GetToken(); // Usa TokenStorage en lugar de Settings
            if (!string.IsNullOrEmpty(token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }
        public async Task<string> StoreReservaAsync(ReservaRequest request)
        {
            SetAuthHeader();

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/reserva", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetReservasAsync()
        {
            SetAuthHeader();
            var response = await _client.GetAsync($"{_baseUrl}/reserva");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetReservaByIdAsync(int id)
        {
            SetAuthHeader();
            var response = await _client.GetAsync($"{_baseUrl}/reserva/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateReservaAsync(int estados_resevas_id, int id)
        {
            SetAuthHeader();
            var request = new ReservaRequest
            {
                estados_reservas_id = estados_resevas_id,
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/reserva/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> VerificarQrAsync(int codigo, int id)
        {
            SetAuthHeader();
            var request = new ReservaRequest
            {
                Codigo = codigo.ToString()
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/verificar-qr", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCodigoReservaDia(int becas_id)
        {
            try
            {
                // ✅ 1. Agregar token de autenticación
                SetAuthHeader();

                // ✅ 2. Hacer GET con el ID en la URL (sin body)
                var response = await _client.GetAsync($"{_baseUrl}/api/reservas/codigo-del-dia/{becas_id}");

                // ✅ 3. Verificar respuesta
                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException($"Error {response.StatusCode}: {errorContent}");
                }

                // ✅ 4. Retornar JSON crudo para que el controller lo deserialice
                return await response.Content.ReadAsStringAsync();
            }
            catch (System.Exception)
            {
                throw; // Re-lanzar para que el controller maneje
            }
        }


    }
}
