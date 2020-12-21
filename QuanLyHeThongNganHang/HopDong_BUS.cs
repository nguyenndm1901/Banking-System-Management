using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHeThongNganHang
{
    public class HopDong_BUS
    {
        private HopDong_DAL hdDAL;

        public HopDong_BUS()
        {
            hdDAL = new HopDong_DAL();
        }
        public List<HopDong_DTO> select()
        {
            return hdDAL.select();
        }
    }
}
