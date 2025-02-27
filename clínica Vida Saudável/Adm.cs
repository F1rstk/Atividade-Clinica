using Microsoft.VisualBasic.Logging;
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
    public partial class Adm : Form
    {
        public Adm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void CarregarPacientes()
        {
            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";
            string query = "SELECT * FROM Paciente"; // Seleciona todos os registros da tabela Paciente

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    // Abrir a conexão com o banco de dados
                    conn.Open();

                    // Criar o comando para a consulta
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Criar um adaptador para preencher os dados no DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                    // Criar um DataTable para armazenar os dados
                    DataTable dataTable = new DataTable();

                    // Preencher o DataTable com os dados da consulta
                    dataAdapter.Fill(dataTable);

                    // Configurar o DataGridView para exibir os dados
                    dataGridViewPacientes.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso a consulta falhe
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        private void CarregarMedicos()
        {
            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";
            string query = "SELECT * FROM Medicos"; // Seleciona todos os registros da tabela Paciente

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    // Abrir a conexão com o banco de dados
                    conn.Open();

                    // Criar o comando para a consulta
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Criar um adaptador para preencher os dados no DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

                    // Criar um DataTable para armazenar os dados
                    DataTable dataTable = new DataTable();

                    // Preencher o DataTable com os dados da consulta
                    dataAdapter.Fill(dataTable);

                    // Configurar o DataGridView para exibir os dados
                    dataGridViewPacientes.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso a consulta falhe
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }





        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string tef = txtTelefone.Text;
            string email = txtemail.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(tef) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO  Paciente(nome, cpf, telefone, email) VALUES (@nome, @cpf, @telefone, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@telefone", tef);
                    cmd.Parameters.AddWithValue("@email", email);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);

                }
            }

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            CarregarPacientes();
            dataGridViewPacientes.Visible = true;
        }

        private void ExcluirPaciente()
        {
            int idPaciente = Convert.ToInt32(txtIdPaciente.Text);

            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";

            using (MySqlConnection conn = new MySqlConnection(connString))
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Paciente WHERE idPaciente = @idPaciente";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idPaciente", idPaciente);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Paciente excluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);

                }



        }

        private void ExcluirMedico()
        {
            int idMedico = Convert.ToInt32(txtIdPaciente.Text);

            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";

            using (MySqlConnection conn = new MySqlConnection(connString))
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Medicos WHERE idMedicos = @idMedicos";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idMedicos", idMedico);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médico excluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);

                }



        }







        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirPaciente(); // Chama o método para excluir o paciente
        }

        private void rdbMédico_CheckedChanged(object sender, EventArgs e)
        {
            lblcpf.Text = "CRM:";
            lblemail.Text = "Especialidade:";
            btnExcluitmed.Location = new Point(300, 369);
            btnExcluitmed.Visible = true;
            btnExcluir.Visible = false;
            btnCadastromed.Visible = true;
            btnCadastromed.Location = new Point(65, 369);
            btnCadastrar.Visible = false;
            btnCadastrar.Location = new Point(517, 369);
            btnselect.Visible = false;
            btnselect.Location = new Point(625, 369);
            btnmedselect.Visible = true;
            btnmedselect.Location = new Point(183, 369);
            dataGridViewPacientes.Visible = false;

        }

        private void rdbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            lblcpf.Text = "CPF:";
            lblemail.Text = "Email:";
            btnExcluir.Visible = true;
            btnExcluitmed.Visible = false;
            btnExcluitmed.Location = new Point(420, 369);
            btnCadastromed.Visible = false;
            btnCadastromed.Location = new Point(517, 369);
            btnCadastrar.Visible = true;
            btnCadastrar.Location = new Point(65, 369);
            btnselect.Visible = true;
            btnselect.Location = new Point(183, 369);
            btnmedselect.Visible = false;
            btnmedselect.Location = new Point(625, 369);
            dataGridViewPacientes.Visible = false;
        }

        private void btnExcluitmed_Click(object sender, EventArgs e)
        {
            ExcluirMedico();
        }

        private void btnCadastromed_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string crm = txtCpf.Text;
            string tef = txtTelefone.Text;
            string especialidade = txtemail.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(crm) || string.IsNullOrWhiteSpace(tef) || string.IsNullOrWhiteSpace(especialidade))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO  Medicos(nome, crm, especialidade, telefone) VALUES (@nome, @crm, @especialidade, @telefone)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@crm", crm);
                    cmd.Parameters.AddWithValue("@telefone", tef);
                    cmd.Parameters.AddWithValue("@especialidade", especialidade);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Médico cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);

                }
            }
        }

        private void btnmedselect_Click(object sender, EventArgs e)
        {
            CarregarMedicos();
            dataGridViewPacientes.Visible = true;
        }
    }
}
