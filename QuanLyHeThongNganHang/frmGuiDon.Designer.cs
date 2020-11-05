namespace QuanLyHeThongNganHang
{
    partial class frmGuiDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKhachHang = new System.Windows.Forms.Label();
            this.labelSoTien = new System.Windows.Forms.Label();
            this.labelNgayVay = new System.Windows.Forms.Label();
            this.labelKyHan = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtKyHan = new System.Windows.Forms.TextBox();
            this.dateDangKy = new System.Windows.Forms.DateTimePicker();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hồ Sơ Vay Vốn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelThang);
            this.panel1.Controls.Add(this.labelDonVi);
            this.panel1.Controls.Add(this.dateDangKy);
            this.panel1.Controls.Add(this.txtKyHan);
            this.panel1.Controls.Add(this.txtSoTien);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.labelNgayVay);
            this.panel1.Controls.Add(this.labelKyHan);
            this.panel1.Controls.Add(this.labelSoTien);
            this.panel1.Controls.Add(this.labelKhachHang);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 169);
            this.panel1.TabIndex = 1;
            // 
            // labelKhachHang
            // 
            this.labelKhachHang.AutoSize = true;
            this.labelKhachHang.Location = new System.Drawing.Point(3, 12);
            this.labelKhachHang.Name = "labelKhachHang";
            this.labelKhachHang.Size = new System.Drawing.Size(89, 13);
            this.labelKhachHang.TabIndex = 0;
            this.labelKhachHang.Text = "Tên khách hàng:";
            // 
            // labelSoTien
            // 
            this.labelSoTien.AutoSize = true;
            this.labelSoTien.Location = new System.Drawing.Point(3, 56);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(92, 13);
            this.labelSoTien.TabIndex = 1;
            this.labelSoTien.Text = "Số tiền muốn vay:";
            // 
            // labelNgayVay
            // 
            this.labelNgayVay.AutoSize = true;
            this.labelNgayVay.Location = new System.Drawing.Point(3, 144);
            this.labelNgayVay.Name = "labelNgayVay";
            this.labelNgayVay.Size = new System.Drawing.Size(97, 13);
            this.labelNgayVay.TabIndex = 3;
            this.labelNgayVay.Text = "Ngày đăng ký vay:";
            // 
            // labelKyHan
            // 
            this.labelKyHan.AutoSize = true;
            this.labelKyHan.Location = new System.Drawing.Point(3, 100);
            this.labelKyHan.Name = "labelKyHan";
            this.labelKyHan.Size = new System.Drawing.Size(92, 13);
            this.labelKyHan.TabIndex = 2;
            this.labelKyHan.Text = "Kỳ hạn muốn vay:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(98, 9);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(227, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(98, 53);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(138, 20);
            this.txtSoTien.TabIndex = 4;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKyHan
            // 
            this.txtKyHan.Location = new System.Drawing.Point(98, 97);
            this.txtKyHan.Name = "txtKyHan";
            this.txtKyHan.Size = new System.Drawing.Size(138, 20);
            this.txtKyHan.TabIndex = 5;
            this.txtKyHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateDangKy
            // 
            this.dateDangKy.Enabled = false;
            this.dateDangKy.Location = new System.Drawing.Point(98, 138);
            this.dateDangKy.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateDangKy.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateDangKy.Name = "dateDangKy";
            this.dateDangKy.Size = new System.Drawing.Size(227, 20);
            this.dateDangKy.TabIndex = 6;
            this.dateDangKy.Value = new System.DateTime(2020, 11, 6, 2, 31, 37, 0);
            // 
            // labelDonVi
            // 
            this.labelDonVi.AutoSize = true;
            this.labelDonVi.Location = new System.Drawing.Point(242, 56);
            this.labelDonVi.Name = "labelDonVi";
            this.labelDonVi.Size = new System.Drawing.Size(30, 13);
            this.labelDonVi.TabIndex = 7;
            this.labelDonVi.Text = "VNĐ";
            this.labelDonVi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Location = new System.Drawing.Point(242, 100);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(38, 13);
            this.labelThang.TabIndex = 8;
            this.labelThang.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vui lòng kiểm tra kỹ các thông tin. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dữ liệu sẽ không thể thay đổi sau khi nhấn \"Gửi\".";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(110, 249);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 56);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmGuiDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 317);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGuiDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Vay Vốn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelDonVi;
        private System.Windows.Forms.DateTimePicker dateDangKy;
        private System.Windows.Forms.TextBox txtKyHan;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label labelNgayVay;
        private System.Windows.Forms.Label labelKyHan;
        private System.Windows.Forms.Label labelSoTien;
        private System.Windows.Forms.Label labelKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}