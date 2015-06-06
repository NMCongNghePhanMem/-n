using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataTransferObject;
using BusinessLogicTier;

namespace QuanLyKhachSan
{
    public partial class FormTraCuuPhong : Form
    {
        public static int DON_GIA_CAO_NHAT;
        public static int DON_GIA_THAP_NHAT = 0;
        static FormTraCuuPhong()
        {
            LoaiPhongBUS l = new LoaiPhongBUS();
            DON_GIA_CAO_NHAT = l.getDonGiaLonNhat();
        }
        PhongBUS phongBUS;
        LoaiPhongBUS loaiPhongBUS;
        public FormTraCuuPhong()
        {
            InitializeComponent();
            phongBUS = new PhongBUS();
            loaiPhongBUS = new LoaiPhongBUS();
            DataTable dt = phongBUS.getDanhMucPhong();
            updateListView(dt);

            DataTable loaiPhongDT = loaiPhongBUS.getDanhMucLoaiPhong();
            comboBoxLoaiPhong.DataSource = loaiPhongDT;

            DataRow dr = loaiPhongDT.NewRow();
            dr["MaLoaiPhong"] = "Tất cả";
            dr["DonGia"] = "0";
            loaiPhongDT.Rows.InsertAt(dr, 0);


            comboBoxLoaiPhong.DisplayMember = "MaLoaiPhong";
            comboBoxLoaiPhong.ValueMember = "MaLoaiPhong";


            comboBoxLoaiPhong.SelectedIndex = 0;
            comboBoxDonGia.SelectedIndex = 0;
            comboBoxTinhTrang.SelectedIndex = 0;



        }
        private void updateListView(DataTable dt)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                ListViewItem lvItems = new ListViewItem();
                lvItems.Text = (i + 1).ToString();
                lvItems.SubItems.Add(dt.Rows[i]["MaPhong"].ToString());
                lvItems.SubItems.Add(dt.Rows[i]["MaLoaiPhong"].ToString());
                lvItems.SubItems.Add(dt.Rows[i]["DonGia"].ToString());

                string tinhTrang = "";
                if(bool.Parse(dt.Rows[i]["TinhTrangPhong"].ToString())==true){
                    tinhTrang="Chưa Thuê";
                }
                else{
                    tinhTrang ="Đang Thuê";
                }
                lvItems.SubItems.Add(tinhTrang);
                this.listView1.Items.Add(lvItems);

            }
        }
        private void FormTraCuuPhong_Load(object sender, EventArgs e)
        {

            //cmd.CommandText = "Select * From "
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string phong = textBoxPhong.Text;
            string loaiPhong = comboBoxLoaiPhong.Text;
            if (loaiPhong == "Tất cả")
            {
                loaiPhong = "";
            }

            bool? tinhTrang = true;
            switch (comboBoxTinhTrang.Text)
            {
                case "Tất cả":
                    tinhTrang = null;
                    break;
                case "Đang thuê":
                    tinhTrang = false;
                    break;
                case "Chưa thuê":
                    tinhTrang = true;
                    break;
            }
            int GiaTu = 0, GiaDen = DON_GIA_CAO_NHAT;
            switch (comboBoxDonGia.Text)
            {
                case "Tất cả":
                    break;
                case "dưới 150k":
                    GiaTu = 0;
                    GiaDen = 150000;
                    break;
                case "150k->170k":
                    GiaTu = 150000;
                    GiaDen = 170000;
                    break;
                case "trên 170k":
                    GiaTu = 171000;
                    GiaDen = DON_GIA_CAO_NHAT;
                    break;
            }
            DataTable dt = phongBUS.traCuuPhong(phong, loaiPhong, tinhTrang, GiaDen, GiaTu);
            updateListView(dt);
        }
    }
}
