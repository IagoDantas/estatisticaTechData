using estatisticaTechDataClassLibrary;
using Newtonsoft.Json;
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
    public partial class UC_controlCompara : UserControl
    {
        int id;
        string jsonString;
        string type;
        private estatisticaTechDataClassLibrary.Connection conexao;
        public UC_controlCompara(int id)
        {
            this.id = id;
            conexao = new estatisticaTechDataClassLibrary.Connection();
            InitializeComponent();  
        }
        private void UC_controlCompara_Load(object sender, EventArgs e)
        {
            PegaJson();
            var jsonDataList = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(jsonString);
            if (type == "1")
            {
                type1(jsonDataList);
            }
            else if (type == "2")
            {
                type2(jsonDataList);
            }
            else if (type == "3")
            {
                type3(jsonDataList);
            }
        }

        private void type1(List<Dictionary<string, string>> jsonDataList)
        {
            double[,] matrizNew = UC_BackgroundCompara.funEstancia.matrizExcel;
            double rowNew = matrizNew.GetLength(0);
            double[,] matrizOld = Atributos(jsonDataList);
            double rodOld = matrizOld.GetLength(0);
            GraficoC(zedInicial1, matrizNew, rowNew);
            GraficoP(zedInicial2, matrizNew, rowNew);
            GraficoC(zedCompara1, matrizNew, rowNew);
            GraficoP(zedCompara2, matrizNew, rowNew);
            rdbEscolha1.Text = "Gráfico C";
            rdbEscolha2.Visible = false;
            rdbEscolha2.Enabled = true;
            rdbEscolha3.Text = "Gráfico P";
            rdbOutro1.Text = "Gráfico C";
            rdbOutro2.Visible = false;
            rdbOutro2.Enabled = true;
            rdbOutro3.Text = "Gráfico P";
            rdbEscolha1.CheckedChanged += (s, eventArgs) =>
            {
                zedInicial1.Visible = true;
                zedInicial2.Visible = false;
            };
            rdbEscolha3.CheckedChanged += (s, eventArgs) =>
            {
                zedInicial1.Visible = false;
                zedInicial2.Visible = true;
            };
            rdbOutro1.CheckedChanged += (s, eventArgs) =>
            {
                zedCompara1.Visible = true;
                zedCompara2.Visible = false;
            };
            rdbOutro3.CheckedChanged += (s, eventArgs) =>
            {
                zedCompara1.Visible = false;
                zedCompara2.Visible = true;
            };
            rdbEscolha1.Checked = true;
            rdbOutro1.Checked = true;
        }
        private void type2(List<Dictionary<string, string>> jsonDataList)
        {
            double[] arrayNew = UC_BackgroundCompara.funEstancia.arrayExcel;
            double[] mediasNew = UC_BackgroundCompara.funEstancia.mediasIniciais;
            double[] amplitudesNew = UC_BackgroundCompara.funEstancia.amplitudes;
            double[,] matrizOld = Variaveis(jsonDataList);
            int x = matrizOld.GetLength(0), y = matrizOld.GetLength(1);
            double[] vetor = new double[x * y];
            for (int i = 0; i < x * y; i++)
            {
                vetor[i] = matrizOld[i / y, i % y];
            }
            double[] mediasOld = ClsCalculos.CalcularMediasInicias(matrizOld, x, y);
            double[] amplitudesOld = ClsCalculos.CalcularAmplitudes(matrizOld, x, y);
            GraficoControle(zedInicial3, vetor);
            GraficoMedia(zedInicial4, mediasOld);
            GraficoAmplitude(zedInicial5, amplitudesOld);
            GraficoControle(zedCompara3, arrayNew);
            GraficoMedia(zedCompara4, mediasNew);
            GraficoAmplitude(zedCompara5, amplitudesNew);

            rdbEscolha1.Text = "Controle Individual";
            rdbEscolha2.Text = "Medias";
            rdbEscolha3.Text = "Amplitude";
            rdbOutro1.Text = "Controle Individual";
            rdbOutro2.Text = "Medias";
            rdbOutro3.Text = "Amplitude";
            rdbEscolha1.CheckedChanged += (s, eventArgs) =>
            {
                zedInicial3.Visible = true;
                zedInicial4.Visible = false;
                zedInicial5.Visible = false;
            };
            rdbEscolha2.CheckedChanged += (s, eventArgs) =>
            {
                zedInicial3.Visible = false;
                zedInicial4.Visible = true;
                zedInicial5.Visible = false;
            };
            rdbEscolha3.CheckedChanged += (s, eventArgs) =>
            {
                zedInicial3.Visible = false;
                zedInicial4.Visible = false;
                zedInicial5.Visible = true;
            };
            rdbOutro1.CheckedChanged += (s, eventArgs) =>
            {
                zedCompara3.Visible = true;
                zedCompara4.Visible = false;
                zedCompara5.Visible = false;
            };
            rdbOutro2.CheckedChanged += (s, eventArgs) =>
            {
                zedCompara3.Visible = false;
                zedCompara4.Visible = true;
                zedCompara5.Visible = false;
            };
            rdbOutro3.CheckedChanged += (s, eventArgs) =>
            {
                zedCompara3.Visible = false;
                zedCompara4.Visible = false;
                zedCompara5.Visible = true;
            };
            rdbEscolha1.Checked = true;
            rdbOutro1.Checked = true;    
        }
        private void type3(List<Dictionary<string, string>> jsonDataList)
        {

            double[] arrayNew = UC_BackgroundCompara.funEstancia.arrayExcel;
            double[] arrayOld = Dist(jsonDataList);
            GraficoDist(zedInicial6, arrayOld);
            GraficoDist(zedCompara6, arrayNew);
            zedInicial6.Visible = true;
            zedCompara6.Visible = true;
            rdbEscolha1.Visible = false;
            rdbEscolha1 .Enabled = true;
            rdbEscolha2.Text = "Distribuição Normal";
            rdbEscolha3.Visible = false;
            rdbEscolha3.Enabled = true;
            rdbOutro1.Visible = false;
            rdbOutro1.Enabled = true;
            rdbOutro2.Text = "Distribuição Normal";
            rdbOutro3.Visible = false;
            rdbOutro3.Enabled = true;

            rdbEscolha2.Checked = true;
            rdbOutro2.Checked = true;
        }
        private void GraficoC(ZedGraphControl zedGraph, double[,] matriz, double row)
        {
            // Configurar o objeto GraphPane para o gráfico C
            GraphPane cGraphPane = zedGraph.GraphPane;
            cGraphPane.Title.Text = "Gráfico C";
            cGraphPane.XAxis.Title.Text = "Amostras";
            cGraphPane.YAxis.Title.Text = "Número de Defeitos";
            double media = 0;
            double yMax = 0, yMin = 0;


            // Adicionar os pontos de dados ao gráfico C
            PointPairList cPointPairs = new PointPairList();
            List<double> data = new List<double>();
            for (int i = 0; i < row; i++)
            {
                double cValue = 1 - (matriz[i, 0] / matriz[i, 1]);
                cPointPairs.Add(i + 1, cValue);
                if (i == 0)
                {
                    yMin = cValue;
                    yMax = cValue;
                }
                else
                {
                    if (cValue > yMax)
                        yMax = cValue;
                    if (cValue < yMin)
                        yMin = cValue;
                }
                data.Add(cValue);
                media += cValue;
            }
            LineItem cCurve = cGraphPane.AddCurve("C", cPointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            media = media / (row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = cGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = cGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = cGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);
            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            cCurve.Line.Width = 2.0f;
            cCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            cGraphPane.XAxis.MajorGrid.IsVisible = true;
            cGraphPane.YAxis.MajorGrid.IsVisible = true;
            cGraphPane.XAxis.Scale.Min = 0;
            cGraphPane.XAxis.Scale.Max = row + 1;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                cGraphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                cGraphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
            }
            else
            {
                cGraphPane.YAxis.Scale.Min = lic - 0.01;
                cGraphPane.YAxis.Scale.Max = lsc + 0.01;
            }
            cGraphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            cGraphPane.XAxis.Scale.MajorStep = 1;
            cGraphPane.YAxis.Scale.MajorStep = yMajorStep;

            // Atualizar os gráficos
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        private void GraficoP(ZedGraphControl zedGraph, double[,] matriz, double row)
        {
            // Configurar o objeto GraphPane para o gráfico P
            GraphPane pGraphPane = zedGraph.GraphPane;
            pGraphPane.Title.Text = "Gráfico P";
            pGraphPane.XAxis.Title.Text = "Amostras";
            pGraphPane.YAxis.Title.Text = "Proporção de Defeitos";
            double media = 0;
            // Adicionar os pontos de dados ao gráfico P
            PointPairList pPointPairs = new PointPairList();
            List<double> data = new List<double>();
            double yMin = 0, yMax = 0;

            for (int i = 0; i < row; i++)
            {
                double pValue = matriz[i, 0] / matriz[i, 1];
                pPointPairs.Add(i + 1, pValue);
                data.Add(pValue);
                if (i == 0)
                {
                    yMin = pValue;
                    yMax = pValue;
                }
                else
                {
                    if (pValue > yMax)
                        yMax = pValue;
                    if (pValue < yMin)
                        yMin = pValue;
                }
                media += pValue;
            }
            LineItem pCurve = pGraphPane.AddCurve("P", pPointPairs, System.Drawing.Color.Blue, SymbolType.Circle);
            media /= (row);
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

            double lsc = media + 3 * desvioPadrao;
            double lic = media - 3 * desvioPadrao;


            LineItem mediaLine = pGraphPane.AddCurve("Média", new double[] { -1, data.Count + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
            LineItem lscLine = pGraphPane.AddCurve("LSC", new double[] { -1, data.Count + 1 }, new double[] { lsc, lsc }, Color.Red, SymbolType.None);
            LineItem licLine = pGraphPane.AddCurve("LIC", new double[] { -1, data.Count + 1 }, new double[] { lic, lic }, Color.Red, SymbolType.None);


            mediaLine.Line.Width = 3.0f;
            lscLine.Line.Width = 3.0f;
            licLine.Line.Width = 3.0f;
            mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            pCurve.Line.Width = 2.0f;
            pCurve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

            pGraphPane.XAxis.MajorGrid.IsVisible = true;
            pGraphPane.YAxis.MajorGrid.IsVisible = true;
            pGraphPane.XAxis.Scale.Min = 0;
            pGraphPane.XAxis.Scale.Max = row + 1;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                pGraphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                pGraphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
            }
            else
            {
                pGraphPane.YAxis.Scale.Min = lic - 0.01;
                pGraphPane.YAxis.Scale.Max = lsc + 0.01;
            }
            pGraphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            pGraphPane.XAxis.Scale.MajorStep = 1;
            pGraphPane.YAxis.Scale.MajorStep = yMajorStep;
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        private void GraficoControle(ZedGraphControl zedGraph, double[] arrayTeste)
        {
            // Configurar o objeto GraphPane para o gráfico Individual (I)
            GraphPane graphPane = zedGraph.GraphPane;
            zedGraph.Dock = DockStyle.Fill;
            graphPane.Title.Text = "Gráfico de Controle Individual (I)";
            graphPane.XAxis.Title.Text = "Amostra";
            graphPane.YAxis.Title.Text = "Valor observado";

            // Dados de exemplo
            PointPairList pointsMedia = new PointPairList();
            List<double> data = new List<double>();
            data.AddRange(arrayTeste);
            double media = data.Average();
            double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());
            double yMin = 0, yMax = 0;
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


            double lsc = media + 3 * desvioPadrao;
            double lic = media + 3 * desvioPadrao;

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
            graphPane.XAxis.Scale.Min = -1;
            graphPane.XAxis.Scale.Max = data.Count;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                graphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                graphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
            }
            else
            {
                graphPane.YAxis.Scale.Min = lic - 0.01;
                graphPane.YAxis.Scale.Max = lsc + 0.01;
            }

            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            graphPane.XAxis.Scale.MajorStep = 10;
            graphPane.YAxis.Scale.MajorStep = yMajorStep;

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        private void GraficoMedia(ZedGraphControl zedGraph, double[] medias)
        {
            // Configurar o objeto GraphPane para o gráfico X-barra
            GraphPane graphPane = zedGraph.GraphPane;
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
                graphPane.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                graphPane.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
            }
            else
            {
                graphPane.YAxis.Scale.Min = lic - 0.01;
                graphPane.YAxis.Scale.Max = lsc + 0.01;
            }
            graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;
            graphPane.YAxis.Scale.MajorStep = yMajorStep;
            graphPane.XAxis.Scale.MajorStep = 1;

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        private void GraficoAmplitude(ZedGraphControl zedGraph, double[] amplitudes)
        {
            // Configurar o objeto GraphPane para o gráfico de Amplitude (R)
            GraphPane graphPaneR = zedGraph.GraphPane;
            zedGraph.Dock = DockStyle.Fill;
            graphPaneR.Title.Text = "Gráfico de Controle de Amplitude (R)";
            graphPaneR.XAxis.Title.Text = "Amostras";
            graphPaneR.YAxis.Title.Text = "Amplitudes";



            // Adicionar os pontos de dados ao gráfico de Amplitude (R)
            LineItem amplitudesCurve = graphPaneR.AddCurve("Amplitudes", null, amplitudes, Color.Blue, SymbolType.Circle);
            double yMin = amplitudes.Min();
            double yMax = amplitudes.Max();

            double media = amplitudes.Average();
            double desvioPadrao = Math.Sqrt(amplitudes.Select(x => Math.Pow(x - media, 2)).Average());
            double lsc = media + (3 * desvioPadrao);
            double lic = media - (3 * desvioPadrao);

            LineItem mediaLine = graphPaneR.AddCurve("Média", new double[] { 0, amplitudes.Length + 1 }, new double[] { media, media }, Color.Green, SymbolType.None);
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
            graphPaneR.XAxis.Scale.Max = amplitudes.Length + 1;
            if (yMax > lsc || yMin < lic)
            {
                double diffMax, diffMin;
                diffMax = yMax - lsc;
                diffMin = lic - yMin;
                graphPaneR.YAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                graphPaneR.YAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
            }
            else
            {
                graphPaneR.YAxis.Scale.Min = lic - 0.01;
                graphPaneR.YAxis.Scale.Max = lsc + 0.01;
            }
            graphPaneR.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            double yDataRange = yMax - yMin;
            double yMajorStep = yDataRange / 10;

            graphPaneR.XAxis.Scale.MajorStep = 1;
            graphPaneR.YAxis.Scale.MajorStep = yMajorStep;

            // Atualizar o gráfico
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        private void GraficoDist(ZedGraphControl zedGraph, double[] arrayTeste)
        {
            try
            {
                GraphPane graphPane = zedGraph.GraphPane;
                zedGraph.Dock = DockStyle.Fill;
                graphPane.Title.Text = "Distribuição Normal";
                graphPane.XAxis.Title.Text = "Valores da Amostra";
                graphPane.YAxis.Title.Text = "Densidade de Probabilidade";

                if (arrayTeste != null)
                {
                    List<double> data = new List<double>();
                    data.AddRange(arrayTeste);
                    double media = data.Average();
                    double desvioPadrao = Math.Sqrt(data.Select(x => Math.Pow(x - media, 2)).Average());

                    PointPairList pointPairList = new PointPairList();
                    double numDevs = 3;
                    double xMin = media - (numDevs * desvioPadrao);
                    double xMax = media + (numDevs * desvioPadrao);
                    double step = 0.1;
                    double lic = media - (3 * desvioPadrao);
                    double lsc = media + (3 * desvioPadrao);
                    double yMin = 0, yMax = 0;



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



                    LineItem mediaLine = graphPane.AddCurve("Média", new double[] { media, media }, new double[] { yMin - 0.001, yMax + 0.001 }, Color.Green, SymbolType.None);
                    LineItem lscLine = graphPane.AddCurve("LSC", new double[] { lsc, lsc }, new double[] { yMin - 0.001, yMax + 0.001 }, Color.Red, SymbolType.None);
                    LineItem licLine = graphPane.AddCurve("LIC", new double[] { lic, lic }, new double[] { yMin - 0.001, yMax + 0.001 }, Color.Red, SymbolType.None);
                    mediaLine.Line.Width = 3.0f;
                    lscLine.Line.Width = 3.0f;
                    licLine.Line.Width = 3.0f;
                    mediaLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
                    lscLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
                    licLine.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

                    // Adicionar uma curva ao gráfico com a lista de pontos
                    LineItem curve = graphPane.AddCurve("Curva", pointPairList, System.Drawing.Color.Blue, SymbolType.None);
                    curve.Line.Width = 2.0f;
                    curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;

                    graphPane.XAxis.MajorGrid.IsVisible = true;
                    graphPane.YAxis.MajorGrid.IsVisible = true;
                    if (xMax > lsc || xMin < lic)
                    {
                        double diffMax, diffMin;
                        diffMax = xMax - lsc;
                        diffMin = lic - xMin;
                        graphPane.XAxis.Scale.Min = (lic - Math.Max(diffMax, diffMin)) - 0.01;
                        graphPane.XAxis.Scale.Max = (lsc + Math.Max(diffMax, diffMin)) + 0.01;
                    }
                    else
                    {
                        graphPane.XAxis.Scale.Min = lic - 0.01;
                        graphPane.XAxis.Scale.Max = lsc + 0.01;
                    }
                    graphPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
                    graphPane.YAxis.Scale.Min = yMin - 0.01;
                    graphPane.YAxis.Scale.Max = yMax + 0.01;
                    // Calcular o intervalo entre os rótulos na escala do eixo X
                    double yDataRange = yMax - yMin; // Substitua xMax e xMin pelos valores reais
                    double yMajorStep = yDataRange / 10; // Dividir o intervalo em 10 partes (ajuste conforme necessário)

                    double xDataRange = xMax - xMin;
                    double xMajorStep = 1;

                    while (xMajorStep * 10 < xDataRange)
                    {
                        xMajorStep *= 10;
                    }

                    graphPane.YAxis.Scale.MajorStep = yMajorStep;
                    graphPane.XAxis.Scale.MajorStep = xMajorStep;


                    // Atualizar o gráfico
                    zedGraph.AxisChange();
                    zedGraph.Invalidate();
                }

            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }


        }
        private void PegaJson()
        {
            try
            {
                string[] columns = { "data", "type_count_id"};
                string where = $"id='{id}'";
                List<string>[] result = conexao.SelectData("table_master", columns, where);

                if (result[0].Count > 0)
                {
                    type = result[1][0].ToString();
                    jsonString = result[0][0].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double[,] Variaveis(List<Dictionary<string, string>> jsonDataList)
        {
            if (jsonDataList == null || jsonDataList.Count == 0)
            {
                // Trate o caso em que não há dados
                return null;
            }
            var atributoDiferente = EncontrarAtributoDiferente(jsonDataList[0]);
            if (atributoDiferente == null)
            {
                return null;
            }
            int x = 0;
            int y = 0; 
            foreach (var jsonData in jsonDataList)
            {
                y = 0;
                foreach (var sample in jsonData)
                {
                    if (sample.Key != atributoDiferente)
                    {
                        y++;
                    }
                }
                if (y > 0)
                {
                    x++;
                }
            }
            double[,] arr = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                int j = 0;
                foreach (var sample in jsonDataList[i])
                {
                    if (sample.Key != atributoDiferente)
                    {
                        arr[i, j] = Double.Parse(sample.Value);
                        j++;
                    }
                }
            }
            string EncontrarAtributoDiferente(Dictionary<string, string> sample)
            {
                foreach (var kvp in sample)
                {
                    if (!Double.TryParse(kvp.Value, out double result))
                    {
                        return kvp.Key;
                    }
                }

                return null;
            }
            return arr;
        }
        private double[] Dist(List<Dictionary<string, string>> jsonDataList)
        {
            if (jsonDataList == null || jsonDataList.Count == 0)
            {
                // Trate o caso em que não há dados
                return null;
            }

            var atributoDiferente = EncontrarAtributoDiferente(jsonDataList[0]);
            if (atributoDiferente == null)
            {
                return null;
            }

            int y = 0;

            // Conta o número de amostras (excluindo o atributo diferente)
            foreach (var jsonData in jsonDataList)
            {
                foreach (var sample in jsonData)
                {
                    if (sample.Key != atributoDiferente)
                    {
                        y++;
                    }
                }
            }

            double[] arr = new double[y];
            int i = 0;

            // Preenche o array com os valores do atributo diferente
            foreach (var jsonData in jsonDataList)
            {
                foreach (var sample in jsonData)
                {
                    if (sample.Key != atributoDiferente)
                    {
                        arr[i] = Double.Parse(sample.Value);
                        i++;
                    }
                }
            }

            string EncontrarAtributoDiferente(Dictionary<string, string> sample)
            {
                foreach (var kvp in sample)
                {
                    if (Double.TryParse(kvp.Value, out double result))
                    {
                        return kvp.Key;
                    }
                }

                return null;
            }

            return arr;
        }
        private double[,] Atributos(List<Dictionary<string, string>> jsonDataList)
        {
            if (jsonDataList == null || jsonDataList.Count == 0)
            {
                return null;
            }
            var atributos = EncontrarAtributos(jsonDataList[0]);
            if (atributos == null || atributos.Count != 2)
            {
                return null;
            }
            int y = jsonDataList.Count;
            double[,] matriz = new double[2, y];

            for (int i = 0; i < y; i++)
            {
                foreach (var kvp in jsonDataList[i])
                {
                    if (kvp.Key == atributos[0])
                    {
                        matriz[0, i] = Double.Parse(kvp.Value);
                    }
                    if(kvp.Key == atributos[1])
                    {
                        matriz[0, i] = Double.Parse(kvp.Value);
                    }
                }
            }

            List<string> EncontrarAtributos(Dictionary<string, string> sample)
            {
                var keys = sample.Keys.ToList();
                int numeroAtributos = keys.Count;

                if (numeroAtributos >= 2)
                {
                    // Descarta o primeiro atributo e retorna os dois últimos
                    keys.RemoveAt(0);
                    return keys.ToList();
                }

                return null;
            }

            return matriz;
        }
    }
}
