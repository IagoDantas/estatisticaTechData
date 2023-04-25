using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace estatisticaTechData
{
    public partial class frmCadastro : Form
    {
        private Connection conexao;
        public frmCadastro()
        {
            InitializeComponent();
            conexao = new Connection();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

            int tipoUsuario = rdbAluno.Checked ? tipoUsuario = 1 : tipoUsuario = 0 ;
            int status_usuario = 1;

            if(rdbAluno.Checked == false && rdbProfessor.Checked == false)
            {
                MessageBox.Show("Por favor selecione se é aluno ou professor","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNome.Texts))
            {
                MessageBox.Show("Por favor insira um nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Texts))
            {
                MessageBox.Show("Por favor insira uma senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmaSenha.Texts))
            {
                MessageBox.Show("Por favor insira uma confirmação de senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmaSenha.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                MessageBox.Show("Por favor insira um email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRA.Texts))
            {
                MessageBox.Show("Por favor insira um RA", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRA.Focus();
                return;
            }

            if (txtSenha.Texts == txtConfirmaSenha.Texts)
            {
                try
                {
                    string[] columns = { "email" };
                    string where = $"email='{txtEmail.Texts}'";
                    List<string>[] result = conexao.SelectData("users", columns, where);

                    if (result[0].Count > 0)
                    {
                        MessageBox.Show("Já existe um usuário com este email ou ra ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        Dictionary<string, string> data = new Dictionary<string, string>();
                        data.Add("name", txtNome.Texts);
                        data.Add("email", txtEmail.Texts);
                        data.Add("password", txtSenha.Texts);
                        data.Add("type", tipoUsuario.ToString());

                        if (conexao.InsertData("users", data) == true)
                        {
                            MessageBox.Show("Dados gravados com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gravar dados");
                        }

                        frmHome home = new frmHome();
                        home.Show();
                        this.Close();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
                MessageBox.Show("A senha e a confirmação não coincidem"); 
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("Por favor insira apenas números");
                e.Handled = true;
            }
        }

        private void lklSignIn_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
    }
}
