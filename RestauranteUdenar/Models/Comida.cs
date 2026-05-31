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
}
