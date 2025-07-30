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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void profissionaisDaSaúdeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profissionaisDeSaúdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profsaude f1 = new profsaude();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
