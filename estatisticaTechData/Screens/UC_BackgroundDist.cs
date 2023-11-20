﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using estatisticaTechDataClassLibrary;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace estatisticaTechData.Screens
{
    public partial class UC_BackgroundDist : UserControl
    {
        public static UC_BackgroundDist funEstancia;
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
        private string jsonString;
        private int chargeId;
        private estatisticaTechDataClassLibrary.Connection conexao;
        DataTable dt;

        public UC_BackgroundDist(int chargeId)
        {
            try
            {
                funEstancia = this;
                conexao = new estatisticaTechDataClassLibrary.Connection();
                this.chargeId = chargeId;
                carregaInformacoes();
                PegaJson();
                dt = ConvertJsonToDataTable(jsonString);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            InitializeComponent();
        }
        public UC_BackgroundDist() // Chama o construtor com parâmetro e passa 0 como chargeId padrão
        {
            try
            {
                funEstancia = this;
                conexao = new estatisticaTechDataClassLibrary.Connection();
                carregaInformacoes();
                dt = Cls_Utils.OpenExcel(conexao, 3, email, senha);

                // Restante do seu código...
            }
            catch (Exception ex)
            {
                throw ex;
            }
            InitializeComponent();

        }

        public static DataTable ConvertJsonToDataTable(string jsonString)
        {
            DataTable dataTable = new DataTable();

            // Converta o JSON para um objeto JArray
            JArray jsonArray = JArray.Parse(jsonString);

            // Crie colunas para a DataTable usando as chaves do primeiro objeto no array
            foreach (JToken token in jsonArray[0])
            {
                dataTable.Columns.Add(((JProperty)token).Name, typeof(string));
            }

            // Adicione as linhas à DataTable
            foreach (JObject jsonObject in jsonArray)
            {
                DataRow row = dataTable.NewRow();
                foreach (JProperty property in jsonObject.Properties())
                {
                    row[property.Name] = property.Value.ToString();
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }


        private void PegaJson()
        {
            try
            {
                if(chargeId == 0)
                {
                    MessageBox.Show("Erro" ,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] columns = { "data" };
                    string where = $"id='{chargeId}'";
                    List<string>[] result = conexao.SelectData("charge", columns, where);

                    if (result[0].Count > 0)
                    {
                        jsonString = result[0][0].ToString();
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void UC_BackgroundDist_Load(object sender, EventArgs e)
        {
            try {
                dgvTeste.DataSource = dt.DefaultView;
               
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
