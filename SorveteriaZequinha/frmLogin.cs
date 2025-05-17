using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

            Usuario = txtBoxUsu.Text.Trim();
            Senha = txtBoxSenha.Text.Trim();

            if (validarUsu(Usuario,Senha))
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

        private void btnConectar_Click_1(object sender, EventArgs e)
        {

            Conexao.obterConexao();

            MessageBox.Show("DataBase Conectado");

            Conexao.fecharConaxao();
        }

        //Criando o método de validar o usuário

        public bool validarUsu(string nome, string senha)
        {

            MySqlCommand comm = new MySqlCommand();

            comm.CommandText = "SELECT * FROM `usuarios` WHERE " +
                "Nome = @nome AND " +
                "Senha = @senha;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome",MySqlDbType.VarChar,50).Value = nome;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,50).Value = senha;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            bool resp = DR.HasRows;

            Conexao.fecharConaxao();

            return resp;

        }

    }
}
