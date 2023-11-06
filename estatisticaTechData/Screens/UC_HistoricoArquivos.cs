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

            // Obtenha os dados da tabela "charge"
            string[] chargeColumns = { "date", "data", "status", "user_id" };
            List<string>[] chargeResult = conexao.SelectData("charge", chargeColumns, "");

            if (chargeResult[0].Count > 0)
            {
                int panelY = 2;

                for (int i = 0; i < chargeResult[0].Count; i++)
                {
                    // Obtenha a data da carga
                    DateTime fileDate = DateTime.Parse(chargeResult[0][i]);
                    string dateText = fileDate.ToString();

                    // Obtenha o user_id da carga
                    int cargaUserId = int.Parse(chargeResult[3][i].ToString());

                    // Obtenha o nome do usuário da tabela "users"
                    string[] userColumns = { "name" };
                    string userWhere = $"id = {cargaUserId}";
                    List<string>[] userResult = conexao.SelectData("users", userColumns, userWhere);

                    if (userResult[0].Count > 0)
                    {
                        // Obtenha o nome do usuário
                        string cargaUserName = userResult[0][0];

                        // Crie um novo Panel com o estilo desejado
                        Panel panel = new Panel();
                        panel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Location = new Point(10, panelY); // Ajuste as coordenadas conforme necessário
                        panel.Size = new Size(801, 50);

                        // Crie um Label para exibir o nome
                        Label labelNome = new Label();
                        labelNome.Text = $"Nome: {cargaUserName}";
                        labelNome.Location = new Point(10, 10); // Ajuste as coordenadas conforme necessário

                        // Crie um Label para exibir a data e ajuste sua posição para que fique ao lado do Label do nome
                        Label labelData = new Label();
                        labelData.Text = $"Data: {dateText}";
                        labelData.Location = new Point(labelNome.Right + 10, 10); // Ajuste as coordenadas conforme necessário

                        // Adicione os Labels ao Panel
                        panel.Controls.Add(labelNome);
                        panel.Controls.Add(labelData);
                        

                        // Adicione o Panel ao seu formulário
                        this.Controls.Add(panel);
                        pnlArquivos.Controls.Add(panel);
                        panelY += panel.Height + 10;
                    }
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
