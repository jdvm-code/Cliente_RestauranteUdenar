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

        //login
        public async Task<string> LoginAsync(string email, string password)
        {
            var body = new {email, password };
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/login", content);
            return await response.Content.ReadAsStringAsync();
        }

        //registro
        public async Task<string> RegisterAsync(RegisterRequest request)
        {
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/register", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetUsuariosAsync(string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            return await _client.GetStringAsync($"{_baseUrl}/usuarios");
        }

        public async Task<string> GetUsuarioByIdAsync(int id, string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            return await _client.GetStringAsync($"{_baseUrl}/usuarios/{id}");
        }

        public async Task<string> UpdateUsuarioAsync(int id, Usuario usuario, string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var json = JsonSerializer.Serialize(usuario);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/usuarios/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        //cambiar contraseña
        public async Task<string> CambiarPasswordAsync(string passwordActual, string passwordNuevo, string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var body = new { password_actual = passwordActual, password = passwordNuevo };
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/cambiar-password", content);
            return await response.Content.ReadAsStringAsync();
        }

        //logout
        public async Task<string> LogoutAsync(string token)
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.PostAsync($"{_baseUrl}/logout", null);
            return await response.Content.ReadAsStringAsync();


        }
    }
}