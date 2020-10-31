namespace SistemaCadastro
{
    partial class Cadastro_de_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCod = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.DadosPessoais = new System.Windows.Forms.GroupBox();
            this.GroupBoxSexo = new System.Windows.Forms.GroupBox();
            this.RbtnFemenino = new System.Windows.Forms.RadioButton();
            this.RbtnMasculino = new System.Windows.Forms.RadioButton();
            this.BtnLimpaImg = new System.Windows.Forms.Button();
            this.BtnCarregaImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtRg = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtCep = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblLogradouro = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblCep = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkBoxTwitter = new System.Windows.Forms.CheckBox();
            this.ChkBoxFacebook = new System.Windows.Forms.CheckBox();
            this.ChkBoxEmail = new System.Windows.Forms.CheckBox();
            this.TxtTwitter = new System.Windows.Forms.TextBox();
            this.TxtFacebook = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblFacebook = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.DadosPessoais.SuspendLayout();
            this.GroupBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCod
            // 
            this.LblCod.AutoSize = true;
            this.LblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.LblCod.Location = new System.Drawing.Point(6, 29);
            this.LblCod.Name = "LblCod";
            this.LblCod.Size = new System.Drawing.Size(56, 18);
            this.LblCod.TabIndex = 0;
            this.LblCod.Text = "Código";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.LblNome.Location = new System.Drawing.Point(6, 58);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 18);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.LblRg.Location = new System.Drawing.Point(6, 87);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(31, 18);
            this.LblRg.TabIndex = 2;
            this.LblRg.Text = "RG";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.LblTel.Location = new System.Drawing.Point(6, 118);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(145, 18);
            this.LblTel.TabIndex = 3;
            this.LblTel.Text = "Telefone Residencial";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.LblCpf.Location = new System.Drawing.Point(213, 90);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(38, 18);
            this.LblCpf.TabIndex = 4;
            this.LblCpf.Text = "CPF";
            // 
            // DadosPessoais
            // 
            this.DadosPessoais.Controls.Add(this.GroupBoxSexo);
            this.DadosPessoais.Controls.Add(this.BtnLimpaImg);
            this.DadosPessoais.Controls.Add(this.BtnCarregaImg);
            this.DadosPessoais.Controls.Add(this.pictureBox1);
            this.DadosPessoais.Controls.Add(this.TxtTel);
            this.DadosPessoais.Controls.Add(this.TxtCpf);
            this.DadosPessoais.Controls.Add(this.TxtRg);
            this.DadosPessoais.Controls.Add(this.TxtNome);
            this.DadosPessoais.Controls.Add(this.TxtCod);
            this.DadosPessoais.Controls.Add(this.LblCod);
            this.DadosPessoais.Controls.Add(this.LblTel);
            this.DadosPessoais.Controls.Add(this.LblCpf);
            this.DadosPessoais.Controls.Add(this.LblRg);
            this.DadosPessoais.Controls.Add(this.LblNome);
            this.DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.DadosPessoais.Location = new System.Drawing.Point(4, 9);
            this.DadosPessoais.Name = "DadosPessoais";
            this.DadosPessoais.Size = new System.Drawing.Size(789, 236);
            this.DadosPessoais.TabIndex = 5;
            this.DadosPessoais.TabStop = false;
            this.DadosPessoais.Text = "Dados Pessoais";
            // 
            // GroupBoxSexo
            // 
            this.GroupBoxSexo.Controls.Add(this.RbtnFemenino);
            this.GroupBoxSexo.Controls.Add(this.RbtnMasculino);
            this.GroupBoxSexo.Location = new System.Drawing.Point(9, 156);
            this.GroupBoxSexo.Name = "GroupBoxSexo";
            this.GroupBoxSexo.Size = new System.Drawing.Size(222, 72);
            this.GroupBoxSexo.TabIndex = 13;
            this.GroupBoxSexo.TabStop = false;
            this.GroupBoxSexo.Text = "Sexo";
            // 
            // RbtnFemenino
            // 
            this.RbtnFemenino.AutoSize = true;
            this.RbtnFemenino.Location = new System.Drawing.Point(122, 26);
            this.RbtnFemenino.Name = "RbtnFemenino";
            this.RbtnFemenino.Size = new System.Drawing.Size(92, 22);
            this.RbtnFemenino.TabIndex = 1;
            this.RbtnFemenino.TabStop = true;
            this.RbtnFemenino.Text = "Femenino";
            this.RbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // RbtnMasculino
            // 
            this.RbtnMasculino.AutoSize = true;
            this.RbtnMasculino.Location = new System.Drawing.Point(6, 26);
            this.RbtnMasculino.Name = "RbtnMasculino";
            this.RbtnMasculino.Size = new System.Drawing.Size(94, 22);
            this.RbtnMasculino.TabIndex = 0;
            this.RbtnMasculino.TabStop = true;
            this.RbtnMasculino.Text = "Masculino";
            this.RbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // BtnLimpaImg
            // 
            this.BtnLimpaImg.Location = new System.Drawing.Point(642, 76);
            this.BtnLimpaImg.Name = "BtnLimpaImg";
            this.BtnLimpaImg.Size = new System.Drawing.Size(126, 38);
            this.BtnLimpaImg.TabIndex = 12;
            this.BtnLimpaImg.Text = "Limpar Imagem";
            this.BtnLimpaImg.UseVisualStyleBackColor = true;
            // 
            // BtnCarregaImg
            // 
            this.BtnCarregaImg.Location = new System.Drawing.Point(642, 22);
            this.BtnCarregaImg.Name = "BtnCarregaImg";
            this.BtnCarregaImg.Size = new System.Drawing.Size(126, 38);
            this.BtnCarregaImg.TabIndex = 11;
            this.BtnCarregaImg.Text = "Carrega Imagem";
            this.BtnCarregaImg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(479, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 182);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(157, 118);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(170, 23);
            this.TxtTel.TabIndex = 7;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(257, 87);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(165, 23);
            this.TxtCpf.TabIndex = 9;
            // 
            // TxtRg
            // 
            this.TxtRg.Location = new System.Drawing.Point(68, 84);
            this.TxtRg.Name = "TxtRg";
            this.TxtRg.Size = new System.Drawing.Size(139, 23);
            this.TxtRg.TabIndex = 8;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(68, 58);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(405, 23);
            this.TxtNome.TabIndex = 7;
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(68, 29);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.Size = new System.Drawing.Size(100, 23);
            this.TxtCod.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCidade);
            this.groupBox1.Controls.Add(this.TxtBairro);
            this.groupBox1.Controls.Add(this.TxtLogradouro);
            this.groupBox1.Controls.Add(this.TxtCep);
            this.groupBox1.Controls.Add(this.TxtNumero);
            this.groupBox1.Controls.Add(this.LblCidade);
            this.groupBox1.Controls.Add(this.LblLogradouro);
            this.groupBox1.Controls.Add(this.LblBairro);
            this.groupBox1.Controls.Add(this.LblNumero);
            this.groupBox1.Controls.Add(this.LblCep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.groupBox1.Location = new System.Drawing.Point(4, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(517, 57);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(251, 23);
            this.TxtCidade.TabIndex = 9;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(296, 57);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(155, 23);
            this.TxtBairro.TabIndex = 8;
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(333, 28);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(435, 23);
            this.TxtLogradouro.TabIndex = 7;
            // 
            // TxtCep
            // 
            this.TxtCep.Location = new System.Drawing.Point(68, 28);
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(163, 23);
            this.TxtCep.TabIndex = 6;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(68, 57);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(163, 23);
            this.TxtNumero.TabIndex = 5;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(457, 57);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(54, 18);
            this.LblCidade.TabIndex = 4;
            this.LblCidade.Text = "Cidade";
            // 
            // LblLogradouro
            // 
            this.LblLogradouro.AutoSize = true;
            this.LblLogradouro.Location = new System.Drawing.Point(242, 28);
            this.LblLogradouro.Name = "LblLogradouro";
            this.LblLogradouro.Size = new System.Drawing.Size(85, 18);
            this.LblLogradouro.TabIndex = 3;
            this.LblLogradouro.Text = "Logradouro";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(242, 57);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(48, 18);
            this.LblBairro.TabIndex = 2;
            this.LblBairro.Text = "Bairro";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(6, 57);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(62, 18);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "Número";
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.Location = new System.Drawing.Point(6, 31);
            this.LblCep.Name = "LblCep";
            this.LblCep.Size = new System.Drawing.Size(39, 18);
            this.LblCep.TabIndex = 0;
            this.LblCep.Text = "CEP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkBoxTwitter);
            this.groupBox2.Controls.Add(this.ChkBoxFacebook);
            this.groupBox2.Controls.Add(this.ChkBoxEmail);
            this.groupBox2.Controls.Add(this.TxtTwitter);
            this.groupBox2.Controls.Add(this.TxtFacebook);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LblFacebook);
            this.groupBox2.Controls.Add(this.LblEmail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.groupBox2.Location = new System.Drawing.Point(4, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 125);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Extras";
            // 
            // ChkBoxTwitter
            // 
            this.ChkBoxTwitter.AutoSize = true;
            this.ChkBoxTwitter.Location = new System.Drawing.Point(642, 92);
            this.ChkBoxTwitter.Name = "ChkBoxTwitter";
            this.ChkBoxTwitter.Size = new System.Drawing.Size(71, 22);
            this.ChkBoxTwitter.TabIndex = 8;
            this.ChkBoxTwitter.Text = "Twitter";
            this.ChkBoxTwitter.UseVisualStyleBackColor = true;
            // 
            // ChkBoxFacebook
            // 
            this.ChkBoxFacebook.AutoSize = true;
            this.ChkBoxFacebook.Location = new System.Drawing.Point(642, 62);
            this.ChkBoxFacebook.Name = "ChkBoxFacebook";
            this.ChkBoxFacebook.Size = new System.Drawing.Size(96, 22);
            this.ChkBoxFacebook.TabIndex = 7;
            this.ChkBoxFacebook.Text = "FaceBook";
            this.ChkBoxFacebook.UseVisualStyleBackColor = true;
            // 
            // ChkBoxEmail
            // 
            this.ChkBoxEmail.AutoSize = true;
            this.ChkBoxEmail.Location = new System.Drawing.Point(642, 34);
            this.ChkBoxEmail.Name = "ChkBoxEmail";
            this.ChkBoxEmail.Size = new System.Drawing.Size(69, 22);
            this.ChkBoxEmail.TabIndex = 6;
            this.ChkBoxEmail.Text = "E-mail";
            this.ChkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // TxtTwitter
            // 
            this.TxtTwitter.Location = new System.Drawing.Point(89, 91);
            this.TxtTwitter.Name = "TxtTwitter";
            this.TxtTwitter.Size = new System.Drawing.Size(528, 23);
            this.TxtTwitter.TabIndex = 5;
            // 
            // TxtFacebook
            // 
            this.TxtFacebook.Location = new System.Drawing.Point(89, 62);
            this.TxtFacebook.Name = "TxtFacebook";
            this.TxtFacebook.Size = new System.Drawing.Size(528, 23);
            this.TxtFacebook.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(89, 33);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(528, 23);
            this.TxtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Twitter";
            // 
            // LblFacebook
            // 
            this.LblFacebook.AutoSize = true;
            this.LblFacebook.Location = new System.Drawing.Point(6, 64);
            this.LblFacebook.Name = "LblFacebook";
            this.LblFacebook.Size = new System.Drawing.Size(77, 18);
            this.LblFacebook.TabIndex = 1;
            this.LblFacebook.Text = "FaceBook";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(6, 36);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 18);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "E-mail";
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnIncluir.Location = new System.Drawing.Point(4, 493);
            this.BtnIncluir.Margin = new System.Windows.Forms.Padding(6);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(97, 62);
            this.BtnIncluir.TabIndex = 8;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnAlterar.Location = new System.Drawing.Point(113, 493);
            this.BtnAlterar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(98, 62);
            this.BtnAlterar.TabIndex = 9;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnConsultar.Location = new System.Drawing.Point(223, 493);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(108, 62);
            this.BtnConsultar.TabIndex = 10;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnExcluir.Location = new System.Drawing.Point(346, 493);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(80, 62);
            this.BtnExcluir.TabIndex = 11;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnLimpar.Location = new System.Drawing.Point(440, 493);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(88, 62);
            this.BtnLimpar.TabIndex = 12;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.BtnSair.Location = new System.Drawing.Point(540, 493);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(94, 62);
            this.BtnSair.TabIndex = 13;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Cadastro_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro_de_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_de_Clientes";
            this.DadosPessoais.ResumeLayout(false);
            this.DadosPessoais.PerformLayout();
            this.GroupBoxSexo.ResumeLayout(false);
            this.GroupBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblCod;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.GroupBox DadosPessoais;
        private System.Windows.Forms.GroupBox GroupBoxSexo;
        private System.Windows.Forms.RadioButton RbtnFemenino;
        private System.Windows.Forms.RadioButton RbtnMasculino;
        private System.Windows.Forms.Button BtnLimpaImg;
        private System.Windows.Forms.Button BtnCarregaImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtRg;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblLogradouro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblCep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtCep;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblFacebook;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.CheckBox ChkBoxTwitter;
        private System.Windows.Forms.CheckBox ChkBoxFacebook;
        private System.Windows.Forms.CheckBox ChkBoxEmail;
        private System.Windows.Forms.TextBox TxtTwitter;
        private System.Windows.Forms.TextBox TxtFacebook;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
    }
}