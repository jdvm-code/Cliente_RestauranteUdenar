using RestauranteUdenar.Properties;
using System;
using System.Configuration;

namespace RestauranteUdenar.Properties
{
    public static class TokenStorage
    {
        /// <summary>
        ///// Guarda el token de autenticación en la configuración de la aplicación.
        /// </summary>
        /// <param name="token"></param>
        public static void SaveToken(string token)
        {
            Properties.Settings.Default.AuthToken = token;
            Properties.Settings.Default.Save();
        }

        public static string GetToken()
        {
            return Properties.Settings.Default.AuthToken ?? string.Empty;
        }

        public static void ClearToken()
        {
            Properties.Settings.Default.AuthToken = string.Empty;
            Properties.Settings.Default.Save();
        }

        public static bool HasToken()
        {
            return !string.IsNullOrEmpty(GetToken());
        }

        internal static void SaveToken(object token)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
            
        public static void SaveUserId(int userId)
        {
            Properties.Settings.Default.UserId = userId;
            Properties.Settings.Default.Save();
        }

        public static string GetUserId()
        {
            return Properties.Settings.Default.UserId.ToString();
        }

        public static void ClearUserId()
        {
            Properties.Settings.Default.UserId = 0;
            Properties.Settings.Default.Save();
        }   

        public static bool HasUserId()
        {
            return Properties.Settings.Default.UserId != 0;
        }

        internal static void SaveUserId(object userId)
        {
            throw new NotImplementedException();
        }



    }
}

