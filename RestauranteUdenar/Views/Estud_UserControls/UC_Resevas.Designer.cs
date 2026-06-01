namespace RestauranteUdenar.Views.UserControls
{
    partial class UC_Resevas
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
            lbl_estado = new Label();
            btn_ConfirmarReserva = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            combo_comida = new ComboBox();
            combo_horarios = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lbl_almuerzo = new Label();
            lbl_desayuno = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(927, 81);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 0;
            label1.Text = "Reservar Horario";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.BackColor = Color.Transparent;
            lbl_estado.Dock = DockStyle.Bottom;
            lbl_estado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_estado.ForeColor = Color.DarkGray;
            lbl_estado.Location = new Point(10, 46);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Padding = new Padding(8, 4, 8, 4);
            lbl_estado.Size = new Size(520, 25);
            lbl_estado.TabIndex = 1;
            lbl_estado.Text = "Selecciona el horario en el que asistirás al restaurante universitario para el almuerzo.";
            // 
            // btn_ConfirmarReserva
            // 
            btn_ConfirmarReserva.Location = new Point(60, 338);
            btn_ConfirmarReserva.Name = "btn_ConfirmarReserva";
            btn_ConfirmarReserva.Size = new Size(162, 30);
            btn_ConfirmarReserva.TabIndex = 8;
            btn_ConfirmarReserva.Text = "Confirmar reserva";
            btn_ConfirmarReserva.UseVisualStyleBackColor = true;
            btn_ConfirmarReserva.Click += btn_ConfirmarReserva_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(combo_comida);
            panel2.Controls.Add(combo_horarios);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_ConfirmarReserva);
            panel2.Location = new Point(40, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 428);
            panel2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 259);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // combo_comida
            // 
            combo_comida.FormattingEnabled = true;
            combo_comida.Location = new Point(27, 180);
            combo_comida.Name = "combo_comida";
            combo_comida.Size = new Size(232, 23);
            combo_comida.TabIndex = 17;
            // 
            // combo_horarios
            // 
            combo_horarios.FormattingEnabled = true;
            combo_horarios.Location = new Point(27, 106);
            combo_horarios.Name = "combo_horarios";
            combo_horarios.Size = new Size(232, 23);
            combo_horarios.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 241);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 14;
            label5.Text = "Fecha para la reserva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 162);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Comida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 34);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 11;
            label3.Text = "Haz tu reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 9;
            label2.Text = "Horarios";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_almuerzo);
            panel3.Controls.Add(lbl_desayuno);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(376, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 282);
            panel3.TabIndex = 10;
            // 
            // lbl_almuerzo
            // 
            lbl_almuerzo.AutoSize = true;
            lbl_almuerzo.Location = new Point(47, 188);
            lbl_almuerzo.Name = "lbl_almuerzo";
            lbl_almuerzo.Size = new Size(38, 15);
            lbl_almuerzo.TabIndex = 2;
            lbl_almuerzo.Text = "label7";
            // 
            // lbl_desayuno
            // 
            lbl_desayuno.AutoSize = true;
            lbl_desayuno.Location = new Point(47, 109);
            lbl_desayuno.Name = "lbl_desayuno";
            lbl_desayuno.Size = new Size(38, 15);
            lbl_desayuno.TabIndex = 1;
            lbl_desayuno.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 27);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 0;
            label6.Text = "Reservas para hoy";
            // 
            // UC_Resevas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Resevas";
            Size = new Size(927, 568);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbl_estado;
        private Button btn_ConfirmarReserva;
        private Panel panel2;
        private ComboBox combo_comida;
        private ComboBox combo_horarios;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Panel panel3;
        private Label lbl_almuerzo;
        private Label lbl_desayuno;
        private Label label6;
    }
}
