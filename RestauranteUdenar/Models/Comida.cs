using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Comida
    {
        //#[Fillable(['tipo'])]
        public int Id { get; set; }
        public string Tipo { get; set; }
    }

    public class ComidaRequest
    {
        public string Tipo { get; set; }
    }

    public class ComidaResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string error { get; set; }
        public Comida Data { get; set; }
    }
}
