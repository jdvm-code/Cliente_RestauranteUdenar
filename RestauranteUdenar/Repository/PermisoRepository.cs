using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class PermisoRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;
        public PermisoRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);

        }

        public async Task<string> StorePermisoAsync(string name, string short_name)
        {
            var request = new PermisoRequest { Name = name, ShortName = short_name };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/permisos", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPermisosAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/permisos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdatePermisoAsync(int id, string name, string short_name)
        {
            var request = new PermisoRequest { Name = name, ShortName = short_name };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/permisos/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeletePermisoAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/permisos/{id}");
            return await response.Content.ReadAsStringAsync();
        }

    }
}
