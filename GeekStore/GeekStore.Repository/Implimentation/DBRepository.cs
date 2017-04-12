using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using GeekStore.Domain.Components;

namespace GeekStore.Repository.Implimentation
{
    public class DBRepository
    {
        private static string _connectionString = null;
        static DBRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["GeekStoreConnectionString"].ConnectionString;
        }

        public IEnumerable<GPU> GetGPUS()
        {
            List<GPU> gpus = null;
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                var sqlCommandText = "SELECT * FROM GPU";
                using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while(reader.Read())
                    {
                        gpus.Add(new GPU(reader["Architecture"].ToString(), int.Parse(reader["InterfaceWidth"].ToString()), reader["Manufacturer"].ToString(),
                                 reader["MemoryInterface"].ToString(), reader["Model"].ToString(), int.Parse(reader["VRAM"].ToString())));
                    }
                }
            }
            return gpus;
        }
    }
}
