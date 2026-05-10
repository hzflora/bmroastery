using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafeSistemi
{
    public class DatabaseHelper
    {
        private string connectionString = "server=localhost;database=bmRoastery;user=root;password=atakan123!;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
