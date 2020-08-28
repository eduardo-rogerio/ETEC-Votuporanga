using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            decimal peso, altura, resul;
            peso = Convert.ToDecimal(txt_peso.Text);
            altura = Convert.ToDecimal(txt_altura.Text);
            resul = peso / (altura * altura);

            if (resul < 17)
            {
                lbl_resul.Text =(resul.ToString("F ") +" Muito abaixo do peso") ;
            }
            else if (resul >=17 && resul <= 18)
            {
                lbl_resul.Text = (resul.ToString("F ") + " abaixo do peso");
            }
            else if (resul>18 && resul <= 24)
            {
                lbl_resul.Text = (resul.ToString("F") + " Peso normal");
            }
            else if (resul>24 && resul<= 29)
            {
                lbl_resul.Text = (resul.ToString("F") + " Acima do peso");
            }
            else if (resul>30 && resul<=34)
            {
                lbl_resul.Text = (resul.ToString("F") + " Obesidade I");
            }
            else if (resul > 34 && resul <= 40)
            {
                lbl_resul.Text = (resul.ToString("F") + " Obesidade II");
            }
            else if (resul > 40)
            {
                lbl_resul.Text = (" Seu IMC é "+resul.ToString("F")+" Obesidade III");
            }


        }

        private void btn_limp_Click(object sender, EventArgs e)
        {
            txt_altura.Clear();
            txt_peso.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?","Mensagem do sistema",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
