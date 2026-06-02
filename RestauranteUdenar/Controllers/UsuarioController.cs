// Controllers/UsuarioController.cs
using Newtonsoft.Json;
using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Repository;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public class UsuarioController
{
    private readonly UsuarioRepository _repository;
    private readonly BecaController becaController;


    public UsuarioController()
    {
        _repository = new UsuarioRepository();
        becaController = new BecaController();
    }

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

    public async Task<(bool exito, string mensaje, Usuario usuario)> LoginAsync(string email, string password)
    {
        try
        {
            var json = await _repository.LoginAsync(email, password);
            var response = JsonConvert.DeserializeObject < LoginResponse > (json);

            bool esExitoso = response.success == "true" || response.success == "True";

            if (esExitoso)
            {
                // Guardar token y usuario
                TokenStorage.SaveToken(response.token);
                TokenStorage.SaveUserId(response.user.id);

                // Guardar usuario completo en Session
                Session.seLogueo(response.user, response.token);

                return (true, "Login exitoso", response.user);
            }
            else
            {
                return (false, response.message, null);
            }
        }
        catch (Exception ex)
        {
            return (false, ex.Message, null);
        }
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
            Session.CerrarSesion();
        }
    }


}

