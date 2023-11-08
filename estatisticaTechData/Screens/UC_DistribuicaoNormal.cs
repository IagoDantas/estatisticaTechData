using estatisticaTechDataClassLibrary;
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

namespace estatisticaTechData.Screens
{
    public partial class UC_DistribuicaoNormal : UserControl
    {
        double cpk,
            lsc = UC_BackgroundDist.funEstancia.media + 3 * UC_BackgroundDist.funEstancia.desvioPadrao,
            lic = UC_BackgroundDist.funEstancia.media - 3 * UC_BackgroundDist.funEstancia.desvioPadrao,
            media = UC_BackgroundDist.funEstancia.media,
            desvioPadrao = UC_BackgroundDist.funEstancia.desvioPadrao;

        public UC_DistribuicaoNormal()
        {
            InitializeComponent();
            cpk = ClsCalculos.CalculateCpk(UC_BackgroundDist.funEstancia.media, UC_BackgroundDist.funEstancia.desvioPadrao, lsc, lic);
        }
        private void UC_DistribuicaoNormal_Load(object sender, EventArgs e)
        {
            Grafico();
            lblMedia.Text = media.ToString("f4");
            lblDesvio.Text = desvioPadrao.ToString("f4");
            lblCpk.Text = cpk.ToString("f4");
        }

        private void Grafico()
        {
            GraphPane graphPane = zedDistribuição.GraphPane;
            zedDistribuição.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Distribuição Normal";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor";


            List<double> data = new List<double>();
            data.AddRange(UC_BackgroundDist.funEstancia.arrayExcel);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            PointPairList pointPairList = new PointPairList();
            double numDevs = 3;
            double xMin = media - (numDevs * desvioPadrao);
            double xMax = media + (numDevs * desvioPadrao);
            double step = 0.1;
            double lic = media - (3 * desvioPadrao);
            double lsc = media + (3 * desvioPadrao);
            double yMin=0, yMax=0;

              
            
            for (double x = xMin; x <= xMax; x += step)
            {
                double y = (1 / (desvioPadrao * Math.Sqrt(2 * Math.PI))) *
                           Math.Exp(-Math.Pow(x - media, 2) / (2 * Math.Pow(desvioPadrao, 2)));
                if (x == xMin)
                {
                    yMin = y;
                    yMax = y;
                }
                else
                {
                    if (y > yMax)
                        yMax = y;
                    if (y < yMin)
                        yMin = y;
                }

                pointPairList.Add(x, y);
            }

            

            LineItem mediaLine = graphPane.AddCurve("Média", new double[] { media, media }, new double[] { yMin, yMax}, Color.DarkGreen, SymbolType.None);
            LineItem lscLine = graphPane.AddCurve("LSC",  new double[] { lsc, lsc }, new double[] { yMin, yMax}, Color.Red, SymbolType.None);
            LineItem licLine = graphPane.AddCurve("LIC",  new double[] { lic, lic }, new double[] { yMin, yMax}, Color.Red, SymbolType.None);

            // Adicionar uma curva ao gráfico com a lista de pontos
            LineItem curve = graphPane.AddCurve("Curva", pointPairList, System.Drawing.Color.Blue, SymbolType.None);

            graphPane.XAxis.Scale.Min = xMin-2;
            graphPane.XAxis.Scale.Max = xMax+2;
            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            graphPane.YAxis.Scale.Min = yMin - 0.01; 
            graphPane.YAxis.Scale.Max = yMax + 0.01; 

            // Atualizar o gráfico
            zedDistribuição.AxisChange();
            zedDistribuição.Invalidate();
        }

        private void btnVermais_Click(object sender, EventArgs e)
        {
            string nomeDaGuia = "BackgroundDist";
            frmHub.funEstancia.guia(nomeDaGuia);
        }
    }
}
