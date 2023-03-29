using estatisticaTechData.Resources;
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
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }
        public frmConfiguracao(string username,string email,string senha)
        {
            InitializeComponent();
            txtNome.Text = username;
            txtEmail.Text = email;
            txtSenha.Text = senha;
        }

        private void pcbEditaNome_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtNome.Focus();
            pcbConfirmaNome.Enabled = true;
            pcbEditaNome.Enabled = false;
            pcbConfirmaNome.Visible = true;
            pcbEditaNome.Visible = false;
        }
        private void pcbEditaEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtEmail.Focus();
            pcbConfirmaEmail.Enabled = true;
            pcbEditaEmail.Enabled = false;
            pcbConfirmaEmail.Visible = true;
            pcbEditaEmail.Visible = false;
        }
        private void pcbEditaSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Enabled = true;
            txtSenha.Focus();
            pcbConfirmaSenha.Enabled = true;
            pcbEditaSenha.Enabled = false;
            pcbConfirmaSenha.Visible = true;
            pcbEditaSenha.Visible = false;
        }
        private void pcbConfirmaNome_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            pcbConfirmaNome.Enabled = false;
            pcbEditaNome.Enabled = true;
            pcbConfirmaNome.Visible = false;
            pcbEditaNome.Visible = true;
        }
        private void pcbConfirmaEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = false;
            pcbConfirmaEmail.Enabled = false;
            pcbEditaEmail.Enabled = true;
            pcbConfirmaEmail.Visible = false;
            pcbEditaEmail.Visible = true;
        }
        private void pcbConfirmaSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Enabled = false;
            pcbConfirmaSenha.Enabled = false;
            pcbEditaSenha.Enabled = true;
            pcbConfirmaSenha.Visible = false;
            pcbEditaSenha.Visible = true;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
        private void btnDistribuicao_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicaoNormal = new frmDistribuicaoNormal();
            distribuicaoNormal.Show();
            this.Close();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoArquivos historicoArquivos = new frmHistoricoArquivos();
            historicoArquivos.Show();
            this.Close();
        }

        //hover
        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(220, 236, 223);
            btnInicio.ForeColor = Color.Black;
        }
        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
        }
        private void btnDistribuicao_MouseEnter(object sender, EventArgs e)
        {
            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;
        }
        private void btnDistribuicao_MouseLeave(object sender, EventArgs e)
        {
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
        }
        private void btnPrevisaoDemanda_MouseEnter(object sender, EventArgs e)
        {
            btnPrevisaoDemanda.BackColor = Color.FromArgb(220, 236, 223);
            btnPrevisaoDemanda.ForeColor = Color.Black;
        }
        private void btnPrevisaoDemanda_MouseLeave(object sender, EventArgs e)
        {
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
        }
        private void btnHistorico_MouseEnter(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromArgb(220, 236, 223);
            btnHistorico.ForeColor = Color.Black;
        }
        private void btnHistorico_MouseLeave(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
        }
        private void btnConfig_MouseEnter(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            pcbConfig.BackColor = Color.FromArgb(0, 107, 117);
        }
        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(220, 236, 223);
            btnConfig.ForeColor = Color.Black;
            pcbConfig.BackColor = Color.FromArgb(220, 236, 223);
        }


    }
}
