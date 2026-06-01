using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestauranteUdenar.Views
{
    public partial class RegisterView : Form
    {
        private readonly RolController _rolController;

        public RegisterView()
        {
            InitializeComponent();
            this.Load += RegisterView_Load;  // ← Conectar evento
            _rolController = new RolController();

        }

        private async void RegisterView_Load(object sender, EventArgs e)
        {
            await CargarRolesAsync();
        }

        private async Task CargarRolesAsync()
        {
            try
            {
                cmb_roles.Enabled = false;

                var (exito, mensaje, roles) = await _rolController.GetRolesAsync();

                if (exito && roles != null && roles.Count > 0)
                {
                    cmb_roles.DisplayMember = "name";
                    cmb_roles.ValueMember = "id";
                    cmb_roles.DataSource = roles;
                }
                else
                {
                    cmb_roles.DataSource = null; 
                    cmb_roles.Items.Clear();
                    cmb_roles.Items.Add("Error al cargar roles");
                }
            }
            catch (Exception ex)
            {
                cmb_roles.DataSource = null;
                cmb_roles.Items.Clear();
                cmb_roles.Items.Add("Error: " + ex.Message);

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmb_roles.Enabled = true;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            var rolSeleccionado = cmb_roles.SelectedItem as Rol;

            if (rolSeleccionado != null)
            {
                int rolId = rolSeleccionado.id;
                string rolName = rolSeleccionado.name;

                MessageBox.Show($"Rol seleccionado: {rolName} (ID: {rolId})");
            }
        }
    }
}
