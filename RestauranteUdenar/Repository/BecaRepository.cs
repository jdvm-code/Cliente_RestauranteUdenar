using RestauranteUdenar.Models;
using System;
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
        private void SetAuthHeader()
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);
        }

        public async Task<string> StoreBecaAsync(BecaRequest request)
        {
            SetAuthHeader();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/becas", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBecaAsync()
        {
            SetAuthHeader();
            var response = await _client.GetAsync($"{_baseUrl}/becas");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetBecaByUserIdAsync(int user_id)
        {
            SetAuthHeader();
            var response = await _client.GetAsync($"{_baseUrl}/becas/user/{user_id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();

        }

        public async Task<string> UpdateBecaAsync(int id, BecaRequest request)
        {
            SetAuthHeader();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/becas/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteBecaAsync(int id)
        {
            SetAuthHeader();
            var response = await _client.DeleteAsync($"{_baseUrl}/becas/{id}");
            return await response.Content.ReadAsStringAsync();
        }


    }
}
