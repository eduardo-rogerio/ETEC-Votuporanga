using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TxtItens.Text);
            TxtItens.Clear();
            TxtItens.Focus();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nenhum item foi selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApagarT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar todos os itens", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                listBox1.Items.Clear();
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxtItens.Clear();
            listBox1.SelectedIndex = -1;
            TxtPosicao.Text = " ";
            TxtSelecao.Text = " ";
            TxtTotal.Text = " ";
            TxtItens.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                TxtPosicao.Text = listBox1.SelectedIndex.ToString();
                TxtSelecao.Text = listBox1.SelectedItem.ToString();
                TxtTotal.Text = listBox1.Items.Count.ToString();
            }
        }

        private void TxtItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAdicionar_Click(sender, e);
            }
        }
    }
 }

