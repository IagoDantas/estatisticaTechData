﻿using estatisticaTechDataClassLibrary;
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
    public partial class UC_DistribuicaoNormal : UserControl
    {
        double cpk,
            lsc = UC_BackgroundDist.funEstancia.media + 3 * UC_BackgroundDist.funEstancia.desvioPadrao,
            lic = UC_BackgroundDist.funEstancia.media - 3 * UC_BackgroundDist.funEstancia.desvioPadrao,
            media = UC_BackgroundDist.funEstancia.media,
            desvioPadrao = UC_BackgroundDist.funEstancia.desvioPadrao,
            iqr = UC_BackgroundDist.funEstancia.IQR;
        double variancia;

        public UC_DistribuicaoNormal()
        {
            variancia = (desvioPadrao / media) * 100;
            InitializeComponent();
            cpk = ClsCalculos.CalculateCpk(UC_BackgroundDist.funEstancia.media, UC_BackgroundDist.funEstancia.desvioPadrao, lsc, lic);
        }
        private void UC_DistribuicaoNormal_Load(object sender, EventArgs e)
        {
            if (UC_BackgroundDist.funEstancia.arrayExcel == null)
            {
                frmHub.funEstancia.apagarAbaSelecionada();
            }
            else
            {
                Grafico();
                lblMedia.Text = media.ToString("f4");
                lblDesvio.Text = desvioPadrao.ToString("f4");
                lblIQR.Text = cpk.ToString("f4");
                if (variancia <= 15) lblAnalise.Text = "Dispersão baixa";
                else if (variancia <= 30) lblAnalise.Text = "Dispersão média";
                else lblAnalise.Text = "Dispersão alta";
                lblVariancia.Text = Math.Pow(desvioPadrao, 2).ToString("f4");
                lblIQR.Text = iqr.ToString("f4");
            }

        }

        private void Grafico()
        {
            try
            {
                GraphPane graphPane = zedDistribuição.GraphPane;
                zedDistribuição.Dock = DockStyle.Fill;
                graphPane.Title.Text = "Distribuição Normal";
                graphPane.XAxis.Title.Text = "Valores da Amostra";
                graphPane.YAxis.Title.Text = "Densidade de Probabilidade";

                if(UC_BackgroundDist.funEstancia.arrayExcel != null)
                {
                    List<double> data = new List<double>();
                    data.AddRange(UC_BackgroundDist.funEstancia.arrayExcel);
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
                    graphPane.XAxis.Scale.Min = xMin - 2;
                    graphPane.XAxis.Scale.Max = xMax + 2;
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
                    zedDistribuição.AxisChange();
                    zedDistribuição.Invalidate();
                }
               
            }
            
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex);
            }


        }

        private void btnVermais_Click(object sender, EventArgs e)
        {
            string nomeDaGuia = "BackgroundDist";
            frmHub.funEstancia.guia(nomeDaGuia);
        }
    }
}
