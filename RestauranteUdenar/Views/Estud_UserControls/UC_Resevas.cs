using RestauranteUdenar.Controllers;
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

        public UC_Resevas()
        {
            InitializeComponent();
            _horarioController = new HorarioController();
            _comidaController = new ComidaController();
            _reservaController = new ReservaController();
            _becaController = new BecaController();
            _usuarioController = new UsuarioController();

            CargarHorariosAsync();
            CargarComidasAsync();


            int userId = int.Parse(TokenStorage.GetUserId());
            label3.Text = $"Usuario ID: {userId}";
        }

        public async Task<int> ObtenerIdRoleAsync()
        {
            var json = await _usuarioController.meAsync();
            var response = JsonSerializer.Deserialize<Usuario>(json);
            return response.role_id;
        }

        private async void UC_Resevas_Load(object sender, EventArgs e)
        {
            CargarHorariosAsync();
        }
        private async void btn_ConfirmarReserva_Click_1(object sender, EventArgs e)
        {
            await hacerReservaAsync();
        }

        private async void CargarHorariosAsync()
        {
            try
            {
                var resultado = await _horarioController.GetHorariosAsync();

                if (!resultado.exito)
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                combo_horarios.Items.Clear();

                if (resultado.horarios == null || resultado.horarios.Count == 0)
                {
                    MessageBox.Show("No hay horarios disponibles");
                    return;
                }

                foreach (var horario in resultado.horarios)
                {
                    var item = new ComboBoxItem
                    {
                        Display = $"{horario.hora_inicio} - {horario.hora_fin}",
                        Value = horario.id
                    };

                    combo_horarios.Items.Add(item);
                }

                if (combo_horarios.Items.Count > 0)
                {
                    combo_horarios.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error cargando horarios: {ex.Message}");
            }
        }

        private async void CargarComidasAsync()
        {
            try
            {
                var resultado = await _comidaController.GetComidaAsync();

                if (!resultado.exito)
                {
                    MessageBox.Show(resultado.mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                combo_comida.Items.Clear();

                if (resultado.comidas == null || resultado.comidas.Count == 0)
                {
                    MessageBox.Show("No hay comidas disponibles");
                    return;
                }

                foreach (var comida in resultado.comidas)
                {
                    var item = new ComboBoxItem
                    {
                        Display = comida.tipo,
                        Value = comida.id
                    };

                    combo_comida.Items.Add(item);
                }

                if (combo_comida.Items.Count > 0)
                {
                    combo_comida.SelectedIndex = 0;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error cargando comidas: {ex.Message}");
            }
        }
        public async Task<int> ObtenerBecaUsuarioAsync()
        {
            int userId = int.Parse(TokenStorage.GetUserId());

            var resultado = await _becaController.GetBecaByUserIdAsync(userId);
            if (resultado.exito && resultado.beca != null)
            {
                return resultado.beca.id;
            }
            return 0;
        }

        private async Task hacerReservaAsync()
        {
            try
            {
                if (combo_horarios.Items.Count == 0)
                {
                    MessageBox.Show("No hay horarios cargados. Espere a que se carguen.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (combo_comida.Items.Count == 0)
                {
                    MessageBox.Show("No hay comidas cargadas. Espere a que se carguen.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemHorario = combo_horarios.SelectedItem as ComboBoxItem;
                if (itemHorario == null || combo_horarios.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor seleccione un horario",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var itemComida = combo_comida.SelectedItem as ComboBoxItem;
                if (itemComida == null || combo_comida.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor seleccione una comida",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string userIdStr = TokenStorage.GetUserId();
                if (string.IsNullOrEmpty(userIdStr))
                {
                    MessageBox.Show("No se encontró el ID de usuario. Inicie sesión nuevamente.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(userIdStr, out int userId))
                {
                    MessageBox.Show("El ID de usuario no es válido.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fechaRegistro = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");   
                string fechaReserva = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                var request = new ReservaRequest
                {
                    becas_id = userId,
                    horarios_id = itemHorario.Value,
                    comidas_id = itemComida.Value,
                    estados_reservas_id = 1,
                    fecha_registro = fechaRegistro,    
                    fecha_reserva = fechaReserva        
                };

                var resultado = await _reservaController.StoreReservaAsync(request);

                if (resultado.exito)
                {
                    MessageBox.Show("Reserva creada exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Opcional: limpiar selección o recargar datos
                    // combo_horarios.SelectedIndex = -1;
                    // combo_comida.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(resultado.mensaje, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}