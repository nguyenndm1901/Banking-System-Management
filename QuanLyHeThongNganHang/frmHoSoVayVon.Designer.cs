namespace QuanLyHeThongNganHang
{
    partial class frmHoSoVayVon
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
            this.labelHSVV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtNgayDangKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKyHan = new System.Windows.Forms.TextBox();
            this.txtTienVay = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.labelKyHanVay = new System.Windows.Forms.Label();
            this.labelNgayDangKy = new System.Windows.Forms.Label();
            this.labelSoTienVay = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHSVV
            // 
            this.labelHSVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHSVV.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHSVV.Location = new System.Drawing.Point(0, 24);
            this.labelHSVV.Name = "labelHSVV";
            this.labelHSVV.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelHSVV.Size = new System.Drawing.Size(783, 57);
            this.labelHSVV.TabIndex = 0;
            this.labelHSVV.Text = "Hồ Sơ Vay Vốn";
            this.labelHSVV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.txtNgayDangKy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtKyHan);
            this.panel1.Controls.Add(this.txtTienVay);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.labelKyHanVay);
            this.panel1.Controls.Add(this.labelNgayDangKy);
            this.panel1.Controls.Add(this.labelSoTienVay);
            this.panel1.Controls.Add(this.labelTenKH);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 79);
            this.panel1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 11;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, 12);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(58, 13);
            this.labelID.TabIndex = 10;
            this.labelID.Text = "Mã Hồ Sơ:";
            // 
            // txtNgayDangKy
            // 
            this.txtNgayDangKy.Location = new System.Drawing.Point(631, 52);
            this.txtNgayDangKy.Name = "txtNgayDangKy";
            this.txtNgayDangKy.ReadOnly = true;
            this.txtNgayDangKy.Size = new System.Drawing.Size(99, 20);
            this.txtNgayDangKy.TabIndex = 9;
            this.txtNgayDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng";
            // 
            // txtKyHan
            // 
            this.txtKyHan.Location = new System.Drawing.Point(372, 52);
            this.txtKyHan.Name = "txtKyHan";
            this.txtKyHan.ReadOnly = true;
            this.txtKyHan.Size = new System.Drawing.Size(99, 20);
            this.txtKyHan.TabIndex = 6;
            this.txtKyHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTienVay
            // 
            this.txtTienVay.Location = new System.Drawing.Point(77, 52);
            this.txtTienVay.Name = "txtTienVay";
            this.txtTienVay.ReadOnly = true;
            this.txtTienVay.Size = new System.Drawing.Size(167, 20);
            this.txtTienVay.TabIndex = 5;
            this.txtTienVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(409, 9);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(321, 20);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKyHanVay
            // 
            this.labelKyHanVay.AutoSize = true;
            this.labelKyHanVay.Location = new System.Drawing.Point(300, 55);
            this.labelKyHanVay.Name = "labelKyHanVay";
            this.labelKyHanVay.Size = new System.Drawing.Size(66, 13);
            this.labelKyHanVay.TabIndex = 4;
            this.labelKyHanVay.Text = "Kỳ Hạn Vay:";
            // 
            // labelNgayDangKy
            // 
            this.labelNgayDangKy.AutoSize = true;
            this.labelNgayDangKy.Location = new System.Drawing.Point(546, 55);
            this.labelNgayDangKy.Name = "labelNgayDangKy";
            this.labelNgayDangKy.Size = new System.Drawing.Size(79, 13);
            this.labelNgayDangKy.TabIndex = 2;
            this.labelNgayDangKy.Text = "Ngày Đăng Ký:";
            // 
            // labelSoTienVay
            // 
            this.labelSoTienVay.AutoSize = true;
            this.labelSoTienVay.Location = new System.Drawing.Point(3, 55);
            this.labelSoTienVay.Name = "labelSoTienVay";
            this.labelSoTienVay.Size = new System.Drawing.Size(68, 13);
            this.labelSoTienVay.TabIndex = 1;
            this.labelSoTienVay.Text = "Số Tiền Vay:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(300, 12);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(92, 13);
            this.labelTenKH.TabIndex = 0;
            this.labelTenKH.Text = "Tên Khách Hàng:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềToolStripMenuItem
            // 
            this.quayVềToolStripMenuItem.Name = "quayVềToolStripMenuItem";
            this.quayVềToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quayVềToolStripMenuItem.Text = "Quay Về";
            this.quayVềToolStripMenuItem.Click += new System.EventHandler(this.quayVềToolStripMenuItem_Click);
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 216);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(759, 260);
            this.dgvView.TabIndex = 10;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nhân Viên:";
            // 
            // labelTenNV
            // 
            this.labelTenNV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTenNV.Location = new System.Drawing.Point(78, 185);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(300, 19);
            this.labelTenNV.TabIndex = 12;
            this.labelTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.Location = new System.Drawing.Point(522, 169);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(88, 41);
            this.btnDuyet.TabIndex = 13;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.Location = new System.Drawing.Point(680, 169);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(88, 41);
            this.btnTuChoi.TabIndex = 14;
            this.btnTuChoi.Text = "Từ Chối";
            this.btnTuChoi.UseVisualStyleBackColor = true;
            this.btnTuChoi.Click += new System.EventHandler(this.btnTuChoi_Click);
            // 
            // frmHoSoVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 488);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.labelTenNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHSVV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoSoVayVon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ Sơ Vay Vốn";
            this.Load += new System.EventHandler(this.frmHoSoVayVon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHSVV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKyHan;
        private System.Windows.Forms.TextBox txtTienVay;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label labelKyHanVay;
        private System.Windows.Forms.Label labelNgayDangKy;
        private System.Windows.Forms.Label labelSoTienVay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNgayDangKy;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnTuChoi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
    }
}