﻿using System;
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
        public frmCadastro()
        {
            InitializeComponent();
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

            if (txtSenha == txtConfirmaSenha)
            {   
                try
                {
                    estatisticaTechDataDataSetTableAdapters.tb_usuarioTableAdapter user = new estatisticaTechDataDataSetTableAdapters.tb_usuarioTableAdapter();
                    estatisticaTechDataDataSet.tb_usuarioDataTable dt = user.GetDataByEmailPassword(txtEmail.Texts, txtSenha.Texts);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Já existe um usuário com este email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string stringconn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\repos\estatisticaTechData\estatisticaTechData.accdb";
                        OleDbConnection conn = new OleDbConnection(stringconn);
                        conn.Open();
                        string SQL;
                        SQL = "insert into tb_usuario(nome,email,senha,tipo_usuario,status_usuario,ra)Values";
                        SQL += "('" + txtNome.Texts + "','" + txtEmail.Texts + "','" + txtSenha.Texts + "','" + tipoUsuario + "','" + status_usuario + "','" + txtRA.Texts + "')";

                        OleDbCommand cmd = new OleDbCommand(SQL, conn);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dados gravados com sucesso");

                        conn.Close();

                        frmHome home = new frmHome();
                        home.Show();
                        this.Close();
                    }
                    
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
            else
                MessageBox.Show("A senha e a confirmação não coincidem"); 
        }
    }
}
