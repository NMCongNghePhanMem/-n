using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DataAccessTier
{
    public class ChiTietBaoCaoDAO : DBConnection
    {
        DataTable dt = new DataTable();
        SqlCommand command;
        SqlParameter []parameter;
        SqlDataAdapter adapter;
        public ChiTietBaoCaoDAO() : base() { }

        public bool ThemChiTietBaoCao(ChiTietBaoCaoDTO ctbc)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ThemChiTietBaoCao";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[4];
                parameter[0] = new SqlParameter("@MaBaoCao", ctbc.MaBaoCao);
                parameter[1] = new SqlParameter("@MaLoaiPhong", ctbc.MaLoaiPhong);
                parameter[2] = new SqlParameter("@DoanhThu", ctbc.DoanhThu);
                parameter[3] = new SqlParameter("@TiLe", ctbc.TiLe);

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

        public bool XoaTatCaChiTietBaoCao(string maBaoCao)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "XoaTatCaChiTietBaoCao";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@MaBaoCao", maBaoCao);

                command.Parameters.AddRange(parameter);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
        }

        public DataTable ChiTietBaoCaoMaLoaiPhongVaDoanhThu(int thang, int nam)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "ChiTietBaoCaoMaLoaiPhongVaDoanhThu";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[2];
                parameter[0] = new SqlParameter("@Thang", thang);
                parameter[1] = new SqlParameter("@Nam", nam);

                command.Parameters.AddRange(parameter);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);

                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }

        public DataTable NoiDungChiTietBaoCao(string maBaoCao)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "NoiDungChiTietBaoCao";
                command.CommandType = CommandType.StoredProcedure;

                parameter = new SqlParameter[1];
                parameter[0] = new SqlParameter("@MaBaoCao", maBaoCao);

                command.Parameters.AddRange(parameter);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);

                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }
    }
}
