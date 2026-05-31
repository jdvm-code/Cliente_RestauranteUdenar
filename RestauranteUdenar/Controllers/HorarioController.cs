using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class HorarioController
    {
        private readonly HorarioRepository _horarioRepository;

        public HorarioController()
        {
            _horarioRepository = new HorarioRepository();
        }
        
        public async Task<(bool exito, string mensaje)> StoreHorarioAsync(string hora_inicio, string hora_fin)
        {
            try
            {
                var json = await _horarioRepository.StoreHorarioAsync(hora_inicio, hora_fin);
                var response = JsonConvert.DeserializeObject<HorarioResponse>(json);
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public async Task<(bool exito, string mensaje, List<Horario> roles)> GetHorariosAsync()
        {
            try
            {
                var json = await _horarioRepository.GetHorariosAsync();
                var horarios = JsonConvert.DeserializeObject<List<Horario>>(json);
                return (true, "Horarios obtenidos exitosamente", horarios);
                
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

       
    }
}
