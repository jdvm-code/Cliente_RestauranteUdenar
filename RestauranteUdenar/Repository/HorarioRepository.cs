using Newtonsoft.Json;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Repository
{

    public class HorarioRepository
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public HorarioRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }
         public async Task<string> StoreHorarioAsync(TimeOnly horario_inicio, TimeOnly hora_fin, int cupo)
         {
            var request = new HorarioRequest
            {
                Hora_inicio = horario_inicio,
                Hora_fin = hora_fin,
                Cupo = cupo
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}/horarios", content);
            return await response.Content.ReadAsStringAsync();
         }

        public async Task<string> GetHorariosAsync()
        {
            var response = await _client.GetAsync($"{_baseUrl}/horarios");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> UpdateHorarioAsync(TimeOnly hora_inicio, TimeOnly hora_fin, int cupo, int id)
        {
            var request = new HorarioRequest
            {
                Hora_inicio = hora_inicio,
                Hora_fin = hora_fin,
                Cupo = cupo
            };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}/horarios/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> DeleteHorarioAsync(int id)
        {
            var response = await _client.DeleteAsync($"{_baseUrl}/horarios/{id}");
            return await response.Content.ReadAsStringAsync();
        }

        internal async Task<string> StoreHorarioAsync(string hora_inicio, string hora_fin)
        {
            throw new NotImplementedException();
        }
    }
}
