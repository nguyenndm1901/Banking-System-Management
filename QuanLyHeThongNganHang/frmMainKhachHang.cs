using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmMainKhachHang : Form
    {
        public frmMainKhachHang()
        {
            InitializeComponent();
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

        private void showHSVV()
        {
            frmGuiDon hsvv = new frmGuiDon();
            hsvv.ShowDialog();
        }

        private void btnHoSoVayVon_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showHSVV));
            thread.Start();
            this.Dispose();
        }

        private void showGiaHan()
        {
            frmGiaHanNo giahan = new frmGiaHanNo();
            giahan.ShowDialog();
        }

        private void btnGiaHanjNo_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showGiaHan));
            thread.Start();
            this.Dispose();
        }
    }
}
