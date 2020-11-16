namespace SistemaCadastro
{
    partial class comboBox
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
            this.TxtItens = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPosicao = new System.Windows.Forms.TextBox();
            this.TxtSelecao = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnApagarT = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma palavra";
            // 
            // TxtItens
            // 
            this.TxtItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.TxtItens.Location = new System.Drawing.Point(147, 9);
            this.TxtItens.Name = "TxtItens";
            this.TxtItens.Size = new System.Drawing.Size(301, 23);
            this.TxtItens.TabIndex = 1;
            this.TxtItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItens_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(21, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(427, 259);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Posição na lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item selecionado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.label4.Location = new System.Drawing.Point(12, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de itens";
            // 
            // TxtPosicao
            // 
            this.TxtPosicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.TxtPosicao.Location = new System.Drawing.Point(147, 334);
            this.TxtPosicao.Name = "TxtPosicao";
            this.TxtPosicao.ReadOnly = true;
            this.TxtPosicao.Size = new System.Drawing.Size(301, 23);
            this.TxtPosicao.TabIndex = 6;
            // 
            // TxtSelecao
            // 
            this.TxtSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.TxtSelecao.Location = new System.Drawing.Point(147, 361);
            this.TxtSelecao.Name = "TxtSelecao";
            this.TxtSelecao.ReadOnly = true;
            this.TxtSelecao.Size = new System.Drawing.Size(301, 23);
            this.TxtSelecao.TabIndex = 7;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.TxtTotal.Location = new System.Drawing.Point(147, 391);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(301, 23);
            this.TxtTotal.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.btnAdicionar.Location = new System.Drawing.Point(476, 9);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(82, 27);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.btnApagar.Location = new System.Drawing.Point(476, 56);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(82, 28);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnApagarT
            // 
            this.btnApagarT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.btnApagarT.Location = new System.Drawing.Point(476, 102);
            this.btnApagarT.Name = "btnApagarT";
            this.btnApagarT.Size = new System.Drawing.Size(82, 75);
            this.btnApagarT.TabIndex = 11;
            this.btnApagarT.Text = "Apagar todos os itens";
            this.btnApagarT.UseVisualStyleBackColor = true;
            this.btnApagarT.Click += new System.EventHandler(this.btnApagarT_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.btnLimpar.Location = new System.Drawing.Point(476, 197);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 34);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.btnSair.Location = new System.Drawing.Point(476, 251);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 32);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnApagarT);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtSelecao);
            this.Controls.Add(this.TxtPosicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TxtItens);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtItens;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPosicao;
        private System.Windows.Forms.TextBox TxtSelecao;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnApagarT;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

