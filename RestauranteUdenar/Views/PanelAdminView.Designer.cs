namespace RestauranteUdenar.Views
{
    partial class PanelAdminView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdminView));
            pnl_slidebar = new Panel();
            btn_logoutAdmin = new Button();
            btn_verificarCodigo = new Button();
            btn_reportesAdmin = new Button();
            btn_reservasAdmin = new Button();
            panel3 = new Panel();
            label5 = new Label();
            lblBienvenida = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Fpnl_UC_Controls = new FlowLayoutPanel();
            panel1 = new Panel();
            label7 = new Label();
            pnl_slidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Fpnl_UC_Controls.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_slidebar
            // 
            pnl_slidebar.BackColor = Color.FromArgb(0, 150, 64);
            pnl_slidebar.Controls.Add(btn_logoutAdmin);
            pnl_slidebar.Controls.Add(btn_verificarCodigo);
            pnl_slidebar.Controls.Add(btn_reportesAdmin);
            pnl_slidebar.Controls.Add(btn_reservasAdmin);
            pnl_slidebar.Controls.Add(panel3);
            pnl_slidebar.Controls.Add(panel2);
            pnl_slidebar.Dock = DockStyle.Left;
            pnl_slidebar.Location = new Point(0, 0);
            pnl_slidebar.Name = "pnl_slidebar";
            pnl_slidebar.Padding = new Padding(5);
            pnl_slidebar.Size = new Size(250, 564);
            pnl_slidebar.TabIndex = 0;
            // 
            // btn_logoutAdmin
            // 
            btn_logoutAdmin.BackColor = Color.Transparent;
            btn_logoutAdmin.Dock = DockStyle.Top;
            btn_logoutAdmin.FlatAppearance.BorderSize = 0;
            btn_logoutAdmin.FlatStyle = FlatStyle.Flat;
            btn_logoutAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logoutAdmin.ForeColor = SystemColors.Control;
            btn_logoutAdmin.Image = (Image)resources.GetObject("btn_logoutAdmin.Image");
            btn_logoutAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logoutAdmin.Location = new Point(5, 281);
            btn_logoutAdmin.Name = "btn_logoutAdmin";
            btn_logoutAdmin.Padding = new Padding(15, 10, 15, 10);
            btn_logoutAdmin.Size = new Size(240, 54);
            btn_logoutAdmin.TabIndex = 10;
            btn_logoutAdmin.Text = "Cerrar sesión";
            btn_logoutAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logoutAdmin.UseVisualStyleBackColor = false;
            btn_logoutAdmin.Click += btn_logoutAdmin_Click;
            // 
            // btn_verificarCodigo
            // 
            btn_verificarCodigo.BackColor = Color.Transparent;
            btn_verificarCodigo.Dock = DockStyle.Top;
            btn_verificarCodigo.FlatAppearance.BorderSize = 0;
            btn_verificarCodigo.FlatStyle = FlatStyle.Flat;
            btn_verificarCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_verificarCodigo.ForeColor = SystemColors.Control;
            btn_verificarCodigo.Image = (Image)resources.GetObject("btn_verificarCodigo.Image");
            btn_verificarCodigo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_verificarCodigo.Location = new Point(5, 227);
            btn_verificarCodigo.Name = "btn_verificarCodigo";
            btn_verificarCodigo.Padding = new Padding(15, 10, 15, 10);
            btn_verificarCodigo.Size = new Size(240, 54);
            btn_verificarCodigo.TabIndex = 9;
            btn_verificarCodigo.Text = "Verificar Código";
            btn_verificarCodigo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_verificarCodigo.UseVisualStyleBackColor = false;
            btn_verificarCodigo.Click += btn_verificarCodigo_Click;
            // 
            // btn_reportesAdmin
            // 
            btn_reportesAdmin.BackColor = Color.Transparent;
            btn_reportesAdmin.Dock = DockStyle.Top;
            btn_reportesAdmin.FlatAppearance.BorderSize = 0;
            btn_reportesAdmin.FlatStyle = FlatStyle.Flat;
            btn_reportesAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportesAdmin.ForeColor = SystemColors.Control;
            btn_reportesAdmin.Image = (Image)resources.GetObject("btn_reportesAdmin.Image");
            btn_reportesAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportesAdmin.Location = new Point(5, 173);
            btn_reportesAdmin.Name = "btn_reportesAdmin";
            btn_reportesAdmin.Padding = new Padding(15, 10, 15, 10);
            btn_reportesAdmin.Size = new Size(240, 54);
            btn_reportesAdmin.TabIndex = 8;
            btn_reportesAdmin.Text = "Reportes";
            btn_reportesAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reportesAdmin.UseVisualStyleBackColor = false;
            btn_reportesAdmin.Click += btn_reportesAdmin_Click;
            // 
            // btn_reservasAdmin
            // 
            btn_reservasAdmin.BackColor = Color.Transparent;
            btn_reservasAdmin.Dock = DockStyle.Top;
            btn_reservasAdmin.FlatAppearance.BorderSize = 0;
            btn_reservasAdmin.FlatStyle = FlatStyle.Flat;
            btn_reservasAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reservasAdmin.ForeColor = SystemColors.Control;
            btn_reservasAdmin.Image = (Image)resources.GetObject("btn_reservasAdmin.Image");
            btn_reservasAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reservasAdmin.Location = new Point(5, 119);
            btn_reservasAdmin.Name = "btn_reservasAdmin";
            btn_reservasAdmin.Padding = new Padding(15, 10, 15, 10);
            btn_reservasAdmin.Size = new Size(240, 54);
            btn_reservasAdmin.TabIndex = 7;
            btn_reservasAdmin.Text = "Gestión Reservas";
            btn_reservasAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reservasAdmin.UseVisualStyleBackColor = false;
            btn_reservasAdmin.Click += btn_reservasAdmin_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblBienvenida);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(5, 62);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2);
            panel3.Size = new Size(240, 57);
            panel3.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(59, 31);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "correo@udenar.edu.co";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(59, 14);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(111, 17);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "Nombre Apellido";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(5);
            pictureBox2.Size = new Size(53, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(240, 57);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(59, 31);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "UDENAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 14);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 3;
            label4.Text = "SUBSIDIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.dinner;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(5);
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Fpnl_UC_Controls
            // 
            Fpnl_UC_Controls.Controls.Add(panel1);
            Fpnl_UC_Controls.Dock = DockStyle.Fill;
            Fpnl_UC_Controls.Location = new Point(250, 0);
            Fpnl_UC_Controls.Name = "Fpnl_UC_Controls";
            Fpnl_UC_Controls.Size = new Size(771, 564);
            Fpnl_UC_Controls.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(647, 44);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(10, 25, 47);
            label7.Location = new Point(10, 10);
            label7.Name = "label7";
            label7.Size = new Size(153, 25);
            label7.TabIndex = 1;
            label7.Text = "Panel Estudiante";
            // 
            // PanelAdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1021, 564);
            Controls.Add(Fpnl_UC_Controls);
            Controls.Add(pnl_slidebar);
            Name = "PanelAdminView";
            Text = "PanelAdminView";
            pnl_slidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Fpnl_UC_Controls.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_slidebar;
        private FlowLayoutPanel Fpnl_UC_Controls;
        private Panel panel3;
        private Label label5;
        private Label lblBienvenida;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btn_logoutAdmin;
        private Button btn_verificarCodigo;
        private Button btn_reportesAdmin;
        private Button btn_reservasAdmin;
        private Panel panel1;
        private Label label7;
    }
}