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

        public static bool EstaLogueado => UsuarioActual != null && TokenStorage.HasToken();

        public static void CerrarSesion()
        {
            UsuarioActual = null;
            TokenStorage.ClearToken();
        }
    }
}
