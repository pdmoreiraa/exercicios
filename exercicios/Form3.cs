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
    public partial class frmex12 : Form
    {
        public frmex12()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtg.Clear();
            txtresult.Clear();
            txtg.Focus();
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double c, f;
            int i;

            c = Convert.ToDouble(txtg.Text);

            f = (c * 1.8) + 32;

            for (i = 10; i <= 100; i += 10)
            {
                txtresult.Text += "Os Graus somados 10 são: " + (f + i) + " °F" + Environment.NewLine;
            }
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double c, f, i;

            c = Convert.ToDouble(txtg.Text);

            f = (c * 1.8) + 32;

            i = 10;

            do
            {
                txtresult.Text += "Os Graus somados 10 são: " + (f + i) + " °F" + Environment.NewLine;
                i = i + 10;
            } while (i <= 100);
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double c, f, i;

            c = Convert.ToDouble(txtg.Text);

            f = c * 1.8 + 32;

            i = 10;

            while (i <= 100)
            {
                txtresult.Text += "Os Graus somados 10 são: " + (f + i) + " °F" + Environment.NewLine;
                i += 10;
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frmprincipal = new frmprincipal();
            frmprincipal.Show();
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }
    }
}
