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
        public delegate void sendName(string tenKH);
        public sendName Sender;

        public frmMainKhachHang()
        {
            InitializeComponent();
            Sender = new sendName(getName);
        }

        private void getName(string tenKH)
        {
            lblTenKH.Text = tenKH;
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
            frmGuiHoSoVayVon hsvv = new frmGuiHoSoVayVon();
            hsvv.Sender(tenKH);
            hsvv.ShowDialog();
        }

        public static string tenKH = "";

        private void btnHoSoVayVon_Click(object sender, EventArgs e)
        {
            tenKH = lblTenKH.Text;
            Thread thread = new Thread(new ThreadStart(showHSVV));
            thread.Start();
            this.Dispose();
        }

        private void showGiaHan()
        {
            frmGiaHanNo giahan = new frmGiaHanNo();
            giahan.Sender(tenKH);
            giahan.ShowDialog();
        }

        private void btnGiaHanjNo_Click(object sender, EventArgs e)
        {
            tenKH = lblTenKH.Text;
            Thread thread = new Thread(new ThreadStart(showGiaHan));
            thread.Start();
            this.Dispose();
        }
    }
}
