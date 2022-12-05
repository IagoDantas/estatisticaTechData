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

        public frmMenu(string username, string email, string senha)
        {
            InitializeComponent();
            lblUsuario.Text = username;
        }

        private void lklSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddGraficoDistNormal_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicao = new frmDistribuicaoNormal();
            distribuicao.Show();
            this.Close();
        }

        private void btnVisualizarGraficoDistNormal_Click(object sender, EventArgs e)
        {
            frmHistoricoDistNormal historicoDist = new frmHistoricoDistNormal();
            historicoDist.Show();
            this.Close();
        }

        private void btnHistoricoArquivos_Click(object sender, EventArgs e)
        {
            frmHistoricoArquivos historicoArquivos = new frmHistoricoArquivos();
            historicoArquivos.Show();
            this.Close();
        }

        private void btnConfigUsuario_Click(object sender, EventArgs e)
        {
            frmConfiguracao configuracao = new frmConfiguracao();
            configuracao.Show();
            this.Close();
        }

  
    }
}
