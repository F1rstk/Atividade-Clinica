using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace clínica_Vida_Saudável
{
    public partial class Paciente : Form
    {
        private string conexaoString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";

        public Paciente()
        {
            InitializeComponent();
            CarregarMedicos();
            CarregarHorariosDisponiveis();
            CarregarConsultasPaciente();
        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter o id do paciente (substitua 3 com a lógica correta para pegar o id do paciente logado)
                int idPaciente = 3; // Substitua por lógica para obter o idPaciente real

                if (idPaciente == 0)
                {
                    MessageBox.Show("Paciente não encontrado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar se o médico foi selecionado
                if (cmbMedico.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um médico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obter o id do médico selecionado
                int idMedico = ObterIdMedico(cmbMedico.SelectedItem.ToString());
                if (idMedico == -1)
                {
                    MessageBox.Show("Médico não encontrado. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar se a data e o horário foram selecionados
                if (dtpData.Value == null || lstHorarioDisponiveis.SelectedItem == null)
                {
                    MessageBox.Show("Selecione a data e o horário da consulta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserir a consulta no banco de dados
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    string query = "INSERT INTO Consulta (idPaciente, idMedicos, dataConsulta, horarioConsulta, status) " +
                                   "VALUES (@idPaciente, @idMedico, @dataConsulta, @horarioConsulta,)"; // 1 para 'Agendada'

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                        cmd.Parameters.AddWithValue("@idMedico", idMedico);
                        cmd.Parameters.AddWithValue("@dataConsulta", dtpData.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@horarioConsulta", lstHorarioDisponiveis.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Consulta agendada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarConsultasPaciente();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao agendar consulta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Implementar a alteração de consulta, se necessário
        }

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

        private void CarregarMedicos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT idMedicos, nome FROM Medicos ORDER BY nome";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbMedico.Items.Clear();
                            while (reader.Read())
                            {
                                cmbMedico.Items.Add(new { Text = reader["nome"].ToString(), Value = reader["idMedicos"] });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar médicos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarHorariosDisponiveis()
        {
            lstHorarioDisponiveis.Items.Clear();
            for (int hora = 7; hora <= 21; hora++)
            {
                lstHorarioDisponiveis.Items.Add($"{hora}:00");
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

        private int ObterIdMedico(string nomeMedico)
        {
            int idMedico = -1;
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT idMedicos FROM Medicos WHERE TRIM(nome) = @nome";  // Use TRIM para garantir que espaços extras não interfiram

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeMedico.Trim());  // Usando Trim para garantir que espaços extras não interfiram
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            idMedico = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show($"Médico '{nomeMedico}' não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter ID do médico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return idMedico;
        }

    }
}
