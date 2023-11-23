using ClosedXML.Excel;
using estatisticaTechDataClassLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData
{
    public partial class UC_BackgroundCompara : UserControl
    {
        public static UC_BackgroundCompara funEstancia;
        int x, y;
        public double[] arrayExcel;
        public double[] mediasIniciais;
        public double[] amplitudes;
        public double[,] matrizExcel;
        string email, senha;
        double[] modas, quartis, percentis;
        double mediana, variancia, dispersao, coeficientePercentilicoCurtose, coeficienteAssimetria;
        public double media, desvioPadrao, IQR;
        private int userId;
        private int chargeId, typeID;
        private estatisticaTechDataClassLibrary.Connection conexao;

        public UC_BackgroundCompara(int id)
        {
            InitializeComponent();
            this.typeID = id;
            funEstancia = this;
            conexao = new estatisticaTechDataClassLibrary.Connection();
        }

        private void UC_BackgroundCompara_Load(object sender, EventArgs e)
        {
            try
            {
                carregaInformacoes();
                DataTable dt = new DataTable();
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            bool isFirstRow = true;
                            var rows = workbook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (isFirstRow)
                                {
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dt.Columns.Add(cell.Value.ToString());
                                    }
                                    isFirstRow = false;
                                }
                                else
                                {
                                    dt.Rows.Add();
                                    int i = 0;
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                    }
                                }
                            }
                            dgvTeste.DataSource = dt.DefaultView;
                            
                            byte[] excelData;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                workbook.SaveAs(ms);
                                excelData = ms.ToArray();
                            }

                            string json = JsonConvert.SerializeObject(dt, Formatting.Indented);


                            string[] columns2 = { "id" };
                            string where2 = $"email='{email}' AND password='{senha}'";
                            List<string>[] result2 = conexao.SelectData("users", columns2, where2);

                            if (result2[0].Count > 0)
                            {
                                userId = int.Parse(result2[0][0].ToString());

                                Dictionary<string, string> dataCharge = new Dictionary<string, string>();
                                dataCharge.Add("date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                dataCharge.Add("file", Convert.ToBase64String(excelData));
                                dataCharge.Add("user_id", userId.ToString());
                                dataCharge.Add("status", "A");
                                dataCharge.Add("data", json);


                                if (conexao.InsertData("charge", dataCharge) == true)
                                {

                                    chargeId = conexao.GetLastInsertedId();
                                    Dictionary<string, string> dataTableMaster = new Dictionary<string, string>();
                                    dataTableMaster.Add("status", "A");
                                    dataTableMaster.Add("data", json);
                                    dataTableMaster.Add("user_id", userId.ToString());
                                    dataTableMaster.Add("type_count_id",  typeID.ToString());
                                    dataTableMaster.Add("charge_id", chargeId.ToString());

                                    if (conexao.InsertData("table_master", dataTableMaster) != true)
                                    {
                                        MessageBox.Show("Falha ao salvar os dados no banco");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao adicionar o arquivo.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Erro ao obter o ID do usuário");
                            }
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    else
                    {

                    }
                }
                x = dgvTeste.RowCount - 1;
                y = dgvTeste.ColumnCount - 1;
                arrayExcel = ArrayExcel(x, y, dgvTeste);
                matrizExcel = new double[x, y];
                int contador = 0;
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < y; j++)
                    {
                        matrizExcel[i, j] = arrayExcel[contador];
                        contador++;
                    }

                dgvTeste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                mediasIniciais = ClsCalculos.CalcularMediasInicias(matrizExcel, x, y);
                DataRow newRow = dt.NewRow();
                for (int i = 0; i <= mediasIniciais.Length; i++)
                {
                    if (i == 0)
                        newRow[i] = "Média(s):";
                    else
                        newRow[i] = mediasIniciais[i - 1].ToString("f4");
                }
                dt.Rows.Add(newRow);

                amplitudes = ClsCalculos.CalcularAmplitudes(matrizExcel, x, y);
                newRow = dt.NewRow();
                for (int i = 0; i <= amplitudes.Length; i++)
                {
                    if (i == 0)
                        newRow[i] = "Amplitude(s):";
                    else
                        newRow[i] = amplitudes[i - 1].ToString("f4");
                }
                dt.Rows.Add(newRow);
                dgvTeste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Atualizar o DataSource do DataGridView
                dgvTeste.DataSource = dt;
                x = x * y;

                //Array para os cálculos
                double[] arrayCopy = new double[arrayExcel.Length];
                Array.Copy(arrayExcel, arrayCopy, arrayExcel.Length);

                //Media das medias
                media = ClsCalculos.CalcularMedia(mediasIniciais, mediasIniciais.Length);
                lblMedia.Text = "A média das médias é: " + media.ToString("F");
                lblMedia.Visible = true;

                //Coeficiente Percentilico de Curtose
                coeficientePercentilicoCurtose = ClsCalculos.CalcularCoeficientePercentilicoCurtose(arrayCopy, x);
                lblCoeficientePercentilicoCurtose.Text = $"O coeficiente % de curtose é {coeficientePercentilicoCurtose.ToString("f4")}";
                lblCoeficientePercentilicoCurtose.Visible = true;

                //Coeficiente de Assimetria
                coeficienteAssimetria = ClsCalculos.CalcularCoeficienteAssimetria(arrayCopy);
                lblCoeficienteAssimetria.Text = $"O coeficiente de assimetria é {coeficienteAssimetria.ToString("f4")}";
                lblCoeficienteAssimetria.Visible = true;

                //Variancia
                variancia = ClsCalculos.CalcularVariancia(arrayCopy);
                lblVariancia.Text = $"A variância  desse conjunto é {variancia.ToString("f4")}";
                lblVariancia.Visible = true;

                //Dispersão
                dispersao = ClsCalculos.CalcularDispersao(arrayCopy);
                lblDipersao.Text = $"A dispersão desse conjunto é {dispersao.ToString("f4")} ou seja {(dispersao * 100).ToString("f2")}%";
                lblDipersao.Visible = true;

                //Moda
                modas = ClsCalculos.CalcularModa(arrayCopy);
                if (modas.Length == 0)
                    lblModa.Text = "Esta grupo é amodal";
                else if (modas.Length == 1)
                    lblModa.Text = "A moda deste grupo é: " + modas[0];
                else
                    lblModa.Text = "As modas deste grupo são: " + modas[0] + " e " + modas[1];
                lblModa.Visible = true;

                //Mediana
                mediana = ClsCalculos.CalcularMediana(arrayCopy, x);
                lblMediana.Text = "A mediana desses valores é: " + mediana;
                lblMediana.Visible = true;

                //Quartis
                quartis = ClsCalculos.CalcularQuartis(arrayCopy, x);
                lblQuartis.Text = "Os quartis desses valores são: \nQ1: " + quartis[0] + "\nQ2: " + quartis[1] + "\nQ3: " + quartis[2];
                lblQuartis.Visible = true;

                //Percentis
                percentis = ClsCalculos.CalcularPercentis(arrayCopy);

                //Desvio Padrão
                desvioPadrao = ClsCalculos.CalcularDesvioPadrao(arrayCopy);
                lblDesvioPadrao.Text = $"O desvio padrão deste conjunto é {desvioPadrao.ToString("F")}";
                lblDesvioPadrao.Visible = true;

                //IQR
                IQR = quartis[2] - quartis[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private void txtPercentil_Enter(object sender, EventArgs e)
        {
            txtPercentil.Select(0, 0);
        }

        public void carregaInformacoes()
        {
            try
            {
                string[] columns = { "email", "password" };
                string where = $"email='{frmHub.funEstancia.emailUser}'";
                List<string>[] result = conexao.SelectData("users", columns, where);
                email = result[0][0].ToString();
                senha = result[1][0].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPercentis_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPercentil.Text))
                lblPercentis.Text = "A caixa de texto está vazia, digite um número.";
            else
            {
                int numTXT = Convert.ToInt32(txtPercentil.Text);
                if (numTXT > 0 && numTXT <= 100)
                    lblPercentis.Text = $"O percentil N°{numTXT} é: {percentis[numTXT - 1]}.";
                else
                    lblPercentis.Text = "Digite um número entre 1 a 100.";
            }
            lblPercentis.Visible = true;
        }
        private void dgvTeste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = System.Drawing.Color.FromArgb(220, 236, 223);
            e.CellStyle.ForeColor = System.Drawing.Color.Black;
            e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 107, 117);
            e.CellStyle.SelectionForeColor = System.Drawing.Color.White;
        }
        public static double[] ArrayExcel(int x, int y, DataGridView dgvTeste)
        {
            int size = x * y, p = 0;
            double[] arrExcel = new double[size];
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    DataGridViewCell cell = dgvTeste[rowIndex: i, columnIndex: j];
                    arrExcel[p] = Convert.ToDouble(cell.Value);
                    p++;
                }
            }

            return arrExcel;
        }
    }
}
