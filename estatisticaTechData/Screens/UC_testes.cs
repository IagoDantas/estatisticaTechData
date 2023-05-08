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

namespace estatisticaTechData.Screens
{
    public partial class UC_testes : UserControl
    {
        int x, y;
        double[] arrayExcel;
        double[] modas, quartis, percentis;
        double media, mediana, desvioPadrao,variancia, dispersao, coeficientePercentilicoCurtose, coeficienteAssimetria;

        public UC_testes()
        {
            InitializeComponent();
        }

        private void testes_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
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
            x = x * y;
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
        private void btnMedia_Click(object sender, EventArgs e)
        {
            media = ClsCalculos.CalcularMedia(arrayExcel, x); 
            lblMedia.Text = "A média é: " + media.ToString("F");
            lblMedia.Visible = true;
        }

        private void btnCoeficientePercenCurtose_Click(object sender, EventArgs e)
        {
            coeficientePercentilicoCurtose = ClsCalculos.CalcularCoeficientePercentilicoCurtose(arrayExcel, x);
            lblCoeficientePercentilicoCurtose.Text = $"O coeficiente % de curtose é {Math.Round(coeficientePercentilicoCurtose, 2)}";
            lblCoeficientePercentilicoCurtose.Visible = true;
        }

        private void btnCoeficienteAssimetria_Click(object sender, EventArgs e)
        {
            coeficienteAssimetria = ClsCalculos.CalcularCoeficienteAssimetria(arrayExcel);
            lblCoeficienteAssimetria.Text = $"O coeficiente de assimetria é {Math.Round(coeficienteAssimetria, 2)}";
            lblCoeficienteAssimetria.Visible = true;
        }

        private void btnVariancia_Click(object sender, EventArgs e)
        {
            variancia = ClsCalculos.CalcularVariancia(arrayExcel);
            lblVariancia.Text = $"A variância  desse conjunto é {Math.Round(variancia,2)}";
            lblVariancia.Visible = true;
        }

        private void btnDispersao_Click(object sender, EventArgs e)
        {
            dispersao = Math.Round(ClsCalculos.CalcularDispersao(arrayExcel), 4);
            lblDipersao.Text = $"A dispersão desse conjunto é {dispersao} ou  seja {dispersao*100}%";
            lblDipersao.Visible = true;
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            modas = ClsCalculos.CalcularModa(arrayExcel);
            if (modas.Length == 0)
                lblModa.Text = "Esta grupo é amodal";
            else if (modas.Length == 1)
                lblModa.Text = "A moda deste grupo é: " + modas[0];
            else
                lblModa.Text = "As modas deste grupo são: " + modas[0] + " e " + modas[1];
            lblModa.Visible = true;
        }

        private void btnMediana_Click(object sender, EventArgs e)
        {
            mediana = ClsCalculos.CalcularMediana(arrayExcel, x);
            lblMediana.Text = "A mediana desses valores é: " + mediana;
            lblMediana.Visible = true;
        }

        private void dgvTeste_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.BackColor = System.Drawing.Color.FromArgb(220, 236, 223);
            e.CellStyle.ForeColor = System.Drawing.Color.Black;
            e.CellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(0, 107, 117);
            e.CellStyle.SelectionForeColor = System.Drawing.Color.White;
        }

        private void btnQuartis_Click(object sender, EventArgs e)
        {
            quartis = ClsCalculos.CalcularQuartis(arrayExcel, x);
            lblQuartis.Text = "Os quartis desses valores são: \nQ1: " + quartis[0] + "\nQ2: " + quartis[1] + "\nQ3: " + quartis[2];
            lblQuartis.Visible = true;
        }

        private void btnPercentis_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPercentil.Text))
                lblPercentis.Text = "A caixa de texto está vazio, digite um número.";
            else
            {
                int numTXT = Convert.ToInt32(txtPercentil.Text);
                percentis = ClsCalculos.CalcularPercentis(arrayExcel);

                if (numTXT > 0 && numTXT <= 100)
                    lblPercentis.Text = $"O percentil N°{numTXT} é: {percentis[numTXT - 1]}.";
                else
                    lblPercentis.Text = "Digite um número entre 1 a 100.";
            }
            lblPercentis.Visible = true;
        }

        private void btnDesvioPadrao_Click(object sender, EventArgs e)
        {
            desvioPadrao = ClsCalculos.CalcularDesvioPadrao(arrayExcel);
            lblDesvioPadrao.Text = desvioPadrao.ToString("F");
            lblDesvioPadrao.Visible = true;
        }
    }
}
