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
            if (cbOther.Checked == true)
            {
                txtOther.Enabled = true;
                value.Add(txtOther.Text);
            }
            else if (cbOther.Checked == false)
            {
                txtOther.Enabled = false;
                value.Remove(txtOther.Text);
            }
                test.Text = string.Join(" | ", value);
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
    }
}
