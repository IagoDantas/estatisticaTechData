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
    public partial class frmGraphAmpli : Form
    {
        double[] amplitudes;

        public frmGraphAmpli(double[] amplitudes)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.amplitudes = amplitudes;
        }

        private void frmGraphAmpli_Load(object sender, EventArgs e)
        {
            // Configurar o objeto GraphPane para o gráfico de Amplitude (R)
            GraphPane graphPaneR = zgcGraph.GraphPane;
            zgcGraph.Dock = DockStyle.Fill;
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
            zgcGraph.AxisChange();
            zgcGraph.Invalidate();
        }

    }
}
