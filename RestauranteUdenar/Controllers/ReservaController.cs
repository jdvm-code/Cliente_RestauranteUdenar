using Newtonsoft.Json;
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
    public class ReservaController
    {
        private readonly ReservaRepository _reservaRepository;

        public ReservaController()
        {
            _reservaRepository = new ReservaRepository();
        }

        public async Task<ApiResponse<List<Reserva>>> GetAllReservasAsync(string fecha = null, int? estado = null, int? comida = null)
        {
            try
            {
                var response = await _reservaRepository.GetAllReservasAsync(fecha, estado, comida);

                if (response == null)
                {
                    return new ApiResponse<List<Reserva>>
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
                return new ApiResponse<List<Reserva>>
                {
                    success = false,
                    message = "Error al obtener reservas",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Reserva>> ConfirmarReservaAsync(int reservaId)
        {
            try
            {
                var response = await _reservaRepository.ConfirmarReservaAsync(reservaId);

                if (response == null)
                {
                    return new ApiResponse<Reserva>
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
                return new ApiResponse<Reserva>
                {
                    success = false,
                    message = "Error al confirmar",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Reserva>> CancelarReservaAsync(int reservaId)
        {
            try
            {
                var response = await _reservaRepository.CancelarReservaAsync(reservaId);

                if (response == null)
                {
                    return new ApiResponse<Reserva>
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
                return new ApiResponse<Reserva>
                {
                    success = false,
                    message = "Error al cancelar",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<List<Reserva>>> GetReservasByUsuarioYFechaAsync(int usuarioId, string fecha)
        {
            try
            {
                var response = await _reservaRepository.GetReservasByUsuarioYFechaAsync(usuarioId, fecha);

                if (response == null)
                {
                    return new ApiResponse<List<Reserva>>
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
                return new ApiResponse<List<Reserva>>
                {
                    success = false,
                    message = "Error al obtener reservas",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Reserva>> CrearReservaAsync(object reservaData)
        {
            try
            {
                var response = await _reservaRepository.CrearReservaAsync(reservaData);

                if (response == null)
                {
                    return new ApiResponse<Reserva>
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
                return new ApiResponse<Reserva>
                {
                    success = false,
                    message = "Error al crear la reserva",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Reserva>> MarcarAsistenciaAsync(string codigo)
        {
            try
            {
                var response = await _reservaRepository.MarcarAsistenciaAsync(codigo);

                if (response == null)
                {
                    return new ApiResponse<Reserva>
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
                return new ApiResponse<Reserva>
                {
                    success = false,
                    message = "Error al marcar asistencia",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }
    }
}



