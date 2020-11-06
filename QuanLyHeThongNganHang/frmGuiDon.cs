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
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmGuiDon : Form
    {
        public frmGuiDon()
        {
            InitializeComponent();
        }

        private bool IsValidated()
        {
            if (txtTenKH.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKH.Focus();
                return false;
            }
            if (txtSoTien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu số tiền cần vay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return false;
            }
            if (txtKyHan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu kỳ hạn vay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKyHan.Focus();
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [HoSoVayVon](tenKH,soTien,ngayDangKy,kyHan) VALUES (@tenKH,@soTien,@ngayDangKy,@kyHan)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@tenKH", txtTenKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@soTien", txtSoTien.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngayDangKy", dateDangKy.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@kyHan", txtKyHan.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã gửi đơn đăng ký.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                LuuThongTin((int)Save.save);
                txtTenKH.Clear();
                txtSoTien.Clear();
                txtKyHan.Clear();
            }
        }

        private void showKhachHang()
        {
            frmMainKhachHang main = new frmMainKhachHang();
            main.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showKhachHang));
            thread.Start();
            this.Dispose();
        }
    }
}
