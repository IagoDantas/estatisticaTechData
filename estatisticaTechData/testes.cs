﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
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

        private void button2_Click(object sender, EventArgs e)
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
            double moda = 0, compara;
            int contA, contB = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    compara = arrayExcel[i, j];
                    contA = 0;
                    for (int k = 0; k < x; k++)
                    {
                        for (int l = 0; l < y; l++)
                        {
                            if(compara == arrayExcel[k, l])
                            {
                                contA++;
                            }
                        }
                    }
                    if(contA > contB)
                    {
                        contB = contA;
                        moda = compara;
                    }
                }
            }

            label2.Text = "A moda é: " + moda;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.RowCount;
            int y = dataGridView1.ColumnCount;
            int length = x * y;
            double[] arrayExcel = new double[length];
            int p = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    DataGridViewCell cell = dataGridView1[rowIndex: i, columnIndex: j];
                    arrayExcel[p] = Convert.ToDouble(cell.Value);
                    p++;
                }
            }

            Array.Sort(arrayExcel);
            double mediana;
            int posicao;
            bool lenghtTest = (length % 2 != 0);
            if (lenghtTest)
            {
                posicao = (length + 1) / 2;
                mediana = arrayExcel[posicao-1];
            }
            else
            {
                posicao = length/2;
                mediana = (arrayExcel[posicao-1] + arrayExcel[posicao])/ 2;
            }

            label3.Text = "A mediana desses valores é: "+mediana;
        }
    }
}