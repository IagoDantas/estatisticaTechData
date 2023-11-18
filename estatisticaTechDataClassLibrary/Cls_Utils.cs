using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ClosedXML.Excel;
using Newtonsoft.Json;

namespace estatisticaTechDataClassLibrary
{
    public class Cls_Utils
    {
        public static bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static DataTable OpenExcel(Connection conn, int type, string email, string senha)
        {
            int userId, chargeId;
            try 
            { 

                DataTable dtP = new DataTable();
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                        {
                            bool isFirstRow = true;
                            var rows = workbook.Worksheet(1).RowsUsed();
                            foreach (var row in rows)
                            {
                                if (isFirstRow)
                                {
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dtP.Columns.Add(cell.Value.ToString());
                                    }
                                    isFirstRow = false;
                                }
                                else
                                {
                                    dtP.Rows.Add();
                                    int i = 0;
                                    foreach (IXLCell cell in row.Cells())
                                    {
                                        dtP.Rows[dtP.Rows.Count - 1][i++] = cell.Value.ToString();
                                    }
                                }
                            }

                            byte[] excelData;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                workbook.SaveAs(ms);
                                excelData = ms.ToArray();
                            }

                            string json = JsonConvert.SerializeObject(dtP, Newtonsoft.Json.Formatting.Indented);


                            string[] columns2 = { "id" };
                            string where2 = $"email='{email}' AND password='{senha}'";
                            List<string>[] result2 = conn.SelectData("users", columns2, where2);

                            if (result2[0].Count > 0)
                            {
                                userId = int.Parse(result2[0][0].ToString());

                                Dictionary<string, string> dataCharge = new Dictionary<string, string>();
                                dataCharge.Add("date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                dataCharge.Add("file", Convert.ToBase64String(excelData));
                                dataCharge.Add("user_id", userId.ToString());
                                dataCharge.Add("status", "A");
                                dataCharge.Add("data", json);


                                if (conn.InsertData("charge", dataCharge) == true)
                                {

                                    chargeId = conn.GetLastInsertedId();
                                    Dictionary<string, string> dataTableMaster = new Dictionary<string, string>();
                                    dataTableMaster.Add("status", "A");
                                    dataTableMaster.Add("data", json);
                                    dataTableMaster.Add("user_id", userId.ToString());
                                    dataTableMaster.Add("type_count_id", type.ToString());
                                    dataTableMaster.Add("charge_id", chargeId.ToString());

                                    if (conn.InsertData("table_master", dataTableMaster) != true)
                                    {
                                        MessageBox.Show("Falha ao salvar os dados no banco");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao adicionar o arquivo.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Erro ao obter o ID do usuário");
                            }
                            Cursor.Current = Cursors.Default;
                            return dtP;
                        }
                    }
                    else
                    {
                        throw new Exception("fechou");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }


            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }
    }
}
