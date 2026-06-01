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
    }

    public class BecaRequest
    {
        public int users_id { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public int estados_beca_id { get; set; }
    }

    public class BecaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public Beca beca { get; set; }
    }
}
