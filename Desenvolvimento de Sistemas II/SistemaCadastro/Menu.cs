using System;
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

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDeProduto objProduto = new CadastroDeProduto();
            objProduto.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "calc.exe";
            process1.Start();
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    clienteToolStripMenuItem_Click(sender,e);
                    break;
                case Keys.F3:
                    produtoToolStripMenuItem_Click(sender, e);
                    break;
            }
        }

        private void TmrTempo_Tick(object sender, EventArgs e)
        {
            tspData.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            tspHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
