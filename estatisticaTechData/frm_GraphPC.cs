using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
//using ExcelDataReader;
using System.IO;
using estatisticaTechDataClassLibrary;
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using DocumentFormat.OpenXml.Office2010.PowerPoint;

namespace estatisticaTechData
{
    public partial class frm_GraphPC : Form
    {
        //Matriz de testes pra ver o grafico funcionando
        const int size = 30;
        double[,] baseDados = new double[size, 2];

        public frm_GraphPC()
        {
            InitializeComponent();
        }

        private void frm_GraphControlC_Load(object sender, EventArgs e)
        {
            GraphPane graphPane = zed_graphC.GraphPane;
            graphPane.Title.Text = "Gráfico de Controle C";
            graphPane.XAxis.Title.Text = "Amostras";
            graphPane.YAxis.Title.Text = "Contagem de defeitos";

            setBase();
            randomBase();
            updateGraphC(baseDados);
        }

        private void btn_novaBaseC_Click(object sender, EventArgs e)
        {
            DataTable dt = excelReader();
            double[,] dtArray = new double[dt.Rows.Count, 2];

            int i = 0;
            foreach (DataRow row in dt.Rows) {
                dtArray[i, 0] = i + 1;
                dtArray[i, 1] = double.Parse(row[1].ToString());
                i++;
            }

            updateGraphC(dtArray);
        }


        private void btn_random_Click(object sender, EventArgs e)
        {
            randomBase();
            updateGraphC(baseDados);
        }






        public void setBase()
        {
            for (int i = 0; i < size; i++)
            {
                baseDados[i, 0] = i + 1;
            }
        }

        public void randomBase()
        {
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                baseDados[i, 1] = rand.Next(10, 25);
            }
        }



        public void updateGraphC(double[,] dataArray)
        {
            GraphPane graphPane = zed_graphC.GraphPane;
            graphPane.CurveList.Clear();
            graphPane.GraphObjList.Clear();


            //Cria a linha com o array passado
            LineItem curve = graphPane.AddCurve("Contagem de defeitos", new PointPairList(), Color.OrangeRed, SymbolType.None);
            curve.Line.Width = 2f;

            for (int i = 0; i < dataArray.GetLength(0); i++) {
                curve.AddPoint(dataArray[i, 0], dataArray[i, 1]);
            }


            //Faz calculos da média, limite superior e inferior
            double media = 0;
            for (int i = 0; i < dataArray.GetLength(0); i++)
            {
                media += dataArray[i, 1];
            }
            media /= dataArray.GetLength(0);

            double lSup = media + (3 * Math.Sqrt(media));
            double lInf = media - (3 * Math.Sqrt(media));


            //Cria as linhas de média e limites
            LineObj mediaLine = new LineObj(Color.Red, 0, media, dataArray.GetLength(0) + 1, media);
            mediaLine.Line.Width = 1f;
            graphPane.GraphObjList.Add(mediaLine);

            LineObj topLine = new LineObj(Color.Blue, 0, lSup, dataArray.GetLength(0) + 1, lSup);
            topLine.Line.Width = 2f;
            graphPane.GraphObjList.Add(topLine);

            LineObj bottomLine = new LineObj(Color.Blue, 0, lInf, dataArray.GetLength(0) + 1, lInf);
            bottomLine.Line.Width = 2f;
            graphPane.GraphObjList.Add(bottomLine);



            //Definindo escala do gráfico
            graphPane.YAxis.Scale.Min = 10;
            graphPane.YAxis.Scale.Max = 30;
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = 10;


            //Funçoes pra atualizar o gráfico
            zed_graphC.AxisChange();
            zed_graphC.Invalidate();
        }

        public DataTable excelReader()
        {
            DataTable table = new DataTable();
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
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
                                    table.Columns.Add(cell.Value.ToString());
                                }
                                isFirstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                {
                                    table.Rows[table.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                        }
                    }
                }
            }

            return table;
        }

        private void btn_NovaBaseP_Click(object sender, EventArgs e)
        {
            DataTable dt = excelReader();

            double[,] dtArray = new double[dt.Rows.Count, 3];

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                dtArray[i, 0] = i + 1;
                dtArray[i, 1] = double.Parse(row[1].ToString());
                dtArray[i, 2] = double.Parse(row[2].ToString());
                i++;
            }

            updateGraphP(dtArray);
        }

        public void updateGraphP(double[,] dataArray)
        {
            GraphPane graphPane = zed_graphC.GraphPane;
            graphPane.CurveList.Clear();
            graphPane.GraphObjList.Clear();

            int size = dataArray.GetLength(0);

            // Calcular P e P médio
            double pmedio = 0;
            double[] pValues = new double[size];
            for (int i = 0; i < size; i++)
            {
                pValues[i] = dataArray[i, 2] / dataArray[i, 1];
                pmedio += pValues[i];
            }

            pmedio /= size;


            // Calcular sigmas
            double[] sigmas = new double[size];

            for (int i = 0; i < size; i++)
            {
                sigmas[i] = Math.Sqrt(pmedio * (1 - pmedio)) / Math.Sqrt(dataArray[i, 1]);
            }

            // Calcular limites de cada amostra
            double[] lSup = new double[size];
            double[] lInf = new double[size];
            for (int i = 0; i < size; i++)
            {
                lSup[i] = pmedio + (3 * sigmas[i]);
                lInf[i] = pmedio - (3 * sigmas[i]);
            }



            //Desenhar o gráfico
            LineItem curveP = graphPane.AddCurve("Valor de P", new PointPairList(), Color.OrangeRed, SymbolType.None);
            curveP.Line.Width = 2f;

            for (int i = 0; i < size; i++)
            {
                curveP.AddPoint(dataArray[i, 0], pValues[i]);
            }


            LineItem curveSup = graphPane.AddCurve("Limite Superior", new PointPairList(), Color.Blue, SymbolType.None);
            curveSup.Line.Width = 2f;

            for (int i = 0; i < size; i++)
            {
                curveSup.AddPoint(dataArray[i, 0], lSup[i]);
            }


            LineItem curveInf = graphPane.AddCurve("Limite Inferior", new PointPairList(), Color.Blue, SymbolType.None);
            curveInf.Line.Width = 2f;

            for (int i = 0; i < size; i++)
            {
                curveInf.AddPoint(dataArray[i, 0], lInf[i]);
            }


            LineObj pMedioLine = new LineObj(Color.Red, 0, pmedio, dataArray.GetLength(0) + 1, pmedio);
            pMedioLine.Line.Width = 1f;
            graphPane.GraphObjList.Add(pMedioLine);


            //Definindo escala do gráfico
            graphPane.YAxis.Scale.Min = 0;
            graphPane.YAxis.Scale.Max = 0.5;
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = 20;


            //Funçoes pra atualizar o gráfico
            zed_graphC.AxisChange();
            zed_graphC.Invalidate();
        }
    }
}
