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
    public partial class frmThanhLyHopDong : Form
    {
        public frmThanhLyHopDong()
        {
            InitializeComponent();
        }

        private HopDong_BUS hdBUS;

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvView.Rows[e.RowIndex];
                labelMaHopDong.Text = row.Cells[0].Value.ToString();
                labelMaHoSo.Text = row.Cells[1].Value.ToString();
                labelTenKH.Text = row.Cells[2].Value.ToString();
                labelSoTien.Text = row.Cells[3].Value.ToString();
                labelKyHan.Text = row.Cells[4].Value.ToString();
                txtTaiSan.Text = row.Cells[5].Value.ToString();
            }
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
            List<HopDong_DTO> listHopDong = hdBUS.select();

            if (listHopDong == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu từ database");
                return;
            }

            dgvView.Columns.Clear();
            dgvView.DataSource = null;

            dgvView.AutoGenerateColumns = false;
            dgvView.AllowUserToAddRows = false;
            this.dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView.DataSource = listHopDong;

            DataGridViewTextBoxColumn clID = new DataGridViewTextBoxColumn();
            clID.Name = "id";
            clID.HeaderText = "Mã Hợp Đồng";
            clID.DataPropertyName = "id";
            dgvView.Columns.Add(clID);

            DataGridViewTextBoxColumn clMaHoSo = new DataGridViewTextBoxColumn();
            clMaHoSo.Name = "maHoSo";
            clMaHoSo.HeaderText = "Mã Hồ Sơ";
            clMaHoSo.DataPropertyName = "maHoSo";
            dgvView.Columns.Add(clMaHoSo);

            DataGridViewTextBoxColumn clTenKH = new DataGridViewTextBoxColumn();
            clTenKH.Name = "benB";
            clTenKH.HeaderText = "Tên Khách Hàng";
            clTenKH.DataPropertyName = "benB";
            dgvView.Columns.Add(clTenKH);

            DataGridViewTextBoxColumn clSoTien = new DataGridViewTextBoxColumn();
            clSoTien.Name = "soTien";
            clSoTien.HeaderText = "Số Tiền";
            clSoTien.DataPropertyName = "soTien";
            dgvView.Columns.Add(clSoTien);

            DataGridViewTextBoxColumn clKyHan = new DataGridViewTextBoxColumn();
            clKyHan.Name = "kyHan";
            clKyHan.HeaderText = "Kỳ Hạn";
            clKyHan.DataPropertyName = "kyHan";
            dgvView.Columns.Add(clKyHan);

            DataGridViewTextBoxColumn clLyDo = new DataGridViewTextBoxColumn();
            clLyDo.Name = "taiSan";
            clLyDo.HeaderText = "Tài Sản";
            clLyDo.DataPropertyName = "taiSan";
            dgvView.Columns.Add(clLyDo);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvView.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmThanhLyHopDong_Load(object sender, EventArgs e)
        {
            hdBUS = new HopDong_BUS();
            dgvView.DataSource = null;
            LoadTable();
        }

        public enum Save
        {
            save = 1,
        }

        private void ThanhLyHopDong(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [HopDong] WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", labelMaHopDong.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [GiaHanVayVon] WHERE maHoSo = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", labelMaHoSo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [HoSoVayVon] WHERE id = @id", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", labelMaHoSo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thanh lý thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            ThanhLyHopDong((int)Save.save);
            labelMaHopDong.Text = "";
            labelMaHoSo.Text = "";
            labelTenKH.Text = "";
            labelSoTien.Text = "";
            labelKyHan.Text = "";
            txtTaiSan.Text = "";
            LoadTable();
        }
    }
}
