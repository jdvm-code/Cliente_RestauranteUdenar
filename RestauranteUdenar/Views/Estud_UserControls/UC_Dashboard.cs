using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RestauranteUdenar.Views.Estud_UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        private readonly Color COLOR_HOVER_FONDO = Color.FromArgb(0, 160, 80);    // Verde más claro

        public UC_Dashboard()
        {
            InitializeComponent();
            btn_ReservarAhora.BackColor = COLOR_HOVER_FONDO;
        }


        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel_inasistencias_Paint(object sender, PaintEventArgs e)
        {
            diseño(sender, e);
        }

        private void panel_alertas_Paint(object sender, PaintEventArgs e)
        {
            diseño(sender, e);

        }

        private void panel_reserva_Paint(object sender, PaintEventArgs e)
        {
            diseño(sender, e);
        }

        public void diseño(Object sender, PaintEventArgs e)
        {
            Rectangle bounds = new Rectangle(0, 0, ((Panel)sender).Width - 1, ((Panel)sender).Height - 1);
            int cornerRadius = 15; // Ajusta qué tan redondo lo quieres

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Rellenar el fondo de blanco
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Opcional: Un borde gris muy sutil para simular profundidad
            using (Pen pen = new Pen(Color.FromArgb(201, 191, 191), 1))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btn_ReservarAhora_Click(object sender, EventArgs e)
        {

        }

    }
}
