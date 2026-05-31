using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Horario
    {
        //#[Fillable(['hora_inicio', 'hora_fin', 'cupo'])]
        public int Id { get; set; }
        public TimeOnly Hora_inicio { get; set; }
        public TimeOnly Hora_fin {  get; set; }

    }

    public class HorarioRequest
    {
        public TimeOnly Hora_inicio { get; set; }
        public TimeOnly Hora_fin { get; set; }
        public int Cupo { get; set; }
    }

    public class HorarioResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public Horario horario { get; set; }
    }
}
