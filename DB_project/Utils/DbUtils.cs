using System;
using System.Text;
using MySql.Data.MySqlClient;

namespace DB_project.Utils
{
    public static class DbUtils
    {
        private static MySqlConnection _conn;

        private static readonly string ConnStr =
            $"server={Configurator.Config["server"]};user={GetEnvironmentVariable()};database={Configurator.Config["database"]};" +
            $"password={Configurator.Config["password"]};";

        public static string GetEnvironmentVariable()
        {
            var userNameValue = Environment.GetEnvironmentVariable("userNameValue");
            
            if (userNameValue == null)
            {
                userNameValue = Configurator.Config["user"];
            }

            return userNameValue;
        }

        public static string ExecuteQuery(string query)
        {
            var builder = new StringBuilder();
            _conn = new MySqlConnection(ConnStr);
            _conn.Open();

            var command = new MySqlCommand(query, _conn);

            using (var read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    var fieldCount = read.FieldCount;

                    string text = "";
                    for (int i = 0; i < fieldCount; i++)
                    {
                        text += ($"{read[i]}" + "'\t'");
                    }

                    builder.Append($"{text}\n");
                }
            }

            _conn.Close();
            return builder.ToString();
        }
    }
}