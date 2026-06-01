using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class RolRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public RolRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        private void SetAuthHeader() =>
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);

        public async Task<string> GetRolesAsync()
        {
            SetAuthHeader();
            return await _client.GetStringAsync($"{_baseUrl}/roles");
        }

        public async Task<string> StoreRolAsync(string nombre, string shortName)
        {
            SetAuthHeader();
            var body = new { nombre };
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/roles", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateRolAsync(int id, string nombre)
        {
            SetAuthHeader();
            var body = new { nombre };
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/roles/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteRolAsync(int id)
        {
            SetAuthHeader();
            var response = await _client.DeleteAsync($"{_baseUrl}/roles/{id}");
            return await response.Content.ReadAsStringAsync();
        }

        // POST /roles/{id}/asignar-permiso
        public async Task<string> AsignarPermisoAsync(int rolId, int permisoId)
        {
            SetAuthHeader();
            var body = new { permiso_id = permisoId };
            var json = JsonConvert.SerializeObject(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/roles/{rolId}/asignar-permiso", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
