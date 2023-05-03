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
            int lenght = N / 2, i,j;
            double[] arrQ1 = new double[lenght];
            double[] arrQ3 = new double[lenght];                
            if (N % 2 == 0)
            {
                for (i = 0; i < lenght; i++)
                    arrQ1[i] = arrExcel[i];
                j = 0;
                for (i = lenght; i < lenght*2; i++)
                {
                    arrQ3[j] = arrExcel[i];
                    j++;
                }
                arrQuartis[0] = CalcularMediana(arrQ1, arrQ1.Length);
                arrQuartis[2] = CalcularMediana(arrQ3, arrQ3.Length);
            }
            else
            {
                for (i = 0; i < lenght; i++)
                    arrQ1[i] = arrExcel[i];
                j = 0;
                for (i = lenght+1; i <= lenght * 2; i++)
                {
                    arrQ3[j] = arrExcel[i];
                    j++;
                }
                arrQuartis[0] = CalcularMediana(arrQ1, arrQ1.Length);
                arrQuartis[2] = CalcularMediana(arrQ3, arrQ3.Length);
            }



            arrQuartis[1] = CalcularMediana(arrExcel, N);
            

            return arrQuartis;
        }

        static public double[] CalcularPercentis(double[] arrExcel)
        {
            double[] arrPercentil = new double[100];

            Array.Sort(arrExcel);

            int percentil = 1;
            for (int i = 0; i < 100; i++)
            {
                double posicao = (percentil / 100.0) * arrExcel.Length;

                if (posicao % 1 == 0)
                {
                    int indice = (int)posicao - 1;
                    arrPercentil[i] = arrExcel[indice];
                }
                else
                {
                    int indiceInferior = (int)Math.Floor(posicao) - 1;
                    int indiceSuperior = (int)Math.Ceiling(posicao) - 1;
                    if(indiceSuperior == arrExcel.Length)
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

    }
}
