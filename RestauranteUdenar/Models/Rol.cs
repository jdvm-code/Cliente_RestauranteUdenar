using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    public class RoleRequest
    {
        public string Name { get; set; }    
        public string ShortName { get; set; }
    }

    public class RolResponse
    {
        public string success { get; set; }
        public string message { get; set; }
        public Rol Role { get; set; }
    }


}
