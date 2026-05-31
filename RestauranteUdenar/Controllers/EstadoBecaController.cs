using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class EstadoBecaController
    {
        private readonly EstadoBecaRepository _estadoBecaRepository;

        public EstadoBecaController()
        {
            _estadoBecaRepository = new EstadoBecaRepository();
        }

        public async Task<(bool exito, string mensaje)> StoreEstadoBecaAsync(string status)
        {
            try
            {
                var json = await _estadoBecaRepository.StoreEstBecaAsync(status);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoBecaResponse>(json);
                return (true, "Estado de beca creado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<Models.EstadoBeca> estados)> GetEstadoBecaAsync()
        {
            try
            {
                var json = await _estadoBecaRepository.GetEstBecaAsync();
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.EstadoBeca>>(json);
                return (true, "Estados de beca obtenidos exitosamente", response);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }

        }

        public async Task<(bool exito, string mensaje)> UpdateEstadoBecaAsync(string id, string status)
        {
            try
            {
                var json = await _estadoBecaRepository.UpdateEstBecaAsync(id, status);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoBecaResponse>(json);
                return (true, "Estado de beca actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> DeleteEstadoBecaAsync(string id)
        {
            try
            {
                var json = await _estadoBecaRepository.DeleteEstBecaAsync(id);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.EstadoBecaResponse>(json);
                return (true, "Estado de beca eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
