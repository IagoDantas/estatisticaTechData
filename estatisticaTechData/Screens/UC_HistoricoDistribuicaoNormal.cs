using estatisticaTechData.Screens;
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
    public partial class UC_HistoricoDistribuicaoNormal : UserControl
    {
        public UC_HistoricoDistribuicaoNormal()
        {
            InitializeComponent();
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            btnDropdown.Visible = false;
            btnComparar.Visible = true;
            btnEditar.Visible = true;
            btnVisualizar.Visible = true;
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            frmHub.funEstancia.abrirCompara();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            btnEdit.Visible = true;
            btnEdit.Enabled = true;
            btnRead.Visible = true;
            btnRead.Enabled = true;
            btnCompara.Visible = true;
            btnCompara.Enabled = true;
            btnShow.Visible = false;
            btnShow.Enabled = false;
        }
    }
}
