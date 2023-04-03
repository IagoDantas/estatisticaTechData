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
    public partial class frmHub : Form
    {
        public frmHub()
        {
            InitializeComponent();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            uC_DistribuicaoNormal1.Enabled = false;
            uC_DistribuicaoNormal1.Visible = false;
            uC_HistóricoDistribuicaoNormal1.Visible = true;
            uC_HistóricoDistribuicaoNormal1.Enabled = true;
            uC_DistribuicaoNormalComparacao1.Enabled = false;
            uC_DistribuicaoNormalComparacao1.Visible = false;
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(220, 236, 223);
            btnHistorico.ForeColor = Color.Black;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = false;
            btnPrevisaoDemanda.Enabled = true;
        }

        private void btnPrevisaoDemanda_Click(object sender, EventArgs e)
        {
            uC_DistribuicaoNormal1.Enabled = false;
            uC_DistribuicaoNormal1.Visible = false;
            uC_DistribuicaoNormalComparacao1.Enabled = true;
            uC_DistribuicaoNormalComparacao1.Visible = true;
            uC_HistóricoDistribuicaoNormal1.Visible = false;
            uC_HistóricoDistribuicaoNormal1.Enabled = false;
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(220, 236, 223);
            btnPrevisaoDemanda.ForeColor = Color.Black;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnDistribuicao.Enabled = true;
            btnHistorico.Enabled = true;
            btnPrevisaoDemanda.Enabled = false;
        }

        private void btnDistribuicao_Click(object sender, EventArgs e)
        {
            uC_DistribuicaoNormal1.Enabled = true;
            uC_DistribuicaoNormal1.Visible = true;
            uC_DistribuicaoNormalComparacao1.Enabled = false;
            uC_DistribuicaoNormalComparacao1.Visible = false;
            uC_HistóricoDistribuicaoNormal1.Visible = false;
            uC_HistóricoDistribuicaoNormal1.Enabled = false;
            btnConfig.BackColor = Color.FromArgb(0, 107, 117);
            btnConfig.ForeColor = Color.White;
            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
            btnDistribuicao.Enabled = false;
            btnHistorico.Enabled = true;
            btnPrevisaoDemanda.Enabled = true;

        }
    }
}
