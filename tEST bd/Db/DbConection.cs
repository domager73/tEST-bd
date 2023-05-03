using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tEST_bd.Db
{
    internal class DbConnection
    {
        public NpgsqlConnection Connection { private set; get; }

        public DbConnection(string host, string username, string password, string databasename)
        {
            string _connectionString =
                $"Host={host};Username={username};Password={password};Database={databasename}";

            Connection = new NpgsqlConnection(_connectionString);
            Connection.Open();
        }
    }
}
