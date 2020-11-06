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
using System.Data.SqlClient;
using System.Configuration;

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
            return true;
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
            this.Dispose();
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
                    Usertype = getUserType(txtUsername.Text, txtPassword.Text);
                    if (Usertype == "Ngân Hàng")
                    {
                        Thread thread = new Thread(new ThreadStart(showMain));
                        thread.Start();
                        this.Dispose();
                    }
                    if (Usertype == "Khách Hàng")
                    {
                        Thread thread = new Thread(new ThreadStart(showKhachHang));
                        thread.Start();
                        this.Dispose();
                    }
                }
            }
        }
        public static string Usertype = "";

        private void showMain()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void showKhachHang()
        {
            frmMainKhachHang guidon = new frmMainKhachHang();
            guidon.ShowDialog();
        }

        private void showSignUp()
        {
            frmLoaiTaiKhoan signup = new frmLoaiTaiKhoan();
            signup.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {           
            Thread thread = new Thread(new ThreadStart(showSignUp));
            thread.Start();
            this.Close();
        }


        private string getUserType(string username, string password)
        {
            string usertype = "";
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                SqlConnection con = new SqlConnection(ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from DangNhap where username = '" + username + "' and password = '" + password + "'", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        usertype = dr["usertype"].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Truy vấn thất bại !");
            }
            return usertype;
        }
    }
}
