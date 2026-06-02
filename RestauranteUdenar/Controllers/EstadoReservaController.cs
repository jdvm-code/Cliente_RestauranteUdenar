using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using RestauranteUdenar.Responses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestauranteUdenar.Controllers
{
    public class EstadoReservaController
    {
        private readonly EstadoReservaRepository _estadoReservaRepository;

        public EstadoReservaController()
        {
            _estadoReservaRepository = new EstadoReservaRepository();
        }

        public async Task<ApiResponse<List<EstadoReserva>>> GetEstadosAsync()
        {
            try
            {
                var response = await _estadoReservaRepository.GetEstadosAsync();

                if (response == null)
                {
                    return new ApiResponse<List< EstadoReserva >>
                    {
                        success = false,
                        message = "Respuesta vacía",
                        data = null,
                        error = "No se recibió respuesta"
                    }
                    ;
                }

                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<List< EstadoReserva >>
                {
                    success = false,
                    message = "Error al obtener estados",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }


    } 
}
