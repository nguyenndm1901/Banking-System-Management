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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            btnForgot.FlatAppearance.MouseOverBackColor = btnForgot.BackColor;
            btnForgot.BackColorChanged += (s, e) => {
                btnForgot.FlatAppearance.MouseOverBackColor = btnForgot.BackColor;
            };
        }

        private void showForgot()
        {
            frmQuenMatKhau forgot = new frmQuenMatKhau();
            forgot.ShowDialog();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showForgot));
            thread.Start();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void showSignUp()
        {
            frmDangKy signup = new frmDangKy();
            signup.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showSignUp));
            thread.Start();
        }
    }
}
