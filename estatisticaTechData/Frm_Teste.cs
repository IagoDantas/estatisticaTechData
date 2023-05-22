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
        public Frm_Teste()
        {
            InitializeComponent();
        }

        private void Frm_Teste_Load(object sender, EventArgs e)
        {
            // Obter a referência ao objeto ZedGraphControl

            // Adicionar o controle ZedGraphControl ao formulário
            Controls.Add(grafico);

            // Configurar o gráfico
            GraphPane graphPane = grafico.GraphPane;
            graphPane.Title.Text = "Distribuição Normal";
            graphPane.XAxis.Title.Text = "Valores X";
            graphPane.YAxis.Title.Text = "Valores Y";

            // Criar uma lista de pontos para a distribuição normal
            PointPairList pointPairList = new PointPairList();
            double mean = 0; // Média
            double stdDev = 1; // Desvio padrão
            double xMin = -3; // Valor mínimo do eixo x
            double xMax = 3; // Valor máximo do eixo x
            double step = 0.1; // Incremento para gerar os pontos

            for (double x = xMin; x <= xMax; x += step)
            {
                double y = (1 / (stdDev * Math.Sqrt(2 * Math.PI))) *
                           Math.Exp(-Math.Pow(x - mean, 2) / (2 * Math.Pow(stdDev, 2)));

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
