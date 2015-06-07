using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using System.Windows.Forms;

namespace DataAccessTier
{
    public class ChiTietHoaDonDAO : DBConnection
    {
        SqlParameter[] parameter;
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt = new DataTable();
        string maPhieuThueKTT = "";
       // DateTime d;
        public ChiTietHoaDonDAO() : base() { }

        public bool ThemChiTietHoaDon(ChiTietHoaDonDTO cthd)
        {
            try
            {
                //d = Convert.ToDateTime(cthd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[6];
                parameter[0] = new SqlParameter("@MaHoaDon", cthd.MaHoaDon);
                parameter[1] = new SqlParameter("@MaPhieuThue",cthd.MaPhieuThue);
                parameter[2] = new SqlParameter("@SoNgayThue",cthd.SoNgayThue);
                parameter[3] = new SqlParameter("@DonGia",cthd.DonGia);
                parameter[4] = new SqlParameter("@ThanhTien",cthd.ThanhTien);
                parameter[5] = new SqlParameter("@return", SqlDbType.Int);
                parameter[5].Direction = ParameterDirection.ReturnValue;

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "THEMCHITIETHOADON";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                if ((int)parameter[5].Value == -1)
                    return false;
                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }

        }

        public bool XoaChiTietHoaDon(string maHoaDon, string maPhieuThue)
        {
            try
            {
                //d = Convert.ToDateTime(cthd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[2];
                parameter[0] = new SqlParameter(@"MaHoaDon", maHoaDon);
                parameter[1] = new SqlParameter(@"MaPhieuThue", maPhieuThue);
                
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "XOACHITIETHOADON";
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

        public bool CapNhatChiTietHoaDon(string maHoaDonOld,string maPhieuThueOld,ChiTietHoaDonDTO cthd)
        {
            try
            {
                //d = Convert.ToDateTime(cthd.NgayThanhToan);
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                parameter = new SqlParameter[7];
                parameter[1] = new SqlParameter(@"MaHoaDon", cthd.MaHoaDon);
                parameter[0] = new SqlParameter(@"MaPhieuThue", cthd.MaPhieuThue);
                parameter[2] = new SqlParameter(@"SoNgayThue", cthd.SoNgayThue);
                parameter[3] = new SqlParameter(@"DonGia", cthd.DonGia);
                parameter[4] = new SqlParameter(@"ThanhTien", cthd.ThanhTien);
                parameter[5] = new SqlParameter(@"MaHoaDonOLD", maHoaDonOld);
                parameter[6] = new SqlParameter(@"MaPhieuThueOLD", maPhieuThueOld);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "THEMCHITIETHOADON";
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

        public int SoNgayThue(string maHoaDon)
        {
            int result = -1;
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SONGAYTHUE";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[2];
                parameter[0] = new SqlParameter("@MaHoaDon", maHoaDon);
                parameter[1] = new SqlParameter("@SoNgayThue",SqlDbType.Int);
                parameter[1].Direction = ParameterDirection.Output;

                command.Parameters.AddRange(parameter);
                //SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //    result = (int)reader[0];
                command.ExecuteNonQuery();
                result = (int)parameter[1].Value;
                connection.Close();
                
                return result;
            }
            catch
            {
                connection.Close();
                return result;
            }
        }

        public float DonGia(string maHoaDon,string maPhieuThue )
        {
            float result = -1;
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DONGIA";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[3];
                parameter[0] = new SqlParameter("@MaHoaDon", maHoaDon);
                parameter[1] = new SqlParameter("@MaPhieuThue", maPhieuThue);
                parameter[2] = new SqlParameter("@DonGia",SqlDbType.Float);
                parameter[2].Direction = ParameterDirection.Output;


                command.Parameters.AddRange(parameter);
                
                command.ExecuteNonQuery();
                result = float.Parse(parameter[2].Value.ToString());
                connection.Close();
               // command.Dispose();
                return result;
            }
            catch
            {
               // throw;
                connection.Close();
                return result;
            }
        }

         public string MaPhieuThueKhongTonTaiCTHD(string maPhong, DateTime ngayThanhToan)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "MaPhieuThueKhongTonTaiCTHD";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[4];
                parameter[0] = new SqlParameter("@MaPhong",maPhong);
                parameter[1] = new SqlParameter("@NgayThanhToan", ngayThanhToan);
                parameter[2] = new SqlParameter("@MaPhieuThue", SqlDbType.VarChar,10);
                parameter[2].Direction = ParameterDirection.Output;
                parameter[3] = new SqlParameter("@result", SqlDbType.Int);
                parameter[3].Direction = ParameterDirection.ReturnValue;

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();

                connection.Close();
                if ((int)parameter[3].Value == 1)
                    return parameter[2].Value.ToString();
                else
                    return "";
            }
            catch
            {
                throw;
                connection.Close();
                return "";
            }
        }

        public DataTable LayThongTinCTHDVaPTP (string maHoaDon)
         {
            try
            {
            if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "LayThongTinCTHDVaPTP";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@MaHoaDon", maHoaDon);

                command.Parameters.AddRange(parameter);
                adapter = new SqlDataAdapter(command);
                dt.Clear();
               // apdater.SelectCommand = command;
                adapter.Fill(dt);

                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
               //throw;
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
         }

        public bool XoaTatCaChiTietHoaDon(string maHoaDon)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "XOATATCACHITIETHOADON";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@MaHoaDon", maHoaDon);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public bool CapNhatTinhTrangPhong(string maPhong, bool tinhTrangPhong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "CapNhatTinhTrangPhong";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[2];
                parameter[0] = new SqlParameter("@MaPhong", maPhong);
                parameter[1] = new SqlParameter("@TinhTrangPhong", tinhTrangPhong);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }
    }
}
