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

        public async Task<string> StoreRolAsync(string name, string short_name)
        {
            var request = new RoleRequest { Name = name, ShortName = short_name };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/roles", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRolesAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/roles");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateRolAsync(string id, string name, string short_name)
        {
            var request = new RoleRequest { Name = name, ShortName = short_name };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/roles/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteRolAsync(string id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/roles/{id}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
