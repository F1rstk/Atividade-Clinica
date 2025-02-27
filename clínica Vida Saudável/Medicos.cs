using MySql.Data.MySqlClient;
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
    public partial class Medicos : Form




    {
        public Medicos()
        {
            InitializeComponent();
            CarregarConsultasPaciente();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
           

        }

        private string conexaoString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma consulta para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idConsulta = Convert.ToInt32(dgvConsultas.SelectedRows[0].Cells["idConsulta"].Value);

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "DELETE FROM Consulta WHERE idConsulta = @idConsulta";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idConsulta", idConsulta);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Consulta cancelada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarConsultasPaciente();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarConsultasPaciente()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    string query = "SELECT idConsulta, nome AS Medicos, especialidade, dataConsulta, horarioConsulta, status " +
                                   "FROM Consulta " +
                                   "INNER JOIN Medicos m ON Consulta.idMedicos = m.idMedicos " +
                                   "WHERE Consulta.idPaciente = @idPaciente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", 3); // Trocar com o id do paciente real

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvConsultas.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar consultas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
