using RestauranteUdenar.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestauranteUdenar.Repository
{
    public class UsuarioRepository 
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public UsuarioRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        //POST /register
        public async Task<string> RegisterAsync(string name, string email, string password, string role)
        {
            var request = new RegisterRequest { name = name, email = email, password = password, role = role };
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/register", content);
            return await response.Content.ReadAsStringAsync();
        }

        // POST /login → igual que ConsultarApi() en ApiManagerPoke
        public async Task<LoginResponse> LoginAsync(string email, string password)
        {
            var request = new LoginRequest { email = email, password = password };
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync($"{_baseUrl}/login", content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error {response.StatusCode}: {responseString}");

            return JsonSerializer.Deserialize < LoginResponse > (responseString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        // GET /list 
        public async Task<string> GetUsuariosAsync(string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            return await _client.GetStringAsync($"{_baseUrl}/list");
        }

        // GET buscar por id = /find/{id}
        public async Task<string> GetUsuarioByIdAsync(int id, string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            return await _client.GetStringAsync($"{_baseUrl}/find/{id}");
        }

        // PUT /actualizar/{id}
        public async Task<string> UpdateUsuarioAsync(int id, Usuario usuario, string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var json = JsonSerializer.Serialize(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync($"{_baseUrl}/actualizar/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<bool> LogoutAsync(string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await _client.PostAsync($"{_baseUrl}/logout", null);
            return response.IsSuccessStatusCode;
        }


    }
}