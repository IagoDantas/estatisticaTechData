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
    public partial class frmCompara : Form
    {
        public frmCompara()
        {
            InitializeComponent();
        }
       
        
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicaoNormal = new frmDistribuicaoNormal();
            distribuicaoNormal.ShowDialog();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            frmHistoricoArquivos historico = new frmHistoricoArquivos();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracao configuracao = new frmConfiguracao();
        }
    }
}
