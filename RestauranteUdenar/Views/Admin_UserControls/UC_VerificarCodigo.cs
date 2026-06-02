using System;
using System.Drawing;
using System.Windows.Forms;
using RestauranteUdenar.Controllers;

namespace RestauranteUdenar.Views.Admin_UserControls
{
    public partial class UC_VerificarCodigo : UserControl
    {
        private readonly ReservaController _reservaController;

        public UC_VerificarCodigo()
        {
            InitializeComponent();
            _reservaController = new ReservaController();
        }

        private async void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                lblResultado.Text = "⚠️ Ingrese un código";
                lblResultado.ForeColor = Color.Orange;
                return;
            }

            var response = await _reservaController.MarcarAsistenciaAsync(codigo);

            if (response.success)
            {
                lblResultado.Text = "✅ Asistencia registrada";
                lblResultado.ForeColor = Color.Green;
                txtCodigo.Clear();
            }
            else
            {
                lblResultado.Text = "❌ " + (response.error ?? response.message);
                lblResultado.ForeColor = Color.Red;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            lblResultado.Text = "";
        }

        private void UC_VerificarCodigo_Load(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            lblResultado.Text = "";
            lblResultado.ForeColor = Color.Black;
        }

        private async void btnVerificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}