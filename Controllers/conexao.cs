using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace caeliweb.Controllers
{
    public class conexao : Controller
    {
        private string connectionString;

        public conexao()
        {
            // Aqui está sua cadeia de conexão
            connectionString = "Server=bdcaeli.c9u6m4e8slft.us-east-2.rds.amazonaws.com;Port=3306;Database=CaeliSoftwares;Uid=admin;Pwd=Filsck01;";
        }

        public void ConnectToDatabase()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                    // Aqui você pode executar consultas ou outras operações no banco de dados
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
