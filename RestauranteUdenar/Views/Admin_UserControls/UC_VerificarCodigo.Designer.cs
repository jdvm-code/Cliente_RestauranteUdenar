namespace RestauranteUdenar.Views.Admin_UserControls
{
    partial class UC_VerificarCodigo
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
            lblResultado = new Label();
            btnLimpiar = new Button();
            btnVerificar = new Button();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(979, 55);
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
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "Validar Asistencias";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblResultado);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnVerificar);
            panel2.Controls.Add(txtCodigo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(66, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 350);
            panel2.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = Color.FromArgb(10, 25, 47);
            lblResultado.Location = new Point(38, 162);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(183, 234);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 31);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnVerificar.Location = new Point(40, 234);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(137, 31);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(40, 160);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(217, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(10, 25, 47);
            label3.Location = new Point(40, 142);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(10, 25, 47);
            label2.Location = new Point(67, 49);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Verificar reserva";
            // 
            // UC_VerificarCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_VerificarCodigo";
            Size = new Size(979, 539);
            Load += UC_VerificarCodigo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private Button btnVerificar;
        private Button btnLimpiar;
        private Label lblResultado;
    }
}
