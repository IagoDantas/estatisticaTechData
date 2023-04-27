using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData
{
    public partial class frmHome : Form
    {
        private estatisticaTechDataClassLibrary.Connection conexao;
        public frmHome()
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void lklSignUp_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Visible = false;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPassword.Focus();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSignIn.PerformClick();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(txtUser.Texts))
            {
                MessageBox.Show("Por favor insira um email","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Texts))
            {
                MessageBox.Show("Por favor insira uma senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                string[] columns = { "name", "email", "password" };
                string where = $"email='{txtUser.Texts}' AND password='{txtPassword.Texts}'";
                List<string>[] result = conexao.SelectData("users", columns, where);

                if (result[0].Count > 0)
                {
                    string username = result[0][0].ToString();
                    string email = result[1][0].ToString();
                    string senha = result[2][0].ToString();
                    MessageBox.Show("Login efetuado com sucesso!!\nVocê será redirecionado a página de menu.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    frmHub hub = new frmHub();
                    hub.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Seu email ou a sua senha estão incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
