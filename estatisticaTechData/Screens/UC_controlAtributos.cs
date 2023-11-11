using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Vml;
using estatisticaTechDataClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ZedGraph;
using Fill = ZedGraph.Fill;

namespace estatisticaTechData.Screens
{
    public partial class UC_controlAtributos : System.Windows.Forms.UserControl
    {
        double[,] matriz;
        double row;
        double mediaD;
        double desvioPadrao;
        double def, ams;

        public UC_controlAtributos()
        {
            InitializeComponent();
            matriz = UC_BackgroundAtributos.funEstancia.matrizExcel;
            row = matriz.GetLength(0);
            for(int i = 0; i < row; i++)
            {
                def += matriz[i, 0];
                ams += matriz[i, 1];
            }
        }
        private void UC_controlVariaveis_Load(object sender, EventArgs e)
        {
            CalcMedia();
            CalcDesvioPadrao();
            GraficoC();
            GraficoP();
            rdbGraphC.Checked = true;
            lblDef.Text = def.ToString();
            lblAmostra.Text = ams.ToString();
            double pct = (def / ams) * 100;
            lblTaxa.Text = pct.ToString("f2") + "%";
        }

        private void GraficoC()
        {
            // Configurar o objeto GraphPane para o gráfico C
            GraphPane cGraphPane = zedGraphC.GraphPane;
            cGraphPane.Title.Text = "Gráfico C";
            cGraphPane.XAxis.Title.Text = "Amostras";
            cGraphPane.YAxis.Title.Text = "Número de Defeitos";
            double media= 0;
            double yMax=0, yMin=0;


            // Adicionar os pontos de dados ao gráfico C
            PointPairList cPointPairs = new PointPairList();
            List<double> data = new List<double>();
            for (int i = 0; i < row; i++)
            {
                double cValue = 1 - (matriz[i, 0] / matriz[i, 1]);
                cPointPairs.Add(i + 1, cValue);
                if (i == 0)
                {
                    yMin = cValue;
                    yMax = cValue;
                }
                else
                {
                    if (cValue > yMax)
                        yMax = cValue;
                    if (cValue < yMin)
                        yMin = cValue;
                }
                data.Add(cValue);
                media+= cValue;
            }
            LineItem cCurve = cGraphPane.AddCurve("C", cPointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            media = media /(row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = cGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = cGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = cGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);
            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            cCurve.Line.Width = 2.0f;
            cCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            cGraphPane.XAxis.MajorGrid.IsVisible = true;
            cGraphPane.YAxis.MajorGrid.IsVisible = true;
            cGraphPane.XAxis.Scale.Min = 0;
            cGraphPane.XAxis.Scale.Max = row + 1;
            cGraphPane.YAxis.Scale.Min = lic - 0.01;
            cGraphPane.YAxis.Scale.Max = lsc + 0.01;
            cGraphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin; 
            double yMajorStep = yDataRange / 10; 

            cGraphPane.XAxis.Scale.MajorStep = 1;
            cGraphPane.YAxis.Scale.MajorStep = yMajorStep;

            // Atualizar os gráficos
            zedGraphC.AxisChange();
            zedGraphC.Invalidate();
        }

        private void GraficoP()
        {
            // Configurar o objeto GraphPane para o gráfico P
            GraphPane pGraphPane = zedGraphP.GraphPane;
            pGraphPane.Title.Text = "Gráfico P";
            pGraphPane.XAxis.Title.Text = "Amostras";
            pGraphPane.YAxis.Title.Text = "Proporção de Defeitos";
            double media = 0;
            // Adicionar os pontos de dados ao gráfico P
            PointPairList pPointPairs = new PointPairList();
            List<double> data = new List<double>();
            double yMin=0, yMax=0;

            for (int i = 0; i < row; i++)
            {
                double pValue = matriz[i, 0] / matriz[i, 1];
                pPointPairs.Add(i + 1, pValue);
                data.Add(pValue);
                if (i == 0)
                {
                    yMin = pValue;
                    yMax = pValue;
                }
                else
                {
                    if (pValue > yMax)
                        yMax = pValue;
                    if (pValue < yMin)
                        yMin = pValue;
                }
                media += pValue;
            }
            LineItem pCurve = pGraphPane.AddCurve("P", pPointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            media /= (row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = pGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = pGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = pGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);


            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            pCurve.Line.Width = 2.0f;
            pCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            pGraphPane.XAxis.MajorGrid.IsVisible = true;
            pGraphPane.YAxis.MajorGrid.IsVisible = true;
            pGraphPane.XAxis.Scale.Min = 0;
            pGraphPane.XAxis.Scale.Max = row + 1;
            pGraphPane.YAxis.Scale.Min = lic - 0.01;
            pGraphPane.YAxis.Scale.Max = lsc + 0.01;
            pGraphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            pGraphPane.XAxis.Scale.MajorStep = 1;
            pGraphPane.YAxis.Scale.MajorStep = yMajorStep;
            zedGraphP.AxisChange();
            zedGraphP.Invalidate();
        }

        private void rdbGraphP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGraphP.Checked)
            {
                zedGraphP.Visible = true;
                zedGraphC.Visible = false;
            }
        }

        private void rdbGraphC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGraphC.Checked)
            {
                zedGraphC.Visible = true;
                zedGraphP.Visible = false;
            }
        }

        private void CalcMedia()
        {
            mediaD = 0;
            for(int i =0; i < row; i++)
            {
                mediaD += matriz[i, 0];
            }
            mediaD /= row; 
        }

        private void CalcDesvioPadrao()
        {
            double somaQuadrados = 0;
            for (int i = 0; i < row; i++)
            {
                double valor = matriz[i, 0];
                somaQuadrados += Math.Pow(valor - mediaD, 2);
            }

            double variancia = somaQuadrados / (row - 1); // Usamos (row - 1) para calcular a variância corrigida
            desvioPadrao = Math.Sqrt(variancia);
        }

        private void btnVermais_Click(object sender, EventArgs e)
        {
            string nomeDaGuia = "BackgroundAtributo";
            frmHub.funEstancia.guia(nomeDaGuia);
        }
    }
}
