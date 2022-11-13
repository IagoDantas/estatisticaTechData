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
    public partial class frmDistribuicaoNormal : Form
    {
        public frmDistribuicaoNormal()
        {
            InitializeComponent();
        }

        //Click
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoArquivos historicoArquivos = new frmHistoricoArquivos();
            historicoArquivos.Show();
            this.Close();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracao configuracao = new frmConfiguracao();
            configuracao.Show();
            this.Close();
        }
        private void btnAcessoHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoDistNormal hist = new frmHistoricoDistNormal();
            hist.Show();
            this.Close();
        }


        //Hover
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
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
        }
        private void btnDistribuicao_MouseLeave(object sender, EventArgs e)
        {
            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;
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
            btnConfig.BackColor = Color.FromArgb(220, 236, 223);
            btnConfig.ForeColor = Color.Black;
            pcbConfig.BackColor = Color.FromArgb(220, 236, 223);
        }
        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            pcbConfig.BackColor = Color.FromArgb(0, 107, 117);
        }

        private void frmDistribuicaoNormal_Load(object sender, EventArgs e)
        {

        }
    }
}
