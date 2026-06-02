namespace RestauranteUdenar.Views.Admin_UserControls
{
    partial class Uc_GestionReservas
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
            btnActualizar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            lblTotalReservas = new Label();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvReservas = new DataGridView();
            codigo_usuario = new DataGridViewTextBoxColumn();
            usuario_nombre = new DataGridViewTextBoxColumn();
            fecha_reserva = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            comida_tipo = new DataGridViewTextBoxColumn();
            estado_name = new DataGridViewTextBoxColumn();
            fecha_registro = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnExportar = new Button();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            btnVerDetalle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbComida = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpFechaFiltro = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnHoy = new Button();
            btnLimpiar = new Button();
            btnFiltrar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(962, 55);
            panel1.TabIndex = 9;
            // 
            // btnActualizar
            // 
            btnActualizar.Dock = DockStyle.Right;
            btnActualizar.Location = new Point(782, 10);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(170, 35);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(261, 32);
            label1.TabIndex = 0;
            label1.Text = "Panel Administrativo";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(962, 613);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(10, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(942, 593);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(5, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(932, 461);
            panel5.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTotalReservas);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(932, 44);
            panel4.TabIndex = 0;
            // 
            // lblTotalReservas
            // 
            lblTotalReservas.AutoSize = true;
            lblTotalReservas.Dock = DockStyle.Fill;
            lblTotalReservas.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            lblTotalReservas.ForeColor = Color.FromArgb(10, 25, 47);
            lblTotalReservas.Location = new Point(179, 0);
            lblTotalReservas.Name = "lblTotalReservas";
            lblTotalReservas.Size = new Size(0, 19);
            lblTotalReservas.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(10, 25, 47);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 32);
            label6.TabIndex = 3;
            label6.Text = "RESULTADOS:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvReservas);
            flowLayoutPanel1.Location = new Point(3, 79);
            flowLayoutPanel1.MaximumSize = new Size(0, 369);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(926, 315);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // dgvReservas
            // 
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Columns.AddRange(new DataGridViewColumn[] { codigo_usuario, usuario_nombre, fecha_reserva, horario, comida_tipo, estado_name, fecha_registro });
            dgvReservas.Dock = DockStyle.Fill;
            dgvReservas.Location = new Point(3, 3);
            dgvReservas.MaximumSize = new Size(1000, 0);
            dgvReservas.MinimumSize = new Size(0, 350);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.Size = new Size(881, 350);
            dgvReservas.TabIndex = 1;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnExportar, 3, 0);
            tableLayoutPanel2.Controls.Add(btnCancelar, 2, 0);
            tableLayoutPanel2.Controls.Add(btnConfirmar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnVerDetalle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 425);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(932, 36);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnExportar
            // 
            btnExportar.Dock = DockStyle.Fill;
            btnExportar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnExportar.Location = new Point(702, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(227, 30);
            btnExportar.TabIndex = 15;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(469, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(227, 30);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Fill;
            btnConfirmar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConfirmar.Location = new Point(236, 3);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(227, 30);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Dock = DockStyle.Fill;
            btnVerDetalle.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnVerDetalle.Location = new Point(3, 3);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(227, 30);
            btnVerDetalle.TabIndex = 12;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(cmbComida, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaFiltro, 0, 1);
            tableLayoutPanel1.Controls.Add(cmbEstado, 1, 1);
            tableLayoutPanel1.Controls.Add(btnHoy, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 2);
            tableLayoutPanel1.Controls.Add(btnFiltrar, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(932, 90);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cmbComida
            // 
            cmbComida.Dock = DockStyle.Fill;
            cmbComida.FormattingEnabled = true;
            cmbComida.Location = new Point(626, 33);
            cmbComida.Name = "cmbComida";
            cmbComida.Size = new Size(303, 23);
            cmbComida.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(10, 25, 47);
            label5.Location = new Point(626, 0);
            label5.Name = "label5";
            label5.Size = new Size(303, 30);
            label5.TabIndex = 5;
            label5.Text = "Tipo comida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(10, 25, 47);
            label4.Location = new Point(310, 0);
            label4.Name = "label4";
            label4.Size = new Size(310, 30);
            label4.TabIndex = 4;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(10, 25, 47);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 30);
            label3.TabIndex = 3;
            label3.Text = "Fecha:";
            // 
            // dtpFechaFiltro
            // 
            dtpFechaFiltro.Dock = DockStyle.Fill;
            dtpFechaFiltro.Location = new Point(3, 33);
            dtpFechaFiltro.Name = "dtpFechaFiltro";
            dtpFechaFiltro.Size = new Size(301, 23);
            dtpFechaFiltro.TabIndex = 6;
            // 
            // cmbEstado
            // 
            cmbEstado.Dock = DockStyle.Fill;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(310, 33);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(310, 23);
            cmbEstado.TabIndex = 7;
            // 
            // btnHoy
            // 
            btnHoy.Dock = DockStyle.Fill;
            btnHoy.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnHoy.Location = new Point(3, 63);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(301, 24);
            btnHoy.TabIndex = 9;
            btnHoy.Text = "hoy";
            btnHoy.UseVisualStyleBackColor = true;
            btnHoy.Click += btnHoy_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(310, 63);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(310, 24);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Dock = DockStyle.Fill;
            btnFiltrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnFiltrar.Location = new Point(626, 63);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(303, 24);
            btnFiltrar.TabIndex = 11;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 25, 47);
            label2.Location = new Point(5, 5);
            label2.Name = "label2";
            label2.Size = new Size(248, 32);
            label2.TabIndex = 2;
            label2.Text = "Gestion de Reservas";
            // 
            // Uc_GestionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Uc_GestionReservas";
            Size = new Size(962, 668);
            Load += Uc_GestionReservas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnActualizar;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbComida;
        private DateTimePicker dtpFechaFiltro;
        private ComboBox cmbEstado;
        private Button btnHoy;
        private Button btnLimpiar;
        private Button btnFiltrar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label lblTotalReservas;
        private Label label6;
        private DataGridView dgvReservas;
        private DataGridViewTextBoxColumn codigo_usuario;
        private DataGridViewTextBoxColumn usuario_nombre;
        private DataGridViewTextBoxColumn fecha_reserva;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn comida_tipo;
        private DataGridViewTextBoxColumn estado_name;
        private DataGridViewTextBoxColumn fecha_registro;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnExportar;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Button btnVerDetalle;
        private Panel panel5;
    }
}
