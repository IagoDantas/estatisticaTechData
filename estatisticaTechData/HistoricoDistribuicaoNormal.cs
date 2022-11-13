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
    public partial class frmHistoricoDistNormal : Form
    {
        public frmHistoricoDistNormal()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            frmCompara compara = new frmCompara();
            compara.Show();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicaoNormal = new frmDistribuicaoNormal();
            distribuicaoNormal.ShowDialog();
            this.Close();
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            btnDropdown.Visible = false;
            btnComparar.Visible = true;
            btnEditar.Visible = true;
            btnVisualizar.Visible = true;
        }
    }
}
