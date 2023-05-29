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
    public partial class frmGraphMedia : Form
    {
        double[] arrayTeste;
        public frmGraphMedia(double[] arrayTeste)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.arrayTeste = arrayTeste;
        }

        private void frmGraphMedia_Load(object sender, EventArgs e)
        {
            grafico.Dock = DockStyle.Fill;
            // Configurar o gráfico
            GraphPane graphPane = grafico.GraphPane;
            graphPane.Title.Text = "Gráfico de Média";
            graphPane.XAxis.Title.Text = "Eixo X";
            graphPane.YAxis.Title.Text = "Eixo Y";


            // Dados de exemplo
            PointPairList pointsMedia = new PointPairList();
            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            for (int i = 0; i < data.Count; i++)
            {
                pointsMedia.Add(i + 1, data[i]);
            }

            double media = pointsMedia.Average(p => p.Y);
            double xMin = 1;
            double xMax = data.Count;

            LineItem mediaLine = graphPane.AddCurve("Média", new[] { xMin, xMax }, new[] { media, media }, Color.Red);
            mediaLine.Line.Width = 2;

            ZedGraphControl zedGraphControl = new ZedGraphControl();

            zedGraphControl.GraphPane = graphPane;

            this.Controls.Add(zedGraphControl);

        }
    }
}
