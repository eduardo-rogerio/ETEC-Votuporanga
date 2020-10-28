namespace SistemaCadastro
{
    partial class Calculadora
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
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_resul = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(180, 13);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(45, 20);
            this.txt_n2.TabIndex = 0;
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(62, 13);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(45, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // txt_resul
            // 
            this.txt_resul.Location = new System.Drawing.Point(320, 13);
            this.txt_resul.Name = "txt_resul";
            this.txt_resul.Size = new System.Drawing.Size(45, 20);
            this.txt_resul.TabIndex = 2;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(259, 20);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(55, 13);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Resultado";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(4, 20);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(37, 13);
            this.lbl_n2.TabIndex = 4;
            this.lbl_n2.Text = "Valor1";
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(125, 20);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(37, 13);
            this.lbl_n1.TabIndex = 5;
            this.lbl_n1.Text = "Valor2";
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(128, 102);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(75, 23);
            this.btn_mult.TabIndex = 6;
            this.btn_mult.Text = "Multiplicação";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(128, 51);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(75, 23);
            this.btn_soma.TabIndex = 7;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(248, 51);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 23);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "Subtração";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(248, 102);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 23);
            this.btn_div.TabIndex = 9;
            this.btn_div.Text = "Divisão";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 136);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_resul);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.txt_n2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_resul;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_div;
    }
}

