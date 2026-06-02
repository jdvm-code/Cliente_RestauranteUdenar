namespace RestauranteUdenar.Views.UserControls
{
    partial class UC_MiCodigo
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lbl_InfoReserva = new Label();
            btnCodigoReserva = new Button();
            lblCodigoReserva = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(972, 55);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Acceso al Restaurante";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(lbl_InfoReserva);
            panel2.Controls.Add(btnCodigoReserva);
            panel2.Controls.Add(lblCodigoReserva);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.Gray;
            panel2.Location = new Point(43, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(525, 486);
            panel2.TabIndex = 8;
            // 
            // lbl_InfoReserva
            // 
            lbl_InfoReserva.AutoSize = true;
            lbl_InfoReserva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_InfoReserva.ForeColor = Color.Black;
            lbl_InfoReserva.Location = new Point(99, 173);
            lbl_InfoReserva.Name = "lbl_InfoReserva";
            lbl_InfoReserva.Size = new Size(322, 84);
            lbl_InfoReserva.TabIndex = 9;
            lbl_InfoReserva.Text = "$\"📅 {tipoComida}\\n\" +\r\n$\"📆 Fecha: {reserva.fecha_reserva}\\n\" +\r\n$\"📝 Estado: {GetEstadoReserva(reserva\r\n$\"⏱ Registro: {reserva.fecha_registro}\";";
            // 
            // btnCodigoReserva
            // 
            btnCodigoReserva.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCodigoReserva.ForeColor = Color.Black;
            btnCodigoReserva.Location = new Point(146, 404);
            btnCodigoReserva.Name = "btnCodigoReserva";
            btnCodigoReserva.Size = new Size(192, 38);
            btnCodigoReserva.TabIndex = 4;
            btnCodigoReserva.Text = "button1";
            btnCodigoReserva.UseVisualStyleBackColor = true;
            btnCodigoReserva.Click += btnCodigoReserva_Click_1;
            // 
            // lblCodigoReserva
            // 
            lblCodigoReserva.AutoSize = true;
            lblCodigoReserva.ForeColor = Color.Black;
            lblCodigoReserva.Location = new Point(25, 362);
            lblCodigoReserva.Name = "lblCodigoReserva";
            lblCodigoReserva.Size = new Size(102, 15);
            lblCodigoReserva.TabIndex = 2;
            lblCodigoReserva.Text = "lbl_codigoReserva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(111, 42);
            label3.Name = "label3";
            label3.Size = new Size(288, 74);
            label3.TabIndex = 1;
            label3.Text = "Mi código de reserva\r\n::::::::::::::::::::::::::::::::::::::";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(25, 329);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 0;
            label2.Text = "Muestra este codigo al ingreso del restaurante";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.QR;
            pictureBox1.Location = new Point(594, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UC_MiCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "UC_MiCodigo";
            Size = new Size(972, 604);
            Load += UC_MiCodigo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblCodigoReserva;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnCodigoReserva;
        private Label lbl_InfoReserva;
    }
}
