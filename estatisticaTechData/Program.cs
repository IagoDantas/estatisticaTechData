using DocumentFormat.OpenXml.Spreadsheet;
using ExemploGraficoControle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estatisticaTechData
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            double[] array = { 3, 5, 3 };
            Application.Run(new frmGraphMedia(array));
        }
    }
}
