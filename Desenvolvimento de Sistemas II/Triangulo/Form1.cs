using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool VerificaTriangulo(int l1, int l2, int l3)
        {
            bool resul; 

            if (l1 > l2 - l3 && l1 < l2 + l3)
            {
                resul = true;
            }
            else if (l2 > l1 - l3 && l2 < l1 - l3)
            {
                resul = true;
            }
            else if (l3 > l1 - l2 && l3 < l1 + l2)
            {
                resul = true;
            }
            else
            {
                resul = false;
                MessageBox.Show("Não forma triângulo");
            }

            return resul;
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtLado1.Text) || string.IsNullOrWhiteSpace(TxtLado2.Text) || string.IsNullOrWhiteSpace(TxtLado3.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            int l1 = int.Parse(TxtLado1.Text);
            int l2 = int.Parse(TxtLado2.Text);
            int l3 = int.Parse(TxtLado3.Text);

            BtnLimpar.Enabled = true;

            if (VerificaTriangulo(l1,l2,l3) != false) 
            {
            

            if (l1==l2 && l2==l3)
            {
                ImgTriangulo.Image = Properties.Resources.TRIANGULO_EQUILATERO;
                

            }
            else if(l1!=l2 && l2!=l3 && l3 != l1)
            {
                ImgTriangulo.Image = Properties.Resources.TRIANGULO_ESCALENO;
                
            }
            else
            {
                ImgTriangulo.Image = Properties.Resources.TRIANGULO_ACUTANGULO;
                
            }

            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtLado1.Clear();
            TxtLado2.Clear();
            TxtLado3.Clear();
            TxtLado1.Focus();

            BtnLimpar.Enabled = false;

            ImgTriangulo.Image = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl,!e.Shift,true,true,true);  
            }
        }

        private void TxtLado1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtLado2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void TxtLado3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
