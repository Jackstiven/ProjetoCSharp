namespace SorveteriaZequinha
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.grpBDadosPessoais = new System.Windows.Forms.GroupBox();
            this.datTPDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbBFuncao = new System.Windows.Forms.ComboBox();
            this.mskTBTell = new System.Windows.Forms.MaskedTextBox();
            this.mskTBCpf = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTBCEP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBLogradouro = new System.Windows.Forms.TextBox();
            this.txtBCidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpBLocalidade = new System.Windows.Forms.GroupBox();
            this.cmbBUF = new System.Windows.Forms.ComboBox();
            this.cmbBEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBNumero = new System.Windows.Forms.TextBox();
            this.txtBComplemento = new System.Windows.Forms.TextBox();
            this.grpBDadosPessoais.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.grpBLocalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBDadosPessoais
            // 
            this.grpBDadosPessoais.Controls.Add(this.datTPDataDeNascimento);
            this.grpBDadosPessoais.Controls.Add(this.cmbBFuncao);
            this.grpBDadosPessoais.Controls.Add(this.mskTBTell);
            this.grpBDadosPessoais.Controls.Add(this.mskTBCpf);
            this.grpBDadosPessoais.Controls.Add(this.label8);
            this.grpBDadosPessoais.Controls.Add(this.label5);
            this.grpBDadosPessoais.Controls.Add(this.label7);
            this.grpBDadosPessoais.Controls.Add(this.label6);
            this.grpBDadosPessoais.Controls.Add(this.label4);
            this.grpBDadosPessoais.Controls.Add(this.txtBEmail);
            this.grpBDadosPessoais.Controls.Add(this.label3);
            this.grpBDadosPessoais.Controls.Add(this.txtBNome);
            this.grpBDadosPessoais.Controls.Add(this.label2);
            this.grpBDadosPessoais.Controls.Add(this.txtBCodigo);
            this.grpBDadosPessoais.Controls.Add(this.label1);
            this.grpBDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.grpBDadosPessoais.Name = "grpBDadosPessoais";
            this.grpBDadosPessoais.Size = new System.Drawing.Size(760, 115);
            this.grpBDadosPessoais.TabIndex = 0;
            this.grpBDadosPessoais.TabStop = false;
            this.grpBDadosPessoais.Text = "Dados pessoais";
            // 
            // datTPDataDeNascimento
            // 
            this.datTPDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datTPDataDeNascimento.Location = new System.Drawing.Point(389, 53);
            this.datTPDataDeNascimento.Name = "datTPDataDeNascimento";
            this.datTPDataDeNascimento.Size = new System.Drawing.Size(111, 24);
            this.datTPDataDeNascimento.TabIndex = 5;
            this.datTPDataDeNascimento.ValueChanged += new System.EventHandler(this.datTPDataDeNascimento_ValueChanged);
            // 
            // cmbBFuncao
            // 
            this.cmbBFuncao.FormattingEnabled = true;
            this.cmbBFuncao.Items.AddRange(new object[] {
            "Execultivo"});
            this.cmbBFuncao.Location = new System.Drawing.Point(584, 53);
            this.cmbBFuncao.Name = "cmbBFuncao";
            this.cmbBFuncao.Size = new System.Drawing.Size(170, 26);
            this.cmbBFuncao.TabIndex = 6;
            // 
            // mskTBTell
            // 
            this.mskTBTell.Location = new System.Drawing.Point(389, 23);
            this.mskTBTell.Mask = "99999-9999";
            this.mskTBTell.Name = "mskTBTell";
            this.mskTBTell.Size = new System.Drawing.Size(85, 24);
            this.mskTBTell.TabIndex = 2;
            // 
            // mskTBCpf
            // 
            this.mskTBCpf.Location = new System.Drawing.Point(584, 23);
            this.mskTBCpf.Mask = "999,999,999-99";
            this.mskTBCpf.Name = "mskTBCpf";
            this.mskTBCpf.Size = new System.Drawing.Size(112, 24);
            this.mskTBCpf.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dat nascimento";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 1;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tell";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Função";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "CPF";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBEmail
            // 
            this.txtBEmail.Location = new System.Drawing.Point(73, 83);
            this.txtBEmail.MaxLength = 100;
            this.txtBEmail.Name = "txtBEmail";
            this.txtBEmail.Size = new System.Drawing.Size(170, 24);
            this.txtBEmail.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBNome
            // 
            this.txtBNome.Location = new System.Drawing.Point(73, 53);
            this.txtBNome.MaxLength = 50;
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(170, 24);
            this.txtBNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Enabled = false;
            this.txtBCodigo.Location = new System.Drawing.Point(73, 23);
            this.txtBCodigo.MaxLength = 20;
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(170, 24);
            this.txtBCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnVoltar);
            this.panelBotoes.Controls.Add(this.btnLimpar);
            this.panelBotoes.Controls.Add(this.btnPesquisar);
            this.panelBotoes.Controls.Add(this.btnExcluir);
            this.panelBotoes.Controls.Add(this.btnAlterar);
            this.panelBotoes.Controls.Add(this.btnCadastrar);
            this.panelBotoes.Controls.Add(this.btnNovo);
            this.panelBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotoes.Location = new System.Drawing.Point(12, 498);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(766, 51);
            this.panelBotoes.TabIndex = 16;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(654, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 41);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(544, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 41);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(435, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 41);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(326, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 41);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(220, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 41);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(112, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 41);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(3, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNovo.Size = new System.Drawing.Size(110, 41);
            this.btnNovo.TabIndex = 17;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "CEP";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskTBCEP
            // 
            this.mskTBCEP.Location = new System.Drawing.Point(60, 27);
            this.mskTBCEP.Mask = "999,999,999";
            this.mskTBCEP.Name = "mskTBCEP";
            this.mskTBCEP.Size = new System.Drawing.Size(86, 24);
            this.mskTBCEP.TabIndex = 9;
            this.mskTBCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Logradouro";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBLogradouro
            // 
            this.txtBLogradouro.Location = new System.Drawing.Point(243, 27);
            this.txtBLogradouro.MaxLength = 100;
            this.txtBLogradouro.Name = "txtBLogradouro";
            this.txtBLogradouro.Size = new System.Drawing.Size(328, 24);
            this.txtBLogradouro.TabIndex = 10;
            // 
            // txtBCidade
            // 
            this.txtBCidade.Location = new System.Drawing.Point(75, 57);
            this.txtBCidade.MaxLength = 100;
            this.txtBCidade.Name = "txtBCidade";
            this.txtBCidade.Size = new System.Drawing.Size(283, 24);
            this.txtBCidade.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cidade";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBLocalidade
            // 
            this.grpBLocalidade.Controls.Add(this.cmbBUF);
            this.grpBLocalidade.Controls.Add(this.cmbBEstado);
            this.grpBLocalidade.Controls.Add(this.label13);
            this.grpBLocalidade.Controls.Add(this.label9);
            this.grpBLocalidade.Controls.Add(this.label14);
            this.grpBLocalidade.Controls.Add(this.label12);
            this.grpBLocalidade.Controls.Add(this.label15);
            this.grpBLocalidade.Controls.Add(this.label16);
            this.grpBLocalidade.Controls.Add(this.label11);
            this.grpBLocalidade.Controls.Add(this.mskTBCEP);
            this.grpBLocalidade.Controls.Add(this.label10);
            this.grpBLocalidade.Controls.Add(this.txtBLogradouro);
            this.grpBLocalidade.Controls.Add(this.txtBNumero);
            this.grpBLocalidade.Controls.Add(this.txtBComplemento);
            this.grpBLocalidade.Controls.Add(this.txtBCidade);
            this.grpBLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBLocalidade.Location = new System.Drawing.Point(12, 133);
            this.grpBLocalidade.Name = "grpBLocalidade";
            this.grpBLocalidade.Size = new System.Drawing.Size(760, 115);
            this.grpBLocalidade.TabIndex = 8;
            this.grpBLocalidade.TabStop = false;
            this.grpBLocalidade.Text = "Localidade";
            // 
            // cmbBUF
            // 
            this.cmbBUF.FormattingEnabled = true;
            this.cmbBUF.Location = new System.Drawing.Point(611, 55);
            this.cmbBUF.Name = "cmbBUF";
            this.cmbBUF.Size = new System.Drawing.Size(143, 26);
            this.cmbBUF.TabIndex = 14;
            // 
            // cmbBEstado
            // 
            this.cmbBEstado.FormattingEnabled = true;
            this.cmbBEstado.Location = new System.Drawing.Point(424, 55);
            this.cmbBEstado.Name = "cmbBEstado";
            this.cmbBEstado.Size = new System.Drawing.Size(147, 26);
            this.cmbBEstado.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 1;
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(577, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "UF";
            this.label14.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Estado";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(577, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Número";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Complemento";
            this.label16.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBNumero
            // 
            this.txtBNumero.Location = new System.Drawing.Point(645, 27);
            this.txtBNumero.MaxLength = 100;
            this.txtBNumero.Name = "txtBNumero";
            this.txtBNumero.Size = new System.Drawing.Size(109, 24);
            this.txtBNumero.TabIndex = 11;
            // 
            // txtBComplemento
            // 
            this.txtBComplemento.Location = new System.Drawing.Point(123, 85);
            this.txtBComplemento.MaxLength = 100;
            this.txtBComplemento.Name = "txtBComplemento";
            this.txtBComplemento.Size = new System.Drawing.Size(235, 24);
            this.txtBComplemento.TabIndex = 15;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.grpBLocalidade);
            this.Controls.Add(this.grpBDadosPessoais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antas Trabalhadoras";
            this.grpBDadosPessoais.ResumeLayout(false);
            this.grpBDadosPessoais.PerformLayout();
            this.panelBotoes.ResumeLayout(false);
            this.grpBLocalidade.ResumeLayout(false);
            this.grpBLocalidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBDadosPessoais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.TextBox txtBEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTBCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBFuncao;
        private System.Windows.Forms.MaskedTextBox mskTBTell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datTPDataDeNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTBCEP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBLogradouro;
        private System.Windows.Forms.TextBox txtBCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpBLocalidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBUF;
        private System.Windows.Forms.ComboBox cmbBEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBNumero;
        private System.Windows.Forms.TextBox txtBComplemento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
    }
}