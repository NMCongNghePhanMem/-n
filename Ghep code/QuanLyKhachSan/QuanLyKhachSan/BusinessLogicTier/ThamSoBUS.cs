using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;

namespace BusinessLogicTier
{
    public class ThamSoBUS
    {
        ThamSoDAO m_ThamSo;

        public ThamSoBUS()
        {
            m_ThamSo = new ThamSoDAO();
        }

        public DataTable LayThamSo()
        {
            return m_ThamSo.LayThamSo();
        }
    }
}
