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
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

            int tipoUsuario = rdbAluno.Checked ? tipoUsuario = 1 : tipoUsuario = 0 ;
            int status_usuario = 1;


            /*if (txtSenha == txtConfirmaSenha)
            {*/
                try
                {
                    string stringconn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\repos\estatisticaTechData\estatisticaTechData.accdb";
                    OleDbConnection conn = new OleDbConnection(stringconn);
                    conn.Open();
                    string SQL;
                    SQL = "insert into tb_usuario(nome,email,senha,tipo_usuario,status_usuario,ra)Values";
                    SQL += "('"+txtNome.Texts+"','"+txtEmail.Texts+"','"+txtSenha.Texts+"','"+tipoUsuario+"','"+status_usuario+"','"+txtRA.Texts+"')";

                    OleDbCommand cmd = new OleDbCommand(SQL, conn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados gravados com sucesso");

                    conn.Close();

                    frmHome home = new frmHome();
                    home.Show();
                    this.Close();
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

        }
           /*} else
                MessageBox.Show("A senha e a confirmação não coincidem");*/
    }
}
