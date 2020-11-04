using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {
            Label labelForgot = sender as Label;

            if (labelForgot != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (labelForgot.ForeColor == Color.Black)
                    return;

                labelForgot.ForeColor = Color.Black;
            }
        }
    }
}
