using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                mediana = (arrExcel[posicao] + arrExcel[posicao + 1]) / 2;
            }
            else
            {
                posicao = N + 1 / 2;
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
    }
}
