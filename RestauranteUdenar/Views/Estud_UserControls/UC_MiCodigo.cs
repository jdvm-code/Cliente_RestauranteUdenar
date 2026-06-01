using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestauranteUdenar.Views.UserControls
{
    public partial class UC_MiCodigo : UserControl
    {

        private ReservaController _reservaController;
        private int becasId;
        public UC_MiCodigo()
        {
            InitializeComponent();
            _reservaController = new ReservaController();

            lbl_codigoAlm.Text = $"Código:";
            lbl_codigoDes.Text = $"Código:";

        }

        private async void UC_MiCodigo_Load(object sender, EventArgs e)
        {

        }

       
    }
}
