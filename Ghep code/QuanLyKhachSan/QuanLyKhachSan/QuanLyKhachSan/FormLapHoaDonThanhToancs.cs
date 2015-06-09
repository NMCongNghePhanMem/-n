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



            if (objHoaDon.LayHoaDonNgayHienTai().Rows.Count == 0)
                cboMaHoaDon.Enabled = false;

            btnXoaCTHD.Enabled = false;
            groupBox2.Enabled = false;

            cboMaHoaDon.Text = "";
            // Binding
            dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
            cboMaHoaDon.DataSource = dtHoaDon;
            cboMaHoaDon.DisplayMember = "MaHoaDon";
            cboMaHoaDon.ValueMember = "MaHoaDon";

            txtDiaChi.DataBindings.Add("Text", dtHoaDon, "DiaChi");
            txtKhachHang.DataBindings.Add("Text", dtHoaDon, "TenKhachHang");
            txtTriGia.DataBindings.Add("Text", dtHoaDon, "TongChiTietThanhToan", false, DataSourceUpdateMode.Never);
            if (cboMaHoaDon.Text.Length > 0)
                groupBox2.Enabled = true;
            if (txtTriGia.Text != "")
                temptTongChiTietThanhToan = float.Parse(txtTriGia.Text);

            if (dtHoaDon.Rows.Count <= 0)
            {
                txtDiaChi.Enabled = txtKhachHang.Enabled = dateTimePicker1.Enabled = false;
                btnLuuHD.Enabled = btnXoaHD.Enabled = false;
            }

            dtCTHD = objChiTietHoaDon.LayThongTinCTHDVaPTP(cboMaHoaDon.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtCTHD;

            dataGridView1.Columns[1].DataPropertyName = "MaPhong";
            dataGridView1.Columns[2].DataPropertyName = "SoNgayThue";
            dataGridView1.Columns[3].DataPropertyName = "DonGia";
            dataGridView1.Columns[4].DataPropertyName = "ThanhTien";
            dataGridView1.Columns[5].DataPropertyName = "MaPhieuThue";

            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = stt;
                stt++;
            }
            stt = 1;

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            temptTongChiTietThanhToan = 0;
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
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
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
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
                    return;
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
                maPhieuThue = objChiTietHoaDon.MaPhieuThueKhongTonTaiCTHD(dataGridView1.CurrentRow.Cells[1].Value.ToString(), dateTimePicker1.Value);
                if (maPhieuThue.Length == 0)
                {
                    
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc phòng đã thanh toán.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.");
                    MessageBox.Show("Nhập sai phòng hoặc phòng chưa tồn tại.\nHoặc phòng đã thanh toán.\nHoặc ngày thanh toán nhỏ hơn ngày thuê.\nVui lòng kiểm tra lại thông tin.", "Thông báo !");
                    return;
                }
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

                objChiTietHoaDon.XoaChiTietHoaDon(cthd.MaHoaDon, maPhieuThue);

                temptTongChiTietThanhToan += float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtTriGia.Text = temptTongChiTietThanhToan.ToString();
            }
        }

        private void cboMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaHoaDon_SelectionChangeCommitted(this.cboMaHoaDon, null);
            isPressDelete = false;
            //dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
            //cboMaHoaDon.DataSource = dtHoaDon;
            // txtTriGia.DataBindings.Add("Text", dtHoaDon, "TongChiTietThanhToan");
        }

        private void cboMaHoaDon_SelectionChangeCommitted(object sender, EventArgs e)
        {

            btnXoaHD.Enabled = btnLuuHD.Enabled = true;
            txtDiaChi.Enabled = txtKhachHang.Enabled = dateTimePicker1.Enabled = true;

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
            // Nếu không có chi tiết nào thì không hiện nút xóa
            if (dataGridView1.Rows.Count == 1)
            {
                btnXoaCTHD.Enabled = false;
            }
            //if (txtTriGia.Text != "")
            //    temptTongChiTietThanhToan = float.Parse(txtTriGia.Text);

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            if (txtTriGia.Text != "")
                temptTongChiTietThanhToan = float.Parse(txtTriGia.Text);
            //if(dataGridView1.Rows[e.RowIndex].Cells[4].Value != null)
            //{
            //    temptTongChiTietThanhToan = float.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            //    temptPhieuThueVaPhongDaXoa.maPhong = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    temptPhieuThueVaPhongDaXoa.maPhieuThue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //}
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Sẽ xóa luôn trong cơ sở dữ liệu.\nBạn có muốn tiếp tục", "Lưu ý !", MessageBoxButtons.OKCancel);
            if (d == System.Windows.Forms.DialogResult.No)
                return;
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    maPhong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, true);
                }

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
        }

        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1 && isPressDelete == false)
            {
                MessageBox.Show("Vui lòng nhập thông tin hóa đơn");
                return;
            }
            temptTongChiTietThanhToan = 0;
            if (isThemHoaDon == true)
            {
                try
                {
                    cthd.MaHoaDon = maHoaDonGanNhat;
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
                    objChiTietHoaDon.XoaTatCaChiTietHoaDon(cthd.MaHoaDon);
                    hd.MaHoaDon = cboMaHoaDon.Text;
                    hd.NgayThanhToan = dateTimePicker1.Value;
                    hd.TenKhachHang = txtKhachHang.Text;
                    hd.DiaChi = txtDiaChi.Text;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        cthd.MaPhieuThue = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        cthd.SoNgayThue = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        cthd.DonGia = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        cthd.ThanhTien = cthd.DonGia * cthd.SoNgayThue;
                        objChiTietHoaDon.ThemChiTietHoaDon(cthd);
                        //{
                        //    MessageBox.Show("Có lỗi xảy ra, không lưu được.");
                        //    return;
                        //}
                        // hd.TongChiTietThanhToan = float.Parse(txtTriGia.Text);
                        temptTongChiTietThanhToan += cthd.ThanhTien;


                        hd.TongChiTietThanhToan = temptTongChiTietThanhToan;

                        if (!objHoaDon.CapNhatHoaDon(hd))
                        {
                            MessageBox.Show("Có lỗi xảy ra, không lưu được.");
                            return;
                        }
                    }
                    if (dataGridView1.Rows.Count == 1)
                    {
                        temptTongChiTietThanhToan = 0;
                        hd.TongChiTietThanhToan = 0;

                        if (!objHoaDon.CapNhatHoaDon(hd))
                        {
                            MessageBox.Show("Có lỗi xảy ra, không lưu được.");
                            return;
                        }
                    }
                    txtTriGia.Text = temptTongChiTietThanhToan.ToString();
                    MessageBox.Show("Cập nhật cthd thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btnXoaCTHD.Enabled = true;
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
            // cập nhật lại datasource cho combobox
            dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
            cboMaHoaDon.DataSource = dtHoaDon;

            cboMaHoaDon_SelectionChangeCommitted(this.cboMaHoaDon, null);
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            //bool tinhTrangPhong;
            DialogResult d = MessageBox.Show("Sẽ xóa luôn trong cơ sở dữ liệu.\nBạn có muốn tiếp tục", "Lưu ý !", MessageBoxButtons.OKCancel);
            if (d == System.Windows.Forms.DialogResult.Cancel)
                return;
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    maPhong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, false);
                }
                objChiTietHoaDon.XoaTatCaChiTietHoaDon(cboMaHoaDon.Text);
                txtTriGia.Text = "";

                hd.MaHoaDon = cboMaHoaDon.Text;
                hd.NgayThanhToan = dateTimePicker1.Value;
                hd.TenKhachHang = txtKhachHang.Text;
                hd.DiaChi = txtDiaChi.Text;
                hd.TongChiTietThanhToan = 0;

                objHoaDon.CapNhatHoaDon(hd);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dtHoaDon = objHoaDon.LayHoaDonNgayHienTai();
                cboMaHoaDon.DataSource = dtHoaDon;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
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

        private void FormLapHoaDonThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < PhieuThueVaPhongDaXoa.Count; i++)
            {
                maPhong = PhieuThueVaPhongDaXoa[i].maPhong;
                objChiTietHoaDon.CapNhatTinhTrangPhong(maPhong, true);
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
