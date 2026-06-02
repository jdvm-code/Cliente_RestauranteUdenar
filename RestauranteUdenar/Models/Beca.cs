using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Beca
    {
        //#[Fillable(['fecha_inicio', 'fecha_fin', 'estados_becas_id', 'users_id'])]
        public int id { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public int estados_becas_id { get; set; }
        public int users_id { get; set; }


        public Usuario usuario { get; set; }
    }
}
