using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ThamSoDTO
    {
        int m_ID;
        ushort m_SoKhachToiDa;
        ushort m_SoKhachKhongTinhPhuThu;
        float m_TiSoPhuThu;
        float m_HeSoPhuThu;
        DateTime m_NgayCapNhat;

        public DateTime NgayCapNhat
        {
            get { return m_NgayCapNhat; }
            set { m_NgayCapNhat = value; }
        }

        public float HeSoPhuThu
        {
            get { return m_HeSoPhuThu; }
            set { m_HeSoPhuThu = value; }
        }

        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

        public ushort SoKhachToiDa
        {
            get { return m_SoKhachToiDa; }
            set { m_SoKhachToiDa = value; }
        }

        public ushort SoKhachKhongTinhPhuThu
        {
            get { return m_SoKhachKhongTinhPhuThu; }
            set { m_SoKhachKhongTinhPhuThu = value; }
        }

        public float TiSoPhuThu
        {
            get { return m_TiSoPhuThu; }
            set { m_TiSoPhuThu = value; }
        }

        public ThamSoDTO()
        { }

        public ThamSoDTO(int _id, ushort _soKhachToiDa, ushort _soKhachKhongTinhPhuThu, float _tiSoPhuThu, float _heSoPhuThu, DateTime _ngayCapNhat)
        {
            m_ID = _id;
            m_SoKhachToiDa = _soKhachToiDa;
            m_SoKhachKhongTinhPhuThu = _soKhachKhongTinhPhuThu;
            m_TiSoPhuThu = _tiSoPhuThu;
            m_HeSoPhuThu = _heSoPhuThu;
            m_NgayCapNhat = _ngayCapNhat;
        }
    }
}
