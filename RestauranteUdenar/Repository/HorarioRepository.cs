using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Responses;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteUdenar.Repository
{
    public class HorarioRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public HorarioRepository(string baseUrl = "http://127.0.0.1:8000/api")
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

        public async Task<ApiResponse<List<Horario>>> GetIndexAsync()
        {
            try
            {
                AgregarToken();

                var response = await _client.GetAsync($"{_baseUrl}/horario");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("Token inválido o expirado. Debe iniciar sesión nuevamente.");
                    }
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Horario>>>(responseContent);

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
        public async Task<string> StoreHorarioAsync(string hora_inicio, string hora_fin, int cupo)
        {
            AgregarToken();

            var request = new HorarioRequest
            {
                hora_inicio = hora_inicio,
                hora_fin = hora_fin,
                Cupo = cupo
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/horario", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
            }

            return responseContent;
        }

        public async Task<string> UpdateHorarioAsync(string hora_inicio, string hora_fin, int cupo, int id)
        {
            AgregarToken();

            var request = new HorarioRequest
            {
                hora_inicio = hora_inicio,
                hora_fin = hora_fin,
                Cupo = cupo
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/horario/{id}", content);
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
            }

            return responseContent;
        }

        public async Task<string> DeleteHorarioAsync(int id)
        {
            AgregarToken();

            var response = await _client.DeleteAsync($"{_baseUrl}/horario/{id}");
            var responseContent = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
            }

            return responseContent;
        }
    }
}