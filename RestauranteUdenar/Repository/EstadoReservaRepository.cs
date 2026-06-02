using Newtonsoft.Json;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Responses;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class EstadoReservaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public EstadoReservaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        private void AgregarToken()
        {
            if (!string.IsNullOrEmpty(Session.Token))
            {
                _client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Session.Token);
            }
        }

        public async Task<ApiResponse<List<EstadoReserva>>> GetEstadosAsync()
        {
            try
            {
                AgregarToken();

                var response = await _client.GetAsync($"{_baseUrl}/estado-reserva");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Error {response.StatusCode}: {responseContent}");
                }

                return JsonConvert.DeserializeObject < ApiResponse < List < EstadoReserva >>> (responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
    }
}

