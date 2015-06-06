﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;

namespace QuanLyKhachSan
{
    public enum ERole
    {
        QuanLy,
        NhanVien,
    }
    public partial class MainForm : Form
    {
        public static ERole role;
        public MainForm()
        {
            InitializeComponent();
            if (role == ERole.NhanVien)
            {
                msQuanLyPhong.Visible = false;
                msThietLap.Visible = false;
                msTaiChinh.Visible = false;
            }
        }

        private void msQuanLyPhong_Click(object sender, EventArgs e)
        {
            DanhMucPhong formDanhMucPhong = new DanhMucPhong();
            formDanhMucPhong.ShowDialog();
        }

        private void msTaoPTP_Click(object sender, EventArgs e)
        {
            PhieuThuePhong formPhieuThuePhong = new PhieuThuePhong();
            formPhieuThuePhong.ShowDialog();
        }

        private void msXemPTP_Click(object sender, EventArgs e)
        {
            ChiTietPhieuThue formPTHienTai = new ChiTietPhieuThue();
            formPTHienTai.ShowDialog();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msThietLap_Click(object sender, EventArgs e)
        {
            FormThayDoiQuyDinh formThayDoiQuyDinh = new FormThayDoiQuyDinh();
            formThayDoiQuyDinh.ShowDialog();
        }

        private void msTraCuuPhong_Click(object sender, EventArgs e)
        {
            FormTraCuuPhong formTraCuuPhong = new FormTraCuuPhong();
            formTraCuuPhong.ShowDialog();
        }


    }
}