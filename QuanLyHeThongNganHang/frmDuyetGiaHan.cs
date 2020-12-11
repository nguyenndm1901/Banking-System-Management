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
    public partial class frmDuyetGiaHan : Form
    {
        public delegate void sendName(string tenNV);
        public sendName Sender;

        public frmDuyetGiaHan()
        {
            InitializeComponent();
            Sender = new sendName(getName);
        }

        private void getName(string tenNV)
        {
            labelTenNV.Text = tenNV;
        }

        private void Main()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Main);
            thread.Start();
            this.Dispose();
        }
    }
}
