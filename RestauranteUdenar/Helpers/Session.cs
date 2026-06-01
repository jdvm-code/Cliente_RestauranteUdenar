using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteUdenar.Helpers
{
    using RestauranteUdenar.Models;
    using RestauranteUdenar.Properties;

    public static class Session
    {
        public static Usuario UsuarioActual { get; set; }
        public static string Token => TokenStorage.GetToken();
        public static string User_id => TokenStorage.GetUserId(); 

        public static bool EstaLogueado => UsuarioActual != null && TokenStorage.HasToken();
        public static void seLogueo(Usuario usuario, string token)
        {
            UsuarioActual = usuario;
            TokenStorage.SaveToken(token);
            TokenStorage.SaveUserId(usuario.id);
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
            TokenStorage.ClearToken();
        }
    }
}
