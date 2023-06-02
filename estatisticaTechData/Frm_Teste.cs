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
    public partial class Frm_Teste : Form
    {
        double[] arrayTeste;
        public Frm_Teste(double[] arrayTeste)
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.arrayTeste = arrayTeste;
        }

        private void Frm_Teste_Load(object sender, EventArgs e)

        { 
            GraphPane graphPane = grafico.GraphPane;
            grafico.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Distribuição Normal";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor";


            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            PointPairList pointPairList = new PointPairList();
            double numDevs = 3;
            double xMin = media - (numDevs * desvioPadrao);
            double xMax = media + (numDevs * desvioPadrao);
            double step = 0.1;
            
            

            for (double x = xMin; x <= xMax; x += step)
            {
                double y = (1 / (desvioPadrao * Math.Sqrt(2 * Math.PI))) *
                           Math.Exp(-Math.Pow(x - media, 2) / (2 * Math.Pow(desvioPadrao, 2)));

                pointPairList.Add(x, y);
            }

            // Adicionar uma curva ao gráfico com a lista de pontos
            LineItem curve = graphPane.AddCurve("Curva", pointPairList, System.Drawing.Color.Blue, SymbolType.None);

            // Atualizar o gráfico
            grafico.AxisChange();
            grafico.Invalidate();
        }


    }
}
