using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Test.Models;
using Test.Reository;
using System.Data;

namespace Test.Repository
{
    public class TestTableRepository : ITestTable
    {
        public DataTable AllTests()
        {
            NpgsqlConnection connection = Database.GetConnection();
            string query = @"select * from testtable;";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            connection.Open();
            NpgsqlDataReader Reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(Reader);
            /*return dataTable.AsEnumerable().Select(row => new TestTable
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString()
            });*/
            return dataTable;
        }
    }
}
