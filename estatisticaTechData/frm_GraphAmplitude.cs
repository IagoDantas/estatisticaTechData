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

namespace estatisticaTechData
{
    public partial class frmGraphAmplitude : Form
    {
        double[] arrayTeste;
        public frmGraphAmplitude(double[] arrayTeste)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.arrayTeste = arrayTeste;
        }

        private void frmGraphAmplitude_Load(object sender, EventArgs e)
        {
            // Configurar o objeto GraphPane para o gráfico de amplitude
            GraphPane graphPane = grafico.GraphPane;
            grafico.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Amplitude";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor";

            // Ordenar os dados em ordem crescente
            double[] sortedData = arrayTeste.OrderBy(x => x).ToArray();

            // Criar uma lista de rótulos para o eixo X
            List<string> labels = new List<string>();
            for (int i = 0; i < sortedData.Length; i++)
            {
                labels.Add((i + 1).ToString());
            }

            // Criar uma lista de pontos para o gráfico de amplitude
            PointPairList dataPoints = new PointPairList();
            for (int i = 0; i < sortedData.Length; i++)
            {
                dataPoints.Add(i + 1, sortedData[i]);
            }

            // Adicionar os pontos de dados ao gráfico de amplitude
            LineItem amplitudeCurve = graphPane.AddCurve("Amplitude", dataPoints, Color.Red, SymbolType.Circle);

            // Configurar os eixos
            graphPane.XAxis.Scale.TextLabels = labels.ToArray();
            graphPane.XAxis.Type = AxisType.Text;
            graphPane.XAxis.MajorTic.IsBetweenLabels = true;

            graphPane.YAxis.Scale.Min = sortedData[0] - 1;
            graphPane.YAxis.Scale.Max = sortedData[sortedData.Length - 1] + 1;

            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;

            grafico.AxisChange();
            grafico.Invalidate();
        }
    }
}
