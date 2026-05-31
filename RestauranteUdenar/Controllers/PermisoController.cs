using Newtonsoft.Json;
using RestauranteUdenar.Models;
using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Controllers
{
    public class PermisoController
    {
        private readonly PermisoRepository _permisoRepository;

        public PermisoController()
        {
            _permisoRepository = new PermisoRepository();
        }

        public async Task<(bool exito, string mensaje)> StorePermisoAsync(string name, string short_name)
        {
            try
            {
                var json = await _permisoRepository.StorePermisoAsync(name, short_name);
                var response = JsonConvert.DeserializeObject<PermisoResponse>(json);
                return (true, "Permiso creado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje, List<Permiso> permisos)> GetPermisosAsync()
        {
            try
            {
                var json = await _permisoRepository.GetPermisosAsync();
                var permisos = JsonConvert.DeserializeObject<List<Permiso>>(json);
                return (true, "Permisos obtenidos exitosamente", permisos);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool exito, string mensaje)> UpdatePermisoAsync(int id, string name, string short_name)
        {
            try
            {
                var json = await _permisoRepository.UpdatePermisoAsync(id, name, short_name);
                var response = JsonConvert.DeserializeObject<PermisoResponse>(json);
                return (true, "Permiso actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool exito, string mensaje)> DeletePermisoAsync(int id)
        {
            try
            {
                var json = await _permisoRepository.DeletePermisoAsync(id);
                var response = JsonConvert.DeserializeObject<PermisoResponse>(json);
                return (true, "Permiso eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

    }
}
