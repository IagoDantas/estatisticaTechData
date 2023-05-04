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

        public static double[] ArrayExcel(int x, int y, DataGridView dgvTeste)
        {
            int size = x * y, p = 0;
            double[] arrayExcel = new double[size];
            for (int i = 0; i < x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    DataGridViewCell cell = dgvTeste[rowIndex: i, columnIndex: j];
                    arrayExcel[p] = Convert.ToDouble(cell.Value);
                    p++;
                }
            }

            return arrayExcel;
        }
        private void btnMedia_Click(object sender, EventArgs e)
        {
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[] arrayExcel = ArrayExcel(x, y, dgvTeste);
            x = x * y;
            double media = ClsCalculos.CalcularMedia(arrayExcel, x); 
            lblMedia.Text = "A média é: " + media.ToString("F");
            lblMedia.Visible = true;
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[] arrayExcel = ArrayExcel(x, y, dgvTeste);
            double[] modas = ClsCalculos.CalcularModa(arrayExcel);
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
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[] arrayExcel = ArrayExcel(x, y, dgvTeste);
            x = x * y;
            double mediana = ClsCalculos.CalcularMediana(arrayExcel, x);
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
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[] arrayExcel = ArrayExcel(x, y, dgvTeste);
            x = x * y;
            double[] quartis = ClsCalculos.CalcularQuartis(arrayExcel, x);
            lblQuartis.Text = "Os quartis desses valores são: Q1: " + quartis[0] + "\nQ2: " + quartis[1] + "\nQ3: " + quartis[2];
            lblQuartis.Visible = true;
        }

        private void btnPercentis_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPercentil.Text))
                lblPercentis.Text = "A caixa de texto está vazio, digite um número.";
            else
            {
                int numTXT = Convert.ToInt32(txtPercentil.Text);
                int x = dgvTeste.RowCount - 1;
                int y = dgvTeste.ColumnCount - 1;
                double[] arrayExcel = ArrayExcel(x, y, dgvTeste);
                x = x * y;
                double[] percentis = ClsCalculos.CalcularPercentis(arrayExcel);

                if (numTXT > 0 && numTXT <= 100)
                    lblPercentis.Text = $"O percentil N°{numTXT} é: {percentis[numTXT - 1]}.";
                else
                    lblPercentis.Text = "Digite um número entre 1 a 100.";
            }
            lblPercentis.Visible = true;
        }

        private void btnDesvioPadrao_Click(object sender, EventArgs e)
        {
            int x = dgvTeste.RowCount - 1;
            int y = dgvTeste.ColumnCount - 1;
            double[] arrayExcel = ArrayExcel(x, y, dgvTeste);

            double desvioPadrao = ClsCalculos.CalcularDesvioPadrao(arrayExcel);

            lblDesvioPadrao.Text = desvioPadrao.ToString("F");
            lblDesvioPadrao.Visible = true;
        }
    }
}
