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
    public class PhanQuyenDAO: DBConnection
    {
        public PhanQuyenDAO()
        { 
        }

        public DataTable KiemTraMatKhau(PhanQuyenDTO _phanQuyen)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("KiemTraMatKhau", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = _phanQuyen.UserName;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = _phanQuyen.Password;
                command.ExecuteNonQuery();
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
    }
}
