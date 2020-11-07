using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmMasterPassword : Form
    {
        public frmMasterPassword()
        {
            InitializeComponent();
            txtPassword.Select();
            txtPassword.Focus();
        }

        private bool isExisted()
        {
            bool check = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from DangNhap", con);
            con.Open();
            SqlDataAdapter da_kiemtra = new SqlDataAdapter("Select username,password from DangNhap where username = '" + username + "' and password = '" + password + "'", con);
            DataTable dt_kiemtra = new DataTable();
            da_kiemtra.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count <= 0)
            {
                check = true;
            }
            da_kiemtra.Dispose();
            return check;
        }

        private bool IsValidated()
        {
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void showMain()
        {
            frmDangKyNganHang main = new frmDangKyNganHang();
            main.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                if (isExisted())
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ. Kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
                else
                {
                    Thread thread = new Thread(new ThreadStart(showMain));
                    thread.Start();
                    this.Close();
                }
            }
        }

        private void showSignUp()
        {
            frmLoaiTaiKhoan signup = new frmLoaiTaiKhoan();
            signup.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showSignUp));
            thread.Start();
            this.Dispose();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
