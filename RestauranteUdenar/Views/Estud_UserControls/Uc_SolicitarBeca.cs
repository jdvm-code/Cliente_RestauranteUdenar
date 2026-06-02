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

namespace RestauranteUdenar.Views.Estud_UserControls
{
    public partial class Uc_SolicitarBeca : UserControl
    {
        private BecaController _becaController;
        int userIdSession = int.Parse(TokenStorage.GetUserId());


        public Uc_SolicitarBeca()
        {
            InitializeComponent();
        }

        private async void btnSolicitarBeca_Click(object sender, EventArgs e)
        {
            var response = await _becaController.SolicitarBecaAsync(userIdSession);

            if (response.success)
                MessageBox.Show("Solicitud enviada");
            else
                MessageBox.Show(response.error ?? response.message);
        }
    }
}
