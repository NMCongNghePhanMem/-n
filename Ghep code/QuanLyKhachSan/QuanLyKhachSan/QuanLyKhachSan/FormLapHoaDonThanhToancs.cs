using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogicTier;

namespace QuanLyKhachSan
{

    public partial class FormLapHoaDonThanhToan : Form
    {
        HoaDonDTO hd = new HoaDonDTO();
        HoaDonBUS objHoaDon = new HoaDonBUS();
        ChiTietHoaDonBUS objChiTietHoaDon = new ChiTietHoaDonBUS();
        ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
        DataTable dtHoaDon;// = new DataTable();
        DataTable dtCTHD = null;
        string maHoaDonGanNhat = "";
        string maPhieuThue = "";
        string maPhong = "";
        int stt = 1;
        bool isThemHoaDon = false;
        bool isPressDelete = false;
        bool isLuuHoaDon = false;
        float temptTongChiTietThanhToan = 0;
        List<PhongVaMaPhong> PhieuThueVaPhongDaXoa = new List<PhongVaMaPhong>();
        PhongVaMaPhong temptPhieuThueVaPhongDaXoa = new PhongVaMaPhong();

        public FormLapHoaDonThanhToan()
        {
            InitializeComponent();
            hd.TongChiTietThanhToan = 0;
        }

        private void FormHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = "";
            btnLuuHD.Enabled = false;
            dataGridView1.Enabled = false;
            txtDiaChi.Enabled = txtKhachHang.Enabled = txtTriGia.Enabled = dateTimePicker1.Enabled = false;

            maHoaDonGanNhat = objHoaDon.MaHoaDonGanNhat();


            //dtCTHD = objChiTietHoaDon.LayThongTinCTHDVaPTP(txtMaHoaDon.Text);
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = dtCTHD;

            //dataGridView1.Columns[1].DataPropertyName = "MaPhong";
            //dataGridView1.Columns[2].DataPropertyName = "SoNgayThue";
            //dataGridView1.Columns[3].DataPropertyName = "DonGia";
            //dataGridView1.Columns[4].DataPropertyName = "ThanhTien";
            //dataGridView1.Columns[5].DataPropertyName = "MaPhieuThue";
            //dataGridView1.Columns[5].Visible = false;

            //for (int i = 0; i < dtCTHD.Rows.Count; i++)
            //{
            //    dataGridView1.Rows[i].Cells[0].Value = stt;
            //    stt++;
            //}
            //stt = 1;

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            temptTongChiTietThanhToan = 0;
            if (maHoaDonGanNhat == "")
                txtMaHoaDon.Text = "1";
            else
                txtMaHoaDon.Text = (int.Parse(maHoaDonGanNhat) + 1).ToString();
            txtKhachHang.Text = txtDiaChi.Text = txtTriGia.Text = "";
            txtKhachHang.Enabled = txtDiaChi.Enabled = dateTimePicker1.Enabled = true;
            btnLuuHD.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            isThemHoaDon = true;
            stt = 1;
        }


        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2)
            {
<<<<<<< HEAD
                if (dataGridView1.CurrentRow.Cells[3].Value != null)
                    if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
                        return;
=======
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
                    return;
>>>>>>> origin/master
                for (int i = 0; i < PhieuThueVaPhongDaXoa.Count; i++)
                {
                    if (PhieuThueVaPhongDaXoa[i].maPhong == null)
                    {
                        PhieuThueVaPhongDaXoa.RemoveAt(i);
                        i = -1;
                        continue;
                    }
                    if (PhieuThueVaPhongDaXoa[i].maPhong.Equals(dataGridView1.CurrentRow.Cells[1].Value.ToString()) == true)
                    {
                        // gán lại giá trị
                        dataGridView1.CurrentRow.Cells[2].Value = PhieuThueVaPhongDaXoa[i].soNgayThue;
                        dataGridView1.CurrentRow.Cells[3].Value = PhieuThueVaPhongDaXoa[i].donGia;
                        dataGridView1.CurrentRow.Cells[4].Value = PhieuThueVaPhongDaXoa[i].thanhTien;
                        dataGridView1.CurrentRow.Cells[5].Value = PhieuThueVaPhongDaXoa[i].maPhieuThue;

                        temptTongChiTietThanhToan += float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        txtTriGia.Text = temptTongChiTietThanhToan.ToString();
                        // khi xóa -> nhập lại phòng -> xóa khỏi list phiếu thuê phòng đã xóa
                        PhieuThueVaPhongDaXoa.RemoveAt(i);
                        return;
                    }
                }
                // Kiểm tra chỉ cho duy nhất 1 phòng trong Gridview
                for (int i = 0; i < dataGridView1.Rows.Count - 2; i++ )
                {
                    if(dataGridView1.Rows[i].Cells[1].Value.Equals(dataGridView1.CurrentRow.Cells[1].Value))
                    {
                        MessageBox.Show("Phòng đã được nhập ở trên.", "Thông báo !");
                        return;
                    }
                }
                    maPhieuThue = objChiTietHoaDon.MaPhieuThueKhongTonTaiCTHD(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dateTimePicker1.Value);
                if (maPhieuThue.Length == 0)
                {
<<<<<<< HEAD
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc phòng đã thanh toán.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.", "Thông báo !");
                    return;
                }
                //maHoaDonGanNhat = objHoaDon.MaHoaDonGanNhat();
                cthd.MaHoaDon = txtMaHoaDon.Text;
=======
                    
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc phòng đã thanh toán.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.");
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc phòng đã thanh toán.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.", "Thông báo !");
                    return;
                }
                if (isThemHoaDon == true)
                    cthd.MaHoaDon = maHoaDonGanNhat;
                else
                    cthd.MaHoaDon = cboMaHoaDon.Text;
>>>>>>> origin/master
                cthd.MaPhieuThue = maPhieuThue;

                // Thêm chi tiết vào để lấy các giá trị tính toán, đưa vào Gridview, sau khi tính toán xong thì xóa.
                objChiTietHoaDon.ThemChiTietHoaDon(cthd);
                if (objChiTietHoaDon.SoNgayThue(cthd.MaHoaDon) <= 0)
                {
                    MessageBox.Show("Chi tiết hóa đơn đã được lập.");
                    // xóa chi tiết hóa đơn
                    objChiTietHoaDon.XoaChiTietHoaDon(cthd.MaHoaDon, maPhieuThue);
                    // objHoaDon.XoaHoaDon(cthd.MaHoaDon);
                    return;
                }

                dataGridView1.CurrentRow.Cells[2].Value = objChiTietHoaDon.SoNgayThue(cthd.MaHoaDon);
                dataGridView1.CurrentRow.Cells[3].Value = objChiTietHoaDon.DonGia(cthd.MaHoaDon, maPhieuThue);
                dataGridView1.CurrentRow.Cells[4].Value = (int)dataGridView1.CurrentRow.Cells[2].Value * Decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                dataGridView1.CurrentRow.Cells[5].Value = maPhieuThue;

                objChiTietHoaDon.XoaChiTietHoaDon(cthd.MaHoaDon, maPhieuThue);

                temptTongChiTietThanhToan += float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtTriGia.Text = temptTongChiTietThanhToan.ToString();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            if (txtTriGia.Text != "")
                temptTongChiTietThanhToan = float.Parse(txtTriGia.Text);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if(dataGridView1.CurrentRow.Cells[4].Value != null)
                {
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() != "")
                {
                    temptPhieuThueVaPhongDaXoa.maPhong = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    temptPhieuThueVaPhongDaXoa.soNgayThue = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    temptPhieuThueVaPhongDaXoa.donGia = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    temptPhieuThueVaPhongDaXoa.thanhTien = float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    temptPhieuThueVaPhongDaXoa.maPhieuThue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    temptTongChiTietThanhToan -= float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    txtTriGia.Text = temptTongChiTietThanhToan.ToString();
                    PhieuThueVaPhongDaXoa.Add(temptPhieuThueVaPhongDaXoa);
                }
                isPressDelete = true;

                }
            }
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length == 0 || txtKhachHang.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            objChiTietHoaDon.XoaTatCaChiTietHoaDon(txtMaHoaDon.Text);
            // Lưu chi tiets hóa đơn trước
            cthd.MaHoaDon = txtMaHoaDon.Text;
            temptTongChiTietThanhToan = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                cthd.MaPhieuThue = dataGridView1.Rows[i].Cells[5].Value.ToString();
                cthd.SoNgayThue = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                cthd.DonGia = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                cthd.ThanhTien = cthd.DonGia * cthd.SoNgayThue;

                objChiTietHoaDon.ThemChiTietHoaDon(cthd);
                //hd.TongChiTietThanhToan = float.Parse(txtTriGia.Text);
                temptTongChiTietThanhToan += cthd.ThanhTien;

                hd.TongChiTietThanhToan = temptTongChiTietThanhToan;
                objHoaDon.CapNhatHoaDon(hd);
            }
            txtTriGia.Text = temptTongChiTietThanhToan.ToString();
            // lưu xuống database
            hd.DiaChi = txtDiaChi.Text;
            hd.TenKhachHang = txtKhachHang.Text;
            hd.NgayThanhToan = dateTimePicker1.Value;
            hd.TongChiTietThanhToan = temptTongChiTietThanhToan;
            // btnLuuCTHD.Enabled = true;
            hd.MaHoaDon = txtMaHoaDon.Text;
            if (objHoaDon.CapNhatHoaDon(hd))
                MessageBox.Show("Thanh cong");
            else MessageBox.Show("That bai");
            isLuuHoaDon = true;
            // Câp nhật tình trạng phòng , true : đang trống; false : đã thuê
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                maPhong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, true);
            }
            for (int i = 0; i < PhieuThueVaPhongDaXoa.Count; i++)
            {
                maPhong = PhieuThueVaPhongDaXoa[i].maPhong;
                objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, false);
                PhieuThueVaPhongDaXoa.RemoveAt(i);
                i = -1;
                continue;
            }

        }


        private void FormLapHoaDonThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < PhieuThueVaPhongDaXoa.Count; i++)
            {
                maPhong = PhieuThueVaPhongDaXoa[i].maPhong;
                objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, true);
            }
            if (isLuuHoaDon == false)
                objHoaDon.XoaHoaDon(txtMaHoaDon.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (isThemHoaDon == true)
            {
                hd.TenKhachHang = txtKhachHang.Text;
                hd.DiaChi = txtDiaChi.Text;
                hd.NgayThanhToan = dateTimePicker1.Value;
                objHoaDon.ThemHoaDon(hd);
                isThemHoaDon = false;
            }
        }

        private void txtKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '\b' || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

    }

    public class PhongVaMaPhong
    {
        public string maPhieuThue;
        public string maPhong;
        public int soNgayThue;
        public float donGia;
        public float thanhTien;
    }

}
