using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace RestauranteUdenar.Views
{
    public partial class LoginView : Form
    {
        private readonly UsuarioController _controller;
        public LoginView()
        {
            InitializeComponent();

            _controller = new UsuarioController();
            var token = TokenStorage.GetToken();

            txtEmail.Text = "juan.perez@udenar.edu.co";
            txtPassword.Text = "123456789123456";
            ValidarRol();

        }

        public async Task<string> ValidarRol()
        {
            int userId = int.Parse(TokenStorage.GetUserId());
            string message = $"Usuario ID: {userId}";
            return message;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            await _controller.LoginAsync(email, password);
            {
                (bool exito, string mensaje) = await _controller.LoginAsync(email, password);
                if (exito)
                {
                    int roleId = await ObtenerIdRoleAsync();

                    MessageBox.Show($" numero de rol {roleId}");
                    if (roleId == 2)
                    {
                        Form vista = new PanelAdminView();
                        vista.Show();
                        this.Hide();
                    }
                    else if (roleId != 2)
                    {
                        Form vista = new PanelBecasView();
                        vista.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rol no reconocido", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensaje, "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void LoginView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Session.CerrarSesion();
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            Form vista = new RegisterView();
            vista.Show();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
        }

        public async Task<int> ObtenerIdRoleAsync()
        {
            var json = await _controller.meAsync();
            var response = JsonSerializer.Deserialize<Usuario>(json);
            return response.role_id;
        }
    }
}
