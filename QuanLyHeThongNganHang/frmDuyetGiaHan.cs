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
    public partial class frmDuyetGiaHan : Form
    {
        public delegate void sendName(string tenNV);
        public sendName Sender;
        private GiaHan_BUS ghBUS;

        public frmDuyetGiaHan()
        {
            InitializeComponent();
            Sender = new sendName(getName);
        }

        private void getName(string tenNV)
        {
            labelTenNV.Text = tenNV;
        }

        public static string tenNV = "";
        private void Main()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.Sender(tenNV);
            main.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenNV = labelTenNV.Text;
            Thread thread = new Thread(new ThreadStart(Main));
            thread.Start();
            this.Dispose();
        }

        private void LoadTable()
        {
            List<GiaHan_DTO> listGiaHan = ghBUS.select();

            if (listGiaHan == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu từ database");
                return;
            }

            dgvDuyet.Columns.Clear();
            dgvDuyet.DataSource = null;

            dgvDuyet.AutoGenerateColumns = false;
            dgvDuyet.AllowUserToAddRows = false;
            dgvDuyet.DataSource = listGiaHan;

            DataGridViewTextBoxColumn clID = new DataGridViewTextBoxColumn();
            clID.Name = "id";
            clID.HeaderText = "ID";
            clID.DataPropertyName = "id";
            dgvDuyet.Columns.Add(clID);

            DataGridViewTextBoxColumn clTenKH = new DataGridViewTextBoxColumn();
            clTenKH.Name = "tenKH";
            clTenKH.HeaderText = "Tên Khách Hàng";
            clTenKH.DataPropertyName = "tenKH";
            dgvDuyet.Columns.Add(clTenKH);

            DataGridViewTextBoxColumn clMaHoSo = new DataGridViewTextBoxColumn();
            clMaHoSo.Name = "maHoSo";
            clMaHoSo.HeaderText = "Mã Hồ Sơ";
            clMaHoSo.DataPropertyName = "maHoSo";
            dgvDuyet.Columns.Add(clMaHoSo);

            DataGridViewTextBoxColumn clLyDo = new DataGridViewTextBoxColumn();
            clLyDo.Name = "lyDo";
            clLyDo.HeaderText = "Lý Do";
            clLyDo.DataPropertyName = "lyDo";
            dgvDuyet.Columns.Add(clLyDo);

            DataGridViewTextBoxColumn clKyHanCu = new DataGridViewTextBoxColumn();
            clKyHanCu.Name = "kyHanCu";
            clKyHanCu.HeaderText = "Kỳ Hạn Cũ";
            clKyHanCu.DataPropertyName = "kyHanCu";
            dgvDuyet.Columns.Add(clKyHanCu);

            DataGridViewTextBoxColumn clKyHanMoi = new DataGridViewTextBoxColumn();
            clKyHanMoi.Name = "kyHanMoi";
            clKyHanMoi.HeaderText = "Kỳ Hạn Mới";
            clKyHanMoi.DataPropertyName = "kyHanMoi";
            dgvDuyet.Columns.Add(clKyHanMoi);

            DataGridViewTextBoxColumn clNgayDangKy = new DataGridViewTextBoxColumn();
            clNgayDangKy.Name = "ngayDangKy";
            clNgayDangKy.HeaderText = "Ngày Đăng Ký";
            clNgayDangKy.DataPropertyName = "ngayDangKy";
            dgvDuyet.Columns.Add(clNgayDangKy);

            DataGridViewTextBoxColumn clTinhTrang = new DataGridViewTextBoxColumn();
            clTinhTrang.Name = "tinhTrang";
            clTinhTrang.HeaderText = "Tình Trạng";
            clTinhTrang.DataPropertyName = "tinhTrang";
            dgvDuyet.Columns.Add(clTinhTrang);

            DataGridViewTextBoxColumn clNhanVienDuyet = new DataGridViewTextBoxColumn();
            clNhanVienDuyet.Name = "nhanVienDuyet";
            clNhanVienDuyet.HeaderText = "Nhân Viên Duyệt";
            clNhanVienDuyet.DataPropertyName = "nhanVienDuyet";
            dgvDuyet.Columns.Add(clNhanVienDuyet);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvDuyet.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmDuyetGiaHan_Load(object sender, EventArgs e)
        {
            ghBUS = new GiaHan_BUS();
            dgvDuyet.DataSource = null;
            LoadTable();
        }

        private void dgvDuyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDuyet.Rows[e.RowIndex];
                txtMaDon.Text = row.Cells[0].Value.ToString();
                labelTenKH.Text = row.Cells[1].Value.ToString();
                labelMaHoSo.Text = row.Cells[2].Value.ToString();
                labelLyDo.Text = row.Cells[3].Value.ToString();
                labelKyHanCu.Text = row.Cells[4].Value.ToString();
                labelKyHanMoi.Text = row.Cells[5].Value.ToString();
                labelNgayDK.Text = row.Cells[6].Value.ToString();
            }
        }

        public enum Save
        {
            save = 1,
        }

        private void LuuThongTinDuyet(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE [GiaHanVayVon] SET kyHanCu = @kyHanCu, kyHanMoi = '0', nhanVienDuyet = @nhanVienDuyet, tinhTrang = 'Accepted' WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@kyHanCu", labelKyHanMoi.Text);
                        cmd.Parameters.AddWithValue("@nhanVienDuyet", labelTenNV.Text);
                        cmd.Parameters.AddWithValue("@id", txtMaDon.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE [HoSoVayVon] SET kyHan = @kyHan WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@kyHan", labelKyHanMoi.Text);
                        cmd.Parameters.AddWithValue("@id", labelMaHoSo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Duyệt thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void LuuThongTinTuChoi(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE [GiaHanVayVon] SET kyHanCu = @kyHanCu, kyHanMoi = '0', nhanVienDuyet = @nhanVienDuyet, tinhTrang = 'Rejected' WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@kyHanCu", labelKyHanCu.Text);
                        cmd.Parameters.AddWithValue("@nhanVienDuyet", labelTenNV.Text);
                        cmd.Parameters.AddWithValue("@id", txtMaDon.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Từ chối thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(labelKyHanMoi.Text == "0")
            {
                MessageBox.Show("Thất bại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LuuThongTinDuyet((int)Save.save);
                txtMaDon.Text = "";
                labelTenKH.Text = "";
                labelMaHoSo.Text = "";
                labelLyDo.Text = "";
                labelKyHanCu.Text = "";
                labelKyHanMoi.Text = "";
                labelNgayDK.Text = "";
                LoadTable();
            }
        }

        private void brnReject_Click(object sender, EventArgs e)
        {
            if (labelKyHanMoi.Text == "0")
            {
                MessageBox.Show("Thất bại", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LuuThongTinTuChoi((int)Save.save);
                txtMaDon.Text = "";
                labelTenKH.Text = "";
                labelMaHoSo.Text = "";
                labelLyDo.Text = "";
                labelKyHanCu.Text = "";
                labelKyHanMoi.Text = "";
                labelNgayDK.Text = "";
                LoadTable();
            }
        }
    }
}
