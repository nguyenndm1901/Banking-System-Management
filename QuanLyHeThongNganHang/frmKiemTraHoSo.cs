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
    public partial class frmKiemTraHoSo : Form
    {
        public frmKiemTraHoSo()
        {
            InitializeComponent();
        }

        private static string tenKH = "";
        private static string maHoSo = "";

        private void showHopDong()
        {
            frmHopDong hd = new frmHopDong();
            hd.SenderName(tenKH);
            hd.SenderMaHoSo(maHoSo);
            hd.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if((labelTinhTrang.Text == "Rejected") || (labelTinhTrang.Text == "Đang chờ"))
            {
                MessageBox.Show("Hồ sơ không hợp lệ để tạo hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cbMaHoSo.SelectedIndex = -1;
                //labelTinhTrang.Text = "";
                //labelTenNV.Text = "";
            }
            else if(labelTinhTrang.Text == "")
            {
                MessageBox.Show("Yêu cầu chọn đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (labelTinhTrang.Text == "Accepted")
            {
                if (IsValidated())
                {
                    Thread thread = new Thread(new ThreadStart(showHopDong));
                    tenKH = cbTenKH.Text;
                    maHoSo = cbMaHoSo.Text;
                    thread.Start();
                    this.Dispose();
                }
            }
        }

        private void frmKiemTraHoSo_Load(object sender, EventArgs e)
        {
            GetTenKH();
        }

        private void GetTenKH()
        {
            string lines = "SELECT DISTINCT tenKH FROM HoSoVayVon";
            DataTable dtTenKH = new DataTable();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(lines, cnn))
                {
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(dtTenKH);
                        cbTenKH.SelectedIndexChanged -= cbTenKH_SelectedIndexChanged;
                        cbTenKH.DataSource = dtTenKH;
                        cbTenKH.DisplayMember = "tenKH";
                        cbTenKH.ValueMember = "tenKH";
                        cbTenKH.SelectedIndex = -1;
                        cbTenKH.SelectedIndexChanged += cbTenKH_SelectedIndexChanged;
                    }
                }
            }
        }

        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTenKH.SelectedValue.ToString()))
            {
                GetHSVV();
                labelTinhTrang.Text = "";
                labelTenNV.Text = "";
            }
        }

        private void cbMaHoSo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbTenKH.SelectedValue != null)
            {
                string id = Convert.ToString(cbMaHoSo.SelectedValue);
                string tinhTrang = GetTinhTrang(id);
                labelTinhTrang.Text = tinhTrang.ToString();
                string nhanVien = GetNhanVien(id);
                labelTenNV.Text = nhanVien.ToString();
            }
        }

        private string GetTinhTrang(string id)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT tinhTrang FROM HoSoVayVon WHERE id=@id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        private string GetNhanVien(string id)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT nhanVienDuyet FROM HoSoVayVon WHERE id=@id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        private void GetHSVV()
        {
            string lines = "SELECT id FROM HoSoVayVon WHERE tenKH=@tenKH";
            DataTable dtHSVV = new DataTable();
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(lines, cnn))
                {
                    cmd.Parameters.AddWithValue("@tenKH", cbTenKH.SelectedValue.ToString());
                    using(SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        adp.Fill(dtHSVV);
                        cbMaHoSo.SelectedValueChanged -= cbMaHoSo_SelectedValueChanged;
                        cbMaHoSo.DataSource = dtHSVV;
                        cbMaHoSo.DisplayMember = "id";
                        cbMaHoSo.ValueMember = "id";
                        cbMaHoSo.SelectedIndex = -1;
                        cbMaHoSo.SelectedValueChanged += cbMaHoSo_SelectedValueChanged;
                    }
                }
            }
        }

        private bool IsValidated()
        {
            if (cbTenKH.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTenKH.Select();
                return false;
            }
            if (cbMaHoSo.SelectedIndex == -1)
            {
                MessageBox.Show("Yêu cầu chọn mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbMaHoSo.Select();
                return false;
            }
            if (labelTinhTrang.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu kiểm tra cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (labelTenNV.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Yêu cầu kiểm tra cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void showMain()
        {
            frmMainNganHang main = new frmMainNganHang();
            main.ShowDialog();
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(showMain));
            thread.Start();
            this.Dispose();
        }
    }
}
