using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clínica_Vida_Saudável
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paciente paciente = new Paciente(); // ou outro formulário que você deseja abrir
            paciente.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medicos med = new Medicos(); // ou outro formulário que você deseja abrir
            med.Show();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adm ad = new Adm(); // ou outro formulário que você deseja abrir
            ad.Show();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agendamento agendamento = new Agendamento(); // ou outro formulário que você deseja abrir
            agendamento.Show();
        }
    }
}
