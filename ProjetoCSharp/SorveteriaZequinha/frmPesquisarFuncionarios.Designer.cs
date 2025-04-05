namespace SorveteriaZequinha
{
    partial class frmPesquisarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarFuncionarios));
            this.groupBPesquisarPor = new System.Windows.Forms.GroupBox();
            this.radioBCodigo = new System.Windows.Forms.RadioButton();
            this.radioBNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBDescrição = new System.Windows.Forms.TextBox();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBPesquisarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBPesquisarPor
            // 
            this.groupBPesquisarPor.Controls.Add(this.txtBDescrição);
            this.groupBPesquisarPor.Controls.Add(this.label1);
            this.groupBPesquisarPor.Controls.Add(this.radioBNome);
            this.groupBPesquisarPor.Controls.Add(this.radioBCodigo);
            this.groupBPesquisarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBPesquisarPor.Location = new System.Drawing.Point(12, 12);
            this.groupBPesquisarPor.Name = "groupBPesquisarPor";
            this.groupBPesquisarPor.Size = new System.Drawing.Size(554, 83);
            this.groupBPesquisarPor.TabIndex = 0;
            this.groupBPesquisarPor.TabStop = false;
            this.groupBPesquisarPor.Text = "Pesquisar por";
            // 
            // radioBCodigo
            // 
            this.radioBCodigo.AutoSize = true;
            this.radioBCodigo.Location = new System.Drawing.Point(6, 25);
            this.radioBCodigo.Name = "radioBCodigo";
            this.radioBCodigo.Size = new System.Drawing.Size(77, 24);
            this.radioBCodigo.TabIndex = 1;
            this.radioBCodigo.TabStop = true;
            this.radioBCodigo.Text = "Codigo";
            this.radioBCodigo.UseVisualStyleBackColor = true;
            // 
            // radioBNome
            // 
            this.radioBNome.AutoSize = true;
            this.radioBNome.Location = new System.Drawing.Point(89, 25);
            this.radioBNome.Name = "radioBNome";
            this.radioBNome.Size = new System.Drawing.Size(69, 24);
            this.radioBNome.TabIndex = 2;
            this.radioBNome.TabStop = true;
            this.radioBNome.Text = "Nome";
            this.radioBNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "descrição";
            // 
            // txtBDescrição
            // 
            this.txtBDescrição.Location = new System.Drawing.Point(89, 49);
            this.txtBDescrição.Name = "txtBDescrição";
            this.txtBDescrição.Size = new System.Drawing.Size(260, 26);
            this.txtBDescrição.TabIndex = 3;
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(12, 101);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(554, 160);
            this.lstBox.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(572, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(200, 123);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(572, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 123);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPesquisarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 271);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.groupBPesquisarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa ABC Pesquisar Funcionarios";
            this.groupBPesquisarPor.ResumeLayout(false);
            this.groupBPesquisarPor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBPesquisarPor;
        private System.Windows.Forms.TextBox txtBDescrição;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBNome;
        private System.Windows.Forms.RadioButton radioBCodigo;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
    }
}