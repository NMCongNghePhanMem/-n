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
    public class LoaiKhachHangDAO: DBConnection
    {
        public LoaiKhachHangDAO()
        {
        }

        public DataTable LayThongTinLoaiKhachHang()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LietKeThongTinLoaiKhachHang", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                DataTable result = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(result);
                connection.Close();
                return result;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
		
		public LoaiKhachHangDTO getLoaiKhachByID(string pLoaiKhach)
        {
            LoaiKhachHangDTO loaiKhach = new LoaiKhachHangDTO();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLoaiKhachById";
                cmd.Parameters.Add("@ID",SqlDbType.VarChar,10).Value=pLoaiKhach;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    loaiKhach.ID_LoaiKhachHang = reader["MaLoaiKhachHang"].ToString();
                    loaiKhach.TenLoaiKhachHang = reader["TenLoaiKhachHang"].ToString();
                }
            }
            catch (Exception)
            {
                connection.Close();
            }
            return loaiKhach;
        }
        public DataTable getDanhMucLoaiKhach()
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDanhMucLoaiKhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(dt);
            }catch(Exception)
            {
                connection.Close();
            }
            return dt;
        }
		
    }
}
