using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
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

        public async Task<string> StoreEstReservaAsync(string status)
        {
            var request = new EstadoReservaRequest { status = status };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/estado-reserva", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetEstReservaAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/estado-reserva");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateEstReservaAsync(string id, string status)
        {
            var request = new EstadoReservaRequest { status = status };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/estado-reserva/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteEstReservaAsync(string id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/estado-reserva/{id}");
            return await response.Content.ReadAsStringAsync();
        }

    }
}
