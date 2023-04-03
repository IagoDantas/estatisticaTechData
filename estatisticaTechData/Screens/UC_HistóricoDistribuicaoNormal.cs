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
    public partial class UC_HistóricoDistribuicaoNormal : UserControl
    {
        public UC_HistóricoDistribuicaoNormal()
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

       
    }
}
