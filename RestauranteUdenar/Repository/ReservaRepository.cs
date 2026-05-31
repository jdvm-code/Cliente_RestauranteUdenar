using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class ReservaRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;
        public ReservaRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> StoreReservaAsync(int becas_id, int horario_id, int estados_resevas_id,
            DateTime fecha_registro, DateTime fecha_reserva)
        {
            var request = new ReservaRequest
            {
                Becas_id = becas_id,
                Horario_id = horario_id,
                Estados_reservas_id = estados_resevas_id,
                Fecha_registro = fecha_registro,
                Fecha_reserva = fecha_reserva
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/reservas", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetReservasAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/reservas");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateReservaAsync(int estados_resevas_id, int id)
        {
            var request = new ReservaRequest
            {
                Estados_reservas_id = estados_resevas_id,
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/reservas/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> VerificarQrAsync(int codigo, int id)
        {
            var request = new ReservaRequest
            {
                Codigo = codigo.ToString()
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/verificar-qr", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
