using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData.Screens
{
    public partial class UC_CEP : UserControl
    {
        public UC_CEP()
        {
            InitializeComponent();
        }
        private void btnHist_Click(object sender, EventArgs e)
        {
            frmHub.funEstancia.abrirHist();
        }

        private void Btn_NovosDados_Click(object sender, EventArgs e)
        {
            frmHub.funEstancia.abrirTeste();
        }
    }
}
