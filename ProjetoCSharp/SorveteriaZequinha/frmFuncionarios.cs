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
            desabilitarCampos();
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

        public void desabilitarCampos()
        {
            txtBNome.Enabled = false;
            txtBCidade.Enabled = false;
            txtBCodigo.Enabled = false;
            txtBComplemento.Enabled = false;
            txtBEmail.Enabled = false;
            txtBLogradouro.Enabled = false;
            txtBNumero.Enabled = false;
            mskTBCEP.Enabled = false;
            mskTBCpf.Enabled = false;
            mskTBTell.Enabled = false;
            cmbBEstado.Enabled = false;
            cmbBFuncao.Enabled = false;
            cmbBUF.Enabled = false;
            datTPDataDeNascimento.Enabled = false;
            
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            txtBNome.Enabled = true;
            txtBCidade.Enabled = true;
            txtBCodigo.Enabled = true;
            txtBComplemento.Enabled = true;
            txtBEmail.Enabled = true;
            txtBLogradouro.Enabled = true;
            txtBNumero.Enabled = true;
            mskTBCEP.Enabled = true;
            mskTBCpf.Enabled = true;
            mskTBTell.Enabled = true;
            cmbBEstado.Enabled = true;
            cmbBFuncao.Enabled = true;
            cmbBUF.Enabled = true;
            datTPDataDeNascimento.Enabled=true;

            btnAlterar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;

        }

        private void datTPDataDeNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtBCidade.Equals("") ||
                txtBCidade.Equals("") ||
                txtBCodigo.Equals("") ||
                txtBComplemento.Equals("") ||
                txtBEmail.Equals("") ||
                txtBLogradouro.Equals("") ||
                txtBNumero.Equals("") ||
                mskTBCEP.Equals("   .   .") ||
                mskTBCpf.Equals("   .   .   -") ||
                mskTBTell.Equals("     -") ||
                cmbBEstado.Equals("") ||
                cmbBFuncao.Equals("") ||
                cmbBUF.Equals("") ||
                datTPDataDeNascimento.Equals(""))
            {

                MessageBox.Show

            }
        }
    }
}
