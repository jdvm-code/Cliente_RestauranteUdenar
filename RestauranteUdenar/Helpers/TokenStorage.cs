using System;
using System.Configuration;

namespace RestauranteUdenar.Properties
{
    public static class TokenStorage
    {
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
    }
}

