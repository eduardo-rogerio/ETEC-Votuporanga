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
    public partial class comboBox : Form
    {
        public comboBox()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox.Items.Add((object)this.TxtItens.Text);
            TxtItens.Clear();
            TxtItens.Focus();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.ComboBox.SelectedIndex != -1)
            {
                System.Windows.Forms.ComboBox.Items.RemoveAt(System.Windows.Forms.ComboBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
        }

        private void BtnApagarLista_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox.Items.Clear();
            TxtPosicao.Text = " ";
            TxtSelecao.Text = " ";
            TxtTotal.Text = " ";
            TxtItens.Focus();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtItens.Clear();
            System.Windows.Forms.ComboBox.SelectedIndex = -1;
            TxtPosicao.Text = " ";
            TxtSelecao.Text = " ";
            TxtTotal.Text = " ";
            TxtItens.Focus();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (System.Windows.Forms.ComboBox.SelectedIndex != -1)
            {
                TxtPosicao.Text = System.Windows.Forms.ComboBox.SelectedIndex.ToString();
                TxtSelecao.Text = System.Windows.Forms.ComboBox.SelectedItem.ToString();
                TxtTotal.Text = System.Windows.Forms.ComboBox.Items.Count.ToString();
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
    

