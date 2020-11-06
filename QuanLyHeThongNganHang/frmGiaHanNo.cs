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
    public partial class frmGiaHanNo : Form
    {
        public delegate void sendName(string tenKH);
        public sendName Sender;

        public frmGiaHanNo()
        {
            InitializeComponent();
            Sender = new sendName(getName);     
        }

        private void getName(string tenKH)
        {
            txtHoTen.Text = tenKH;
        }

        private void frmGiaHanNo_Load(object sender, EventArgs e)
        {
            cbID.SelectedValueChanged -= cbID_SelectedValueChanged;
            cbID.DataSource = GetHSVV();
            cbID.DisplayMember = "ID";
            cbID.ValueMember = "ID";
            cbID.SelectedIndex = -1;
            cbID.SelectedValueChanged += cbID_SelectedValueChanged;

            string id;
            bool isMaGiaHanExisted = true;
            while (isMaGiaHanExisted)
            {
                id = GenerateID();
                isMaGiaHanExisted = check(id);
                txtIDGiaHan.Text = id;
            }
            cbID.Select();
        }

        private DataTable GetHSVV()
        {
            DataTable dtHSVV = new DataTable();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id FROM HoSoVayVon WHERE tenKH=@tenKH", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@tenKH", txtHoTen.Text.Trim());
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtHSVV.Load(reader);
                }
            }
            return dtHSVV;
        }

        private void cbID_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbID.SelectedValue != null)
            {
                string id = Convert.ToString(cbID.SelectedValue);
                string ngayTao = GetDate(id);
                txtNgayTao.Text = ngayTao.ToString();
                string kyHan = GetKyHan(id);
                txtKyHanCu.Text = kyHan.ToString();
            }
        }

        private string GetDate(string id)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ngayDangKy FROM HoSoVayVon WHERE id=@id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return ((DateTime)cmd.ExecuteScalar()).ToString("dd/MM/yyyy");
                }
            }
        }

        private string GetKyHan(string id)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT kyHan FROM HoSoVayVon WHERE id=@id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return ((Int16)cmd.ExecuteScalar()).ToString();
                }
            }
        }

        private bool check(string id)
        {
            bool MaGiaHanExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM GiaHanVayVon WHERE [id] = @id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    DataTable dtAnyData = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count > 0)
                    {
                        MaGiaHanExist = true;
                    }
                }
            }
            return MaGiaHanExist;
        }

        private string GenerateID()
        {
            string id;
            Random ran = new Random();
            long orderpart1 = ran.Next(100, 999);
            int orderpart2 = ran.Next(0, 99);
            id = "GH" + "-" + orderpart1 + "-" + orderpart2;
            return id;
        }

        private void showMain()
        {
            frmMainKhachHang main = new frmMainKhachHang();
            main.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                LuuThongTin((int)Save.save);
                Thread thread = new Thread(new ThreadStart(showMain));
                thread.Start();
                this.Dispose();
            }
        }

        private bool IsValidated()
        {
            if (cbID.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbID.Select();
                return false;
            }
            if (txtLyDo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu lý do.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLyDo.Focus();
                return false;
            }
            if (txtKyHanMoi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu kỳ hạn mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKyHanMoi.Focus();
                return false;
            }
            if(Convert.ToInt32(txtKyHanMoi.Text.Trim()) < Convert.ToInt32(txtKyHanCu.Text.Trim()))
            {
                MessageBox.Show("Kỳ hạn mới phải lớn hơn kỳ hạn cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKyHanMoi.Focus();
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [GiaHanVayVon](id,tenKH,maHoSo,lyDo,kyHanCu,kyHanMoi,ngayDangKy) VALUES (@id,@tenKH,@maHoSo,@lyDo,@kyHanCu,@kyHanMoi,@ngayDangKy)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtIDGiaHan.Text.Trim());
                        cmd.Parameters.AddWithValue("@tenKH", txtHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@maHoSo", cbID.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@lyDo", txtLyDo.Text.Trim());
                        cmd.Parameters.AddWithValue("@kyHanCu", txtKyHanCu.Text.Trim());
                        cmd.Parameters.AddWithValue("@kyHanMoi", txtKyHanMoi.Text.Trim());
                        cmd.Parameters.AddWithValue("@ngayDangKy", dateDangKy.Value.ToString("yyyy - MM - dd"));
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã gửi đăng ký gia hạn.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
