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
    public partial class frmex11 : Form
    {
        public frmex11()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            int n, i, r;

            n = Convert.ToInt32(txtnum.Text);

            for (i = 0; i <= 10; i++)
            {
                r = n * i;
                txtresult.Text = String.Concat(txtresult.Text+"\r\n" + r.ToString());
            }
            


        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frmprincipal = new frmprincipal();
            frmprincipal.Show();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            int n, i, r;

            n = Convert.ToInt32(txtnum.Text);

            i = 1;
            while (i <= 10)
            {
                r = n * i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + r.ToString());
                i++;
            }

        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            int n, i, r;

            n = Convert.ToInt32(txtnum.Text);

            i = 1;
            do
            {
                r = n * i;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + r.ToString());
                i++;
            }
            while (i <= 10);
        }
    }
}
