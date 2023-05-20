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
    public partial class Frm_ValidaEmail : Form
    {
        private estatisticaTechDataClassLibrary.Connection conexao;

        public Frm_ValidaEmail()
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Texts))
            {
                MessageBox.Show("Por favor insira um email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                string[] columns = { "email" };
                string where = $"email='{txtEmail.Texts}'";
                List<string>[] result = conexao.SelectData("users", columns, where);

                if (result[0].Count > 0)
                { 
                
                    Screens.Frm_EsqueceuSenha alterarSenha = new Screens.Frm_EsqueceuSenha(txtEmail.Texts);
                    alterarSenha.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Email inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
  
    }
}
