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
    public partial class FormLapBaoCaoDoanThuTheoThang : Form
    {
        BaoCaoDTO bc = new BaoCaoDTO();
        ChiTietBaoCaoDTO ctbc = new ChiTietBaoCaoDTO();
        BaoCaoBUS objBaoCao = new BaoCaoBUS();
        ChiTietBaoCaoBUS objCTBC = new ChiTietBaoCaoBUS();
        DataTable dt = new DataTable();
        int stt = 1;
        ListViewItem lvi;
        float tongDoanhthu;
        public FormLapBaoCaoDoanThuTheoThang()
        {
            InitializeComponent();
        }

        private void FormLapBaoCaoDoanThuTheoThang_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 13; i++)
                cboThang.Items.Add(i);
            for (int i = objBaoCao.NamNhoNhat(); i <= DateTime.Now.Year; i++)
                cboNam.Items.Add(i);
            cboThang.Text = "";
            cboNam.Text = DateTime.Now.Year.ToString();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cboNam.Text == "")
                return;
            if (objBaoCao.LayMaBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text)).Length > 0)
            {
                MessageBox.Show("Báo cáo của tháng này đã được lập.");
                return;
            }
            KetSuatBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cboThang.Text == "")
                return;
            if (objBaoCao.LayMaBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text)).Length > 0)
            {
                MessageBox.Show("Báo cáo của tháng này đã được lập.");
                return;
            }
            KetSuatBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text));

        }
        // kết suất báo cáo và in ra listview
        private void KetSuatBaoCao(int thang, int nam)
        {
            tongDoanhthu = 0;
            dt = objCTBC.ChiTietBaoCaoMaLoaiPhongVaDoanhThu(thang, nam);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tongDoanhthu += float.Parse(dt.Rows[i]["DoanhThu"].ToString());
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = stt.ToString();
                lvi.SubItems.Add(dt.Rows[i]["MaLoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DoanhThu"].ToString());
                lvi.SubItems.Add((float.Parse(dt.Rows[i]["DoanhThu"].ToString()) / tongDoanhthu).ToString());
                listView1.Items.Add(lvi);
                stt++;
            }
            // reset lại biến stt
            stt = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                bc.Thang = int.Parse(cboThang.Text);
                bc.Nam = int.Parse(cboNam.Text);
                bc.TongDoanhThu = tongDoanhthu;

                objBaoCao.ThemBaoCaoThang(bc);

                ctbc.MaBaoCao = objBaoCao.MaBaoCaoGanNhat();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ctbc.MaLoaiPhong = listView1.Items[i].SubItems[1].Text;
                    ctbc.DoanhThu = float.Parse(listView1.Items[i].SubItems[2].Text);
                    ctbc.TiLe = float.Parse(listView1.Items[i].SubItems[3].Text);

                    objCTBC.ThemChiTietBaoCao(ctbc);
                }

                MessageBox.Show("Lưu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnXoaBC_Click(object sender, EventArgs e)
        {
            bc.MaBaoCao = objBaoCao.LayMaBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text));

            objCTBC.XoaTatCaChiTietBaoCao(bc.MaBaoCao);
            objBaoCao.XoaBaoCaoThang(bc.MaBaoCao);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
