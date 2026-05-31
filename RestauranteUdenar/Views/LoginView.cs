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
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            var (exito, mensaje) = await _controller.LoginAsync(txtEmail.Text, txtPassword.Text);

            if (exito)
            {
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir MainForm (como Form1 abre otra vista)
                var main = new PanelBecasView();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

            btnLogin.Enabled = true;
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
