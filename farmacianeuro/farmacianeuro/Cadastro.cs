using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace farmacianeuro
{
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
       
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                /// <summary>
                /// data_source é o caminho do banco de dados
                /// </summary>
                string data_source = "datasource=localhost;username=root;password='';database=farmacia";
                conexao = new MySqlConnection(data_source);
                string sql = "insert into usuario(nome,email,senha,cargo) values (@nome,@email,@senha,@cargo)";
                MySqlCommand command = new MySqlCommand(sql, conexao);
                string senha = txtsenha.Text.Trim();// limpar os espaços gerados
                string senhahash = BCrypt.Net.BCrypt.HashPassword(senha);
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@email", txtemail.Text);
                command.Parameters.AddWithValue("@senha", senhahash);
                command.Parameters.AddWithValue("@cargo", txtcargo.Text);
                conexao.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
        }
    }
}
