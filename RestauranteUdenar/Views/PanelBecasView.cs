using RestauranteUdenar.Controllers;
using RestauranteUdenar.Helpers;
using RestauranteUdenar.Properties;
using RestauranteUdenar.Views.Estud_UserControls;
using RestauranteUdenar.Views.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace RestauranteUdenar.Views
{
    public partial class PanelBecasView : Form
    {
        private readonly UsuarioController _controller;
        // Color amarillo del botón activo (igual al de tu imagen)
        private readonly Color COLOR_ACTIVO_FONDO = Color.FromArgb(251, 186, 0); // #FBBA00
        private readonly Color COLOR_ACTIVO_TEXTO = Color.Black;

        // Color de los botones inactivos (verde de tu menú)
        private readonly Color COLOR_INACTIVO_FONDO = Color.FromArgb(0, 150, 64);   // Verde oscuro
        private readonly Color COLOR_INACTIVO_TEXTO = Color.White;

        // Color cuando pasas el mouse (hover) - opcional, o transparente
        private readonly Color COLOR_HOVER_FONDO = Color.FromArgb(0, 160, 80);    // Verde más claro
        private readonly Color COLOR_HOVER_TEXTO = Color.White;

        // Guardar el botón actualmente activo
        private Button botonActual = null;



        /// <summary>
        /// //
        /// </summary>
        /// 
        int userIdSession = int.Parse(TokenStorage.GetUserId());


        BecaController _becaController;

        public PanelBecasView()
        {
            InitializeComponent();
            ConfigurarBotones();

            panelSidebar.BackColor = Color.FromArgb(0, 150, 64);
            panelMain.BackColor = Color.FromArgb(245, 247, 250);
            _controller = new UsuarioController();
            _becaController = new BecaController();
        }


        private async Task VerificarBecaYMostrarPanel()
        {
            var becaResponse = await _becaController.GetBecaActivaByUsuarioAsync(userIdSession);

            if (becaResponse.success && becaResponse.data != null)
            {
                // Tiene beca activa - mostrar panel de reservas
                UC_Resevas vista = new UC_Resevas();
                MostrarVista(vista);
            }
            else
            {
                // No tiene beca - mostrar UserControl de solicitud
                UC_Resevas vista = new UC_Resevas();
                MostrarVista(vista);
            }
        }

        private void MostrarVista(UserControl vistaFormulario)
        {
            Panel_UC_Controls.Controls.Clear();
            vistaFormulario.Dock = DockStyle.Fill;
            vistaFormulario.BringToFront();
            Panel_UC_Controls.Controls.Add(vistaFormulario);
        }

        private async void PanelBecasView_Load(object sender, EventArgs e)
        {

            await VerificarBecaYMostrarPanel();
            lblBienvenida.Text = $"Usuario: {Session.UsuarioActual?.name}";

        }

        private void btn_hacerReserva_Click(object sender, EventArgs e)
        {
            UC_Resevas vista = new UC_Resevas();
            MostrarVista(vista);
        }

        private void btn_miCodigo_Click(object sender, EventArgs e)
        {
            UC_MiCodigo vista = new UC_MiCodigo();
            MostrarVista(vista);
        }


        private void btn_cambiarContraseña_Click(object sender, EventArgs e)
        {
            Uc_SolicitarBeca vista = new Uc_SolicitarBeca();
            MostrarVista(vista);
        }

        private async void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            await _controller.CerrarSesionAsync();

            var login = new LoginView();
            login.Show();
            this.Close();
        }

        private void ConfigurarBotones()
        {
            // Lista de todos los botones del menú
            Button[] botones = { btn_hacerReserva, btn_miCodigo,
                    btn_cambiarContraseña, btn_cerrarSesion };

            foreach (var btn in botones)
            {
                // Desactivar comportamientos automáticos de WinForms que causan conflictos
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = COLOR_HOVER_FONDO;  // Color al pasar mouse
                btn.FlatAppearance.MouseDownBackColor = COLOR_ACTIVO_FONDO; // Color al hacer click

                // IMPORTANTE: Esto evita que WinForms cambie colores automáticamente
                btn.UseVisualStyleBackColor = false;

                // Establecer colores iniciales
                btn.BackColor = COLOR_INACTIVO_FONDO;
                btn.ForeColor = COLOR_INACTIVO_TEXTO;

                // Asignar eventos
                btn.Click += BotonMenu_Click;
                btn.MouseEnter += BotonMenu_MouseEnter;
                btn.MouseLeave += BotonMenu_MouseLeave;
            }

            // Activar el primer botón por defecto (Dashboard)
            ActivarBoton(btn_hacerReserva);
        }

        // Evento CLICK - Aquí se marca el botón como activo (amarillo)
        private void BotonMenu_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ActivarBoton(btn);

                // Aquí puedes agregar la navegación entre paneles
                // Ejemplo: MostrarPanel(btn.Name);
            }
        }

        // Evento MOUSE ENTER - Pasar el cursor por encima
        private void BotonMenu_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != botonActual)
            {
                // Solo cambiar si NO es el botón activo
                btn.BackColor = COLOR_HOVER_FONDO;
                btn.ForeColor = COLOR_HOVER_TEXTO;
            }
        }

        // Evento MOUSE LEAVE - Quitar el cursor
        private void BotonMenu_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && btn != botonActual)
            {
                // Volver al color inactivo si NO es el botón activo
                btn.BackColor = COLOR_INACTIVO_FONDO;
                btn.ForeColor = COLOR_INACTIVO_TEXTO;
            }
        }


        // Método principal para activar un botón
        private void ActivarBoton(Button botonActivo)
        {
            // Lista con todos los botones del menú
            List<Button> listaBotones = new List<Button> {
            btn_hacerReserva,
    btn_miCodigo,
    btn_cambiarContraseña,
    btn_cerrarSesion
    }
            ;

            foreach (var btn in listaBotones)
            {
                if (btn == botonActivo)
                {
                    // === BOTÓN ACTIVO (AMARILLO) ===
                    botonActual = btn;
                    btn.BackColor = COLOR_ACTIVO_FONDO;
                    btn.ForeColor = COLOR_ACTIVO_TEXTO;

                    // Asegurar que no se vea afectado por hover
                    btn.FlatAppearance.MouseOverBackColor = COLOR_ACTIVO_FONDO;
                }
                else
                {
                    // === BOTÓN INACTIVO (VERDE) ===
                    btn.BackColor = COLOR_INACTIVO_FONDO;
                    btn.ForeColor = COLOR_INACTIVO_TEXTO;

                    // Restaurar hover para los inactivos
                    btn.FlatAppearance.MouseOverBackColor = COLOR_HOVER_FONDO;
                }
            }
        }

        private async void PanelBecasView_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show(
                 "¿Estás seguro de que deseas cerrar sesión?",  // mensaje
                 "Confirmar cierre de sesión",                   // título
                  MessageBoxButtons.YesNo,                        // ← botones (plural, con S)
                  MessageBoxIcon.Question                         // ← icono (sin Button)
            );

            if (resultado == DialogResult.Yes)                // ← DialogResult, no MessageBoxResult
            {
                await _controller.CerrarSesionAsync();
                var login = new LoginView();
                login.Show();
                this.Close();
            }
        }
    }
}
