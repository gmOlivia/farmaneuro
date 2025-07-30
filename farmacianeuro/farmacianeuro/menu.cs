using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmacianeuro
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fornecedores fornecedores = new fornecedores();
            fornecedores.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vendas vendas = new vendas();
            vendas.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estoque estoque = new estoque();
            estoque.ShowDialog();
        }
    }
}
