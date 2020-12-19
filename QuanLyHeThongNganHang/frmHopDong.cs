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
    public partial class frmHopDong : Form
    {
        public delegate void sendName(string tenKH);
        public sendName SenderName;
        public delegate void sendMaHoSo(string maHoSo);
        public sendMaHoSo SenderMaHoSo;

        public frmHopDong()
        {
            InitializeComponent();
            SenderName = new sendName(getName);
            SenderMaHoSo = new sendMaHoSo(getMaHoSo);
            cbOther.Enabled = false;
        }

        private void getName(string tenKH)
        {
            labelTenKH.Text = tenKH;
        }
        private void getMaHoSo(string maHoSo)
        {
            labelMaHoSo.Text = maHoSo;
            string id = labelMaHoSo.Text;
            string soTien = GetSoTien(id);
            labelSoTien.Text = soTien.ToString();
            long a;
            long.TryParse(labelSoTien.Text.Trim(), out a);
            labelSoTien.Text = string.Format("{0:n0}", a);
            string kyHan = GetKyHan(id);
            labelKyHan.Text = kyHan.ToString();
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

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            string id;
            bool isMaHoSoExisted = true;
            while (isMaHoSoExisted)
            {
                id = GenerateID();
                isMaHoSoExisted = check(id);
                labelMaHopDong.Text = id;
            }
            cbAgree.Focus();
        }

        private void cbAgree_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAgree.Checked == true)
            {
                btnCreate.Enabled = true;
            }
            else if (cbAgree.Checked == false)
            {
                btnCreate.Enabled = false;
            }
        }

        private bool check(string id)
        {
            bool MaHoSoExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HopDong WHERE [id] = @id", cnn))
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
            id = "HD" + "-" + orderpart1 + "-" + orderpart2;
            return id;
        }

        private string GetSoTien(string id)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT soTien FROM HoSoVayVon WHERE id=@id", cnn))
                {
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteScalar().ToString();
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
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        private void updateTextBox()
        {
            var value = new List<string>();
            if (cbSoDo.Checked)
            {
                value.Add("Sổ đỏ");
            }
            if (cbCar.Checked)
            {
                value.Add("Xe ô tô");
            }
            if (cbMoto.Checked)
            {
                value.Add("Xe máy");
            }
            if (cbCoPhieu.Checked)
            {
                value.Add("Cổ phiếu");
            }
            if (cbTraiPhieu.Checked)
            {
                value.Add("Trái phiếu");
            }
            if (cbOther.Checked)
            {
                value.Add(txtOther.Text);            
            }
                txtTaiSan.Text = string.Join(" | ", value);
        }

        private void cbSoDo_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void cbCar_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void cbMoto_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void cbCoPhieu_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void cbTraiPhieu_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private void cbOther_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBox();
        }

        private string maHoSo = "";

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                maHoSo = labelMaHoSo.Text;
                if (checkDuplicated(maHoSo))
                {
                    MessageBox.Show("Hồ sơ đã tạo hợp đồng trước đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LuuThongTin((int)Save.save);
                }
            }
        }

        public enum Save
        {
            save = 1,
        }

        private bool IsValidated()
        {
            if (txtTaiSan.Text.Trim() == "")
            {
                MessageBox.Show("Đánh dấu vào một hoặc nhiều loại tài sản để thế chấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((cbOther.Checked == false) && (txtOther.Text.Trim() != ""))
            {
                MessageBox.Show("Vui lòng đánh dấu vào ô 'Khác'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((cbOther.Checked == true) && (txtOther.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng điền tài sản để thế chấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LuuThongTin(int luu)
        {
            try
            {
                string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [HopDong](id,maHoSo,benA,benB,soTien,kyHan,taiSan) VALUES (@id,@maHoSo,@benA,@benB,@soTien,@kyHan,@taiSan)", cnn))
                    {
                        cmd.Parameters.AddWithValue("@id", labelMaHopDong.Text.Trim());
                        cmd.Parameters.AddWithValue("@maHoSo", labelMaHoSo.Text.Trim());
                        cmd.Parameters.AddWithValue("@benA", labelTenNH.Text.Trim());
                        cmd.Parameters.AddWithValue("@benB", labelTenKH.Text.Trim());
                        cmd.Parameters.AddWithValue("@soTien", labelSoTien.Text.Trim());
                        cmd.Parameters.AddWithValue("@kyHan", labelKyHan.Text.Trim());
                        cmd.Parameters.AddWithValue("@taiSan", txtTaiSan.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Tạo hợp đồng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {
            if(txtOther.Text.Trim() != "")
            {
                cbOther.Enabled = true;
            }
            else if(txtOther.Text.Trim() == "")
            {
                cbOther.Enabled = false;
            }
        }

        private bool checkDuplicated(string id)
        {
            bool MaHoSoExist = false;
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (SqlConnection cnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HopDong WHERE [maHoSo] = @id", cnn))
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
    }
}
