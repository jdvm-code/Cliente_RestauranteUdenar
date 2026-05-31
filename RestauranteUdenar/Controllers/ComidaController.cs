using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class ComidaController
    {
        private readonly ComidaRepository _comidaRepository;

        public ComidaController(ComidaRepository comidaRepository)
        {
            _comidaRepository = comidaRepository;
        }

        public async Task<(bool exito, string mensaje)> StoreComidaAsync(string status)
        {
            try
            {
                var json = await _comidaRepository.StoreComidaAsync(status);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.ComidaResponse>(json);
                return (true, "Tipo de comida guardado");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<Models.Comida> comidas)> GetComidaAsync()
        {
            try
            {
                var json = await _comidaRepository.GetComidaAsync();
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Comida>>(json);
                return (true, "Tipos de comida obtenidos", response);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }


        }

        public async Task<(bool exito, string mensaje)> DeleteComidaAsync(string tipo)
        {
            try
            {
                _comidaRepository.DeleteComida(tipo);
                return (true, "Tipo de comida eliminado");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> UpdateComidaAsync(string tipo, string newTipo)
        {
            try
            {
                _comidaRepository.UpdateComida(tipo, newTipo);
                return (true, "Tipo de comida actualizado");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
