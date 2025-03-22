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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void TemporizadporSplash_Tick(object sender, EventArgs e)
        {
            frmLogin Loguin = new frmLogin();
            if (progressBar1.Value >= 100)
            {

                Loguin.Show();
                this.Hide();
                TemporizadporSplash.Enabled = false;

            }
            else
            {

                progressBar1.Value = progressBar1.Value + 1;
                lblPorcento.Text = progressBar1.Value.ToString() + " %";
                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {            
        }

        private void lblPorcento_Click(object sender, EventArgs e)
        {

        }
    }
}
