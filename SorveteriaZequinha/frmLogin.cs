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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Usuario, Senha;

            Usuario = "Classe";
            Senha = "Mago";

            if (txtBoxSenha.Text.Trim().Equals(Senha) && txtBoxUsu.Text.Trim().Equals(Usuario))
            {
            
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            
            }
            else 
            {

                limpeza();
                erro();

            };

            /*frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();*/

        }

        public void erro()
        {

            MessageBox.Show("Burro. Tenta denovo",
                    "HAHAHAHHAHAHAAAHHAHAHHAHA BURRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        public void limpeza()
        {

            txtBoxUsu.Clear();
            txtBoxSenha.Clear();
            txtBoxUsu.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                button1.Focus();

            };

        }

        private void txtBoxUsu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                txtBoxSenha.Focus();

            };

        }
    }
}
