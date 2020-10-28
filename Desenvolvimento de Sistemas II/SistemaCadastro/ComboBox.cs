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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Add(TxtItens.Text);
            TxtItens.Clear();
            TxtItens.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex != -1)
            {
                ComboBox.Items.RemoveAt(ComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
        }

        private void BtnApagarLista_Click(object sender, EventArgs e)
        {
            ComboBox.Items.Clear();
            TxtPosicao.Text = " ";
            TxtSelecao.Text = " ";
            TxtTotal.Text = " ";
            TxtItens.Focus();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtItens.Clear();
            ComboBox.SelectedIndex = -1;
            TxtPosicao.Text = " ";
            TxtSelecao.Text = " ";
            TxtTotal.Text = " ";
            TxtItens.Focus();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox.SelectedIndex != -1)
            {
                TxtPosicao.Text = ComboBox.SelectedIndex.ToString();
                TxtSelecao.Text = ComboBox.SelectedItem.ToString();
                TxtTotal.Text = ComboBox.Items.Count.ToString();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                BtnAdicionar_Click(sender, e);
            }
        }

    }
}
    

