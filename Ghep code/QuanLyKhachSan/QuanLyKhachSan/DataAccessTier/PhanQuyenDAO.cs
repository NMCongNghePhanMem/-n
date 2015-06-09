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

        public bool ThemQuyenTruyCap(PhanQuyenDTO _phanQuyen)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("ThemQuyenTruyCap", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = _phanQuyen.UserName;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = _phanQuyen.Password;
                command.Parameters.Add("@role", SqlDbType.NVarChar).Value = _phanQuyen.Role;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return false;
        }

        public DataTable KiemTraUserName(string _userName)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("KiemTraUserName", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@userName", SqlDbType.VarChar).Value = _userName;
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

        public DataTable DoiMatKhau(PhanQuyenDTO _phanquyen)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("DoiMatKhau", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = _phanquyen.UserName;
                command.Parameters.Add("@newpassword", SqlDbType.VarChar).Value = _phanquyen.Password;
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

        public DataTable LayUsername()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LayUsername", connection);
                command.CommandType = CommandType.StoredProcedure;
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

        public bool XoaPhanQuyen(string _userName)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("XoaPhanQuyen", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = _userName;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return false;
        }

    }
}
