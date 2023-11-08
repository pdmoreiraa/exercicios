using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void exercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex11 frmex11 = new frmex11();
            frmex11.Show();
        }

        private void exercicio12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex12 frmex12 = new frmex12();
            frmex12.Show();
        }

        private void exercicio13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex13 frmex13 = new frmex13();
            frmex13.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
