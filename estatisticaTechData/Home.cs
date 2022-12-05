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
        public frmHome()
        {
            InitializeComponent();
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
                estatisticaTechDataDataSetTableAdapters.tb_usuarioTableAdapter user = new estatisticaTechDataDataSetTableAdapters.tb_usuarioTableAdapter();
                estatisticaTechDataDataSet.tb_usuarioDataTable dt = user.GetDataByEmailPassword(txtUser.Texts,txtPassword.Texts);
                
                if(dt.Rows.Count > 0)
                {
                    string username = dt.Rows[0]["nome"].ToString();
                    string email = dt.Rows[0]["email"].ToString();
                    string senha = dt.Rows[0]["senha"].ToString();
                    MessageBox.Show("Login efetuado com sucesso!!\nVocê será redirecionado a página de menu.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    frmMenu menu = new frmMenu(username,email,senha);
                    menu.Show();
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
    }
}
