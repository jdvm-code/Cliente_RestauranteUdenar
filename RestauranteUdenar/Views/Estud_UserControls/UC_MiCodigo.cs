using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestauranteUdenar.Views.UserControls
{
    public partial class UC_MiCodigo : UserControl
    {
        private readonly ReservaController _reservaController;
        private readonly BecaController _becaController;
        private List<Reserva> _reservasDelDia = new List<Reserva>();
        private bool _mostrandoDesayuno = true;

        int userIdSession = int.Parse(TokenStorage.GetUserId());


        public UC_MiCodigo()
        {
            InitializeComponent();
            _reservaController = new ReservaController();
            _becaController = new BecaController();

            // Suscribir evento Load
            this.Load += UC_MiCodigo_Load;
        }

        private async void UC_MiCodigo_Load(object sender, EventArgs e)
        {
            await CargarReservasDelDia();
        }

        private async Task CargarReservasDelDia()
        {
            try
            {
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");

                var response = await _reservaController.GetReservasByUsuarioYFechaAsync(userIdSession, fecha);

                // Verificar respuesta
                if (response == null)
                {
                    lbl_InfoReserva.Text = "Error: Respuesta nula del servidor";
                    return;
                }

                _reservasDelDia = response.success && response.data != null
                    ? response.data
                    : new List<Reserva>();

                // Reiniciar estado
                _mostrandoDesayuno = true;
                btnCodigoReserva.Text = "Código Desayuno";
                lblCodigoReserva.Text = "---";

                if (_reservasDelDia.Count == 0)
                {
                    lbl_InfoReserva.Text = "No tiene reservas para hoy " + fecha;
                    lbl_InfoReserva.ForeColor = Color.OrangeRed;
                    btnCodigoReserva.Enabled = false;
                }
                else
                {
                    lbl_InfoReserva.Text = $"Tiene {_reservasDelDia.Count} reserva(s).\n" +
                        $" Presione el botón para ver el código.";
                    lbl_InfoReserva.ForeColor = Color.Green;
                    btnCodigoReserva.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                lbl_InfoReserva.Text = "Error: " + ex.Message;
                lbl_InfoReserva.ForeColor = Color.Red;
                btnCodigoReserva.Enabled = false;
            }
        }

        private void btnCodigoReserva_Click_1(object sender, EventArgs e)
        {
            // Verificar que haya reservas cargadas
            if (_reservasDelDia == null || _reservasDelDia.Count == 0)
            {
                lblCodigoReserva.Text = "Sin reservas";
                lbl_InfoReserva.Text = "No hay reservas cargadas.\n" +
                    " Recargue la página.";
                return;
            }

            if (_mostrandoDesayuno)
            {
                // Buscar desayuno (comidas_id = 1)
                var reservaDesayuno = _reservasDelDia.FirstOrDefault(r => r.comidas_id == 1);

                if (reservaDesayuno != null)
                {
                    MostrarReserva(reservaDesayuno, "Desayuno");
                    btnCodigoReserva.Text = "Código Almuerzo";
                    _mostrandoDesayuno = false;
                }
                else
                {
                    lblCodigoReserva.Text = "Sin desayuno";
                    lbl_InfoReserva.Text = "No tiene reserva de\n" +
                        "desayuno para hoy";
                    lbl_InfoReserva.ForeColor = Color.OrangeRed;

                    // Cambiar a almuerzo de todos modos
                    btnCodigoReserva.Text = "Código Almuerzo";
                    _mostrandoDesayuno = false;
                }
            }
            else
            {
                // Buscar almuerzo (comidas_id = 2)
                var reservaAlmuerzo = _reservasDelDia.FirstOrDefault(r => r.comidas_id == 2);

                if (reservaAlmuerzo != null)
                {
                    MostrarReserva(reservaAlmuerzo, "Almuerzo");
                    btnCodigoReserva.Text = "Código Desayuno";
                    _mostrandoDesayuno = true;
                }
                else
                {
                    lblCodigoReserva.Text = "Sin almuerzo";
                    lbl_InfoReserva.Text = "No tiene reserva de\n" +
                                            "almuerzo para hoy";
                    lbl_InfoReserva.ForeColor = Color.OrangeRed;

                    // Cambiar a desayuno de todos modos
                    btnCodigoReserva.Text = "Código Desayuno";
                    _mostrandoDesayuno = true;
                }
            }
        }

        private void MostrarReserva(Reserva reserva, string tipoComida)
        {
            lblCodigoReserva.Text = reserva.codigo;
            lblCodigoReserva.Font = new Font("Courier New", 16, FontStyle.Bold);
            lblCodigoReserva.ForeColor = Color.DarkBlue;

            lbl_InfoReserva.Text = $"📅 {tipoComida}\n" +
                                   $"📆 Fecha: {reserva.fecha_reserva}\n" +
                                   $"📝 Estado: {GetEstadoReserva(reserva.estados_reservas_id)}\n" +
                                   $"⏱ Registro: {reserva.fecha_registro}";
        }

        private string GetEstadoReserva(int estadoId)
        {
            switch (estadoId)
            {
                case 1: return "Pendiente";
                case 2: return "Confirmada";
                case 3: return "Cancelada";
                default: return "Desconocido";
            }
        }

        private void btnCodigoReserva_Click(object sender, EventArgs e)
        {

        }
    }
}