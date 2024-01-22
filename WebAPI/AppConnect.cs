using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebAPI
{
    
    public class AppConnect 
    {
        private const string Password = "1234567890";
        private const string DataBaseName = "diplom";
        private const int Port = 3306;
        private const string Server = "localhost";
        private const string UserName = "root";       
           
       private string connectionString = $"Server={Server};;database={DataBaseName};Port={Port};User id={UserName};Password={Password}";

        private readonly MySqlConnection connection;

        public AppConnect()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection Connection => connection;

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return;
            }
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                return;
            }
            connection.Close();
        }
        
    }
}
