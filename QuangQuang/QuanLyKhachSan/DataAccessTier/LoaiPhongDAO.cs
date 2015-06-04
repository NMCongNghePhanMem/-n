using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessTier
{
    public class LoaiPhongDAO:DBConnection
    {
        public LoaiPhongDAO() : base() { }
        public LoaiPhong  getLoaiPhongByMaLoaiPhong(string pID){
            LoaiPhong loaiPhong = null;
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetLoaiPhongByID", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@ID",SqlDbType.VarChar,10).Value = pID;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    loaiPhong = new LoaiPhong();
                    loaiPhong.ID_LoaiPhong = rd["MaLoaiPhong"].ToString();
                    loaiPhong.DonGia = (int)(float.Parse(rd["DonGia"].ToString()));
                }
                rd.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            return loaiPhong;
        }
        public DataTable getDanhMucLoaiPhong()
        {
            DataTable dt = null;
            try
            {
                dt = new DataTable();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetDanhMucLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                connection.Close(); 
            }
            return dt;
        }
        public int getDonGiaLonNhat()
        {
            int max = 0;
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("GetDonGiaLonNhat", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    max = (int)float.Parse(rd["DonGia"].ToString());
                }
            }
            catch (Exception e)
            {
                connection.Close();
            }
            return max;
        }
        //xoa loaiphong
        //them loai phong
        public int themLoaiPhong(string pMaLoaiPhong, int pDonGia)//return rows effected
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = pDonGia;
                return cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                connection.Close();
            }
            return 0;
        }
        public SqlCommand themLoaiPhongCmd(string pMaLoaiPhong, int pDonGia)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = pDonGia;
                return cmd;

            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
        public int xoaLoaiPhong(string pMaLoaiPhong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("XoaLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                connection.Close();
            }
            return 0;
        }
        public SqlCommand xoaLoaiPhongCmd(string pMaLoaiPhong)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("XoaLoaiPhong", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                return cmd;

            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
        public int capNhapDonGia(string pMaLoaiPhong, int pDonGia)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("CapNhapDonGia", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = pDonGia;
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                connection.Close();
            }
            return 0;
        }
        public SqlCommand capNhapDonGiaCmd(string pMaLoaiPhong, int pDonGia)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("CapNhapDonGia", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiPhong", SqlDbType.VarChar, 10).Value = pMaLoaiPhong;
                cmd.Parameters.Add("@DonGia", SqlDbType.Money).Value = pDonGia;
                return cmd;

            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
        void saoLuuLoaiPhong()
        {

        }
    }
}
