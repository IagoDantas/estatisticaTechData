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

namespace estatisticaTechData.Screens
{
    public partial class UC_testes : UserControl
    {
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



        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[,] arrayExcel = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    DataGridViewCell cell = dgvTeste[rowIndex: i, columnIndex: j];
                    arrayExcel[i, j - 1] = Convert.ToDouble(cell.Value);
                }
            }
            double media = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    media += arrayExcel[i, j];
                }
            }

            int divisor = x * y;
            media = media / divisor;

            lblMedia.Text = "A média é: " + media.ToString("F");
            lblMedia.Visible = true;
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            int x = dgvTeste.RowCount - 1, p = 0;
            int y = dgvTeste.ColumnCount - 1;
            x = x * y;
            double[] arrayExcel = new double[x];
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    DataGridViewCell cell = dgvTeste[rowIndex: i, columnIndex: j];
                    arrayExcel[p] = Convert.ToDouble(cell.Value);
                    p++;
                }
            }

            double[] modas = calcularModa(arrayExcel);

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
            int x = dgvTeste.RowCount;
            int y = dgvTeste.ColumnCount;
            int length = x * y;
            double[] arrayExcel = new double[length];
            int p = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DataGridViewCell cell = dgvTeste[rowIndex: i, columnIndex: j];
                    arrayExcel[p] = Convert.ToDouble(cell.Value);
                    p++;
                }
            }

            Array.Sort(arrayExcel);
            double mediana;
            int posicao;
            if (length % 2 == 0)
            {
                posicao = length / 2;
                mediana = (arrayExcel[posicao] + arrayExcel[posicao + 1]) / 2;
            }
            else
            {
                posicao = length + 1 / 2;
                mediana = arrayExcel[posicao];
            }

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

        static public double[] calcularModa(double[] listaValores)
        {

            double[] listaValoresOrdenada = listaValores.ToArray();
            Array.Sort(listaValoresOrdenada);

            double valorAtual = listaValoresOrdenada[0];
            int contadorValorAtual = 0;

            int[] listaNumRepeticoes = new int[listaValoresOrdenada.Length];
            listaNumRepeticoes[0] = contadorValorAtual;

            for (int i = 1; i <= listaValoresOrdenada.Length - 1; i++)
            {
                if (listaValoresOrdenada[i] != valorAtual)
                {
                    valorAtual = listaValoresOrdenada[i];
                    contadorValorAtual = 0;
                }
                else
                {
                    contadorValorAtual++;
                }
                listaNumRepeticoes[i] = contadorValorAtual;
            }

            int maiorRepeticao = listaNumRepeticoes.Max();

            if (maiorRepeticao > 0)
            {
                int contadorNumRepeticaoMaior = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                        contadorNumRepeticaoMaior++;
                }
                double[] listaRetorno = new double[contadorNumRepeticaoMaior];
                int contadorRetorno = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                    {
                        listaRetorno[contadorRetorno] = listaValoresOrdenada[i];
                        contadorRetorno++;
                    }
                }

                return listaRetorno;
            }
            else
            {
                return new double[0];
            }
        }

    }
}
