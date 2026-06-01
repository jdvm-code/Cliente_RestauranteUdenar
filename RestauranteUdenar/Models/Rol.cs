using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Rol
    {
        public int id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
    }

    public class RoleRequest
    {
        public string name { get; set; }    
        public string short_name { get; set; }
    }

    public class RolResponse
    {
        public string success { get; set; }
        public string message { get; set; }
        public Rol Role { get; set; }
    }


}
