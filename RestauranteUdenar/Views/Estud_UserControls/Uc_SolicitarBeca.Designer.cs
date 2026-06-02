namespace RestauranteUdenar.Views.Estud_UserControls
{
    partial class Uc_SolicitarBeca
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
            label2 = new Label();
            btnSolicitarBeca = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(937, 55);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 25, 47);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(361, 32);
            label1.TabIndex = 0;
            label1.Text = "Solicitar beca de alimentacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 25, 47);
            label2.Location = new Point(321, 347);
            label2.Name = "label2";
            label2.Size = new Size(290, 32);
            label2.TabIndex = 1;
            label2.Text = "Terminos y condiciones";
            // 
            // btnSolicitarBeca
            // 
            btnSolicitarBeca.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSolicitarBeca.Location = new Point(262, 237);
            btnSolicitarBeca.Name = "btnSolicitarBeca";
            btnSolicitarBeca.Size = new Size(406, 98);
            btnSolicitarBeca.TabIndex = 9;
            btnSolicitarBeca.Text = "Solicitar Beca";
            btnSolicitarBeca.UseVisualStyleBackColor = true;
            btnSolicitarBeca.Click += btnSolicitarBeca_Click;
            // 
            // Uc_SolicitarBeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSolicitarBeca);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Uc_SolicitarBeca";
            Size = new Size(937, 600);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnSolicitarBeca;
    }
}
