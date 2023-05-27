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

namespace estatisticaTechData.Screens
{
    public partial class Frm_EsqueceuSenha : Form
    {
        private estatisticaTechDataClassLibrary.Connection conexao;
        string email;
        public Frm_EsqueceuSenha(string emailUsuario)
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
            email = emailUsuario;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_NovaSenha.Texts))
            {
                MessageBox.Show("Senha não alterada, a senha estava vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(Txt_NovaConfirmacaoSenha.Texts))
            {
                MessageBox.Show("Senha não alterada, a confirmação de senha estava vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Lbl_Resultado.Text != "Inaceitavel" )
                {
                    if(Txt_NovaConfirmacaoSenha.Texts == Txt_NovaSenha.Texts)
                    {
                        string[] columns = {"password" };
                        string where = $"email='{email}'";
                        List<string>[] result = conexao.SelectData("users", columns, where);
                        string SenhaAtual = result[0][0].ToString();

                        if (SenhaAtual != Txt_NovaSenha.Texts)
                        {
                            try
                            {
                                where = "";
                                where = $"email='{email}'";
                                Dictionary<string, string> data = new Dictionary<string, string>();
                                data.Add("password", Txt_NovaSenha.Texts);
                                conexao.UpdateData("users", data, where);
                                MessageBox.Show("Senha atualizada");
                                this.Close();
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("A nova senha não pode ser igual a senha antiga", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha e a confirmação de senha não coincidem","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                    }
                }
                else
                {
                    MessageBox.Show("A força da senha não pode ser inaceitável ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }

        private void Txt_NovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Utils.ChecaForcaSenha verifica = new Cls_Utils.ChecaForcaSenha();
            Cls_Utils.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_NovaSenha.Texts);
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

        private void pcbVerNovaSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderNovaSenha.Visible = true;
            Txt_NovaSenha.PasswordChar = false;
            pcbVerNovaSenha.Visible = false;
        }

        private void pcbEsconderNovaSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderNovaSenha.Visible = false;
            Txt_NovaSenha.PasswordChar = true;
            pcbVerNovaSenha.Visible = true;
        }

        private void pcbVerConfirmeSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderConfirmeNovaSenha.Visible = true;
            Txt_NovaConfirmacaoSenha.PasswordChar = false;
            pcbVerConfirmeNovaSenha.Visible = false;
        }

        private void pcbEsconderConfirmeSenha_Click(object sender, EventArgs e)
        {
            pcbEsconderConfirmeNovaSenha.Visible = false;
            Txt_NovaConfirmacaoSenha.PasswordChar = true;
            pcbVerConfirmeNovaSenha.Visible = true;
        }
    }
}