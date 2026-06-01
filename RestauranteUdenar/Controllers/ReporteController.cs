using RestauranteUdenar.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static RestauranteUdenar.DTO.Reportes;

namespace RestauranteUdenar.Controllers
{
    public class ReporteController
    {
        private readonly ReportesRepository _reporteRepository;

        public ReporteController(ReportesRepository reporteRepository)
        {
            _reporteRepository = reporteRepository;
        }

        public async Task<(bool exito, int becas_id, int total_inasistencias)> FaltasBecadoAsync(int id)
        {
            try
            {
                var json = await _reporteRepository.FaltasBecadoAsync(id);
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<FaltasResponse>(json);

                bool esExitoso = response.status == "success";

                return (esExitoso, response.becas_id, response.total_inasistencias);
            }
            catch (Exception ex)
            {
                return (false, 0, 0);
            }
        }


    }
}
