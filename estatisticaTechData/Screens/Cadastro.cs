﻿using estatisticaTechDataClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace estatisticaTechData
{
    public partial class frmCadastro : Form
    {
        private estatisticaTechDataClassLibrary.Connection conexao;
        public frmCadastro()
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Utils.ChecaForcaSenha verifica = new Cls_Utils.ChecaForcaSenha(); 
            Cls_Utils.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txtSenha.Texts);
            Lbl_Resultado.Text = forca.ToString();
            if (Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" || Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }
       
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

            int tipoUsuario = rdbAluno.Checked ? tipoUsuario = 1 : tipoUsuario = 0;
            int status_usuario = 1;

            if (rdbAluno.Checked == false && rdbProfessor.Checked == false)
            {
                MessageBox.Show("Por favor selecione se é aluno ou professor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (Lbl_Resultado.Text != "Inaceitavel")
            {
                if (txtSenha.Texts == txtConfirmaSenha.Texts)
                {
                    try
                    {
                        string[] columns = { "email" };
                        string where = $"email='{txtEmail.Texts}'";
                        List<string>[] result = conexao.SelectData("users", columns, where);

                        string[] columnsAluno = { "ra" };
                        string whereAluno = $"ra='{txtRA.Texts}'";
                        List<string>[] resultAluno = conexao.SelectData("users", columns, where);

                        if (result[0].Count > 0 || resultAluno[0].Count > 0)
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

                                string[] columns2 = { "id" };
                                string where2 = $"email='{txtEmail.Texts}' AND password='{txtSenha.Texts}'";
                                List<string>[] result2 = conexao.SelectData("users", columns2, where2);

                                Dictionary<string, string> dataAluno = new Dictionary<string, string>();
                                dataAluno.Add("ra", txtRA.Texts);
                                dataAluno.Add("user_id", result2[0][0].ToString());

                                if (conexao.InsertData("students", dataAluno) == true)
                                {
                                    MessageBox.Show("Dados gravados com sucesso");
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao gravar dados");
                                }

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
            else
                MessageBox.Show("A força da senha não pode ser inaceitável ");

        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
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

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            pcbEsconderSenha.Visible = false;
            pcbEsconderConfirmeSenha.Visible = false;
        }

        private void pcbVerSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderSenha.Visible = true;
            txtSenha.PasswordChar = false;
            pcbVerSenha.Visible = false;
        }

        private void pcbEsconderSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderSenha.Visible = false;
            txtSenha.PasswordChar = true;
            pcbVerSenha.Visible = true;
        }

        private void pcbVerConfirmeSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderConfirmeSenha.Visible = true;
            txtConfirmaSenha.PasswordChar = false;
            pcbVerConfirmeSenha.Visible = false;
        }

        private void pcbEsconderConfirmeSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderConfirmeSenha.Visible = false;
            txtConfirmaSenha.PasswordChar = true;
            pcbVerConfirmeSenha.Visible = true;
        }
    }
}
