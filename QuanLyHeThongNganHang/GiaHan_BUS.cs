using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHeThongNganHang
{
    public class GiaHan_BUS
    {
        private GiaHan_DAL ghDAL;

        public GiaHan_BUS()
        {
            ghDAL = new GiaHan_DAL();
        }
        public List<GiaHan_DTO> select()
        {
            return ghDAL.select();
        }
    }
}
