namespace clínica_Vida_Saudável
{
    partial class Paciente
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
            btnAgendar = new Button();
            btnAlterar = new Button();
            btnCancelar = new Button();
            dgvConsultas = new DataGridView();
            dtpData = new DateTimePicker();
            lstHorarioDisponiveis = new ComboBox();
            cmbMedico = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(699, 426);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 22);
            btnSair.TabIndex = 0;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(12, 353);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(189, 67);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(273, 353);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(189, 67);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(599, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 67);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvConsultas
            // 
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(0, 1);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowTemplate.Height = 25;
            dgvConsultas.Size = new Size(799, 150);
            dgvConsultas.TabIndex = 5;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(0, 157);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(799, 23);
            dtpData.TabIndex = 6;
            // 
            // lstHorarioDisponiveis
            // 
            lstHorarioDisponiveis.FormattingEnabled = true;
            lstHorarioDisponiveis.Location = new Point(0, 201);
            lstHorarioDisponiveis.Name = "lstHorarioDisponiveis";
            lstHorarioDisponiveis.Size = new Size(799, 23);
            lstHorarioDisponiveis.TabIndex = 7;
            // 
            // cmbMedico
            // 
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(0, 248);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(235, 23);
            cmbMedico.TabIndex = 8;
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbMedico);
            Controls.Add(lstHorarioDisponiveis);
            Controls.Add(dtpData);
            Controls.Add(dgvConsultas);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(btnAgendar);
            Controls.Add(btnSair);
            Name = "Paciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paciente";
            Load += Paciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnAgendar;
        private Button btnAlterar;
        private Button btnCancelar;
        private DataGridView dgvConsultas;
        private DateTimePicker dtpData;
        private ComboBox lstHorarioDisponiveis;
        private ComboBox cmbMedico;
    }
}