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
    public partial class CadastroDeProduto : Form
    {
        public CadastroDeProduto()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Clear();
            TxtDescricao.Clear();
            TxtPreco.Clear();
            TxtQuantidade.Clear();
        }
    }
}
