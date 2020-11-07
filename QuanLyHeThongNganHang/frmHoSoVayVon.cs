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
    public partial class frmHoSoVayVon : Form
    {
        public delegate void sendName(string tenNV);
        public sendName Sender;
        private HoSo_BUS hsBUS;
        public frmHoSoVayVon()
        {
            InitializeComponent();
            Sender = new sendName(getName);
        }

        private void getName(string tenNV)
        {
            labelTenNV.Text = tenNV;
        }

        private void showMain()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void quayVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showMain));
            thread.Start();
            this.Dispose();
        }

        private void LoadTable()
        {
            List<HoSo_DTO> listHoSo = hsBUS.select();

            if(listHoSo == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu từ database");
                return;
            }

            dgvView.Columns.Clear();
            dgvView.DataSource = null;

            dgvView.AutoGenerateColumns = false;
            dgvView.AllowUserToAddRows = false;
            dgvView.DataSource = listHoSo;

            DataGridViewTextBoxColumn clID = new DataGridViewTextBoxColumn();
            clID.Name = "id";
            clID.HeaderText = "ID";
            clID.DataPropertyName = "id";
            dgvView.Columns.Add(clID);

            DataGridViewTextBoxColumn clTenKH = new DataGridViewTextBoxColumn();
            clTenKH.Name = "tenKH";
            clTenKH.HeaderText = "Tên Khách Hàng";
            clTenKH.DataPropertyName = "tenKH";
            dgvView.Columns.Add(clTenKH);

            DataGridViewTextBoxColumn clSoTien = new DataGridViewTextBoxColumn();
            clSoTien.Name = "soTien";
            clSoTien.HeaderText = "Số Tiền";
            clSoTien.DataPropertyName = "soTien";
            dgvView.Columns.Add(clSoTien);

            DataGridViewTextBoxColumn clNgayDangKy = new DataGridViewTextBoxColumn();
            clNgayDangKy.Name = "ngayDangKy";
            clNgayDangKy.HeaderText = "Ngày Đăng Ký";
            clNgayDangKy.DataPropertyName = "ngayDangKy";
            dgvView.Columns.Add(clNgayDangKy);

            DataGridViewTextBoxColumn clKyHan = new DataGridViewTextBoxColumn();
            clKyHan.Name = "kyHan";
            clKyHan.HeaderText = "Kỳ Hạn";
            clKyHan.DataPropertyName = "kyHan";
            dgvView.Columns.Add(clKyHan);

            DataGridViewTextBoxColumn clNhanVienDuyet = new DataGridViewTextBoxColumn();
            clNhanVienDuyet.Name = "nhanVienDuyet";
            clNhanVienDuyet.HeaderText = "Nhân Viên Duyệt";
            clNhanVienDuyet.DataPropertyName = "nhanVienDuyet";
            dgvView.Columns.Add(clNhanVienDuyet);

            DataGridViewTextBoxColumn clTinhTrang = new DataGridViewTextBoxColumn();
            clTinhTrang.Name = "tinhTrang";
            clTinhTrang.HeaderText = "Tình Trạng";
            clTinhTrang.DataPropertyName = "tinhTrang";
            dgvView.Columns.Add(clTinhTrang);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvView.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmHoSoVayVon_Load(object sender, EventArgs e)
        {
            //Sender = new sendName(getName);
            hsBUS = new HoSo_BUS();
            dgvView.DataSource = null;
            LoadTable();
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvView.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtTienVay.Text = row.Cells[2].Value.ToString();
                txtNgayDangKy.Text = row.Cells[3].Value.ToString();
                txtKyHan.Text = row.Cells[4].Value.ToString();
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE [HoSoVayVon] SET nhanVienDuyet = @nhanVienDuyet, tinhTrang = 'Accepted' WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@nhanVienDuyet", labelTenNV.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE [HoSoVayVon] SET nhanVienDuyet = @nhanVienDuyet, tinhTrang = 'Rejected' WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@nhanVienDuyet", labelTenNV.Text);
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Từ chối thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private List<HoSo_DTO> HoSo = new List<HoSo_DTO>();

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            LuuThongTinDuyet((int)Save.save);
            txtID.Clear();
            txtTenKH.Clear();
            txtNgayDangKy.Clear();
            txtTienVay.Clear();
            txtKyHan.Clear();
            LoadTable();
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            LuuThongTinTuChoi((int)Save.save);
            txtID.Clear();
            txtTenKH.Clear();
            txtNgayDangKy.Clear();
            txtTienVay.Clear();
            txtKyHan.Clear();
            LoadTable();
        }
    }
}
