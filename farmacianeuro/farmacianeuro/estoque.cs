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
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void estoque_Load(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ESTg f1 = new ESTg();
            f1.MdiParent = this;
            f1.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ESTc f2 = new ESTc();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
