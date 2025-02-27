namespace clínica_Vida_Saudável
{
    partial class Medicos
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
            dgvConsultas = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(703, 413);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(85, 25);
            btnSair.TabIndex = 0;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // dgvConsultas
            // 
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(2, 1);
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.RowTemplate.Height = 25;
            dgvConsultas.Size = new Size(798, 349);
            dgvConsultas.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 366);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(221, 72);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Medicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(dgvConsultas);
            Controls.Add(btnSair);
            Name = "Medicos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private DataGridView dgvConsultas;
        private Button btnCancelar;
    }
}