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
    public partial class UC_HistoricoArquivos : UserControl
    {
        private string userName;
        private DateTime fileDate;
        string email, senha;

        private estatisticaTechDataClassLibrary.Connection conexao;

        public UC_HistoricoArquivos()
        {
            InitializeComponent();
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void UC_HistoricoArquivos_Load(object sender, EventArgs e)
        {
           /* Dictionary<string, object> userInfo = carregaInformacoes();
            string userId = userInfo["id"].ToString();
            userName = userInfo["nome"].ToString();
            email = userInfo["email"].ToString();
            senha = userInfo["senha"].ToString();

            // Obter a data do arquivo
            string[] chargeColumns = { "date" };
            string chargeWhere = $"user_id = {userId}"; // Supondo que o arquivo associado ao usuário logado seja o mais recente
            List<string>[] chargeResult = conexao.SelectData("charge", chargeColumns, chargeWhere);
            if (chargeResult[0].Count > 0)
            {
                fileDate = DateTime.Parse(chargeResult[0][0]); // Converter a string em DateTime
            }*/
        }

        /*public Dictionary<string, object> carregaInformacoes()
        {
            Dictionary<string, object> userInfo = new Dictionary<string, object>();

            try
            {
                string[] columns = { "id", "email", "senha" };
                string where = $"email='{frmHub.funEstancia.emailUser}'";
                List<string>[] result = conexao.SelectData("users", columns, where);
                userInfo["id"] = result[0][0].ToString();
                userInfo["email"] = result[1][0].ToString();
                userInfo["senha"] = result[2][0].ToString();

                // Obter o nome do usuário a partir do ID
                string userId = userInfo["id"].ToString(); // Obter o ID do usuário
                string[] userColumns = { "name" };
                string userWhere = $"id = {userId}";
                List<string>[] userResult = conexao.SelectData("users", userColumns, userWhere);
                if (userResult[0].Count > 0)
                {
                    userInfo["nome"] = userResult[0][0]; // Armazenar o nome do usuário
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userInfo;
        }*/
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

       
    }
}
