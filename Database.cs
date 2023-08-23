using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace Test
{
    public class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConfigurationManager.ConnectionStrings["plsql"].ConnectionString);
        }
    }
}
