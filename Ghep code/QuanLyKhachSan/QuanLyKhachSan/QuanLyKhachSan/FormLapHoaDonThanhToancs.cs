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
        int stt = 1;
        bool isThemHoaDon = false;
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
            //dt = objChiTietHoaDon.LayThongTinCTHDVaPTP("1");
            btnLuuHD.Enabled = btnXoaHD.Enabled = false;
            txtDiaChi.Enabled = txtKhachHang.Enabled = dateTimePicker1.Enabled = false;

            if (objHoaDon.LayHoaDonNgayHienTai().Rows.Count == 0)
                cboMaHoaDon.Enabled = false;

            btnXoaCTHD.Enabled = false;
            groupBox2.Enabled = false;

            cboMaHoaDon.Text = "";
            dtCTHD = objChiTietHoaDon.LayThongTinCTHDVaPTP(cboMaHoaDon.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtCTHD;

            dataGridView1.Columns[1].DataPropertyName = "MaPhong";
            dataGridView1.Columns[2].DataPropertyName = "SoNgayThue";
            dataGridView1.Columns[3].DataPropertyName = "DonGia";
            dataGridView1.Columns[4].DataPropertyName = "ThanhTien";
            dataGridView1.Columns[5].DataPropertyName = "MaPhieuThue";
            // Binding
            dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
            cboMaHoaDon.DataSource = dtHoaDon;
            cboMaHoaDon.DisplayMember = "MaHoaDon";
            cboMaHoaDon.ValueMember = "MaHoaDon";

            txtDiaChi.DataBindings.Add("Text", dtHoaDon, "DiaChi");
            txtKhachHang.DataBindings.Add("Text", dtHoaDon, "TenKhachHang");
            txtTriGia.DataBindings.Add("Text", dtHoaDon, "TongChiTietThanhToan");
            if (cboMaHoaDon.Text.Length > 0)
                groupBox2.Enabled = true;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            txtKhachHang.Text = txtDiaChi.Text = txtTriGia.Text = "";
            btnLuuHD.Enabled = true;
            txtKhachHang.Enabled = txtDiaChi.Enabled = dateTimePicker1.Enabled = true;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            cboMaHoaDon.Enabled = false;
            groupBox2.Enabled = false;
            isThemHoaDon = true;
            stt = 1;
            btnXoaCTHD.Enabled = false;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length == 0 || txtKhachHang.Text.Length == 0)
                return;
            // lưu xuống database
            hd.DiaChi = txtDiaChi.Text;
            hd.TenKhachHang = txtKhachHang.Text;
            hd.NgayThanhToan = dateTimePicker1.Value;

            // btnLuuCTHD.Enabled = true;
            if (isThemHoaDon == true)
            {
                if (objHoaDon.ThemHoaDon(hd))
                    MessageBox.Show("Thanh cong");
                else MessageBox.Show("That bai");
                groupBox2.Enabled = true;
                cboMaHoaDon.Enabled = true;
                btnLuuHD.Enabled = false;
                btnXoaHD.Enabled = true;
                // cập nhật lại DataSource
                maHoaDonGanNhat = objHoaDon.MaHoaDonGanNhat();
                dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
                cboMaHoaDon.DataSource = dtHoaDon;
                cboMaHoaDon.Text = maHoaDonGanNhat;
                labelMaHoaDon.Text = maHoaDonGanNhat;
            }
            else
            {
                hd.MaHoaDon = cboMaHoaDon.Text;
                if (objHoaDon.CapNhatHoaDon(hd))
                    MessageBox.Show("Thanh cong");
                else MessageBox.Show("That bai");
            }
            txtTriGia.Text = "";
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            // MessageBox.Show("cột phòng leave, tính toán 3 phần còn lại");
            {
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
                        objChiTietHoaDon.XoaChiTietHoaDon(cboMaHoaDon.Text, PhieuThueVaPhongDaXoa[i].maPhieuThue);
                        break;
                    }
                }
                maPhieuThue = objChiTietHoaDon.MaPhieuThueKhongTonTaiCTHD(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dateTimePicker1.Value);
                if (maPhieuThue.Length == 0)
                {
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.");
                    // xóa hóa đơn
                    // objHoaDon.XoaHoaDon(maHoaDonGanNhat);
                    // dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                    return;
                }
                //maHoaDonGanNhat = objHoaDon.MaHoaDonGanNhat();
                if (isThemHoaDon == true)
                    cthd.MaHoaDon = maHoaDonGanNhat;
                else
                    cthd.MaHoaDon = cboMaHoaDon.Text;
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
                for (int i = 0; i < PhieuThueVaPhongDaXoa.Count; i++)
                    // những má hóa đơn có trong list PhieuThuePhongVaPhongDaXoa thì không xóa khỏi database
                    if (PhieuThueVaPhongDaXoa[i].maPhieuThue.Contains(cthd.MaPhieuThue) == false)
                    {
                        objChiTietHoaDon.XoaChiTietHoaDon(cthd.MaHoaDon, maPhieuThue);
                        break;
                    }
                if (PhieuThueVaPhongDaXoa.Count == 0)
                    objChiTietHoaDon.XoaChiTietHoaDon(cthd.MaHoaDon, maPhieuThue);

                hd.TongChiTietThanhToan += float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtTriGia.Text = hd.TongChiTietThanhToan.ToString();
            }
        }

        private void cboMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnXoaHD.Enabled = btnLuuHD.Enabled = true;
            btnXoaCTHD.Enabled = true;
            txtDiaChi.Enabled = txtKhachHang.Enabled = dateTimePicker1.Enabled = true;
            // maHoaDonGanNhat = cboMaHoaDon.SelectedItem.ToString();
            if (cboMaHoaDon.SelectedIndex >= 0)
                labelMaHoaDon.Text = cboMaHoaDon.SelectedValue.ToString();
            if (cboMaHoaDon.Text.Contains("System.Data.DataRowView") == false)
            {
                // binding ở đây.

                dtCTHD = objChiTietHoaDon.LayThongTinCTHDVaPTP(cboMaHoaDon.Text);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtCTHD;

                for (int i = 0; i < dtCTHD.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = stt;
                    stt++;
                }

            }
            stt = 1;
            btnXoaCTHD.Enabled = true;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            //if(dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
            //{
            //    temptTongChiTietThanhToan = float.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            //    temptPhieuThueVaPhongDaXoa.maPhong = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    temptPhieuThueVaPhongDaXoa.maPhieuThue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //}
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            objChiTietHoaDon.XoaTatCaChiTietHoaDon(cboMaHoaDon.Text);
            objHoaDon.XoaHoaDon(cboMaHoaDon.Text);
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            txtDiaChi.Text = txtKhachHang.Text = txtTriGia.Text = "";
            // cập nhật lại combobox
            dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
            cboMaHoaDon.DataSource = dtHoaDon;
            //cboMaHoaDon.Text = "";
            dtCTHD = objChiTietHoaDon.LayThongTinCTHDVaPTP(cboMaHoaDon.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtCTHD;
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            hd.TongChiTietThanhToan = 0;
            if (isThemHoaDon == true)
            {
                try
                {
                    cthd.MaHoaDon = maHoaDonGanNhat;
                    labelMaHoaDon.Text = maHoaDonGanNhat;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        cthd.MaPhieuThue = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        cthd.SoNgayThue = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cthd.DonGia = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        cthd.ThanhTien = cthd.DonGia * cthd.SoNgayThue;
                        objChiTietHoaDon.ThemChiTietHoaDon(cthd);
                        //hd.TongChiTietThanhToan = float.Parse(txtTriGia.Text);
                        hd.TongChiTietThanhToan += cthd.ThanhTien;

                        objHoaDon.CapNhatHoaDon(hd);
                    }
                    txtTriGia.Text = hd.TongChiTietThanhToan.ToString();
                    MessageBox.Show("Thêm cthd thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                //objHoaDon.CapNhatHoaDon(hd);
                // hd.TongChiTietThanhToan = 0;
                isThemHoaDon = false;
            }
            else
            {
                try
                {
                    cthd.MaHoaDon = cboMaHoaDon.Text;
                    labelMaHoaDon.Text = cboMaHoaDon.Text;
                    objChiTietHoaDon.XoaTatCaChiTietHoaDon(cthd.MaHoaDon);
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        cthd.MaPhieuThue = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        cthd.SoNgayThue = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cthd.DonGia = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        cthd.ThanhTien = cthd.DonGia * cthd.SoNgayThue;
                        objChiTietHoaDon.ThemChiTietHoaDon(cthd);
                        // hd.TongChiTietThanhToan = float.Parse(txtTriGia.Text);
                        hd.TongChiTietThanhToan += cthd.ThanhTien;
                        objHoaDon.CapNhatHoaDon(hd);
                    }
                    txtTriGia.Text = hd.TongChiTietThanhToan.ToString();
                    MessageBox.Show("Cập nhật cthd thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            objChiTietHoaDon.XoaTatCaChiTietHoaDon(cboMaHoaDon.Text);
            txtTriGia.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // khi xoa dong -> xoa chi tiet hoa don voi ung voi ma hoa don va ma hoa don tuong ung
            //if(dataGridView1.Rows[e.RowIndex] != null)
            if (txtTriGia.Text == "")
                return;
            txtTriGia.Text = (float.Parse(txtTriGia.Text) - temptTongChiTietThanhToan).ToString();
            PhieuThueVaPhongDaXoa.Add(temptPhieuThueVaPhongDaXoa);
            //objChiTietHoaDon.XoaChiTietHoaDon(cboMaHoaDon.Text, maPhieuThue);

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (dataGridView1.CurrentRow.Cells[4].Value != null)
                {
                    temptTongChiTietThanhToan = float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    temptPhieuThueVaPhongDaXoa.maPhong = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    temptPhieuThueVaPhongDaXoa.maPhieuThue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                }
            }
        }

    }

    public class PhongVaMaPhong
    {
        public string maPhieuThue;
        public string maPhong;
    }

}
