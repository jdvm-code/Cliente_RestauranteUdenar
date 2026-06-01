using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Permiso
    {
        //#[Fillable(['name', 'short_name'])]
        public string id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }

    }

    public class PermisoRequest
    {
        public string name { get; set; }
        public string short_name { get; set; }
    }

    public class PermisoResponse
    {
        public string success { get; set; }
        public string message { get; set; }
        public Rol Role { get; set; }
    }
}
