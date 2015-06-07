using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class DBConnection
    {
        protected SqlConnection connection;
        //public string m_ConnectionString = "Data Source=WIN-KL7CA5972TF\\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        //public string m_ConnectionString = @"Data Source=MINHNHAT\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True";
        public string m_ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        //public string m_ConnectionString = @"Data Source=NHONNGUYEN;Initial Catalog=QLKS;Integrated Security=True";
        public DBConnection()
        {
            try
            {
                connection = new SqlConnection(m_ConnectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
