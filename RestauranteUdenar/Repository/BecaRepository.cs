using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
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

        public async Task<string> StoreBecaAsync(BecaRequest request)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/beca", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBecaAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/beca");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBecaByUserIdAsync(int userId)
        {
            var response = await _client.GetAsync($"{_baseUrl}/beca/user/{userId}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

        }

        public async Task<string> UpdateBecaAsync(int id, BecaRequest request)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/beca/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteBecaAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/beca/{id}");
            return await response.Content.ReadAsStringAsync();
        }


    }
}
