namespace RestauranteUdenar.Views
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lbl_register = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 205);
            label4.Name = "label4";
            label4.Size = new Size(177, 30);
            label4.TabIndex = 14;
            label4.Text = "Sistema de Subsidio Alimentario\r\nUniversidad de Nariño";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.Cursor = Cursors.Hand;
            lbl_register.Location = new Point(39, 472);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(195, 15);
            lbl_register.TabIndex = 13;
            lbl_register.Text = "¿Aún no estas registrado? Clic Aqui.";
            lbl_register.Click += lbl_register_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(39, 413);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(224, 46);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 360);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 342);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 298);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 280);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 512);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lbl_register);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "LoginView";
            Text = "LoginView";
            FormClosing += LoginView_FormClosing_1;
            Load += LoginView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private Label lbl_register;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
    }
}