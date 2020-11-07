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
    public partial class frmGuiHoSoVayVon : Form
    {
        public delegate void sendName(string tenKH);
        public sendName Sender;

        public frmGuiHoSoVayVon()
        {
            InitializeComponent();
            Sender = new sendName(getName);
            Load();
        }
        private void getName(string tenKH)
        {
            lblTenKH.Text = tenKH;
        }

        private bool IsValidated()
        {
            if (lblTenKH.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblTenKH.Focus();
                return false;
            }
            if (txtSoTien.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu số tiền cần vay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoTien.Focus();
                return false;
            }
            else
            {
                int tempSoLuong;
                bool isNumberic = int.TryParse(txtSoTien.Text.Trim(), out tempSoLuong);
                if (!isNumberic)
                {
                    MessageBox.Show("Số tiền phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoTien.Clear();
                    txtSoTien.Focus();
                    return false;
                }
            }
            if (txtKyHan.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu kỳ hạn vay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKyHan.Focus();
                return false;
            }
            else
            {
                int tempSoLuong;
                bool isNumberic = int.TryParse(txtKyHan.Text.Trim(), out tempSoLuong);
                if (!isNumberic)
                {
                    MessageBox.Show("Kỳ hạn phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKyHan.Clear();
                    txtKyHan.Focus();
                    return false;
                }
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [HoSoVayVon](id,tenKH,soTien,ngayDangKy,kyHan,nhanVienDuyet,tinhTrang) VALUES (@id,@tenKH,@soTien,@ngayDangKy,@kyHan,@nhanVienDuyet,@tinhTrang)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                        cmd.Parameters.AddWithValue("@tenKH", lblTenKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@soTien", txtSoTien.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngayDangKy", dateDangKy.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@kyHan", txtKyHan.Text.Trim());
                        cmd.Parameters.AddWithValue("@nhanVienDuyet", "Chưa xác định");
                        cmd.Parameters.AddWithValue("@tinhTrang", "Đang chờ");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã gửi đơn đăng ký.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private bool check(string id)
        {
            bool MaHoSoExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoVayVon WHERE [id] = @id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    DataTable dtAnyData = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count > 0)
                    {
                        MaHoSoExist = true;
                    }
                }
            }
            return MaHoSoExist;
        }

        private string GenerateID()
        {
            string id;
            Random ran = new Random();
            long orderpart1 = ran.Next(100, 999);
            int orderpart2 = ran.Next(0, 99);
            id = "HSVV" + "-" + orderpart1 + "-" + orderpart2;
            return id;
        }

        private void Load()
        {
            string id;
            bool isMaHoSoExisted = true;
            while (isMaHoSoExisted)
            {
                id = GenerateID();
                isMaHoSoExisted = check(id);
                txtID.Text = id;
            }
            txtSoTien.Select();
            txtSoTien.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                LuuThongTin((int)Save.save);
                txtSoTien.Clear();
                txtKyHan.Clear();
                Load();
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

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            long a;
            long.TryParse(txtSoTien.Text.Trim(), out a);
            TextBox tb = sender as TextBox;
            labelConvert.Text = string.Format("{0:n0}", a);
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
