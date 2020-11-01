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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.ShowDialog();
        }

        private void TmrTempo_Tick(object sender, EventArgs e)
        {
            tpsData.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            tpsHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\WinWord.exe";
            process1.Start();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\Excel.exe";
            process1.Start();

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files\Microsoft Office\PowerPoint.exe";
            process1.Start();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Mensagem do sistema", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
