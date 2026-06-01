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

    public async Task<(bool exito, string mensaje)> LoginAsync(string email, string password)
    {
        try
        {
            var json = await _repository.LoginAsync(email, password);
            var response = JsonConvert.DeserializeObject < LoginResponse > (json);

            bool esExitoso = response.success == "true" || response.success == "True";

            if (esExitoso)
            {
                TokenStorage.SaveToken(response.token);
                TokenStorage.SaveUserId(response.user.id);

                await ObtenerBecasIdAsync(response.user.id);

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

    private async Task ObtenerBecasIdAsync(int userId)
    {
        try
        {
            var (exito, mensaje, beca) = await becaController.GetBecaByUserIdAsync(userId);

            if (exito && beca != null)
            {
                TokenStorage.SaveBecasId(beca.id);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al obtener beca: {ex.Message}");
        }
    }

    public async Task<string> ObtenerUsuarioPorIdAsync(int userId)
    {
        var token = TokenStorage.GetToken();
        return await _repository.GetUsuarioByIdAsync(userId, token);
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
            Session.CerrarSesion();
        }
    }

    public async Task <string> meAsync()
    {
        try
        {
            var token = TokenStorage.GetToken();
            if (!string.IsNullOrEmpty(token))
            {
                return await _repository.meAsync(token);

            }
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error en meAsync: {ex.Message}");
            return null;
        }
    }

}

