using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Beca
    {
        //#[Fillable(['fecha_inicio', 'fecha_fin', 'estados_becas_id', 'users_id'])]
        public int Id { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public int Estados_beca_id { get; set; }
        public int User_id { get; set; }
    }
}
