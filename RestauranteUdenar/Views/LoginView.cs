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

            txtEmail.Text = "Juancho@udenar.com";
            //jdvm@gmail.com
            txtPassword.Text = "123";

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            (bool exito, string mensaje, Usuario usuario) = await _controller.LoginAsync(email, password);

            if (exito && usuario != null)
            {
                Form vista;

                if (usuario.role_id == 1)
                {
                    vista = new PanelAdminView();      
                }
                else if (usuario.role_id == 2)
                {
                    vista = new PanelBecasView(); 
                }
                else
                {
                    MessageBox.Show("Rol no reconocido: " + usuario.role_id,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                vista.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mensaje, "Error de autenticación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
