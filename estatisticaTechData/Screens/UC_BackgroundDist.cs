using ClosedXML.Excel;
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
        double[] modas, quartis, percentis;
        double mediana, variancia, dispersao, coeficientePercentilicoCurtose, coeficienteAssimetria;
        public double media, desvioPadrao;

        public UC_BackgroundDist()
        {
            InitializeComponent();
            funEstancia = this;
        }

        private void UC_BackgroundDist_Load(object sender, EventArgs e)
        {
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
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
            x = dgvTeste.RowCount - 1;
            y = dgvTeste.ColumnCount - 1;
            arrayExcel = ArrayExcel(x, y, dgvTeste);
            matrizExcel = new double[x, y];
            int contador = 0;
            for(int i=0;i<x;i++)
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
                if(i==0)
                    newRow[i] = "Média(s):";
                else
                    newRow[i] = Math.Round(mediasIniciais[i-1],4).ToString();
            }
            dt.Rows.Add(newRow);

            amplitudes = ClsCalculos.CalcularAmplitudes(matrizExcel, x, y);
            newRow = dt.NewRow();
            for (int i = 0; i <= amplitudes.Length; i++)
            {
                if (i == 0)
                    newRow[i] = "Amplitude(s):";
                else
                    newRow[i] = Math.Round(amplitudes[i - 1], 4).ToString();
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
            lblCoeficientePercentilicoCurtose.Text = $"O coeficiente % de curtose é {Math.Round(coeficientePercentilicoCurtose, 2)}";
            lblCoeficientePercentilicoCurtose.Visible = true;
            
            //Coeficiente de Assimetria
            coeficienteAssimetria = ClsCalculos.CalcularCoeficienteAssimetria(arrayCopy);
            lblCoeficienteAssimetria.Text = $"O coeficiente de assimetria é {Math.Round(coeficienteAssimetria, 2)}";
            lblCoeficienteAssimetria.Visible = true;
            
            //Variancia
            variancia = ClsCalculos.CalcularVariancia(arrayCopy);
            lblVariancia.Text = $"A variância  desse conjunto é {Math.Round(variancia,2)}";
            lblVariancia.Visible = true;

            //Dispersão
            dispersao = Math.Round(ClsCalculos.CalcularDispersao(arrayCopy), 4);
            lblDipersao.Text = $"A dispersão desse conjunto é {dispersao} ou seja {dispersao * 100}%";
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
            lblDesvioPadrao.Text = desvioPadrao.ToString("F");
            lblDesvioPadrao.Visible = true;
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
