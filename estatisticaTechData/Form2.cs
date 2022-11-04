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
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicao = new frmDistribuicaoNormal();
            distribuicao.Show();
            this.Close();
        }
   
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }
        private void txtRa_Enter(object sender, EventArgs e)
        {
            txtRa.Text = "";
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }
        private void txtSenhaConfirma_Enter(object sender, EventArgs e)
        {
            txtSenhaConfirma.Text = "";
        }

        
    }
}
