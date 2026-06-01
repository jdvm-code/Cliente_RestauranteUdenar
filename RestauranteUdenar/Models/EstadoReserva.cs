using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
//#[Fillable(['status'])]

    public class EstadoReserva
    {
        public int id { get; set; }
        public string status { get; set; }
    }

    public class EstadoReservaRequest
    {
        public string status { get; set; }
    }

    public class EstadoReservaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public EstadoReserva estadoReserva { get; set; }

    }

}
