using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.DTO
{
    public class Reportes
    {
        public class FaltasResponse
        {
            public string status { get; set; }
            public int becas_id { get; set; }
            public int total_inasistencias { get; set; }
        }

    }
}
