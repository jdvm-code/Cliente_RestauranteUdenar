using RestauranteUdenar.Views.Admin_UserControls;
using RestauranteUdenar.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestauranteUdenar.Views
{
    public partial class PanelAdminView : Form
    {
        public PanelAdminView()
        {
            InitializeComponent();
        }

        private void MostrarVista(UserControl vistaFormulario)
        {
            Fpnl_UC_Controls.Controls.Clear();
            vistaFormulario.Dock = DockStyle.Fill;
            vistaFormulario.BringToFront();
            Fpnl_UC_Controls.Controls.Add(vistaFormulario);
        }

        private void btn_logoutAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificarCodigo_Click(object sender, EventArgs e)
        {
            UC_VerificarCodigo vista = new UC_VerificarCodigo();
            MostrarVista(vista);
        }

        private void btn_reportesAdmin_Click(object sender, EventArgs e)
        {
            UC_Reportes vista = new UC_Reportes();
            MostrarVista(vista);
        }

        private void btn_reservasAdmin_Click(object sender, EventArgs e)
        {
            UC_Resevas vista = new UC_Resevas();
            MostrarVista(vista);
        }

       

    }
}
