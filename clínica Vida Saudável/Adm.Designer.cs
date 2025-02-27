namespace clínica_Vida_Saudável
{
    partial class Adm
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
            btnSair = new Button();
            btnCadastrar = new Button();
            btnselect = new Button();
            btnExcluir = new Button();
            rdbMédico = new RadioButton();
            lblPaciente = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblcpf = new Label();
            txtCpf = new TextBox();
            lbltelefone = new Label();
            txtTelefone = new TextBox();
            txtemail = new TextBox();
            lblemail = new Label();
            dataGridViewPacientes = new DataGridView();
            lblID = new Label();
            txtIdPaciente = new TextBox();
            rdbPaciente = new RadioButton();
            btnExcluitmed = new Button();
            btnCadastromed = new Button();
            btnmedselect = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(65, 369);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(89, 64);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastro";
            btnCadastrar.TextAlign = ContentAlignment.BottomCenter;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnselect
            // 
            btnselect.Location = new Point(183, 369);
            btnselect.Name = "btnselect";
            btnselect.Size = new Size(89, 64);
            btnselect.TabIndex = 3;
            btnselect.Text = "Select";
            btnselect.TextAlign = ContentAlignment.BottomCenter;
            btnselect.UseVisualStyleBackColor = true;
            btnselect.Click += btnselect_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(300, 369);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(89, 64);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.BottomCenter;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // rdbMédico
            // 
            rdbMédico.AutoSize = true;
            rdbMédico.Location = new Point(25, 74);
            rdbMédico.Name = "rdbMédico";
            rdbMédico.Size = new Size(65, 19);
            rdbMédico.TabIndex = 5;
            rdbMédico.TabStop = true;
            rdbMédico.Text = "Médico";
            rdbMédico.UseVisualStyleBackColor = true;
            rdbMédico.CheckedChanged += rdbMédico_CheckedChanged;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaciente.Location = new Point(291, 12);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(112, 36);
            lblPaciente.TabIndex = 7;
            lblPaciente.Text = "Paciente";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(202, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 8;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(251, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(231, 23);
            txtNome.TabIndex = 9;
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(205, 123);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(31, 15);
            lblcpf.TabIndex = 10;
            lblcpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(251, 123);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(231, 23);
            txtCpf.TabIndex = 11;
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(191, 168);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(54, 15);
            lbltelefone.TabIndex = 12;
            lbltelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(251, 165);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(231, 23);
            txtTelefone.TabIndex = 13;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(251, 212);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(231, 23);
            txtemail.TabIndex = 14;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(165, 219);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(39, 15);
            lblemail.TabIndex = 15;
            lblemail.Text = "Email:";
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Location = new Point(517, 74);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.RowTemplate.Height = 25;
            dataGridViewPacientes.Size = new Size(232, 160);
            dataGridViewPacientes.TabIndex = 16;
            dataGridViewPacientes.Visible = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(192, 263);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 17;
            lblID.Text = "ID:";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Location = new Point(251, 263);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(37, 23);
            txtIdPaciente.TabIndex = 18;
            // 
            // rdbPaciente
            // 
            rdbPaciente.AutoSize = true;
            rdbPaciente.Location = new Point(25, 119);
            rdbPaciente.Name = "rdbPaciente";
            rdbPaciente.Size = new Size(70, 19);
            rdbPaciente.TabIndex = 19;
            rdbPaciente.TabStop = true;
            rdbPaciente.Text = "Paciente";
            rdbPaciente.UseVisualStyleBackColor = true;
            rdbPaciente.CheckedChanged += rdbPaciente_CheckedChanged;
            // 
            // btnExcluitmed
            // 
            btnExcluitmed.Location = new Point(420, 369);
            btnExcluitmed.Name = "btnExcluitmed";
            btnExcluitmed.Size = new Size(89, 64);
            btnExcluitmed.TabIndex = 20;
            btnExcluitmed.Text = "Excluir";
            btnExcluitmed.TextAlign = ContentAlignment.BottomCenter;
            btnExcluitmed.UseVisualStyleBackColor = true;
            btnExcluitmed.Visible = false;
            btnExcluitmed.Click += btnExcluitmed_Click;
            // 
            // btnCadastromed
            // 
            btnCadastromed.Location = new Point(517, 369);
            btnCadastromed.Name = "btnCadastromed";
            btnCadastromed.Size = new Size(89, 64);
            btnCadastromed.TabIndex = 21;
            btnCadastromed.Text = "Cadastro";
            btnCadastromed.TextAlign = ContentAlignment.BottomCenter;
            btnCadastromed.UseVisualStyleBackColor = true;
            btnCadastromed.Visible = false;
            btnCadastromed.Click += btnCadastromed_Click;
            // 
            // btnmedselect
            // 
            btnmedselect.Location = new Point(625, 369);
            btnmedselect.Name = "btnmedselect";
            btnmedselect.Size = new Size(89, 64);
            btnmedselect.TabIndex = 22;
            btnmedselect.Text = "Select";
            btnmedselect.TextAlign = ContentAlignment.BottomCenter;
            btnmedselect.UseVisualStyleBackColor = true;
            btnmedselect.Visible = false;
            btnmedselect.Click += btnmedselect_Click;
            // 
            // Adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnmedselect);
            Controls.Add(btnCadastromed);
            Controls.Add(btnExcluitmed);
            Controls.Add(rdbPaciente);
            Controls.Add(txtIdPaciente);
            Controls.Add(lblID);
            Controls.Add(dataGridViewPacientes);
            Controls.Add(lblemail);
            Controls.Add(txtemail);
            Controls.Add(txtTelefone);
            Controls.Add(lbltelefone);
            Controls.Add(txtCpf);
            Controls.Add(lblcpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblPaciente);
            Controls.Add(rdbMédico);
            Controls.Add(btnExcluir);
            Controls.Add(btnselect);
            Controls.Add(btnCadastrar);
            Controls.Add(btnSair);
            Name = "Adm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnCadastrar;
        private Button btnselect;
        private Button btnExcluir;
        private RadioButton rdbMédico;
        private Label lblPaciente;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblcpf;
        private TextBox txtCpf;
        private Label lbltelefone;
        private TextBox txtTelefone;
        private TextBox txtemail;
        private Label lblemail;
        private DataGridView dataGridViewPacientes;
        private Label lblID;
        private TextBox txtIdPaciente;
        private RadioButton rdbPaciente;
        private Button btnExcluitmed;
        private Button btnCadastromed;
        private Button btnmedselect;
    }
}