using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class RolController
    {
        private readonly RolRepository _repository;

        public RolController()
        {
            _repository = new RolRepository();
        }

        public async Task<(bool exito, string mensaje)> StoreRolAsync(string name, string short_name)
        {
            try
            {
                var json = await _repository.StoreRolAsync(name, short_name);
                var response = JsonConvert.DeserializeObject<RolResponse>(json);
                return (true, "Rol creado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        // Tu método async que devuelve la tupla
        public async Task<(bool exito, string mensaje, List<Rol> roles)> GetRolesAsync()
        {
            try
            {
                var json = await _repository.GetRolesAsync();
                var roles = JsonConvert.DeserializeObject<List<Rol>>(json);
                return (true, "Roles obtenidos exitosamente", roles);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }
    }
}

