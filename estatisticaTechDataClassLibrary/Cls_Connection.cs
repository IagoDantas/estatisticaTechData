using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace estatisticaTechDataClassLibrary
{
    public class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Connection()
        {
            server = "localhost"; //Endereço do servidor do MySQL
            database = "techdata"; //Nome do banco de dados
            uid = "root"; //Nome de usuário
            password = ""; //Senha

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Não foi possível conectar-se ao servidor.");
                        break;
                    case 1045:
                        Console.WriteLine("Usuário/senha inválido(s).");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool InsertData(string table, Dictionary<string, string> data)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    string columns = string.Join(",", data.Keys);
                    string values = string.Join(",", data.Values.Select(v => $"'{v}'"));

                    string query = $"INSERT INTO {table} ({columns}) VALUES ({values})";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateData(string table, Dictionary<string, string> data, string where)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    string columns = string.Join(",", data.Keys);
                    string values = string.Join(",", data.Values.Select(v => $"'{v}'"));

                    string query = $"UPDATE {table} SET {columns} = {values} WHERE {where}";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeleteData(string table, string where)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    string query = $"DELETE FROM {table} WHERE {where}";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<string>[] SelectData(string table, string[] columns, string where)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    string query = $"SELECT {string.Join(",", columns)} FROM {table} WHERE {where}";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    List<string>[] list = new List<string>[columns.Length];

                    for (int i = 0; i < columns.Length; i++)
                    {
                        list[i] = new List<string>();
                    }

                    while (dataReader.Read())
                    {
                        for (int i = 0; i < columns.Length; i++)
                        {
                            list[i].Add(dataReader[columns[i]] + "");
                        }
                    }

                    dataReader.Close();

                    this.CloseConnection();

                    return list;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
