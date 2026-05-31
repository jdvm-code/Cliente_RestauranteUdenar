using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class ComidaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public ComidaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> StoreComidaAsync(string tipo)
        {
            var request = new ComidaRequest { Tipo = tipo };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/comida", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetComidaAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/comida");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public void DeleteComida(string tipo)
        {
            var response = _client.DeleteAsync($"{_baseUrl}/comida/{tipo}").Result;
        }
        public void UpdateComida(string tipo, string newTipo)
        {
            var request = new ComidaRequest { Tipo = newTipo };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = _client.PutAsync($"{_baseUrl}/comida/{tipo}", content).Result;
        }
    

    }
}
