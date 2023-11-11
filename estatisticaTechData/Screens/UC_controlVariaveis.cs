using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
    public partial class UC_controlVariaveis : UserControl
    {
        double cpk, cp,
            desvio = UC_BackgroundVariaveis.funEstancia.desvioPadrao,
            lsc = UC_BackgroundVariaveis.funEstancia.media + 3 * UC_BackgroundVariaveis.funEstancia.desvioPadrao,
            lic = UC_BackgroundVariaveis.funEstancia.media - 3 * UC_BackgroundVariaveis.funEstancia.desvioPadrao,
            media = UC_BackgroundVariaveis.funEstancia.media;            

        public UC_controlVariaveis()
        {
            InitializeComponent();
            cpk = ClsCalculos.CalculateCpk(UC_BackgroundVariaveis.funEstancia.media, UC_BackgroundVariaveis.funEstancia.desvioPadrao, lsc,lic);
            cp = ClsCalculos.CalculateCp(UC_BackgroundVariaveis.funEstancia.desvioPadrao, lsc, lic);
        }
        private void UC_controlVariaveis_Load(object sender, EventArgs e)
        {
            GraficoControle(UC_BackgroundVariaveis.funEstancia.arrayExcel);
            GraficoAmplitude(UC_BackgroundVariaveis.funEstancia.amplitudes);
            GraficoMedia(UC_BackgroundVariaveis.funEstancia.mediasIniciais);
            double amplitude = UC_BackgroundVariaveis.funEstancia.arrayExcel.Max() - UC_BackgroundVariaveis.funEstancia.arrayExcel.Min();
            rdbControle.Checked = true;
            lblMedia.Text = media.ToString("f4");
            lblDesvio.Text = desvio.ToString("f4");
            lblCpk.Text = cpk.ToString("f4");
            lblCP.Text = cp.ToString("f4");
            lblAmplitude.Text = amplitude.ToString("f4");
        }

        private void GraficoControle(double[] arrayTeste)
        {
            // Configurar o objeto GraphPane para o gráfico Individual (I)
            GraphPane graphPane = zedControle.GraphPane;
            zedControle.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Controle Individual (I)";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor observado";

            // Dados de exemplo
            PointPairList pointsMedia = new PointPairList();
            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            double media = UC_BackgroundVariaveis.funEstancia.media;
            double yMin=0, yMax=0;
            for (int i = 0; i < data.Count; i++)
            {
                pointsMedia.Add(i, data[i]);
                if (i == 0)
                {
                    yMin = data[i];
                    yMax = data[i];
                }
                else
                {
                    if (data[i] > yMax)
                        yMax = data[i];
                    if (data[i] < yMin)
                        yMin = data[i];
                }
            }

            LineItem mediaLine = graphPane.AddCurve("Média", new double[] { 0, data.Count - 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = graphPane.AddCurve("LSC", new double[] { 0, data.Count - 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = graphPane.AddCurve("LIC", new double[] { 0, data.Count - 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);


            LineItem pontosLine = graphPane.AddCurve("Amostras", pointsMedia, Color.Blue, SymbolType.Circle);

            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            pontosLine.Line.Width = 2.0f;
            pontosLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;
            graphPane.XAxis.Scale.Min = - 1;
            graphPane.XAxis.Scale.Max = data.Count;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                graphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.1;
                graphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.1;
            }
            else
            {
                graphPane.YAxis.Scale.Min = lic - 0.1;
                graphPane.YAxis.Scale.Max = lsc + 0.1;
            }

            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            graphPane.XAxis.Scale.MajorStep = 10;
            graphPane.YAxis.Scale.MajorStep = yMajorStep;

            zedControle.AxisChange();
            zedControle.Invalidate();
        }

        private void GraficoMedia(double[] medias)
        {
            // Configurar o objeto GraphPane para o gráfico X-barra
            GraphPane graphPane = zedMedias.GraphPane;
            //grafico.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Médias";
            graphPane.XAxis.Title.Text = "Médias";
            graphPane.YAxis.Title.Text = "Valor";

            // Adicionar os pontos de dados ao gráfico X-barra
            LineItem mediasCurve = graphPane.AddCurve("Médias", null, medias, Color.Blue, SymbolType.Circle);
            double yMin = medias.Min();
            double yMax = medias.Max();

            List<double> data = new List<double>();
            data.AddRange(medias);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = graphPane.AddCurve("Média", new double[] { 0, data.Count + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = graphPane.AddCurve("LSC", new double[] { 0, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = graphPane.AddCurve("LIC", new double[] { 0, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);



            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            mediasCurve.Line.Width = 2.0f;
            mediasCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = data.Count + 1;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                graphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.1;
                graphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.1;
            }
            else
            {
                graphPane.YAxis.Scale.Min = lic - 0.1;
                graphPane.YAxis.Scale.Max = lsc + 0.1;
            }
            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;
            graphPane.YAxis.Scale.MajorStep = yMajorStep;
            graphPane.XAxis.Scale.MajorStep = 1;

            zedMedias.AxisChange();
            zedMedias.Invalidate();
        }
        private void GraficoAmplitude(double[] amplitudes)
        {
            // Configurar o objeto GraphPane para o gráfico de Amplitude (R)
            GraphPane graphPaneR = zedAmplitude.GraphPane;
            zedAmplitude.Dock = DockStyle.Fill;
            graphPaneR.Title.Text = "Gráfico de Controle de Amplitude (R)";
            graphPaneR.XAxis.Title.Text = "Amostras";
            graphPaneR.YAxis.Title.Text = "Amplitudes";



            // Adicionar os pontos de dados ao gráfico de Amplitude (R)
            LineItem amplitudesCurve = graphPaneR.AddCurve("Amplitudes", null, amplitudes, Color.Blue, SymbolType.Circle);
            double yMin = amplitudes.Min();
            double yMax = amplitudes.Max();

            double media = amplitudes.Average();
            double desvioPadrao = Math.Sqrt(amplitudes.Select(x => Math.Pow(x - media, 2)).Average());
            double lsc = media + (3* desvioPadrao);
            double lic = media - (3 * desvioPadrao);

            LineItem mediaLine = graphPaneR.AddCurve("Média", new double[] { 0, amplitudes.Length  +1}, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = graphPaneR.AddCurve("LSC", new double[] { 0, amplitudes.Length + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = graphPaneR.AddCurve("LIC", new double[] { 0, amplitudes.Length + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);

            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            amplitudesCurve.Line.Width = 2.0f;
            amplitudesCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            graphPaneR.XAxis.MajorGrid.IsVisible = true;
            graphPaneR.YAxis.MajorGrid.IsVisible = true;
            graphPaneR.XAxis.Scale.Min = 0;
            graphPaneR.XAxis.Scale.Max = amplitudes.Length +1;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                graphPaneR.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.1;
                graphPaneR.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.1;
            }
            else
            {
                graphPaneR.YAxis.Scale.Min = lic - 0.1;
                graphPaneR.YAxis.Scale.Max = lsc + 0.1;
            }
            graphPaneR.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            graphPaneR.XAxis.Scale.MajorStep = 1;
            graphPaneR.YAxis.Scale.MajorStep = yMajorStep;

            // Atualizar o gráfico
            zedAmplitude.AxisChange();
            zedAmplitude.Invalidate();
        }

        private void rdbControle_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbControle.Checked)
            {
                zedControle.Visible = true;
                zedAmplitude.Visible = false;
                zedMedias.Visible = false;
            }
        }

        private void rdbMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedia.Checked)
            {
                zedMedias.Visible = true;
                zedAmplitude.Visible = false;
                zedControle.Visible = false;
            }
        }

        private void rdbAmplitudes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAmplitudes.Checked)
            {
                zedMedias.Visible = false;
                zedAmplitude.Visible = true;
                zedControle.Visible = false;
            }
        }

        private void btnVermais_Click(object sender, EventArgs e)
        {
            string nomeDaGuia = "BackgroundVariavel";
            frmHub.funEstancia.guia(nomeDaGuia);
        }
    }
}
