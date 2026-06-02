using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using RestauranteUdenar.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class ComidaController
    {
        private readonly ComidaRepository _comidaRepository;

        public ComidaController()
        {
            _comidaRepository = new ComidaRepository();
        }

        public async Task<ApiResponse<List<Comida>>> GetComidaAsync()
        {
            try
            {
                var response = await _comidaRepository.GetIndexComidasAsync();

                if (response == null)
                {
                    return new ApiResponse<List<Comida>>
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
                return new ApiResponse<List<Comida>>
                {
                    success = false,
                    message = "Error al obtener comidas",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }


    }
}
