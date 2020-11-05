﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void showHSVV()
        {
            frmHoSoVayVon hsvv = new frmHoSoVayVon();
            hsvv.ShowDialog();
        }

        private void btnHoSoVayVon_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showHSVV));
            thread.Start();
            this.Dispose();
        }
    }
}
