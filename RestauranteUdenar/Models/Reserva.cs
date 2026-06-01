using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Reserva
    {
        //#[Fillable(['becas_id', 'horarios_id', 'comidas_id', 'estados_reservas_id', 'fecha_registro', 'fecha_reserva', 'codigo'])]
        public int id { get; set; }
        public int becas_id { get; set; }
        public int horarios_id { get; set; }
        public int comidas_id { get; set; }
        public int estados_reservas_id { get; set; }
        public string fecha_registro {  get; set; }
        public string fecha_reserva { get; set; }
        public string Codigo { get; set; }

    }

    public class ReservaRequest
    {
        public int becas_id { get; set; }
        public int horarios_id { get; set; }
        public int comidas_id { get; set; }
        public int estados_reservas_id { get; set; }
        public string fecha_registro { get; set; }
        public string fecha_reserva { get; set; }
        public string Codigo { get; set; }

    }

    public class ReservaResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public Reserva data { get; set; }

    }


}
