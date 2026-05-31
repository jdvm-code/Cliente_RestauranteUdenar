using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
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

        public async Task<(bool exito, string mensaje)> StoreReservaAsync(int becas_id, int horario_id, int estados_resevas_id,
            DateTime fecha_registro, DateTime fecha_reserva)
        {
            try
            {
                var json = await _reservaRepository.StoreReservaAsync(becas_id, horario_id, estados_resevas_id, fecha_registro, fecha_reserva);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> UpdateReservaAsync(int estados_resevas_id, int id)
        {
            try
            {
                var json = await _reservaRepository.UpdateReservaAsync(estados_resevas_id, id);
                var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
                return (response.success, response.message);
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
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
