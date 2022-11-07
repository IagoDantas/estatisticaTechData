using System;
using estatisticaTechData.Resources;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lklSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }

        private void btnAddGraficoDistNormal_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicao = new frmDistribuicaoNormal();
            distribuicao.Show();
            this.Close();
        }

        private void btnVisualizarGraficoDistNormal_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicao = new frmDistribuicaoNormal();
            distribuicao.Show();
            this.Close();
        }

        private void btnHistoricoArquivos_Click(object sender, EventArgs e)
        {
            frmHistoricoArquivos historicoArquivos = new frmHistoricoArquivos();
            historicoArquivos.Show();
            this.Close();
        }
    }
}
