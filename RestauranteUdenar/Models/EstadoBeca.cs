using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class EstadoBeca
    {
        //#[Fillable(['status'])]
        public int id { get; set; }
        public string status { get; set; }
    }

    public class EstadoBecaRequest
    {
        public string status { get; set; }
    }

    public class EstadoBecaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public EstadoBeca estadoBeca { get; set; }

    }
}
