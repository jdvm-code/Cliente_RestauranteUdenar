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
    public class BecaController
    {
        private readonly BecaRepository _becaRepository;

        public BecaController()
        {
            _becaRepository = new BecaRepository();
        }

        public async Task<ApiResponse<Beca>> GetBecaActivaByUsuarioAsync(int userId)
        {
            try
            {
                var response = await _becaRepository.GetBecaActivaByUsuarioAsync(userId);

                if (response == null)
                {
                    return new ApiResponse<Beca>
                    {
                        success = false,
                        message = "Respuesta vacía del servidor",
                        data = null,
                        error = "No se recibió respuesta"
                    }
                    ;
                }

                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<Beca>
                {
                    success = false,
                    message = "Error al buscar beca activa",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Beca>> SolicitarBecaAsync(int userId)
        {
            try
            {
                var response = await _becaRepository.SolicitarBecaAsync(userId);

                if (response == null)
                {
                    return new ApiResponse<Beca>
                    {
                        success = false,
                        message = "Respuesta vacía del servidor",
                        data = null,
                        error = "No se recibió respuesta"
                    }
                    ;
                }

                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<Beca>
                {
                    success = false,
                    message = "Error al solicitar beca",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<Beca>> ActivarBecaAsync(int becaId)
        {
            try
            {
                var response = await _becaRepository.ActivarBecaAsync(becaId);

                if (response == null)
                {
                    return new ApiResponse<Beca>
                    {
                        success = false,
                        message = "Respuesta vacía del servidor",
                        data = null,
                        error = "No se recibió respuesta"
                    }
                    ;
                }

                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse<Beca>
                {
                    success = false,
                    message = "Error al activar beca",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

        public async Task<ApiResponse<List<Beca>>> GetBecasPorEstadoAsync(int estadoId)
        {
            try
            {
                var response = await _becaRepository.GetBecasPorEstadoAsync(estadoId);

                if (response == null)
                {
                    return new ApiResponse<List<Beca>>
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
                return new ApiResponse<List<Beca>>
                {
                    success = false,
                    message = "Error al obtener solicitudes",
                    data = null,
                    error = ex.Message
                }
                ;
            }
        }

    }

}
