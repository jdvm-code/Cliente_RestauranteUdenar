using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RestauranteUdenar.Repository
{
    public class ReportesRepository
    {

        private readonly HttpClient _client;
        private readonly string _baseUrl;

        public ReportesRepository(string baseUrl = "http://127.0.0.1:8000/api")
        {
            _baseUrl = baseUrl;
            _client = new HttpClient();
            _client.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> EstudiantesInactivosAsync(string fechaInicio, string fechaFin)
        {
            SetAuthHeader();
            var response = await _client.GetAsync(
                $"{_baseUrl}/reportes/estudiantes-inactivos?fecha_inicio={fechaInicio}&fecha_fin={fechaFin}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> TraficoRestauranteAsync(string fechaInicio, string fechaFin)
        {
            SetAuthHeader();
            var response = await _client.GetAsync(
                $"{_baseUrl}/reportes/trafico-restaurante?fecha_inicio={fechaInicio}&fecha_fin={fechaFin}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> EstudiantesConInasistenciasAsync(string fechaInicio, string fechaFin)
        {
            SetAuthHeader();
            var response = await _client.GetAsync(
                $"{_baseUrl}/reportes/inasistencias?fecha_inicio={fechaInicio}&fecha_fin={fechaFin}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> FaltasBecadoAsync(int id)
        {
            SetAuthHeader();
            var response = await _client.GetAsync($"{_baseUrl}/becados/{id}/faltas");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private void SetAuthHeader()
        {
            _client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.AuthToken);
        }

    }
}
