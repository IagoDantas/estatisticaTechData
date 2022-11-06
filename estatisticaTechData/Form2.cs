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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            frmDistribuicaoNormal distribuicao = new frmDistribuicaoNormal();
            distribuicao.Show();
            this.Close();
        }
        
    }
}
