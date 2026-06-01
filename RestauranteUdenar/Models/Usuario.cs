using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int role_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class meResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int role_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }

    }


    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
        public Usuario user { get; set; }
    }

    public class LoginResponse
    {
        public string success { get; set; }
        public string message { get; set; }
        public string token { get; set; }
        public Usuario user { get; set; }
    }

    public class RegisterRequest
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }

    public class RegisterResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
    }
}
