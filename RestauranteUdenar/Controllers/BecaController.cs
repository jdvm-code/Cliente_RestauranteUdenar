using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class BecaController
    {
        private readonly BecaRepository _becaRepository;

        public BecaController(BecaRepository becaRepository)
        {
            _becaRepository = becaRepository;
        }

        public async Task<(bool exito, string mensaje)> StoreBecaAsync(BecaRequest request)
        {
            try
            {
                var json = await _becaRepository.StoreBecaAsync(request);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<BecaResponse>(json);
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<Beca> becas)> GetBecaAsync()
        {
            try
            {
                var json = await _becaRepository.GetBecaAsync();
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Beca>>(json);
                return (true, "Becas obtenidas", response);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool exito, string mensaje, Beca beca)> GetBecaByUserIdAsync(int userId)
        {
            try
            {
                var json = await _becaRepository.GetBecaByUserIdAsync(userId);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<BecaResponse>(json);
                return (response.success, response.message, response.Data);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }

        }

        public async Task<(bool exito, string mensaje)> UpdateBecaAsync(int id, BecaRequest request)
        {
            try
            {
                var json = await _becaRepository.UpdateBecaAsync(id, request);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<BecaResponse>(json);
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> DeleteBecaAsync(int id)
        {
            try
            {
                var json = await _becaRepository.DeleteBecaAsync(id);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<BecaResponse>(json);
                return (response.success, response.message);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }

        }
    }
}
