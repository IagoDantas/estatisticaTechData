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
            Dictionary<string, object> userInfo = carregaInformacoes();
            string userId = userInfo["id"].ToString();
            userName = userInfo["nome"].ToString();
            email = userInfo["email"].ToString();
            senha = userInfo["senha"].ToString();

            // Obter a data do arquivo
            string[] chargeColumns = { "date", "data", "status", "user_id" }; // Inclua a coluna "user_id"
            /*string chargeWhere = $"user_id = {userId}";*/ // Substitua "userId" pela ID da carga específica
            List<string>[] chargeResult = conexao.SelectData("charge", chargeColumns, "");

            if (chargeResult[0].Count > 0)
            {
                // Obtenha a data da carga
                fileDate = DateTime.Parse(chargeResult[0][0]);
                TxtData.Text = fileDate.ToString();

                // Obtenha o user_id da carga
                int cargaUserId = int.Parse(chargeResult[3][0].ToString());

                // Agora, com o user_id da carga, você pode obter o nome do usuário da tabela "users"
                string[] userColumns = { "name" };
                string userWhere = $"id = {cargaUserId}";
                List<string>[] userResult = conexao.SelectData("users", userColumns, userWhere);

                if (userResult[0].Count > 0)
                {
                    // Obtenha o nome do usuário
                    string userName = userResult[0][0];
                    TxtNome.Text = userName;
                }
            }
        }

        public Dictionary<string, object> carregaInformacoes()
        {
            Dictionary<string, object> userInfo = new Dictionary<string, object>();

            try
            {
                string[] columns = { "id", "email", "password" };
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
        }

       
    }
}
