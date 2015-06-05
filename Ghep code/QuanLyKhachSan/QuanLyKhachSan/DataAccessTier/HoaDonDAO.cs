using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class HoaDonDAO : DBConnection
    {
        SqlParameter[] parameter;
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt = new DataTable();
        DateTime d;
        string maHoaDonGanNhat = "";
        public HoaDonDAO() : base() { }

        public bool ThemHoaDon(HoaDonDTO hd)
        {
            try
            {
                d = Convert.ToDateTime(hd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[5];
                parameter[0] = new SqlParameter(@"MaHoaDon", hd.MaHoaDon);
                parameter[1] = new SqlParameter(@"NgayThanhToan", d);
                parameter[2] = new SqlParameter(@"TenKhachHang", hd.TenKhachHang);
                parameter[3] = new SqlParameter(@"DiaChi", hd.DiaChi);
                parameter[4] = new SqlParameter(@"TongChiTietThanhToan", hd.TongChiTietThanhToan);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "THEMHOADON";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
           
        }

        public bool XoaHoaDon(string maHoaDon)
        {
            try
            {
                //d = Convert.ToDateTime(hd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter(@"MaHoaDon", maHoaDon);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "XOAHOADON";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                return true;

            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public bool CapNhatHoaDon(HoaDonDTO hd)
        {
            try
            {
                d = Convert.ToDateTime(hd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[5];
                parameter[0] = new SqlParameter(@"MaHoaDon", hd.MaHoaDon);
                parameter[1] = new SqlParameter(@"NgayThanhToan", d);
                parameter[2] = new SqlParameter(@"TenKhachHang", hd.TenKhachHang);
                parameter[3] = new SqlParameter(@"DiaChi", hd.DiaChi);
                parameter[4] = new SqlParameter(@"TongChiTietThanhToan", hd.TongChiTietThanhToan);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CAPNHATHOADON";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                return true;

            }
            catch
            {
                connection.Close();
                return false;
            }
        }

        public DateTime NgayThanhToan(string maHoaDon)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter(@"MaHoaDon", maHoaDon);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "NGAYTHANHTOAAN";
                command.CommandType = CommandType.StoredProcedure;
                //command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    d = Convert.ToDateTime(reader[0]);
                }
                reader.Close();
                connection.Close();
                return d;


            }
            catch
            {
                connection.Close();
                return Convert.ToDateTime("0/0/0");
            }
        }

        public string MaHoaDonGanNhat()
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = connection.CreateCommand();
                command.CommandText = string.Format("select  top 1 MaHoaDon from HOADON ORDER By MaHoaDon DESC");
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    maHoaDonGanNhat = (string)reader[0];
                }
                connection.Close();
                return maHoaDonGanNhat;
            }
            catch
            {
                connection.Close();
                return maHoaDonGanNhat;
            }
        }

        public DataTable LayHoaDonNgayHienTai()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                //dt = new DataTable();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "LAYHOADONNGAYHIENTAI";
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch
            {
                connection.Close();
                return dt;
            }

        }

       
    }
}