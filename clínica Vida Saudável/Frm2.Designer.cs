namespace clínica_Vida_Saudável
{
    partial class Frm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm2));
            btnSair = new Button();
            btnPaciente = new Button();
            btnMedico = new Button();
            btnADM = new Button();
            btnAgendamento = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(1517, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPaciente
            // 
            btnPaciente.BackgroundImage = (Image)resources.GetObject("btnPaciente.BackgroundImage");
            btnPaciente.BackgroundImageLayout = ImageLayout.Center;
            btnPaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnPaciente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPaciente.FlatStyle = FlatStyle.Flat;
            btnPaciente.Location = new Point(50, 21);
            btnPaciente.Name = "btnPaciente";
            btnPaciente.Size = new Size(373, 323);
            btnPaciente.TabIndex = 1;
            btnPaciente.Text = "Paciente";
            btnPaciente.TextAlign = ContentAlignment.BottomCenter;
            btnPaciente.UseVisualStyleBackColor = true;
            btnPaciente.Click += btnPaciente_Click;
            // 
            // btnMedico
            // 
            btnMedico.BackgroundImage = (Image)resources.GetObject("btnMedico.BackgroundImage");
            btnMedico.BackgroundImageLayout = ImageLayout.Center;
            btnMedico.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnMedico.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMedico.FlatStyle = FlatStyle.Flat;
            btnMedico.Location = new Point(50, 478);
            btnMedico.Name = "btnMedico";
            btnMedico.Size = new Size(373, 323);
            btnMedico.TabIndex = 2;
            btnMedico.Text = "Médico";
            btnMedico.TextAlign = ContentAlignment.BottomCenter;
            btnMedico.UseVisualStyleBackColor = true;
            btnMedico.Click += btnMedico_Click;
            // 
            // btnADM
            // 
            btnADM.BackgroundImage = (Image)resources.GetObject("btnADM.BackgroundImage");
            btnADM.BackgroundImageLayout = ImageLayout.Center;
            btnADM.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnADM.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnADM.FlatStyle = FlatStyle.Flat;
            btnADM.Location = new Point(1069, 21);
            btnADM.Name = "btnADM";
            btnADM.Size = new Size(373, 323);
            btnADM.TabIndex = 3;
            btnADM.Text = "Adm";
            btnADM.TextAlign = ContentAlignment.BottomCenter;
            btnADM.UseVisualStyleBackColor = true;
            btnADM.Click += btnADM_Click;
            // 
            // btnAgendamento
            // 
            btnAgendamento.BackgroundImage = (Image)resources.GetObject("btnAgendamento.BackgroundImage");
            btnAgendamento.BackgroundImageLayout = ImageLayout.Center;
            btnAgendamento.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnAgendamento.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAgendamento.FlatStyle = FlatStyle.Flat;
            btnAgendamento.Location = new Point(1050, 478);
            btnAgendamento.Name = "btnAgendamento";
            btnAgendamento.Size = new Size(373, 323);
            btnAgendamento.TabIndex = 4;
            btnAgendamento.Text = "Agendamento";
            btnAgendamento.TextAlign = ContentAlignment.BottomCenter;
            btnAgendamento.UseVisualStyleBackColor = true;
            btnAgendamento.Click += btnAgendamento_Click;
            // 
            // Frm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 881);
            Controls.Add(btnAgendamento);
            Controls.Add(btnADM);
            Controls.Add(btnMedico);
            Controls.Add(btnPaciente);
            Controls.Add(btnSair);
            DoubleBuffered = true;
            Name = "Frm2";
            Text = "Frm2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnPaciente;
        private Button btnMedico;
        private Button btnADM;
        private Button btnAgendamento;
    }
}