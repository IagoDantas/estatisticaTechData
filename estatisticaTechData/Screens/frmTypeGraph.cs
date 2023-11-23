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
    public partial class frmTypeGraph : Form
    {
        public frmTypeGraph()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (rdbDist.Checked == true)
            {
                DialogResult = DialogResult.Retry;
                this.Close();
            }else if (rdbAtributo.Checked == true)
            {
                DialogResult = DialogResult.Ignore;
                this.Close();
            }
            else if(rdbVariavel.Checked == true)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Marque um opção de gráfico!", "Erro");
            }
        }
    }
}
