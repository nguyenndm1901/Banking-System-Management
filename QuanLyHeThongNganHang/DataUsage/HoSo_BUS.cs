using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHeThongNganHang
{
    public class HoSo_BUS
    {
        private HoSo_DAL hsDAL;

        public HoSo_BUS()
        {
            hsDAL = new HoSo_DAL();
        }
        public List<HoSo_DTO> select()
        {
            return hsDAL.select();
        }
    }
}
