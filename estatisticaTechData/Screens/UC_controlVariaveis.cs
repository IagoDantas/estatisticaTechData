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
        public UC_controlVariaveis()
        {
            InitializeComponent();
        }
        private void UC_controlVariaveis_Load(object sender, EventArgs e)
        {
            GraficoControle(UC_Background.funEstancia.arrayExcel);
            GraficoAmplitude(UC_Background.funEstancia.amplitudes);
            GraficoMedia(UC_Background.funEstancia.mediasIniciais);
            rdbControle.Checked = true;
        }

        private void GraficoControle(double[] arrayTeste)
        {
            // Configurar o objeto GraphPane para o gráfico Individual (I)
            GraphPane graphPane = zedControle.GraphPane;
            zedControle.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Controle Individual (I)";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor";

            // Dados de exemplo
            PointPairList pointsMedia = new PointPairList();
            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;

            for (int i = 0; i < data.Count; i++)
            {
                pointsMedia.Add(i, data[i]);
            }

            LineItem mediaLine = graphPane.AddCurve("Média", new double[] { 0, data.Count - 1 }, new double[] { media, media }, Color.Blue, SymbolType.None);
            LineItem lscLine = graphPane.AddCurve("LSC", new double[] { 0, data.Count - 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = graphPane.AddCurve("LIC", new double[] { 0, data.Count - 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);


            LineItem pontosLine = graphPane.AddCurve("Pontos", pointsMedia, Color.Black, SymbolType.Circle);

            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = data.Count - 1;
            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;

            zedControle.AxisChange();
            zedControle.Invalidate();
        }

        private void GraficoMedia(double[] arrayTeste)
        {
            // Configurar o objeto GraphPane para o gráfico X-barra
            GraphPane graphPane = zedMedias.GraphPane;
            //grafico.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Médias";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor";

            // Adicionar os pontos de dados ao gráfico X-barra
            LineItem mediasCurve = graphPane.AddCurve("Médias", null, arrayTeste, Color.Red, SymbolType.Circle);


            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = graphPane.AddCurve("Média", new double[] { 0, data.Count + 1 }, new double[] { media, media }, Color.Blue, SymbolType.None);
            LineItem lscLine = graphPane.AddCurve("LSC", new double[] { 0, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = graphPane.AddCurve("LIC", new double[] { 0, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);



            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = data.Count + 1;
            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;

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
            graphPaneR.YAxis.Title.Text = "Amplitude";



            // Adicionar os pontos de dados ao gráfico de Amplitude (R)
            LineItem amplitudesCurve = graphPaneR.AddCurve("Amplitudes", null, amplitudes, Color.Green, SymbolType.Circle);


            graphPaneR.XAxis.Scale.Min = 0;
            graphPaneR.XAxis.Scale.Max = amplitudes.Length + 1;
            graphPaneR.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            graphPaneR.XAxis.MajorGrid.IsVisible = true;
            graphPaneR.YAxis.MajorGrid.IsVisible = true;

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

    }
}
