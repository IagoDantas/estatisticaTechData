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

        private void btnInicio_MouseHover(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(220, 236, 223);
            btnInicio.ForeColor = Color.Black;
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(0, 107, 117);
            btnInicio.ForeColor = Color.White;
        }

        private void btnDistribuicao_MouseHover(object sender, EventArgs e)
        {
            btnDistribuicao.BackColor = Color.FromArgb(0, 107, 117);
            btnDistribuicao.ForeColor = Color.White;
        }

        private void btnDistribuicao_MouseLeave(object sender, EventArgs e)
        {
            btnDistribuicao.BackColor = Color.FromArgb(220, 236, 223);
            btnDistribuicao.ForeColor = Color.Black;
        }

        private void btnPrevisaoDemanda_MouseHover(object sender, EventArgs e)
        {
            btnPrevisaoDemanda.BackColor = Color.FromArgb(220, 236, 223);
            btnPrevisaoDemanda.ForeColor = Color.Black;
        }

        private void btnPrevisaoDemanda_MouseLeave(object sender, EventArgs e)
        {
            btnPrevisaoDemanda.BackColor = Color.FromArgb(0, 107, 117);
            btnPrevisaoDemanda.ForeColor = Color.White;
        }

        private void btnHistorico_MouseHover(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromArgb(220, 236, 223);
            btnHistorico.ForeColor = Color.Black;
        }

        private void btnHistorico_MouseLeave(object sender, EventArgs e)
        {
            btnHistorico.BackColor = Color.FromArgb(0, 107, 117);
            btnHistorico.ForeColor = Color.White;
        }
    }
}
