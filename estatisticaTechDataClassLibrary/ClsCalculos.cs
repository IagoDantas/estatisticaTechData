﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace estatisticaTechDataClassLibrary
{
    public class ClsCalculos
    {
        public static double[] CalcularMediasInicias(double[,] matriz, int sizeX, int sizeY)
        {
            double[] medias = new double[sizeY];
            for (int j = 0; j < sizeY; j++)
            {
                double sum = 0;
                for (int i = 0; i < sizeX; i++)
                {
                    sum += matriz[i, j];
                }
                medias[j] = sum / sizeX;
            }

            return medias;
        }

        public static double[] CalcularAmplitudes(double[,] matriz, int sizeX, int sizeY)
        {
            double[] amplitudes = new double[sizeY];
            for (int j = 0; j < sizeY; j++)
            {
                double maior = 0, menor = double.MaxValue;
                for (int i = 0; i < sizeX; i++)
                {
                    if (matriz[i, j] > maior)
                        maior = matriz[i, j];
                    if (matriz[i, j] < menor)
                        menor = matriz[i, j];
                }
                amplitudes[j] = maior - menor;
            }

            return amplitudes;
        }
        public static double CalculateCp(double desvio, double upperSpecLimit, double lowerSpecLimit)
        {
            double cp = 0.0;

            cp = (upperSpecLimit-lowerSpecLimit) / (6 * desvio);

            return cp;
        }
        public static double CalculateCpk(double media, double desvio, double upperSpecLimit, double lowerSpecLimit)
        {
            double cpk = 0.0;

            double diffUpper = upperSpecLimit - media;
            double diffLower = media - lowerSpecLimit;

            double up = diffUpper / (3 * desvio);
            double low = diffLower / (3 * desvio);

            if(up <= low)
            {
                cpk = up;
            }
            else
            {
                cpk = low;
            }

            return cpk;
        }
        public static double CalcularMedia(double[] arrExcel, int divisor)
        {
            double mediaResult = 0;
            for (int i = 0; i < divisor; i++)
            {
                mediaResult += arrExcel[i];
            }
            mediaResult = mediaResult / divisor;
            return mediaResult;
        }

        public static double CalcularMediana(double[] arrExcel, int N)
        {
            double mediana = 0;
            Array.Sort(arrExcel);
            int posicao;

            if (N % 2 == 0)
            {
                posicao = (N - 1) / 2;
                mediana = (arrExcel[posicao] + arrExcel[posicao + 1]) / 2.0;
            }
            else
            {
                posicao = N / 2;
                mediana = arrExcel[posicao];
            }

            return mediana;
        }




        static public double[] CalcularModa(double[] listaValores)
        {

            double[] listaValoresOrdenada = listaValores.ToArray();
            Array.Sort(listaValoresOrdenada);

            double valorAtual = listaValoresOrdenada[0];
            int contadorValorAtual = 0;

            int[] listaNumRepeticoes = new int[listaValoresOrdenada.Length];
            listaNumRepeticoes[0] = contadorValorAtual;

            for (int i = 1; i <= listaValoresOrdenada.Length - 1; i++)
            {
                if (listaValoresOrdenada[i] != valorAtual)
                {
                    valorAtual = listaValoresOrdenada[i];
                    contadorValorAtual = 0;
                }
                else
                {
                    contadorValorAtual++;
                }
                listaNumRepeticoes[i] = contadorValorAtual;
            }

            int maiorRepeticao = listaNumRepeticoes.Max();

            if (maiorRepeticao > 0)
            {
                int contadorNumRepeticaoMaior = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                        contadorNumRepeticaoMaior++;
                }
                double[] listaRetorno = new double[contadorNumRepeticaoMaior];
                int contadorRetorno = 0;
                for (int i = 0; i < listaNumRepeticoes.Length; i++)
                {
                    if (listaNumRepeticoes[i] == maiorRepeticao)
                    {
                        listaRetorno[contadorRetorno] = listaValoresOrdenada[i];
                        contadorRetorno++;
                    }
                }

                return listaRetorno;
            }
            else
            {
                return new double[0];
            }
        }

        static public double[] CalcularQuartis(double[] arrExcel, int N)
        {
            double[] arrQuartis = new double[3];
            Array.Sort(arrExcel);

            int meio = N / 2;

            arrQuartis[0] = CalcQuartil(arrExcel, 1);
            arrQuartis[1] = CalcQuartil(arrExcel, 2);
            arrQuartis[2] = CalcQuartil(arrExcel, 3);

            return arrQuartis;
        }

        public static double CalcQuartil(double[] arr, int N)
        {
            double quartil ;
            double pos = (N / 4.0) * ((double)arr.Length + 1.0);
            double pontoInferior = arr[(int)Math.Floor(pos) - 1];
            double pontoSuperior = arr[(int)Math.Ceiling(pos) - 1];
            double d = pos - Math.Truncate(pos);
            quartil = pontoInferior + (d * (pontoSuperior - pontoInferior));
            return quartil;
        }


        public static double[] CalcularPercentis(double[] arrExcel)
        {
            double[] arrPercentil = new double[100];

            Array.Sort(arrExcel);

            for(int i = 0; i < 100; i++)
            {
                arrPercentil[i] = CalcPercentil(arrExcel, i + 1);
            }

            return arrPercentil;
        }

        public static double CalcPercentil(double[] arr, int N)
        {
            double percentil;
            double pos = (N * ((double)arr.Length + 1.0)) / 100.0;
            double pontoInferior;
            if (pos > 1)
            {
                if(N == 100)
                {
                    pontoInferior = arr[(int)Math.Floor(pos) - ((int)Math.Floor(pos) - (arr.Length - 1))];
                }
                else
                {
                    pontoInferior = arr[(int)Math.Floor(pos) - 1];
                }
            }
            else
            {
                pontoInferior = arr[(int)Math.Floor(pos)];

            }
            double pontoSuperior;
            if (pos < arr.Length)
            {
                pontoSuperior = arr[(int)Math.Ceiling(pos) - 1];
            }
            else
            {
                pontoSuperior = arr[arr.Length - 1];
            }
            double d = pos - Math.Truncate(pos);
            percentil = pontoInferior + (d * (pontoSuperior - pontoInferior));
            return percentil;
        }


        public static double CalcularDesvioPadrao(double[] arrExcel)
        {
            double media = CalcularMedia(arrExcel, arrExcel.Length);
            double somatoria = 0;

            //Faz a somatória dos desvios elevados ao quadrado
            for (int i = 0; i < arrExcel.Length; i++)
            {
                somatoria += Math.Pow(arrExcel[i] - media, 2);
            }

            //Faz o calculo final do desvio Padrão
            double desvioPadrao = Math.Sqrt(somatoria / arrExcel.Length);

            return desvioPadrao;
        }

        public static double CalcularVariancia(double[] arrExcel)
        {
            double media = CalcularMedia(arrExcel, arrExcel.Length);
            double somatoria = 0;

            //Faz a somatória dos desvios elevados ao quadrado
            for (int i = 0; i < arrExcel.Length; i++)
            {
                somatoria += Math.Pow(arrExcel[i] - media, 2);
            }

            //Faz o calculo final da variância
            double variancia = somatoria / (arrExcel.Length);

            return variancia;
        }

        public static double CalcularDispersao(double[] arrExcel)
        {
            double media = CalcularMedia(arrExcel, arrExcel.Length);
            double desvioPadrao = CalcularDesvioPadrao(arrExcel);
            double dispersao = desvioPadrao / media;

            return dispersao;
        }

        public static double CalcularCoeficienteAssimetria(double [] arrExcel)
        {
            double media = CalcularMedia(arrExcel, arrExcel.Length);

            double desvioPadrao = CalcularDesvioPadrao(arrExcel);

            double mediana = CalcularMediana(arrExcel, arrExcel.Length);

            double coeficienteAssimetria = 3 * (media - mediana) / desvioPadrao;

            return coeficienteAssimetria;
        }

        public static double CalcularCoeficientePercentilicoCurtose(double[] arrExcel, int N)
        {
            double[] arrQuartis = CalcularQuartis(arrExcel, N);
            double[] arrPercentil = CalcularPercentis(arrExcel);

            double primeiroQuartil = arrQuartis[0];
            double terceiroQuartil = arrQuartis[2];

            double decimoPercentil = arrPercentil[9];
            double nonagesimoPercentil = arrPercentil[89];

            double numerador = terceiroQuartil - primeiroQuartil;
            double denominador = (nonagesimoPercentil - decimoPercentil) * 2;
            double coeficientePercentilico = (numerador / denominador) ;

            return coeficientePercentilico;
        }
    }
}
