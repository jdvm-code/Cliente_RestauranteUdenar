using RestauranteUdenar.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            txtEmail.Text = "juan.perez@udenar.edu.co";
            txtPassword.Text = "123456789";

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            _controller.LoginAsync(email, password);
            {
                (bool exito, string mensaje) = await _controller.LoginAsync(email, password);
                if (exito)
                {
                    Form vista = new PanelBecasView();
                    vista.Show();
                    this.Hide();
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
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            Form vista = new RegisterView();
            vista.Show();   
        }
    }
}
