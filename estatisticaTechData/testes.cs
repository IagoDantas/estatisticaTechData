using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace estatisticaTechData
{
    public partial class testes : Form
    {
        public testes()
        {
            InitializeComponent();
        }

        

        private void testes_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataTable dt = new DataTable();
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach(var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach(IXLCell cell in row.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach(IXLCell cell in row.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                        }
                        dataGridView1.DataSource = dt.DefaultView;
                        Cursor.Current = Cursors.Default;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e )
        {
            int x = dataGridView1.RowCount;
            int y = dataGridView1.ColumnCount;
            double[,] arrayExcel = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DataGridViewCell cell = dataGridView1[rowIndex: i, columnIndex: j];
                    arrayExcel[i, j] = Convert.ToDouble(cell.Value);
                }
            }
            double media = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <y; j++)
                {
                    media += arrayExcel[i, j];
                }
            }
            if (x < 3)
                x = 0;
            else
                x = x - 1;

            if (y == 1)
                y = 0;

            int divisor = x + y;

            media = media / divisor;

            label1.Text = "A média é: "+ media;
        }

        
    }
}
