using RestauranteUdenar.Auxiliares;
using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Models;
using RestauranteUdenar.Properties;
using System;
using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteUdenar.Views.UserControls
{
    public partial class UC_Resevas : UserControl
    {
        private HorarioController _horarioController;
        private ReservaController _reservaController;
        private ComidaController _comidaController;
        private BecaController _becaController;
        private UsuarioController _usuarioController;

        private List<Reserva> _reservasDelDia = new List<Reserva>();


        int userIdSession = int.Parse(TokenStorage.GetUserId());


        public UC_Resevas()
        {
            InitializeComponent();

            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            combo_comida.SelectedIndexChanged += combo_comida_SelectedIndexChanged;

            _horarioController = new HorarioController();
            _comidaController = new ComidaController();
            _reservaController = new ReservaController();
            _becaController = new BecaController();
            _usuarioController = new UsuarioController();

            CargarHorarios();
            CargarComidas();


            label3.Text = $"Usuario ID: {userIdSession}";
        }
        private async void UC_Resevas_Load(object sender, EventArgs e)
        {

        }
        private async void btn_ConfirmarReserva_Click_1(object sender, EventArgs e)
        {
            CrearReserva();

        }

        public async void CrearReserva()
        {
            try
            {
                var becaResponse = await _becaController.GetBecaActivaByUsuarioAsync(userIdSession);

                if (!becaResponse.success || becaResponse.data == null)
                {
                    MessageBox.Show("No tiene beca activa para hacer reservas", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int becaId = becaResponse.data.id;

                var horarioItem = (ComboHorarioItem)combo_horarios.SelectedItem;
                var comidaItem = (ComboComidaItem)combo_comida.SelectedItem;

                //Verificar reservas existentes antes de enviar
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var reservasExistentes = await _reservaController.GetReservasByUsuarioYFechaAsync(userIdSession, fecha);

                if (reservasExistentes.success && reservasExistentes.data != null)
                {
                    // Verificar límite de 2 reservas por día
                    if (reservasExistentes.data.Count >= 2)
                    {
                        MessageBox.Show(
                            "⚠️ Límite de reservas alcanzado\n\n" +
                            "Ya tiene 2 reservas para el día " + fecha + ":\n" +
                            "• Desayuno\n" +
                            "• Almuerzo\n\n" +
                            "No puede realizar más reservas para esta fecha.",
                            "Reservas completas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    // Verificar si ya tiene este tipo de comida
                    bool yaTieneEstaComida = reservasExistentes.data.Any(r => r.comidas_id == comidaItem.Id);
                    if (yaTieneEstaComida)
                    {
                        string tipoComida = comidaItem.Id == 1 ? "desayuno" : "almuerzo";
                        MessageBox.Show(
                            "⚠️ Reserva duplicada\n\n" +
                            "Ya tiene una reserva de " + tipoComida + " para el día " + fecha + ".\n\n" +
                            "Solo puede reservar una vez por desayuno y una por almuerzo.",
                            "Tipo de comida ya reservado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Crear objeto reserva
                var reserva = new
                {
                    becas_id = becaId,
                    horarios_id = horarioItem.Id,
                    comidas_id = comidaItem.Id,
                    estados_reservas_id = 1,
                    fecha_registro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    fecha_reserva = fecha
                };

                //Enviar a la API
                var response = await _reservaController.CrearReservaAsync(reserva);

                if (response.success)
                {
                    MessageBox.Show(
                        "✅ Reserva creada exitosamente\n\n" +
                        "Código: " + response.data.codigo + "\n" +
                        "Fecha: " + response.data.fecha_reserva + "\n" +
                        "Estado: Pendiente",
                        "Reserva confirmada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    // Mensajes personalizados según el error de la API
                    string mensaje = response.error ?? response.message;

                    if (mensaje.Contains("2 reservas") || mensaje.Contains("Límite de reservas"))
                    {
                        MessageBox.Show(
                            "⚠️ Límite de reservas alcanzado\n\n" +
                            "Ya tiene 2 reservas para este día (desayuno y almuerzo).\n" +
                            "No puede realizar más reservas.",
                            "Reservas completas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else if (mensaje.Contains("tipo de comida") || mensaje.Contains("ya tiene una reserva"))
                    {
                        MessageBox.Show(
                            "⚠️ Reserva duplicada\n\n" +
                            "Ya tiene una reserva para este tipo de comida.\n" +
                            "Solo puede reservar una vez por desayuno y una por almuerzo.",
                            "Tipo de comida ya reservado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else if (mensaje.Contains("Cupo agotado") || mensaje.Contains("cupo"))
                    {
                        MessageBox.Show(
                            "⚠️ Cupo agotado\n\n" +
                            "No hay cupos disponibles para este horario.\n" +
                            "Intente con otro horario o fecha.",
                            "Sin cupos disponibles",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else if (mensaje.Contains("beca") || mensaje.Contains("Beca"))
                    {
                        MessageBox.Show(
                            "⚠️ Problema con la beca\n\n" +
                            mensaje,
                            "Error de beca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(
                            "❌ Error al crear la reserva\n\n" +
                            mensaje,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Errores de conexión o excepciones de C#
                MessageBox.Show(
                    "❌ Error de conexión\n\n" +
                    "No se pudo conectar con el servidor.\n" +
                    "Detalle: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void CargarHorarios()
        {
            try
            {
                var response = await _horarioController.GetHorariosAsync();

                if (response.success && response.data != null)
                {
                    var items = response.data.Select(h => new ComboHorarioItem
                    {
                        Id = h.id,
                        Texto = $"{h.hora_inicio} - {h.hora_fin}"
                    }).ToList();

                    combo_horarios.DataSource = items;
                    combo_horarios.DisplayMember = "Texto";   // Lo que se muestra
                    combo_horarios.ValueMember = "Id";// El valor interno (id)
                }
                else
                {
                    MessageBox.Show(response.error ?? response.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void CargarComidas()
        {
            try
            {
                var comidaResponse = await _comidaController.GetComidaAsync();

                if (!comidaResponse.success || comidaResponse.data == null)
                {
                    MessageBox.Show(comidaResponse.error ?? comidaResponse.message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                var reservasResponse = await _reservaController.GetReservasByUsuarioYFechaAsync(userIdSession, fecha);

                _reservasDelDia = reservasResponse.success && reservasResponse.data != null
                    ? reservasResponse.data
                    : new List<Reserva>();

                var items = comidaResponse.data
                    .Where(c => !_reservasDelDia.Any(r => r.comidas_id == c.id)) // Solo comidas NO reservadas
                    .Select(c => new ComboComidaItem
                    {
                        Id = c.id,
                        Texto = c.tipo
                    })
                    .ToList();

                combo_comida.DataSource = items;
                combo_comida.DisplayMember = "Texto";
                combo_comida.ValueMember = "Id";

                if (items.Count == 0)
                {
                    combo_comida.Enabled = false;
                    btn_ConfirmarReserva.Enabled = false;
                    lblMensajeReserva.Text = "⚠️ Ya tiene las 2 reservas para el día " + fecha;
                    lblMensajeReserva.ForeColor = Color.OrangeRed;
                }
                else
                {
                    combo_comida.Enabled = true;
                    combo_comida.SelectedIndex = 0;
                    VerificarReservaExistente();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar comidas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combo_comida_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarReservaExistente();
        }

        private void VerificarReservaExistente()
        {
            if (combo_comida.SelectedItem == null) return;

            var comidaSeleccionada = (ComboComidaItem)combo_comida.SelectedItem;
            bool yaTieneEstaComida = _reservasDelDia.Any(r => r.comidas_id == comidaSeleccionada.Id);

            if (yaTieneEstaComida)
            {
                btn_ConfirmarReserva.Enabled = false;
                lblMensajeReserva.Text = $"⚠️ Ya tiene reservado {comidaSeleccionada.Texto} para este día";
                lblMensajeReserva.ForeColor = Color.OrangeRed;
            }
            else
            {
                btn_ConfirmarReserva.Enabled = true;
                lblMensajeReserva.Text = $"✅ Puede reservar {comidaSeleccionada.Texto}";
                lblMensajeReserva.ForeColor = Color.Green;
            }
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarComidas();
        }





    }

}