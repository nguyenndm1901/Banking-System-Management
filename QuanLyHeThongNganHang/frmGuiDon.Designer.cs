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
            this.labelThang = new System.Windows.Forms.Label();
            this.labelDonVi = new System.Windows.Forms.Label();
            this.dateDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtKyHan = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.labelNgayVay = new System.Windows.Forms.Label();
            this.labelKyHan = new System.Windows.Forms.Label();
            this.labelSoTien = new System.Windows.Forms.Label();
            this.labelKhachHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
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
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 169);
            this.panel1.TabIndex = 1;
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
            // txtKyHan
            // 
            this.txtKyHan.Location = new System.Drawing.Point(98, 97);
            this.txtKyHan.Name = "txtKyHan";
            this.txtKyHan.Size = new System.Drawing.Size(138, 20);
            this.txtKyHan.TabIndex = 5;
            this.txtKyHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(98, 53);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(138, 20);
            this.txtSoTien.TabIndex = 4;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(98, 9);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(227, 20);
            this.txtTenKH.TabIndex = 2;
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
            // labelSoTien
            // 
            this.labelSoTien.AutoSize = true;
            this.labelSoTien.Location = new System.Drawing.Point(3, 56);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(92, 13);
            this.labelSoTien.TabIndex = 1;
            this.labelSoTien.Text = "Số tiền muốn vay:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vui lòng kiểm tra kỹ các thông tin. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 264);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(270, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dữ liệu sẽ không thể thay đổi sau khi nhấn \"Gửi\".";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(110, 297);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 56);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềToolStripMenuItem
            // 
            this.quayVềToolStripMenuItem.Name = "quayVềToolStripMenuItem";
            this.quayVềToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayVềToolStripMenuItem.Text = "Quay về";
            this.quayVềToolStripMenuItem.Click += new System.EventHandler(this.quayVềToolStripMenuItem_Click);
            // 
            // frmGuiDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 365);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGuiDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Vay Vốn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
    }
}