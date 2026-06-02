using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class ComidaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public ComidaRepository(string baseUrl = "http://127.0.0.1:8000/api")
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


        public async Task<string> StoreComidaAsync(string tipo)
        {
            var request = new ComidaRequest { tipo = tipo };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/comida", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<ApiResponse<List<Comida>>> GetIndexComidasAsync()
        {
            try
            {
                AgregarToken();

                var response = await _client.GetAsync($"{_baseUrl}/comida");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        throw new Exception("Token inválido o expirado. Debe iniciar sesión nuevamente.");
                    }
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                var apiResponse = JsonConvert.DeserializeObject<ApiResponse<List<Comida>>>(responseContent);

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

        public void DeleteComida(string tipo)
        {
            var response = _client.DeleteAsync($"{_baseUrl}/comida/{tipo}").Result;
        }
        public void UpdateComida(string tipo, string newTipo)
        {
            var request = new ComidaRequest { tipo = newTipo };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = _client.PutAsync($"{_baseUrl}/comida/{tipo}", content).Result;
        }
    

    }
}
