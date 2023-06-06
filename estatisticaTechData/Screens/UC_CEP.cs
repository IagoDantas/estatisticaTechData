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

        private void btnVIsualize_Click(object sender, EventArgs e)
        {
            if (rdbVariaveis.Checked)
            {
                frmHub.funEstancia.abrirBackgroundVariaveis();
                frmHub.funEstancia.abrirCEPVariavel();
            }else if (rdbAtributos.Checked)
            {
                frmHub.funEstancia.abrirBackgroundAtributos();
                frmHub.funEstancia.abrirCEPAtributo();
            }
            else
            {
                MessageBox.Show("Selecione uma opção", "Erro",MessageBoxButtons.OK ,MessageBoxIcon.Error );
            }
        }
    }
}
