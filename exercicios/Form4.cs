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
    public partial class frmex13 : Form
    {
        public frmex13()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txta.Clear();
            txtco.Clear();
            txtla.Clear();
            txtno.Focus();
        }

        private void lblnum_Click(object sender, EventArgs e)
        {

        }

        double areatotal;

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double la, co, area;

            la = Convert.ToDouble(txtla.Text);
            co = Convert.ToDouble(txtco.Text);

            area = la * co;
            areatotal += area;
            txta.Text = "A área do Cômodo: " + txtno.Text + " é "  + area.ToString();

            var result = MessageBox.Show("Deseja Continuar calculando?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtla.Clear();
                txtco.Clear();
                txtno.Clear();
                txta.Clear();
                txtno.Focus();
            }

            else
            {
                txtla.Clear();
                txtco.Clear();
                txtno.Clear();
                txta.Clear();
                txta.Text = "A Área Total do Imóvel é " + areatotal.ToString();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal frmprincipal = new frmprincipal();
            frmprincipal.Show();
        }

        private void txtco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
