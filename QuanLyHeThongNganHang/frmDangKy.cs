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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private bool isEmailExisted()
        {
            bool check = false;
            string email = txtEmail.Text;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from DangNhap", con);
            con.Open();
            SqlDataAdapter email_kiemtra = new SqlDataAdapter("Select email from DangNhap where email = '" + email + "'", con);
            DataTable dt_email_kiemtra = new DataTable();
            email_kiemtra.Fill(dt_email_kiemtra);
            if (dt_email_kiemtra.Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }
        private bool isUserExisted()
        {
            bool check = false;
            string user = txtUsername.Text;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from DangNhap", con);
            con.Open();
            SqlDataAdapter user_kiemtra = new SqlDataAdapter("Select username from DangNhap where username = '" + user + "'", con);
            DataTable dt_user_kiemtra = new DataTable();
            user_kiemtra.Fill(dt_user_kiemtra);
            if (dt_user_kiemtra.Rows.Count > 0)
            {
                check = true;
            }
            return check;
        }

        private bool IsValidated()
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu e-mail.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (isEmailExisted())
            {
                MessageBox.Show("E-mail đã tồn tại. Kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.SelectAll();
                txtEmail.Focus();
                return false;
            }
            if (isUserExisted())
            {
                MessageBox.Show("Tài khoản đã tồn tại. Kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return false;
            }
            return true;
        }

        public enum Save
        {
            save = 1,
        }

        private void LuuThongTin(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [DangNhap](username,password,email) VALUES (@username,@password,@email)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã đăng ký. Nhấn 'Quay Về' để đăng nhập.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                LuuThongTin((int)Save.save);
                txtEmail.Clear();
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void showLogIn()
        {
            frmDangNhap login = new frmDangNhap();
            login.ShowDialog();
        }

        private void backMenu_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showLogIn));
            thread.Start();
            this.Dispose();
        }
    }
}
