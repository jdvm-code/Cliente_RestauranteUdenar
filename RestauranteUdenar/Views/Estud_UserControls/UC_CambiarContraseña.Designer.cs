namespace RestauranteUdenar.Views.Estud_UserControls
{
    partial class UC_CambiarContraseña
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
            label6 = new Label();
            btnActualizarContraseña = new Button();
            txtConfirmarContrasenia = new TextBox();
            label5 = new Label();
            txtNuevaContrasenia = new TextBox();
            label4 = new Label();
            txtContraseniaAnterior = new TextBox();
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
            panel1.Size = new Size(935, 55);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 0;
            label1.Text = "Cambiar contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnActualizarContraseña);
            panel2.Controls.Add(txtConfirmarContrasenia);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNuevaContrasenia);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtContraseniaAnterior);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(31, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 478);
            panel2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(44, 273);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 8;
            label6.Text = "Al menos 8 caracteres.";
            // 
            // btnActualizarContraseña
            // 
            btnActualizarContraseña.Location = new Point(67, 404);
            btnActualizarContraseña.Name = "btnActualizarContraseña";
            btnActualizarContraseña.Size = new Size(162, 30);
            btnActualizarContraseña.TabIndex = 7;
            btnActualizarContraseña.Text = "Actualizar";
            btnActualizarContraseña.UseVisualStyleBackColor = true;
            // 
            // txtConfirmarContrasenia
            // 
            txtConfirmarContrasenia.Location = new Point(44, 335);
            txtConfirmarContrasenia.Name = "txtConfirmarContrasenia";
            txtConfirmarContrasenia.Size = new Size(216, 23);
            txtConfirmarContrasenia.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 317);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 5;
            label5.Text = "Confirmar contraseña";
            // 
            // txtNuevaContrasenia
            // 
            txtNuevaContrasenia.Location = new Point(44, 247);
            txtNuevaContrasenia.Name = "txtNuevaContrasenia";
            txtNuevaContrasenia.Size = new Size(216, 23);
            txtNuevaContrasenia.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 229);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Nueva contraseña";
            // 
            // txtContraseniaAnterior
            // 
            txtContraseniaAnterior.Location = new Point(44, 169);
            txtContraseniaAnterior.Name = "txtContraseniaAnterior";
            txtContraseniaAnterior.Size = new Size(216, 23);
            txtContraseniaAnterior.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 151);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 1;
            label3.Text = "Contraseña anterior";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 65);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 0;
            label2.Text = "Cambiar contraseña";
            // 
            // UC_CambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_CambiarContraseña";
            Size = new Size(935, 598);
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
        private TextBox txtNuevaContrasenia;
        private Label label4;
        private TextBox txtContraseniaAnterior;
        private Label label3;
        private Label label2;
        private TextBox txtConfirmarContrasenia;
        private Label label5;
        private Button btnActualizarContraseña;
        private Label label6;
    }
}
