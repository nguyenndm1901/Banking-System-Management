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
    public partial class frmHoSoVayVon : Form
    {
        public frmHoSoVayVon()
        {
            InitializeComponent();
        }

        private void showMain()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showMain));
            thread.Start();
            this.Dispose();
        }
    }
}
