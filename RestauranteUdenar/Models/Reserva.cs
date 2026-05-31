using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Reserva
    {
        //#[Fillable(['becas_id', 'horarios_id', 'comidas_id', 'estados_reservas_id', 'fecha_registro', 'fecha_reserva', 'codigo'])]
        public int Id { get; set; }
        public int Becas_id { get; set; }
        public int Horario_id { get; set; }
        public int Estados_reservas_id { get; set; }
        public DateTime Fecha_registro {  get; set; }
        public DateTime Fecha_reserva { get; set; }
        public string Codigo { get; set; }

    }

    public class ReservaRequest
    {
        public int Becas_id { get; set; }
        public int Horario_id { get; set; }
        public int Estados_reservas_id { get; set; }
        public DateTime Fecha_registro { get; set; }
        public DateTime Fecha_reserva { get; set; }
        public string Codigo { get; set; }

    }

    public class ReservaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Reserva data { get; set; }

    }
}
