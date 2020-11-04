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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
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
            if (dt_email_kiemtra.Rows.Count <= 0)
            {
                check = true;
            }
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
            if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu e-mail.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (txtConfirm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Xác nhận lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.Focus();
                return false;
            }
            if (txtConfirm.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirm.SelectAll();
                txtConfirm.Focus();
                return false;
            }
            if (isEmailExisted())
            {
                MessageBox.Show("E-mail không tồn tại. Kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.SelectAll();
                txtEmail.Focus();
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE [DangNhap] SET password = @password WHERE username =(SELECT username FROM DangNhap WHERE email = @email)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@password", txtConfirm.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Khôi phục mật khẩu thành công. Nhấn 'Quay Về' để đăng nhập.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                LuuThongTin((int)Save.save);
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirm.Clear();
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
