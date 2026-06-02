using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using RestauranteUdenar.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestauranteUdenar.Controllers
{
    public class HorarioController
    {
        private readonly HorarioRepository _horarioRepository;

        public HorarioController()
        {
            _horarioRepository = new HorarioRepository();
        }

        public async Task<ApiResponse<List<Horario>>> GetHorariosAsync()
        {
            try
            {
                var response = await _horarioRepository.GetIndexAsync();

                if (response == null)
                {
                    return new ApiResponse<List<Horario>>
                    {
                        success = false,
                        message = "El servidor devolvió una respuesta vacía",
                        data = null,
                        error = "Respuesta nula del repositorio"
                    }
                    ;
                }
                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<List<Horario>>
                {
                    success = false,
                    message = "Error al obtener horarios",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }
    }
}