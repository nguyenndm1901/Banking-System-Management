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
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void showMain()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showMain));
            thread.Start();
            this.Dispose();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {

        }

        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAgree.Checked == true)
            {
                btnCreate.Enabled = true;
            }
            else if (cbAgree.Checked == false)
            {
                btnCreate.Enabled = false;
            }
        }

        private void cbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOther.Checked == true)
            {
                txtOther.Enabled = true;
            }
            else if (cbOther.Checked == false)
            {
                txtOther.Enabled = false;
            }
        }
    }
}
