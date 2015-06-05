using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccessTier
{
    public class ThamSoDAO: DBConnection
    {
        public ThamSoDAO()
        { 
        }

        public DataTable LayThamSo()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("DuLieuThamSo", connection);
                command.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }

        //chưa làm procedure
        public bool ThemThamSoMoi(ThamSoDTO _thamSo)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }


            }
            catch (Exception)
            {
                
                throw;
            }
            return false;
        }

    }
}
