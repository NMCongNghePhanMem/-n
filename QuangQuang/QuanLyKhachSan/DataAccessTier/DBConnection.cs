using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class DBConnection
    {
        protected SqlConnection connection;
        public DBConnection()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=WIN-KL7CA5972TF\SQLEXPRESS;
                                            Initial Catalog=QUANLYKHACHSAN; Integrated Security= true";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
