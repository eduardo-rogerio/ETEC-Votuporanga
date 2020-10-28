namespace SistemaCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtItens = new System.Windows.Forms.TextBox();
            this.TxtPosicao = new System.Windows.Forms.TextBox();
            this.TxtSelecao = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnApagarLista = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posição da Lista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Texto Selecionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de Itens";
            // 
            // TxtItens
            // 
            this.TxtItens.Location = new System.Drawing.Point(159, 12);
            this.TxtItens.Name = "TxtItens";
            this.TxtItens.Size = new System.Drawing.Size(441, 20);
            this.TxtItens.TabIndex = 5;
            this.TxtItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItens_KeyPress);
            // 
            // TxtPosicao
            // 
            this.TxtPosicao.Location = new System.Drawing.Point(159, 151);
            this.TxtPosicao.Name = "TxtPosicao";
            this.TxtPosicao.ReadOnly = true;
            this.TxtPosicao.Size = new System.Drawing.Size(125, 20);
            this.TxtPosicao.TabIndex = 6;
            // 
            // TxtSelecao
            // 
            this.TxtSelecao.Location = new System.Drawing.Point(159, 192);
            this.TxtSelecao.Name = "TxtSelecao";
            this.TxtSelecao.ReadOnly = true;
            this.TxtSelecao.Size = new System.Drawing.Size(125, 20);
            this.TxtSelecao.TabIndex = 7;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(159, 237);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(125, 20);
            this.TxtTotal.TabIndex = 8;
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(159, 53);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 9;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnAdicionar.Location = new System.Drawing.Point(525, 42);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 32);
            this.BtnAdicionar.TabIndex = 10;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnExcluir.Location = new System.Drawing.Point(525, 80);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 52);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Excluir Item";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnApagarLista
            // 
            this.BtnApagarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnApagarLista.Location = new System.Drawing.Point(525, 138);
            this.BtnApagarLista.Name = "BtnApagarLista";
            this.BtnApagarLista.Size = new System.Drawing.Size(75, 63);
            this.BtnApagarLista.TabIndex = 12;
            this.BtnApagarLista.Text = "Excluir \r\nlista";
            this.BtnApagarLista.UseVisualStyleBackColor = true;
            this.BtnApagarLista.Click += new System.EventHandler(this.BtnApagarLista_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnLimpar.Location = new System.Drawing.Point(525, 203);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 39);
            this.BtnLimpar.TabIndex = 13;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnSair.Location = new System.Drawing.Point(525, 248);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 29);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 289);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnApagarLista);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtSelecao);
            this.Controls.Add(this.TxtPosicao);
            this.Controls.Add(this.TxtItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtItens;
        private System.Windows.Forms.TextBox TxtPosicao;
        private System.Windows.Forms.TextBox TxtSelecao;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnApagarLista;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}

