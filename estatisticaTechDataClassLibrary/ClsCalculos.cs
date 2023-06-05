using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static double CalculateCpk(double mean, double standardDeviation, double upperSpecLimit, double lowerSpecLimit)
        {
            double cpk = 0.0;

            // Calcular a diferença entre a média do processo e os limites de especificação
            double diffUpper = upperSpecLimit - mean;
            double diffLower = mean - lowerSpecLimit;

            // Calcular o Cpk utilizando a fórmula
            cpk = Math.Min(diffUpper / (3 * standardDeviation), diffLower / (3 * standardDeviation));

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
                posicao = N / 2;
                mediana = (arrExcel[posicao] + arrExcel[posicao - 1]) / 2;
            }
            else
            {
                posicao = N/2;
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
            Array.Sort(arrExcel);
            double[] arrQuartis = new double[3];
            int lenght = N / 2, i, j;
            double[] arrQ1 = new double[lenght];
            double[] arrQ3 = new double[lenght];
            double[] arrQ2 = new double[N % 2 == 0 ? 2 : 1];

            if (N % 2 == 0)
            {
                for (i = 0; i < lenght; i++)
                    arrQ1[i] = arrExcel[i];
                j = 0;
                for (i = lenght; i < lenght * 2; i++)
                {
                    arrQ3[j] = arrExcel[i];
                    j++;
                }
                arrQuartis[0] = CalcularMediana(arrQ1, arrQ1.Length);
                arrQuartis[2] = CalcularMediana(arrQ3, arrQ3.Length);
                arrQ2[0] = arrExcel[lenght - 1];
                arrQ2[1] = arrExcel[lenght];
            }
            else
            {
                for (i = 0; i < lenght; i++)
                    arrQ1[i] = arrExcel[i];
                j = 0;
                for (i = lenght + 2; i <= lenght * 2; i++)
                {
                    arrQ3[j] = arrExcel[i];
                    j++;
                }
                arrQuartis[0] = CalcularMediana(arrQ1, arrQ1.Length);
                arrQuartis[2] = CalcularMediana(arrQ3, arrQ3.Length);
                arrQ2[0] = arrExcel[lenght];
            }

            arrQuartis[1] = CalcularMediana(arrQ2, arrQ2.Length);

            return arrQuartis;
        }

        public static double[] CalcularPercentis(double[] arrExcel)
        {
            double[] arrPercentil = new double[100];

            Array.Sort(arrExcel);

            int percentil = 1;
            for (int i = 0; i < 100; i++)
            {
                double posicao = ((percentil - 0.5) / 100.0) * (arrExcel.Length + 1);

                if (posicao % 1 == 0)
                {
                    int indice = (int)posicao - 1;
                    arrPercentil[i] = arrExcel[indice];
                }
                else
                {
                    int indiceInferior = (int)Math.Floor(posicao) - 1;
                    int indiceSuperior = (int)Math.Ceiling(posicao) - 1;
                    if (indiceSuperior == arrExcel.Length)
                        indiceSuperior--;
                    if (indiceInferior < 0)
                        indiceInferior = 0;
                    double valorInferior = arrExcel[indiceInferior];
                    double valorSuperior = arrExcel[indiceSuperior];
                    arrPercentil[i] = ((posicao - 1) % 1) * (valorSuperior - valorInferior) + valorInferior;
                }
                percentil++;
            }

            return arrPercentil;
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

            double[] modas = CalcularModa(arrExcel);

            double moda = CalcularMedia(modas,modas.Length);

            double coeficienteAssimetria = (media - moda) / desvioPadrao;

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
