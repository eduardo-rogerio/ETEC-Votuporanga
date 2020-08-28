using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            txt_n1.Focus();
        }
        public void limpar() {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n1.Focus();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);
            resul = n1 + n2;
            txt_resul.Text = resul.ToString();

            limpar();
            txt_n1.Focus();

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);
            resul = n1 - n2;
            txt_resul.Text = resul.ToString();

            limpar();
            txt_n1.Focus();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);
            resul = n1 * n2;
            txt_resul.Text = resul.ToString();

            limpar();
            txt_n1.Focus();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double n1, n2, resul;
            n1 = Double.Parse(txt_n1.Text);
            n2 = Double.Parse(txt_n2.Text);

            if (n2==0)
            {
                MessageBox.Show("Impossível fazer divisão por 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txt_n2.Focus();
            }
            else { 
            resul = n1 / n2;
            txt_resul.Text = resul.ToString();
            }
            limpar();
            txt_n1.Focus();
        }
    }
}
