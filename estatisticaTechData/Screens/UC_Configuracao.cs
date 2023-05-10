using DocumentFormat.OpenXml.Drawing.Diagrams;
using estatisticaTechData.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData
{
    public partial class UC_Configuracao : UserControl
    {
        private estatisticaTechDataClassLibrary.Connection conexao;

        public UC_Configuracao()
        {

            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void UC_Configuracao_Load(object sender, EventArgs e)
        {
            carregaInformacoes();
            txtSenha.PasswordChar = '*';
        }

        public void carregaInformacoes()
        {
            try
            {
                string[] columns = { "name", "email", "password" };
                string where = $"email='{frmHub.funEstancia.emailUser}'";
                List<string>[] result = conexao.SelectData("users", columns, where);
                txtNome.Text = result[0][0].ToString();
                txtEmail.Text = result[1][0].ToString();
                txtSenha.Text = result[2][0].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validaSenha()
        {
            frmValidacao F = new frmValidacao();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            { 
                return true;
            }
            else if(F.DialogResult == DialogResult.No)
            {
                MessageBox.Show($"Senha inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else 
                return false; 
        }

        private void pcbEditaSenha_Click(object sender, EventArgs e)
        {
            bool senhaFrm = validaSenha();
            if(senhaFrm == true)
            {
                txtSenha.Enabled = true;
                txtSenha.Focus();
                txtSenha.PasswordChar = '\0';
                pcbEditaSenha.Enabled = false;
                pcbEditaSenha.Visible = false;
                pcbConfirmaSenha.Visible = true;
                pcbConfirmaSenha.Enabled = true;
            }
        }


        private void pcbEditaEmail_Click(object sender, EventArgs e)
        {
            bool senhaFrm = validaSenha();
            if (senhaFrm == true)
            {
                txtEmail.Enabled = true;
                txtEmail.Focus();
                pcbEditaEmail.Enabled = false;
                pcbEditaEmail.Visible = false;
                pcbConfirmaEmail.Visible = true;
                pcbConfirmaEmail.Enabled = true;
            }
        }

        private void pcbEditaNome_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtNome.Focus();
            pcbEditaNome.Enabled = false;
            pcbEditaNome.Visible = false;
            pcbConfirmaNome.Visible = true;
            pcbConfirmaNome.Enabled = true;
        }
        private void pcbConfirmaSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha não alterada, a caixa de texto estava vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carregaInformacoes();
            }
            else
            {
                try
                {
                    string where = $"email='{frmHub.funEstancia.emailUser}'";
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data.Add("password", txtSenha.Text);
                    conexao.UpdateData("users", data, where);
                    MessageBox.Show("Senha atualizada");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtSenha.Enabled = false;
            txtSenha.PasswordChar = '*';
            pcbEditaSenha.Enabled = true;
            pcbEditaSenha.Visible = true;
            pcbConfirmaSenha.Visible = false;
            pcbConfirmaSenha.Enabled = false;
        }

        private void pcbConfirmaNome_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome não alterado, a caixa de texto estava vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carregaInformacoes();
            }
            else
            {
                try
                {
                    string where = $"email='{frmHub.funEstancia.emailUser}'";
                    Dictionary<string, string> data = new Dictionary<string, string>();
                    data.Add("name", txtNome.Text);
                    conexao.UpdateData("users", data, where);
                    MessageBox.Show("Nome atualizado");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtNome.Enabled = false;
            pcbEditaNome.Enabled = true;
            pcbEditaNome.Visible = true;
            pcbConfirmaNome.Visible = false;
            pcbConfirmaNome.Enabled = false;
        }

        private void pcbConfirmaEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email não alterado, a caixa de texto estava vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                carregaInformacoes();
                txtEmail.Enabled = false;
                pcbEditaEmail.Enabled = true;
                pcbEditaEmail.Visible = true;
                pcbConfirmaEmail.Visible = false;
                pcbConfirmaEmail.Enabled = false;
            }
            else
            {
                try
                {
                    string[] columns = { "email" };
                    string where = $"email='{frmHub.funEstancia.emailUser}'";
                    List<string>[] result = conexao.SelectData("users", columns, where);
                    if (result[0].Count > 0)
                    {
                        MessageBox.Show("Já existe um usuário com este email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                    }
                    else
                    {
                    
                            Dictionary<string, string> data = new Dictionary<string, string>();
                            data.Add("email", txtEmail.Text);
                            conexao.UpdateData("users", data, where);
                            MessageBox.Show("Email atualizado");
                            frmHub.funEstancia.emailUser = txtEmail.Text;
                            txtEmail.Enabled = false;
                            pcbEditaEmail.Enabled = true;
                            pcbEditaEmail.Visible = true;
                            pcbConfirmaEmail.Visible = false;
                            pcbConfirmaEmail.Enabled = false;

                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
