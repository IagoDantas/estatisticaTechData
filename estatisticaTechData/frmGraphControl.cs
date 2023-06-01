using DocumentFormat.OpenXml.Office2010.PowerPoint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace ExemploGraficoControle
{
    public partial class frmGraphControl : Form
    {
        double[] arrayTeste;

        public frmGraphControl(double[] arrayTeste)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.arrayTeste = arrayTeste;
        }

        private void frmGraphControl_Load(object sender, EventArgs e)
        {
            // Configurar o objeto GraphPane para o gráfico Individual (I)
            GraphPane graphPane = grafico.GraphPane;
            grafico.Dock = DockStyle.Fill;
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

            grafico.AxisChange();
            grafico.Invalidate();


        }
    }
}
