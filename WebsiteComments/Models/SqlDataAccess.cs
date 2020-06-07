using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Extensions.Configuration;

namespace WebsiteComments.Models
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public string ConnectionStringName { get; set; } = "Default";
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public void LoadData()
        {
            string connectionString = _config.GetConnectionString(ConnectionStringName);
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
        }
        public void SaveData()
        {

        }
    }
}
