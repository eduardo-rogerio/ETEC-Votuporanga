namespace SistemaCadastro
{
    partial class Imc
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
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_resul = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_peso
            // 
            this.txt_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.2F);
            this.txt_peso.Location = new System.Drawing.Point(12, 29);
            this.txt_peso.Multiline = true;
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 76);
            this.txt_peso.TabIndex = 0;
            this.txt_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_altura
            // 
            this.txt_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.2F);
            this.txt_altura.Location = new System.Drawing.Point(166, 29);
            this.txt_altura.Multiline = true;
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(100, 76);
            this.txt_altura.TabIndex = 1;
            this.txt_altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 179);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(87, 37);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(105, 179);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(92, 37);
            this.btn_limp.TabIndex = 3;
            this.btn_limp.Text = "Limpar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(203, 179);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(63, 37);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_resul
            // 
            this.lbl_resul.AutoSize = true;
            this.lbl_resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resul.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_resul.Location = new System.Drawing.Point(12, 135);
            this.lbl_resul.Name = "lbl_resul";
            this.lbl_resul.Size = new System.Drawing.Size(0, 20);
            this.lbl_resul.TabIndex = 5;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.Location = new System.Drawing.Point(11, 3);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(45, 20);
            this.lbl_peso.TabIndex = 6;
            this.lbl_peso.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "https://www.calculoimc.com.br/";
            // 
            // Imc
            // 
            this.ClientSize = new System.Drawing.Size(278, 259);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_resul);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Imc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_resul;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

