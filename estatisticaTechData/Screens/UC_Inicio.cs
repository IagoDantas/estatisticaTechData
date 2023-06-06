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
    public partial class UC_Inicio : UserControl
    {
        private estatisticaTechDataClassLibrary.Connection conexao;
        public UC_Inicio()
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void UC_Inicio_Load(object sender, EventArgs e)
        {
            carregaInformacoes();
        }

        public void carregaInformacoes()
        {
            try
            {
                string[] columns = { "name", "email", "password" };
                string where = $"email='{frmHub.funEstancia.emailUser}'";
                List<string>[] result = conexao.SelectData("users", columns, where);
                lblName.Text = result[0][0].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
