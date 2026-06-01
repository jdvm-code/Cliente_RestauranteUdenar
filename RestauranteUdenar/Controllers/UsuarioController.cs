// Controllers/UsuarioController.cs
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Repository;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;

public class UsuarioController
{
    private readonly UsuarioRepository _repository;

    // Inyección de dependencias (puedes usar una fábrica simple)
    public UsuarioController()
    {
        _repository = new UsuarioRepository();
    }

    //registro: llama Repository → devuelve resultado
    public async Task<(bool exito, string mensaje)> RegistrarAsync(RegisterRequest request)
    {
        try
        {
            var json = await _repository.RegisterAsync(request);
            var response = JsonConvert.DeserializeObject<RegisterResponse>(json);
            return (response.success, response.message);
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
            var json = await _repository.LoginAsync(email, password);
            var response = JsonConvert.DeserializeObject<LoginResponse>(json);
            bool esExitoso = response.success == "true" || response.success == "True";
            if (esExitoso)
            {
                TokenStorage.SaveToken(response.token);
                TokenStorage.SaveUserId(response.user.id);
                return (true, "Login exitoso");
            }
            else
            {
                return (false, response.message);
            }
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<string> ListarUsuariosAsync()
    {
        var token = TokenStorage.GetToken();
        return await _repository.GetUsuariosAsync(token);
    }

    public async Task CerrarSesionAsync()
    {
        try
        {
            var token = TokenStorage.GetToken();
            if (!string.IsNullOrEmpty(token))
            {
                await _repository.LogoutAsync(token); 
            }
        }
        catch
        {
        }
        finally
        {
            Session.CerrarSesion(); // ← Limpia token local
        }
    }

}

