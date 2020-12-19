using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyHeThongNganHang
{
    public partial class frmTaiSanTheChap : Form
    {
        private TaiSan_BUS tsBUS;

        public frmTaiSanTheChap()
        {
            InitializeComponent();
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
            List<TaiSan_DTO> listTaiSan = tsBUS.select();

            if (listTaiSan == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu từ database");
                return;
            }

            dgvView.Columns.Clear();
            dgvView.DataSource = null;

            dgvView.AutoGenerateColumns = false;
            dgvView.AllowUserToAddRows = false;
            this.dgvView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvView.DataSource = listTaiSan;

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

            DataGridViewTextBoxColumn clLyDo = new DataGridViewTextBoxColumn();
            clLyDo.Name = "taiSan";
            clLyDo.HeaderText = "Tài Sản";
            clLyDo.DataPropertyName = "taiSan";
            dgvView.Columns.Add(clLyDo);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvView.DataSource];
            myCurrencyManager.Refresh();
        }

        private void frmTaiSanTheChap_Load(object sender, EventArgs e)
        {
            tsBUS = new TaiSan_BUS();
            dgvView.DataSource = null;
            LoadTable();
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvView.Rows[e.RowIndex];
                labelMaHopDong.Text = row.Cells[0].Value.ToString();
                labelMaHoSo.Text = row.Cells[1].Value.ToString();
                labelTenKH.Text = row.Cells[2].Value.ToString();
                txtTaiSan.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
