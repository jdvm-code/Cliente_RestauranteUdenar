using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Comida
    {
        //#[Fillable(['tipo'])]
        public int id { get; set; }
        public string tipo { get; set; }
    }

    public class ComidaRequest
    {
        public string tipo { get; set; }
    }

    public class ComidaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public Comida Data { get; set; }
    }
}
