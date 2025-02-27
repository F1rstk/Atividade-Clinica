namespace clínica_Vida_Saudável
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEntrar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            lblemail = new Label();
            lblsenha = new Label();
            txtSenha = new TextBox();
            lbltipo = new Label();
            txtTipo = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            cmbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Image = (Image)resources.GetObject("btnEntrar.Image");
            btnEntrar.Location = new Point(195, 415);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(72, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(224, 224, 224);
            btnSair.FlatAppearance.MouseDownBackColor = Color.Black;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 199, 199);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(195, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(12, 231);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(40, 15);
            lblemail.TabIndex = 4;
            lblemail.Text = "Login:";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(12, 275);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(42, 15);
            lblsenha.TabIndex = 6;
            lblsenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 293);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(246, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Location = new Point(12, 319);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(92, 15);
            lbltipo.TabIndex = 15;
            lbltipo.Text = "Tipo de Usuario:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(156, 341);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(72, 23);
            txtTipo.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(29, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(12, 341);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(133, 242, 229);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(282, 450);
            Controls.Add(cmbTipo);
            Controls.Add(btnLogin);
            Controls.Add(txtTipo);
            Controls.Add(lbltipo);
            Controls.Add(txtSenha);
            Controls.Add(lblsenha);
            Controls.Add(txtEmail);
            Controls.Add(lblemail);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Label lblemail;
        private Label lblsenha;
        private TextBox txtSenha;
        private Label lbltelefone;
        private TextBox txtTelefone;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lbltipo;
        private TextBox txtTipo;
        private TextBox txtEmail;
        private Button btnLogin;
        private ComboBox cmbTipo;
    }
}