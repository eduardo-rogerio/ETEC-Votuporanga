namespace Triangulo
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
            this.TxtLado1 = new System.Windows.Forms.TextBox();
            this.TxtLado2 = new System.Windows.Forms.TextBox();
            this.TxtLado3 = new System.Windows.Forms.TextBox();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.ImgTriangulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "lado1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "lado3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "lado2";
            // 
            // TxtLado1
            // 
            this.TxtLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtLado1.Location = new System.Drawing.Point(12, 32);
            this.TxtLado1.Name = "TxtLado1";
            this.TxtLado1.Size = new System.Drawing.Size(100, 25);
            this.TxtLado1.TabIndex = 3;
            this.TxtLado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLado1_KeyPress);
            // 
            // TxtLado2
            // 
            this.TxtLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtLado2.Location = new System.Drawing.Point(12, 101);
            this.TxtLado2.Name = "TxtLado2";
            this.TxtLado2.Size = new System.Drawing.Size(100, 25);
            this.TxtLado2.TabIndex = 4;
            this.TxtLado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLado2_KeyPress);
            // 
            // TxtLado3
            // 
            this.TxtLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtLado3.Location = new System.Drawing.Point(12, 162);
            this.TxtLado3.Name = "TxtLado3";
            this.TxtLado3.Size = new System.Drawing.Size(100, 25);
            this.TxtLado3.TabIndex = 5;
            this.TxtLado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLado3_KeyPress);
            // 
            // BtnResultado
            // 
            this.BtnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnResultado.Location = new System.Drawing.Point(253, 331);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(78, 29);
            this.BtnResultado.TabIndex = 6;
            this.BtnResultado.Text = "Verificar";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Enabled = false;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnLimpar.Location = new System.Drawing.Point(378, 331);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 29);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // ImgTriangulo
            // 
            this.ImgTriangulo.Location = new System.Drawing.Point(150, 32);
            this.ImgTriangulo.Name = "ImgTriangulo";
            this.ImgTriangulo.Size = new System.Drawing.Size(405, 257);
            this.ImgTriangulo.TabIndex = 8;
            this.ImgTriangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 384);
            this.Controls.Add(this.ImgTriangulo);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.TxtLado3);
            this.Controls.Add(this.TxtLado2);
            this.Controls.Add(this.TxtLado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImgTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLado1;
        private System.Windows.Forms.TextBox TxtLado2;
        private System.Windows.Forms.TextBox TxtLado3;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.PictureBox ImgTriangulo;
    }
}

