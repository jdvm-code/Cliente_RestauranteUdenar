using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Models
{
    //modelo de usuario segun la api
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int role_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    // login request
    public class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    // respuesta login
    public class LoginResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string token { get; set; }
        public Usuario user { get; set; }
    }

    //register
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
