using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RestauranteUdenar.Controllers;
using RestauranteUdenar.Models;

namespace RestauranteUdenar.Views.Admin_UserControls
{
    public partial class UC_GestionBecas : UserControl
    {
        private readonly BecaController _becaController;

        public UC_GestionBecas()
        {
            InitializeComponent();
            _becaController = new BecaController();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.Columns.Clear();

            // Columna ID (oculta)
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "ID",
                DataPropertyName = "id",
                Visible = false
            });

            // Columna Usuario
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "usuario_name",
                Width = 150
            });

            // Columna Fecha Inicio
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaInicio",
                HeaderText = "Fecha Inicio",
                DataPropertyName = "fecha_inicio",
                Width = 100
            });

            // Columna Fecha Fin
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFechaFin",
                HeaderText = "Fecha Fin",
                DataPropertyName = "fecha_fin",
                Width = 100
            });

            // Columna Estado
            dgvSolicitudes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "Estado",
                DataPropertyName = "estado",
                Width = 100
            });
        }

        private async void UC_GestionBecas_Load(object sender, EventArgs e)
        {
            await CargarSolicitudesPendientes();
        }

        private async Task CargarSolicitudesPendientes()
        {
            try
            {
                // Estado 1 = Pendiente
                var response = await _becaController.GetBecasPorEstadoAsync(1);

                if (response.success && response.data != null && response.data.Count > 0)
                {
                    // Crear lista con nombre de usuario incluido
                    var solicitudes = response.data.Select(b => new
                    {
                        b.id,
                        usuario_name = b.usuario?.name ?? "Desconocido",
                        b.fecha_inicio,
                        b.fecha_fin,
                        estado = GetEstadoNombre(b.estados_becas_id)
                    }).ToList();

                    dgvSolicitudes.DataSource = null;
                    dgvSolicitudes.DataSource = solicitudes;

                    lblTotal.Text = $"Total: {solicitudes.Count} solicitudes pendientes";
                }
                else
                {
                    dgvSolicitudes.DataSource = null;
                    lblTotal.Text = "Total: 0 solicitudes pendientes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetEstadoNombre(int estadoId)
        {
            return estadoId switch
            {
                1 => "Pendiente",
                2 => "Activa",
                3 => "Inactiva",
                _ => "Desconocido"
            };
        }

        private async void btnAprobar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int becaId = (int)dgvSolicitudes.SelectedRows[0].Cells["colId"].Value;
            string usuarioNombre = dgvSolicitudes.SelectedRows[0].Cells["colUsuario"].Value.ToString();

            var result = MessageBox.Show($"¿Aprobar beca para {usuarioNombre}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            var response = await _becaController.ActivarBecaAsync(becaId);

            if (response.success)
            {
                MessageBox.Show("Beca aprobada exitosamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarSolicitudesPendientes();
            }
            else
            {
                MessageBox.Show(response.error ?? response.message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarSolicitudesPendientes();
        }
    }
}