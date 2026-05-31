namespace RestauranteUdenar.Views
{
    partial class RegisterView
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
            label4 = new Label();
            label1 = new Label();
            txt_name = new TextBox();
            txt_email = new TextBox();
            label2 = new Label();
            txt_password = new TextBox();
            label3 = new Label();
            label5 = new Label();
            cmb_roles = new ComboBox();
            btn_registrar = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 35);
            label4.Name = "label4";
            label4.Size = new Size(177, 30);
            label4.TabIndex = 15;
            label4.Text = "Sistema de Subsidio Alimentario\r\nUniversidad de Nariño";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 107);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(38, 125);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(224, 23);
            txt_name.TabIndex = 17;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(38, 201);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(224, 23);
            txt_email.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 183);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(38, 275);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(224, 23);
            txt_password.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 257);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 20;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 327);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 22;
            label5.Text = "Rol";
            // 
            // cmb_roles
            // 
            cmb_roles.FormattingEnabled = true;
            cmb_roles.Location = new Point(38, 345);
            cmb_roles.Name = "cmb_roles";
            cmb_roles.Size = new Size(224, 23);
            cmb_roles.TabIndex = 23;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(38, 422);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(224, 46);
            btn_registrar.TabIndex = 24;
            btn_registrar.Text = "Crear usuario";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 512);
            Controls.Add(btn_registrar);
            Controls.Add(cmb_roles);
            Controls.Add(label5);
            Controls.Add(txt_password);
            Controls.Add(label3);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "RegisterView";
            Text = "Form1";
            Load += RegisterView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private TextBox txt_name;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_password;
        private Label label3;
        private Label label5;
        private ComboBox cmb_roles;
        private Button btn_registrar;
    }
}