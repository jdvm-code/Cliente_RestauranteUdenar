namespace RestauranteUdenar.Views.Admin_UserControls
{
    partial class UC_GestionBecas
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
            btnActualizar = new Button();
            btnAprobarSeleccionada = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvSolicitudes = new DataGridView();
            codigo_usuario = new DataGridViewTextBoxColumn();
            usuario_nombre = new DataGridViewTextBoxColumn();
            fecha_reserva = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            comida_tipo = new DataGridViewTextBoxColumn();
            estado_name = new DataGridViewTextBoxColumn();
            fecha_registro = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(1003, 55);
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
            label1.Size = new Size(248, 32);
            label1.TabIndex = 0;
            label1.Text = "Solicitudes de becas";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnAprobarSeleccionada);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(81, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1003, 545);
            panel2.TabIndex = 8;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(288, 449);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(213, 37);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAprobarSeleccionada
            // 
            btnAprobarSeleccionada.Location = new Point(45, 449);
            btnAprobarSeleccionada.Name = "btnAprobarSeleccionada";
            btnAprobarSeleccionada.Size = new Size(213, 37);
            btnAprobarSeleccionada.TabIndex = 11;
            btnAprobarSeleccionada.Text = "Aprobar";
            btnAprobarSeleccionada.UseVisualStyleBackColor = true;
            btnAprobarSeleccionada.Click += btnAprobar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvSolicitudes);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.MaximumSize = new Size(0, 369);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1003, 369);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] { codigo_usuario, usuario_nombre, fecha_reserva, horario, comida_tipo, estado_name, fecha_registro });
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.Location = new Point(3, 3);
            dgvSolicitudes.MaximumSize = new Size(1100, 0);
            dgvSolicitudes.MinimumSize = new Size(0, 350);
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.Size = new Size(932, 350);
            dgvSolicitudes.TabIndex = 1;
            // 
            // codigo_usuario
            // 
            codigo_usuario.HeaderText = "Código";
            codigo_usuario.Name = "codigo_usuario";
            codigo_usuario.Width = 120;
            // 
            // usuario_nombre
            // 
            usuario_nombre.HeaderText = "Usuario";
            usuario_nombre.Name = "usuario_nombre";
            usuario_nombre.Width = 150;
            // 
            // fecha_reserva
            // 
            fecha_reserva.HeaderText = "Fecha Reserva";
            fecha_reserva.Name = "fecha_reserva";
            // 
            // horario
            // 
            horario.HeaderText = "Horario";
            horario.Name = "horario";
            horario.Width = 120;
            // 
            // comida_tipo
            // 
            comida_tipo.HeaderText = "Comida";
            comida_tipo.Name = "comida_tipo";
            // 
            // estado_name
            // 
            estado_name.HeaderText = "Estado";
            estado_name.Name = "estado_name";
            // 
            // fecha_registro
            // 
            fecha_registro.HeaderText = "Fecha Registro";
            fecha_registro.Name = "fecha_registro";
            fecha_registro.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1003, 55);
            panel3.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(10, 25, 47);
            lblTotal.Location = new Point(236, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(22, 32);
            lblTotal.TabIndex = 11;
            lblTotal.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 25, 47);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 0;
            label2.Text = "Resultados";
            // 
            // UC_GestionBecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_GestionBecas";
            Size = new Size(1003, 600);
            Load += UC_GestionBecas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label lblTotal;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgvSolicitudes;
        private DataGridViewTextBoxColumn codigo_usuario;
        private DataGridViewTextBoxColumn usuario_nombre;
        private DataGridViewTextBoxColumn fecha_reserva;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn comida_tipo;
        private DataGridViewTextBoxColumn estado_name;
        private DataGridViewTextBoxColumn fecha_registro;
        private Button btnActualizar;
        private Button btnAprobarSeleccionada;
    }
}
