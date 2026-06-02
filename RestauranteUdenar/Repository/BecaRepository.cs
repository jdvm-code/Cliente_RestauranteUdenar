using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class BecaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public BecaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }
        private void AgregarToken()
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);
        }

        
        // GET - Verificar beca activa
        public async Task<ApiResponse<Beca>> GetBecaActivaByUsuarioAsync(int userId)
        {
            try
            {
                AgregarToken();
                var response = await _client.GetAsync($"{_baseUrl}/becas/usuario/{userId}/activa");
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject < ApiResponse < Beca >> (content);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        // POST - Solicitar beca
        public async Task<ApiResponse<Beca>> SolicitarBecaAsync(int userId)
        {
            try
            {
                AgregarToken();

                var solicitud = new
                {
                    users_id = userId,
                    fecha_registro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    fecha_solicitud = DateTime.Now.ToString("yyyy-MM-dd")
                };

                var json = JsonConvert.SerializeObject(solicitud);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync($"{_baseUrl}/becas/solicitar", content);
                var responseContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject < ApiResponse < Beca >> (responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        // PUT - Activar beca (admin)
        public async Task<ApiResponse<Beca>> ActivarBecaAsync(int becaId)
        {
            try
            {
                AgregarToken();
                var response = await _client.PutAsync($"{_baseUrl}/becas/{becaId}/activar", null);
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject < ApiResponse < Beca >> (content);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }

        public async Task<ApiResponse<List<Beca>>> GetBecasPorEstadoAsync(int estadoId)
        {
            try
            {
                AgregarToken();

                var response = await _client.GetAsync($"{_baseUrl}/becas?estado={estadoId}");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                return JsonConvert.DeserializeObject < ApiResponse < List < Beca >>> (responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}
