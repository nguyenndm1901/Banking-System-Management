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
    }
}
