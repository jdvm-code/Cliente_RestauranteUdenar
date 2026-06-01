using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class ReservaController
    {
        private readonly ReservaRepository _reservaRepository;

        public ReservaController()
        {
            _reservaRepository = new ReservaRepository();
        }

        public ReservaController(ReservaRepository reservaRepository)
        {
            if (reservaRepository != null)
                _reservaRepository = reservaRepository;
            else
                _reservaRepository = new ReservaRepository();
        }

        public async Task<(bool exito, string mensaje)> StoreReservaAsync(ReservaRequest request)
        {
            try
            {
                var json = await _reservaRepository.StoreReservaAsync(request);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
                bool esExito = response.status == "success";

                return (esExito, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, Reserva data)> GetReservaByIdAsync(int id)
        {
            try
            {
                var json = await _reservaRepository.GetReservaByIdAsync(id);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);

                bool esExito = response.status == "success";

                return (esExito, response.message, response.data);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }



        public async Task<(bool exito, string mensaje)> UpdateReservaAsync(int estados_resevas_id, int id)
        {
            try
            {
                var json = await _reservaRepository.UpdateReservaAsync(estados_resevas_id, id);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
                bool esExito = response.status == "success";

                return (esExito, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> VerificarQrAsync(int estados_resevas_id, int id)
        {
            try
            {
                var json = await _reservaRepository.VerificarQrAsync(estados_resevas_id, id);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
                bool esExito = response.status == "success";

                return (esExito, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<ResevaCodigoResponse> data)> 
    GetCodigoReservaDia(int becas_id)
        {
            try
            {
                var json = await _reservaRepository.GetCodigoReservaDia(becas_id);

                // ✅ CORREGIDO: List<<ReservaCodigoResponse> con < > simples
                var listaCodigos = JsonConvert.DeserializeObject < List < ResevaCodigoResponse >> (json);

                if (listaCodigos == null || listaCodigos.Count == 0)
                {
                    return (false, "No hay reservas para hoy", null);
                }

                return (true, $"{listaCodigos.Count} reserva(s) encontrada(s)", listaCodigos);
            }
            catch (JsonException ex)
            {
                return (false, $"Error al procesar respuesta: {ex.Message}", null);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }
    }
}
