using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestauranteUdenar.Controllers;
using RestauranteUdenar.Models;

namespace RestauranteUdenar.Views.Admin_UserControls
{
    public partial class Uc_GestionReservas : UserControl
    {
        private readonly ReservaController _reservaController;

        public Uc_GestionReservas()
        {
            InitializeComponent();
            _reservaController = new ReservaController();

            // Configurar DataGridView en el constructor
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvReservas.AutoGenerateColumns = false;
            dgvReservas.Columns.Clear();

            // Columna ID (oculta)
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "id",
                Visible = false
            });

            // Columna Código
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCodigo",
                HeaderText = "Código",
                DataPropertyName = "codigo",
                Width = 120
            });

            // Columna Fecha Reserva
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaReserva",
                HeaderText = "Fecha Reserva",
                DataPropertyName = "fecha_reserva",
                Width = 100
            });

            // Columna Fecha Registro
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaRegistro",
                HeaderText = "Fecha Registro",
                DataPropertyName = "fecha_registro",
                Width = 150
            });

            // Columna Estado
            dgvReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "Estado",
                DataPropertyName = "estados_reservas_id",
                Width = 80
            });
        }

        private async void Uc_GestionReservas_Load(object sender, EventArgs e)
        {
            CargarFiltros();
            await CargarReservas();
        }

        private void CargarFiltros()
        {
            // Combo estados
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add(new ComboItem { Id = 0, Texto = "Todos" });
            cmbEstado.Items.Add(new ComboItem { Id = 1, Texto = "Pendiente" });
            cmbEstado.Items.Add(new ComboItem { Id = 2, Texto = "Confirmada" });
            cmbEstado.Items.Add(new ComboItem { Id = 3, Texto = "Cancelada" });
            cmbEstado.DisplayMember = "Texto";
            cmbEstado.ValueMember = "Id";
            cmbEstado.SelectedIndex = 0;

            // Combo comidas
            cmbComida.Items.Clear();
            cmbComida.Items.Add(new ComboItem { Id = 0, Texto = "Todos" });
            cmbComida.Items.Add(new ComboItem { Id = 1, Texto = "Desayuno" });
            cmbComida.Items.Add(new ComboItem { Id = 2, Texto = "Almuerzo" });
            cmbComida.DisplayMember = "Texto";
            cmbComida.ValueMember = "Id";
            cmbComida.SelectedIndex = 0;

            // Fecha hoy por defecto
            dtpFechaFiltro.Value = DateTime.Now;
        }

        private async Task CargarReservas()
        {
            try
            {
                string fecha = dtpFechaFiltro.Value.ToString("yyyy-MM-dd");
                int? estado = ((ComboItem)cmbEstado.SelectedItem).Id > 0
                    ? (int?)((ComboItem)cmbEstado.SelectedItem).Id
                    : null;
                int? comida = ((ComboItem)cmbComida.SelectedItem).Id > 0
                    ? (int?)((ComboItem)cmbComida.SelectedItem).Id
                    : null;

                var response = await _reservaController.GetAllReservasAsync(fecha, estado, comida);

                if (response.success && response.data != null)
                {
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = response.data;
                    lblTotalReservas.Text = $"Total: {response.data.Count} reservas";
                }
                else
                {
                    dgvReservas.DataSource = null;
                    lblTotalReservas.Text = "Total: 0 reservas";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos de filtros
        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            await CargarReservas();
        }

        private async void btnHoy_Click(object sender, EventArgs e)
        {
            dtpFechaFiltro.Value = DateTime.Now;
            await CargarReservas();
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaFiltro.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;
            cmbComida.SelectedIndex = 0;
            await CargarReservas();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarReservas();
        }

        // Acciones sobre reserva seleccionada
        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservaId = (int)dgvReservas.SelectedRows[0].Cells["colId"].Value;

            var result = MessageBox.Show("¿Confirmar esta reserva?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            var response = await _reservaController.ConfirmarReservaAsync(reservaId);

            if (response.success)
            {
                MessageBox.Show("Reserva confirmada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarReservas();
            }
            else
            {
                MessageBox.Show(response.error ?? response.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservaId = (int)dgvReservas.SelectedRows[0].Cells["colId"].Value;

            var result = MessageBox.Show("¿Cancelar esta reserva?", "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            var response = await _reservaController.CancelarReservaAsync(reservaId);

            if (response.success)
            {
                MessageBox.Show("Reserva cancelada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarReservas();
            }
            else
            {
                MessageBox.Show(response.error ?? response.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;

            string detalle = $"Código: {reserva.codigo}\n" +
                            $"Fecha Reserva: {reserva.fecha_reserva}\n" +
                            $"Fecha Registro: {reserva.fecha_registro}\n" +
                            $"Estado ID: {reserva.estados_reservas_id}";

            MessageBox.Show(detalle, "Detalle de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Clase auxiliar para combos
        private class ComboItem
        {
            public int Id { get; set; }
            public string Texto { get; set; }
        }
    }
}