namespace RestauranteUdenar.Views.Estud_UserControls
{
    partial class UC_Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbl_estado = new Label();
            panel_inasistencias = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel_alertas = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel_reserva = new Panel();
            label10 = new Label();
            label11 = new Label();
            panelBanner = new Panel();
            btn_ReservarAhora = new Button();
            label9 = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel_inasistencias.SuspendLayout();
            panel_alertas.SuspendLayout();
            panel_reserva.SuspendLayout();
            panelBanner.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "Mi Beneficio";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.FromArgb(220, 245, 225);
            lbl_estado.Dock = DockStyle.Right;
            lbl_estado.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_estado.ForeColor = Color.FromArgb(0, 135, 50);
            lbl_estado.Location = new Point(916, 10);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Padding = new Padding(8, 4, 8, 4);
            lbl_estado.Size = new Size(74, 23);
            lbl_estado.TabIndex = 1;
            lbl_estado.Text = "  Activo  ";
            // 
            // panel_inasistencias
            // 
            panel_inasistencias.BackColor = Color.Transparent;
            panel_inasistencias.Controls.Add(label5);
            panel_inasistencias.Controls.Add(label4);
            panel_inasistencias.Controls.Add(label3);
            panel_inasistencias.Dock = DockStyle.Fill;
            panel_inasistencias.Location = new Point(3, 3);
            panel_inasistencias.Name = "panel_inasistencias";
            panel_inasistencias.Size = new Size(324, 136);
            panel_inasistencias.TabIndex = 3;
            panel_inasistencias.Paint += panel_inasistencias_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(230, 230, 230);
            label5.Dock = DockStyle.Bottom;
            label5.Location = new Point(0, 121);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 2;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label4.Location = new Point(3, 43);
            label4.Name = "label4";
            label4.Size = new Size(97, 37);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(4, 4);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // panel_alertas
            // 
            panel_alertas.BackColor = Color.Transparent;
            panel_alertas.Controls.Add(label7);
            panel_alertas.Controls.Add(label8);
            panel_alertas.Dock = DockStyle.Fill;
            panel_alertas.Location = new Point(333, 3);
            panel_alertas.Name = "panel_alertas";
            panel_alertas.Size = new Size(324, 136);
            panel_alertas.TabIndex = 4;
            panel_alertas.Paint += panel_alertas_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(4, 4);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 3;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 135, 50);
            label8.Location = new Point(4, 43);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 0;
            label8.Text = "label8";
            // 
            // panel_reserva
            // 
            panel_reserva.BackColor = Color.Transparent;
            panel_reserva.Controls.Add(label10);
            panel_reserva.Controls.Add(label11);
            panel_reserva.Dock = DockStyle.Fill;
            panel_reserva.Location = new Point(663, 3);
            panel_reserva.Name = "panel_reserva";
            panel_reserva.Size = new Size(326, 136);
            panel_reserva.TabIndex = 4;
            panel_reserva.Paint += panel_reserva_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(3, 43);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(4, 4);
            label11.Name = "label11";
            label11.Size = new Size(47, 15);
            label11.TabIndex = 0;
            label11.Text = "label11";
            // 
            // panelBanner
            // 
            panelBanner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBanner.BackColor = Color.FromArgb(0, 150, 70);
            panelBanner.Controls.Add(btn_ReservarAhora);
            panelBanner.Controls.Add(label9);
            panelBanner.Controls.Add(label6);
            panelBanner.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelBanner.ForeColor = Color.White;
            panelBanner.Location = new Point(5, 242);
            panelBanner.Name = "panelBanner";
            panelBanner.Padding = new Padding(20);
            panelBanner.Size = new Size(992, 143);
            panelBanner.TabIndex = 3;
            panelBanner.Paint += panelBanner_Paint;
            // 
            // btn_ReservarAhora
            // 
            btn_ReservarAhora.BackColor = Color.Transparent;
            btn_ReservarAhora.FlatAppearance.BorderColor = Color.White;
            btn_ReservarAhora.FlatAppearance.BorderSize = 2;
            btn_ReservarAhora.FlatStyle = FlatStyle.Flat;
            btn_ReservarAhora.Location = new Point(23, 82);
            btn_ReservarAhora.Name = "btn_ReservarAhora";
            btn_ReservarAhora.Padding = new Padding(10, 5, 10, 5);
            btn_ReservarAhora.Size = new Size(138, 47);
            btn_ReservarAhora.TabIndex = 2;
            btn_ReservarAhora.Text = "Reservar ahora";
            btn_ReservarAhora.UseVisualStyleBackColor = false;
            btn_ReservarAhora.Click += btn_ReservarAhora_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(23, 54);
            label9.Name = "label9";
            label9.Size = new Size(182, 19);
            label9.TabIndex = 1;
            label9.Text = "Recuerda reservar tu turno...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(23, 20);
            label6.Name = "label6";
            label6.Size = new Size(215, 30);
            label6.TabIndex = 0;
            label6.Text = "¿Vas a almorzar hoy?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(panel_reserva, 2, 0);
            tableLayoutPanel1.Controls.Add(panel_alertas, 1, 0);
            tableLayoutPanel1.Controls.Add(panel_inasistencias, 0, 0);
            tableLayoutPanel1.Location = new Point(5, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(992, 142);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_estado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1000, 44);
            panel1.TabIndex = 5;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelBanner);
            Name = "UC_Dashboard";
            Size = new Size(1000, 600);
            panel_inasistencias.ResumeLayout(false);
            panel_inasistencias.PerformLayout();
            panel_alertas.ResumeLayout(false);
            panel_alertas.PerformLayout();
            panel_reserva.ResumeLayout(false);
            panel_reserva.PerformLayout();
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lbl_estado;
        private Panel panel_inasistencias;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel_alertas;
        private Label label8;
        private Panel panel_reserva;
        private Label label10;
        private Label label11;
        private Label label7;
        private Panel panelBanner;
        private Label label6;
        private Button btn_ReservarAhora;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}
