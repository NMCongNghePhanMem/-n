using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;
using DataTransferObject;

namespace QuanLyKhachSan
{
    public partial class FormTraCuuBaoCao : Form
    {
        BaoCaoBUS objBaoCao = new BaoCaoBUS();
        ChiTietBaoCaoBUS objCTBC = new ChiTietBaoCaoBUS();
        string maBaoCao = "";
        DataTable dt = new DataTable();
        ListViewItem lvi;
        int stt = 1;
        public FormTraCuuBaoCao()
        {
            InitializeComponent();
        }

        private void FormTraCuuBaoCao_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= DateTime.Now.Month; i++)
                cboThang.Items.Add(i);
            for (int i = objBaoCao.NamNhoNhat(); i <= DateTime.Now.Year; i++)
                cboNam.Items.Add(i);
            cboThang.Text = DateTime.Now.Month.ToString();
            cboNam.Text = DateTime.Now.Year.ToString();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dt.Clear();
            listView1.Items.Clear();
            maBaoCao = objBaoCao.LayMaBaoCao(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
            if (maBaoCao == "")
            {
                MessageBox.Show("Báo cáo chưa được lập.");
                return;
            }

            dt = objCTBC.NoiDungChiTietBaoCao(maBaoCao);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvi = new ListViewItem();
                lvi.Text = stt.ToString();
                lvi.SubItems.Add(dt.Rows[i]["MaLoaiPhong"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["DoanhThu"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["TiLe"].ToString());
                listView1.Items.Add(lvi);
                stt++;
            }
            stt = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
