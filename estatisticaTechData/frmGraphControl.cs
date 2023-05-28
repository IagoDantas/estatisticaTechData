using DocumentFormat.OpenXml.Office2019.Excel.RichData2;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            grafico.Dock = DockStyle.Fill;
            // Configurar o gráfico
            GraphPane graphPane = grafico.GraphPane;
            graphPane.Title.Text = "Gráfico de Controle";
            graphPane.XAxis.Title.Text = "Tempo";
            graphPane.YAxis.Title.Text = "Valor";

            // Dados de exemplo
            List<double> data = new List<double>();
            data.AddRange(arrayTeste);

            // Calcular a média e o desvio padrão dos dados
            double mean = CalculateMean(data);
            double stdDev = CalculateStandardDeviation(data);

            // Calcular os limites de controle (por exemplo, usando 3 desvios padrão)
            double upperLimit = mean + 3 * stdDev;
            double lowerLimit = mean - 3 * stdDev;

            // Adicionar os pontos de dados ao gráfico
            PointPairList pointPairList = new PointPairList();
            for (int i = 0; i < data.Count; i++)
            {
                double x = i + 1; // Tempo (pode ser uma data real)
                double y = data[i]; // Valor do dado

                pointPairList.Add(x, y);
            }

            // Adicionar curva com os pontos de dados
            LineItem curve = graphPane.AddCurve("Dados", pointPairList, Color.Blue, SymbolType.Circle);

            // Adicionar limites de controle como linhas horizontais
            LineObj upperLimitLine = new LineObj(Color.Red, curve.Points[0].X, upperLimit, curve.Points[curve.Points.Count - 1].X, upperLimit);
            LineObj lowerLimitLine = new LineObj(Color.Red, curve.Points[0].X, lowerLimit, curve.Points[curve.Points.Count - 1].X, lowerLimit);

            graphPane.GraphObjList.Add(upperLimitLine);
            graphPane.GraphObjList.Add(lowerLimitLine);

            // Atualizar o gráfico
            grafico.AxisChange();
            grafico.Invalidate();
        }

        private double CalculateMean(List<double> data)
        {
            double sum = 0;
            foreach (double value in data)
            {
                sum += value;
            }

            return sum / data.Count;
        }

        private double CalculateStandardDeviation(List<double> data)
        {
            double mean = CalculateMean(data);
            double sumSquaredDiff = 0;

            foreach (double value in data)
            {
                double diff = value - mean;
                sumSquaredDiff += Math.Pow(diff, 2);
            }

            double variance = sumSquaredDiff / data.Count;
            return Math.Sqrt(variance);
        }
    }
}
