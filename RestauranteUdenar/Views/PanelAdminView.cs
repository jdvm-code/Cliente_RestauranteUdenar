using RestauranteUdenar.Views.Admin_UserControls;
using System;
using System.Windows.Forms;

namespace RestauranteUdenar.Views
{
    public partial class PanelAdminView : Form
    {
        private UsuarioController _userController;

        public PanelAdminView()
        {
            InitializeComponent();
            _userController = new UsuarioController();
        }

        private void MostrarVista(UserControl vistaFormulario)
        {
            // Limpiar controles anteriores
            Panel_UC_ControlsAdmin.Controls.Clear();

            // Configurar el UserControl
            vistaFormulario.Dock = DockStyle.Fill;

            // Agregar al panel
            Panel_UC_ControlsAdmin.Controls.Add(vistaFormulario);

            // Forzar actualización
            vistaFormulario.BringToFront();
            Panel_UC_ControlsAdmin.Refresh();
        }

        private void PanelAdminView_Load(object sender, EventArgs e)
        {
            // Mostrar gestión de reservas por defecto
            btnGestionReservas_Click(null, null);
        }

        private async void PanelAdminView_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                await _userController.CerrarSesionAsync();
                var login = new LoginView();
                login.Show();
                this.Close();
            }
        }

        private void btnGestionReservas_Click(object sender, EventArgs e)
        {
            var ucGestionReservas = new Uc_GestionReservas();
            MostrarVista(ucGestionReservas);
        }

        private void btnGestionBecas_Click(object sender, EventArgs e)
        {
            var ucGestionBecas = new UC_GestionBecas();
            MostrarVista(ucGestionBecas);
        }

        private void btnVerificarCodigo_Click(object sender, EventArgs e)
        {
            var ucVerificarCodigo = new UC_VerificarCodigo();
            MostrarVista(ucVerificarCodigo);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            var ucGestionUsuarios = new UC_GestionUsuarios();
            MostrarVista(ucGestionUsuarios);
        }

        private async void btnCerrarSesion_Click(object sender, EventArgs e)
        {
        }
    }
}