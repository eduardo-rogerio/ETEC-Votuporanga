using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == " ") || (txtSenha.Text == " "))
            {
                MessageBox.Show("Usuário ou senha em branco favor digitar","aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((txtUsuario.Text == "Bauer") && (txtSenha.Text == "123"))
            {
                Hide();
                Menu objMenu = new Menu();
                objMenu.ShowDialog();
            }
        }
    }
}
