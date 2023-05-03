using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tEST_bd.Model;

namespace tEST_bd.Db
{
    internal class TableWorkers
    {
        public NpgsqlConnection _connection;

        public TableWorkers(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public List<Workers> SelectAllWorkers() 
        {
            List<Workers> workers = new List<Workers>();

            string sqlRequest = "SELECT * FROM workers ORDER BY id ASC";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                string name = dataReader.GetString(dataReader.GetOrdinal("name"));
                int experience = dataReader.GetInt32(dataReader.GetOrdinal("experience"));

                workers.Add(new Workers()
                {
                    Id = id,
                    Name = name,
                    Experience = experience,
                });
            }

            dataReader.Close();

            return workers;
        }

        public List<Workers> WhereByExpensive(int exp)
        {
            List<Workers> workers = new List<Workers>();

            string sqlRequest = $"SELECT * FROM workers WHERE experience > {exp}";
            NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

            NpgsqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
                string name = dataReader.GetString(dataReader.GetOrdinal("name"));
                int experience = dataReader.GetInt32(dataReader.GetOrdinal("experience"));

                workers.Add(new Workers()
                {
                    Id = id,
                    Name = name,
                    Experience = experience,
                });
            }

            dataReader.Close();

            return workers;
        }
    }
}
