using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class PhongDAO:DBConnection
    {
        
        public PhongDAO() : base() { }
        public Phong GetPhongByMaPhong(string pMaPhong)
        {
            Phong phong = null;
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
                    phong = new Phong();
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
            return dt;
        }
    }
}
