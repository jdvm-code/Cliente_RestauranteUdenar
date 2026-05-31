using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RestauranteUdenar.Repository
{
    public class EstadoBecaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public EstadoBecaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> StoreEstBecaAsync(string status)
        {
            var request = new EstadoBecaRequest { status = status };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/estado-beca", content);
            return await response.Content.ReadAsStringAsync();

        }
        public async Task<string> GetEstBecaAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/estado-beca");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> UpdateEstBecaAsync(string id, string status)
        {
            var request = new EstadoBecaRequest { status = status };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/estado-beca/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> DeleteEstBecaAsync(string id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/estado-beca/{id}");
            return await response.Content.ReadAsStringAsync();

        }
    }

}
