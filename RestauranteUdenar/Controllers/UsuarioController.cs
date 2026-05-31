// Controllers/UsuarioController.cs
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Repository;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

public class UsuarioController
{
    private readonly UsuarioRepository _repository;

    // Inyección de dependencias (puedes usar una fábrica simple)
    public UsuarioController()
    {
        _repository = new UsuarioRepository();
    }

    //registro: llama Repository → devuelve resultado
    public async Task<(bool exito, string mensaje)> RegistrarAsync(string name, string email, string password,string role)
    {
        try
        {
            var json = await _repository.RegisterAsync(name, email, password, role);
            var response = JsonConvert.DeserializeObject<ReservaResponse>(json);
            return (response.status, response.message);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    // login: llama Repository → guarda token → devuelve resultado
    public async Task<(bool exito, string mensaje)> LoginAsync(string email, string password)
    {
        try
        {
            var response = await _repository.LoginAsync(email, password);

            if (response.success && !string.IsNullOrEmpty(response.token))
            {
                // Guardar token (como FavoritosManager guarda favoritos)
                TokenStorage.SaveToken(response.token);

                // Guardar en sesión en memoria
                Session.UsuarioActual = response.user;

                return (true, $"Bienvenido {response.user.name}");
            }

            return (false, response.message);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<string> ListarUsuariosAsync()
    {
        var token = Session.Token;
        return await _repository.GetUsuariosAsync(token);
    }

    public async Task CerrarSesionAsync()
    {
        try
        {
            var token = Session.Token;
            if (!string.IsNullOrEmpty(token))
            {
                await _repository.LogoutAsync(token); // ← Llamada API
            }
        }
        catch
        {
            // Si falla la API, igual limpiamos local
        }
        finally
        {
            Session.CerrarSesion(); // ← Limpia token local
        }
    }

}
