using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmMainNganHang : Form
    {
        public delegate void sendName(string tenNV);
        public sendName Sender;

        public frmMainNganHang()
        {
            InitializeComponent();
            Sender = new sendName(getName);
        }

        private void getName(string tenNV)
        {
            labelTenNV.Text = tenNV;
        }

        private void showHSVV()
        {
            frmHoSoVayVon hsvv = new frmHoSoVayVon();
            hsvv.Sender(tennv);
            hsvv.ShowDialog();
        }

        public static string tennv = "";

        private void btnHoSoVayVon_Click(object sender, EventArgs e)
        {
            tennv = labelTenNV.Text;
            Thread thread = new Thread(new ThreadStart(showHSVV));
            thread.Start();
            this.Dispose();
        }

        private void showDangNhap()
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
        }

        private void thoátĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showDangNhap));
            thread.Start();
            this.Dispose();
        }

        private void showGHVV()
        {
            frmDuyetGiaHan ghvv = new frmDuyetGiaHan();
            ghvv.Sender(tennv);
            ghvv.ShowDialog();
        }

        private void btnDuyetGiaHan_Click(object sender, EventArgs e)
        {
            tennv = labelTenNV.Text;
            Thread thread = new Thread(new ThreadStart(showGHVV));
            thread.Start();
            this.Dispose();
        }

        private void showHopDong()
        {
            frmKiemTraHoSo hd = new frmKiemTraHoSo();
            hd.ShowDialog();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showHopDong));
            thread.Start();
            this.Dispose();
        }

        private void showTaiSan()
        {
            frmTaiSanTheChap taisan = new frmTaiSanTheChap();
            taisan.ShowDialog();
        }

        private void btnTaiSanTheChap_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showTaiSan));
            thread.Start();
            this.Dispose();
        }

        private void showThanhLy()
        {
            frmThanhLyHopDong thanhly = new frmThanhLyHopDong();
            thanhly.ShowDialog();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showThanhLy));
            thread.Start();
            this.Dispose();
        }
    }
}
