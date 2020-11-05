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
    public partial class frmLoaiTaiKhoan : Form
    {
        public frmLoaiTaiKhoan()
        {
            InitializeComponent();
        }

        private void showDangNhap()
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.ShowDialog();
        }

        private void showNganHang()
        {
            frmMasterPassword dangky = new frmMasterPassword();
            dangky.ShowDialog();
        }

        private void showKhachHang()
        {
            frmDangKyKhachHang dangky = new frmDangKyKhachHang();
            dangky.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showDangNhap));
            thread.Start();
            this.Dispose();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showNganHang));
            thread.Start();
            this.Dispose();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showKhachHang));
            thread.Start();
            this.Dispose();
        }
    }
}
