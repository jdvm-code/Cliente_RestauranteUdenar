using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestauranteUdenar.Controllers
{
    public class HorarioController
    {
        private readonly HorarioRepository _horarioRepository;

        public HorarioController()
        {
            _horarioRepository = new HorarioRepository();
        }

        public async Task<(bool exito, string mensaje, List<Horario> horarios)> GetHorariosAsync()
        {
            try
            {
                var json = await _horarioRepository.GetHorariosAsync();

                if (string.IsNullOrEmpty(json))
                {
                    return (false, "El servidor devolvió una respuesta vacía", null);
                }

                var horarios = JsonConvert.DeserializeObject<List<Horario>>(json);

                if (horarios == null)
                {
                    return (false, "No se pudieron deserializar los horarios", null);
                }

                return (true, "Horarios obtenidos exitosamente", horarios);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }
    }
}