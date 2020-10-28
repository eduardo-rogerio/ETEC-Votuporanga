using IMC;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes objcadastro = new Cadastro_de_Clientes();
            objcadastro.ShowDialog();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calculadora objcalculadora = new Calculadora();
            objcalculadora.ShowDialog();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imc objimc = new Imc();
            objimc.ShowDialog();
        }

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulo objTriangulo = new Triangulo();
            objTriangulo.ShowDialog();
        }
    }
}
