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
    }
}
