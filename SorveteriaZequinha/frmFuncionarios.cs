using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorveteriaZequinha
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        public void desabilitandoCampos()
        {
            txtBNome.Enabled = false;
            txtBEmail.Enabled = false;
            txtBLogradouro.Enabled = false;
            txtBCidade.Enabled = false;
            txtBCodigo.Enabled = false;
            txtBComplemento.Enabled = false;
            txtBNumero.Enabled = false;
            mskTBCEP.Enabled = false;
            mskTBCpf.Enabled = false;
            mskTBTell.Enabled = false;
            cmbBEstado.Enabled = false;
            cmbBFuncao.Enabled = false;
            cmbBUF.Enabled = false;
            txtBBairro.Enabled = false;

            datTPDataDeNascimento.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }

        public void habilitandoCampos()
        {
            txtBNome.Enabled = true;
            txtBEmail.Enabled = true;
            txtBLogradouro.Enabled = true;
            txtBCidade.Enabled = true;
            txtBCodigo.Enabled = true;
            txtBComplemento.Enabled = true;
            txtBNumero.Enabled = true;
            mskTBCEP.Enabled = true;
            mskTBCpf.Enabled = true;
            mskTBTell.Enabled = true;
            cmbBEstado.Enabled = true;
            cmbBFuncao.Enabled = true;
            cmbBUF.Enabled = true;
            txtBBairro.Enabled = true;

            datTPDataDeNascimento.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
