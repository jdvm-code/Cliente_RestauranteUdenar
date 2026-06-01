using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class EstadoReservaController
    {
        private readonly EstadoReservaRepository _estadoReservaRepository;

        public EstadoReservaController()
        {
            _estadoReservaRepository = new EstadoReservaRepository();
        }

        public async Task<(bool exito, string mensaje)> StoreEstadoReservaAsync(string status) 
        {
            try
            {
                var json = await _estadoReservaRepository.StoreEstadoReservaAsync(status);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoReservaResponse>(json);
                return (true, "Estado de reserva creado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<Models.EstadoReserva> estados)> GetEstadoReservaAsync()
        {
            try
            {
                var json = await _estadoReservaRepository.GetEstadosReservaAsync();
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.EstadoReserva>>(json);
                return (true, "Estados de reserva obtenidos exitosamente", response);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool exito, string mensaje)> UpdateEstadoReservaAsync(int id, string status)
        {
            try
            {
                var json = await _estadoReservaRepository.UpdateEstadoReservaAsync(id, status);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoReservaResponse>(json);
                return (true, "Estado de reserva actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> DeleteEstadoReservaAsync(int id)
        {
            try
            {
                var json = await _estadoReservaRepository.DeleteEstadoReservaAsync(id);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoReservaResponse>(json);
                return (true, "Estado de reserva eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

    }
}
