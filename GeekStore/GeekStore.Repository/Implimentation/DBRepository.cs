using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GeekStore.Repository.Implimentation
{
    public class DBRepository
    {
        private static string _connectionString = null;
        static DBRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["GeekStoreConnectionString"].ConnectionString;
        }


    }
}
