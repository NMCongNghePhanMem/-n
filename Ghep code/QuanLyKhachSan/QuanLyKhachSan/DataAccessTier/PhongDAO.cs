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
    public class PhongDAO: DBConnection
    {

        public PhongDAO(): base()
        {
        }

        public bool SetTinhTrangPhongSauThue(string _idPhong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SuaTinhTrangPhongKhiThemPhieuThue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = _idPhong;
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

        public DataTable LayTatCaPhong()
        {
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LietKePhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

                SqlDataAdapter adap = new SqlDataAdapter(command);
                DataTable dtTable = new DataTable();
                adap.Fill(dtTable);
                connection.Close();
                return dtTable;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }

        public bool ThemPhong(PhongDTO _phong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("NhonThemPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaPhong", _phong.ID_Phong);
                command.Parameters.AddWithValue("@MaLoaiPhong", _phong.ID_LoaiPhong);
                command.Parameters.AddWithValue("@TinhTrang", _phong.TinhTrangPhong);
                command.Parameters.AddWithValue("@GhiChu", _phong.GhiChu);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection.Close();
                Console.WriteLine(ex);
            }
            return false;
        }

        public bool XoaPhong(string _idPhong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("XoaPhong", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaPhong", _idPhong);
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

        public bool SuaPhongTrongDanhMuc(string _idPhong, PhongDTO _phong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("SuaPhongTrongDanhMuc", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaPhong", SqlDbType.VarChar).Value = _idPhong;
                command.Parameters.Add("@MaPhongThem", SqlDbType.VarChar).Value = _phong.ID_Phong;
                command.Parameters.Add("@MaLoaiPhongThem", SqlDbType.VarChar).Value = _phong.ID_LoaiPhong;
                command.Parameters.Add("@TinhTrangThem", SqlDbType.VarChar).Value = _phong.TinhTrangPhong;
                command.Parameters.Add("@GhiChuThem", SqlDbType.NVarChar).Value = _phong.GhiChu;
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
		
		public PhongDTO GetPhongByMaPhong(string pMaPhong)
        {
            PhongDTO phong = null;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetPhongByMaPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@MaPhong", System.Data.SqlDbType.NVarChar,10).Value = pMaPhong;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    phong = new PhongDTO();
                    phong.ID_Phong = rd["MaPhong"].ToString();
                    phong.ID_LoaiPhong = rd["MaLoaiPhong"].ToString();
                    phong.TinhTrangPhong = bool.Parse(rd["TinhTrangPhong"].ToString());
                    phong.GhiChu = rd["GhiChu"].ToString();
                }
            }
            catch (Exception)
            {
                connection.Close();
            }
            connection.Close();
            return phong;
        }

        public DataTable GetDanhMucPhong()
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetDanhMucPhong",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception)
            {
                connection.Close();
            }
            connection.Close();
            return dt;
        }

        public DataTable TraCuuPhong(string pPhong,string pLoaiPhong, bool? pTinhTrang,int pGiaMax,int pGiaMin,string pGhiChu = null)//
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("TraCuuPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PHONG", SqlDbType.NVarChar, 10).Value = pPhong;
                //cmd.Parameters.Add(new SqlParameter("@PHONG", SqlDbType.NVarChar, 10, pPhong));
                
                if (pTinhTrang == null)
                    cmd.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value = DBNull.Value;
                else
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.Bit).Value=  pTinhTrang;
                
                cmd.Parameters.Add("@LOAIPHONG", SqlDbType.NVarChar, 10).Value= pLoaiPhong;
                cmd.Parameters.Add("@MINGIA", SqlDbType.Money).Value=pGiaMin;
                cmd.Parameters.Add("@MAXGIA", SqlDbType.Money).Value=pGiaMax;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception)
            {
                connection.Close();
            }
            connection.Close();
            return dt;
        }

        
    }
}
