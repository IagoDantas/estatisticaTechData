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
            string[] chargeColumns = { "date", "data", "status", "user_id", "id" };
            string chargeWhere = "status = 'A'";
            List<string>[] chargeResult = conexao.SelectData("charge", chargeColumns, chargeWhere);
            
            if (chargeResult[0].Count > 0)
            {
                for (int i = 0; i < chargeResult[0].Count; i++)
                {
                    // Obtenha a data da carga
                    fileDate = DateTime.Parse(chargeResult[0][i]);
                    string dateText = fileDate.ToString();

                    // Obtenha o user_id da carga
                    int cargaUserId = int.Parse(chargeResult[3][i].ToString());
                    int chargeId = int.Parse(chargeResult[4][i].ToString());

                    string[] tableMasterColumns = { "id", "type_count_id" };
                    string tableMasterWhere = $"charge_id = {chargeId}";

                    List<string>[] tableMasterResult = conexao.SelectData("table_master", tableMasterColumns, tableMasterWhere);

                    int tableMasterId = int.Parse(tableMasterResult[0][i]);
                    int tableMasterTypeCountId = int.Parse(tableMasterResult[1][i]);

                    string[] typeCountColumns = { "description" };
                    string typeCountWhere = $"id = {tableMasterTypeCountId}";

                    List<string>[] typeCountsResult = conexao.SelectData("type_counts", typeCountColumns, typeCountWhere);

                    string description = typeCountsResult[0][i].ToString();
                    
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
                        panel.Location = new Point(0, i * 50); // Ajuste as coordenadas X e Y conforme necessário
                        panel.Size = new Size(pnlArquivos.Width - 20, 50);

                        // Crie um Label para exibir o nome
                        Label labelNome = new Label();
                        labelNome.Font = new Font("Poppins", 12, FontStyle.Bold);
                        labelNome.AutoSize = true;
                        labelNome.Text = $"Nome: {cargaUserName}";
                        labelNome.Location = new Point(10, 10); // Ajuste as coordenadas conforme necessário

                        // Crie um Label para exibir a data e ajuste sua posição para que fique ao lado do Label do nome
                        Label labelData = new Label();
                        labelData.Font = new Font("Poppins", 12, FontStyle.Regular);
                        labelData.AutoSize = true;
                        labelData.Text = $"Data: {dateText}";
                        labelData.Location = new Point(labelNome.Right + 30, 10); // Ajuste as coordenadas conforme necessário

                        Label labelTipo = new Label();
                        labelTipo.Font = new Font("Poppins", 12, FontStyle.Regular);
                        labelTipo.AutoSize = true;
                        labelTipo.Text = $"Gráfico de {description}";
                        labelTipo.Location = new Point(labelData.Right + 100, 10); // Ajuste as coordenadas conforme necessário

                        techDataButton compareButton = new techDataButton();
                        compareButton.BackColor = Color.FromArgb(0, 107, 117);
                        compareButton.BackgroundColor = Color.FromArgb(0, 107, 117);
                        compareButton.BorderColor = Color.PaleVioletRed;
                        compareButton.BorderRadius = 50;
                        compareButton.BorderSize = 0;
                        compareButton.FlatAppearance.BorderSize = 0;
                        compareButton.FlatStyle = FlatStyle.Flat;
                        compareButton.Font = new Font("Poppins", 10, FontStyle.Bold);
                        compareButton.ForeColor = Color.White;
                        compareButton.Location = new Point(659, labelNome.Top - 10); // Ajuste as coordenadas conforme necessário
                        compareButton.Name = $"btnComparar_{i}"; // Nome único para o botão
                        compareButton.Size = new Size(105, 47);
                        compareButton.TabIndex = 15;
                        compareButton.Text = "Comparar";
                        compareButton.TextColor = Color.White;
                        compareButton.UseVisualStyleBackColor = false;

                        techDataButton deleteButton = new techDataButton();
                        deleteButton.BackColor = Color.FromArgb(0, 107, 117);
                        deleteButton.BackgroundColor = Color.FromArgb(198, 44, 23);
                        deleteButton.BorderColor = Color.PaleVioletRed;
                        deleteButton.BorderRadius = 50;
                        deleteButton.BorderSize = 0;
                        deleteButton.FlatAppearance.BorderSize = 0;
                        deleteButton.FlatStyle = FlatStyle.Flat;
                        deleteButton.Font = new Font("Poppins", 10, FontStyle.Bold);
                        deleteButton.ForeColor = Color.White;
                        deleteButton.Location = new Point(compareButton.Right + 5, labelNome.Top - 10); // Ajuste as coordenadas conforme necessário
                        deleteButton.Name = $"btnDeletar_{i}"; // Nome único para o botão
                        deleteButton.Size = new Size(105, 47);
                        deleteButton.TabIndex = 15;
                        deleteButton.Text = "Deletar";
                        deleteButton.TextColor = Color.White;
                        deleteButton.UseVisualStyleBackColor = false;

                        deleteButton.Click += (s, eventArgs) =>
                        {
                           
                            // Use o buttonIndex para realizar a exclusão do registro
                            string tableCharge = "charge"; 
                            string whereCharge = $"id = {chargeId}"; 
                            
                            bool sucessoCharge = conexao.DeleteData(tableCharge, whereCharge);

                            string tableMaster = "table_master";
                            string whereTableMaster = $"id = {tableMasterId}";

                            bool sucessoTableMaster = conexao.DeleteData(tableMaster, whereTableMaster);

                            if (sucessoCharge && sucessoTableMaster)
                            {
                                // Remove o painel inteiro
                                Control parent = deleteButton.Parent;
                                if (parent != null)
                                {
                                    parent.Parent.Controls.Remove(parent);
                                }

                                // Exibe um MessageBox para indicar que a exclusão foi bem-sucedida
                                MessageBox.Show("Registro excluído com sucesso!");
                            }

                        };
                        compareButton.Click += (s, eventArgs) =>
                        {
                            // Aqui você pode acessar o índice do botão e realizar a exclusão do registro correspondente
                            int buttonIndex = int.Parse(compareButton.Name.Split('_')[1]);
                            // Use o buttonIndex para realizar a exclusão do registro
                        };

                        // Adicione os Labels ao Panel
                        panel.Controls.Add(labelNome);
                        panel.Controls.Add(labelData);

                        panel.Controls.Add(labelTipo);
                        panel.Controls.Add(compareButton);
                        panel.Controls.Add(deleteButton);

                        // Adicione o Panel ao seu formulário
                        pnlArquivos.Controls.Add(panel);

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
