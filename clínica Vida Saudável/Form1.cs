using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace clínica_Vida_Saudável
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add("Administrador");
            cmbTipo.Items.Add("Médico");
            cmbTipo.Items.Add("Paciente");
        }





        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtEmail.Text;
            string senha = txtSenha.Text;
            string tipoDeUsuario = txtTipo.Text;


            // Validação simples para campos vazios
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipoDeUsuario))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }



            // Conexão com o MySQL
            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Usuario (login, senha, tipoDeUsuario) VALUES (@login, @senha, @tipoDeUsuario)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@tipoDeUsuario", tipoDeUsuario);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtEmail.Text;
            string senha = txtSenha.Text;
            string tipoDeUsuario = cmbTipo.SelectedItem?.ToString(); // Agora pegamos o tipo da ComboBox

            // Validação de campos
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipoDeUsuario))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int tipoUsuarioValor;

            // Convertendo o tipo de usuário selecionado na ComboBox para um valor numérico
            switch (tipoDeUsuario.ToLower()) // Usando ToLower para garantir que a comparação seja insensível a maiúsculas/minúsculas
            {
                case "administrador":
                    tipoUsuarioValor = 1;
                    break;
                case "médico":
                    tipoUsuarioValor = 2;
                    break;
                case "paciente":
                    tipoUsuarioValor = 3;
                    break;
                default:
                    MessageBox.Show("Tipo de usuário inválido.");
                    return;
            }

            string connString = "Server=localhost;Database=ClinicaVidaSaudavel;Uid=root;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Alterando a consulta para buscar o login e senha
                    string query = "SELECT tipoDeUsuario FROM Usuario WHERE login = @login AND senha = @senha";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Login ou senha incorretos.");
                        return;
                    }

                    int tipoUsuarioDB = Convert.ToInt32(result); // Convertendo o tipoDeUsuario retornado para número

                    if (tipoUsuarioDB != tipoUsuarioValor)
                    {
                        MessageBox.Show("O tipo de usuário selecionado não corresponde ao cadastrado.");
                        return;
                    }

                    string mensagemUsuario = "Acesso permitido!";
                    Form formDestino = null; // Variável para armazenar o formulário correto

                    // Mudando a lógica do switch para usar números no lugar de strings
                    switch (tipoUsuarioDB)
                    {
                        case 1: // Administrador
                            mensagemUsuario += " Você está acessando como Administrador.";
                            formDestino = new Adm(); // Formulário para Administrador
                            break;
                        case 2: // Médico
                            mensagemUsuario += " Você está acessando como Médico.";
                            formDestino = new Medicos(); // Formulário para Médico
                            break;
                        case 3: // Paciente
                            mensagemUsuario += " Você está acessando como Paciente.";
                            formDestino = new Paciente(); // Formulário para Paciente
                            break;
                        default:
                            mensagemUsuario += " Tipo de usuário não reconhecido.";
                            break;
                    }

                    MessageBox.Show(mensagemUsuario);

                    if (formDestino != null)
                    {
                        formDestino.Show(); // Mostra o formulário correspondente
                        this.Hide(); // Esconde a tela de login
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}




