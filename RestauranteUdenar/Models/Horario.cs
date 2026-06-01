using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Horario
    {
        //#[Fillable(['hora_inicio', 'hora_fin', 'cupo'])]
        public int id { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }
        public int cupo { get; set; }

        }

        public class HorarioRequest
        {
            public string hora_inicio { get; set; }
            public string hora_fin { get; set; }
            public int Cupo { get; set; }
        }

        public class HorarioResponse
        {
            public bool success { get; set; }
            public string message { get; set; }
            public Horario horario { get; set; }
        }
    }

