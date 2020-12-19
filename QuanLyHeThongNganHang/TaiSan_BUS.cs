using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHeThongNganHang
{
    public class TaiSan_BUS
    {
        private TaiSan_DAL tsDAL;

        public TaiSan_BUS()
        {
            tsDAL = new TaiSan_DAL();
        }
        public List<TaiSan_DTO> select()
        {
            return tsDAL.select();
        }
    }
}
