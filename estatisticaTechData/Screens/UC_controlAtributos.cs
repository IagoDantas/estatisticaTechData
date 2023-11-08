using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
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

namespace estatisticaTechData.Screens
{
    public partial class UC_controlAtributos : System.Windows.Forms.UserControl
    {
        double[,] matriz;
        double row;
        double mediaD;
        double desvioPadrao;

        public UC_controlAtributos()
        {
            InitializeComponent();
            matriz = UC_BackgroundAtributos.funEstancia.matrizExcel;
            row = matriz.GetLength(0);
        }
        private void UC_controlVariaveis_Load(object sender, EventArgs e)
        {
            CalcMedia();
            CalcDesvioPadrao();
            GraficoC();
            GraficoP();
            rdbGraphC.Checked = true;
            lblMedia.Text = mediaD.ToString("f4");
            lblDesvio.Text = desvioPadrao.ToString("f4");
        }

        private void GraficoC()
        {
            // Configurar o objeto GraphPane para o gráfico C
            GraphPane cGraphPane = zedGraphC.GraphPane;
            cGraphPane.Title.Text = "Gráfico C";
            cGraphPane.XAxis.Title.Text = "Amostras";
            cGraphPane.YAxis.Title.Text = "Valor C";
            double media= 0;


            // Adicionar os pontos de dados ao gráfico C
            PointPairList cPointPairs = new PointPairList();
            List<double> data = new List<double>();
            for (int i = 0; i < row; i++)
            {
                double cValue = 1 - (matriz[i, 0] / matriz[i, 1]);
                cPointPairs.Add(i + 1, cValue);
                data.Add(cValue);
                media+= cValue;
            }
            LineItem cCurve = cGraphPane.AddCurve("C", cPointPairs, System.Drawing.Color.Red, SymbolType.Circle);
            media = media /(row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = cGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Blue, SymbolType.None);
            LineItem lscLine = cGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = cGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);


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
            pGraphPane.YAxis.Title.Text = "Valor P";
            double media = 0;
            // Adicionar os pontos de dados ao gráfico P
            PointPairList pPointPairs = new PointPairList();
            List<double> data = new List<double>();

            for (int i = 0; i < row; i++)
            {
                double pValue = matriz[i, 0] / matriz[i, 1];
                pPointPairs.Add(i + 1, pValue);
                data.Add(pValue);
                media += pValue;
            }
            LineItem pCurve = pGraphPane.AddCurve("P", pPointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            media /= (row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = pGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Blue, SymbolType.None);
            LineItem lscLine = pGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = pGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);



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
