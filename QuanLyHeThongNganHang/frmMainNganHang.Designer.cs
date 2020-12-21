namespace QuanLyHeThongNganHang
{
    partial class frmMainNganHang
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
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.btnTaiSanTheChap = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnDuyetGiaHan = new System.Windows.Forms.Button();
            this.btnHoSoVayVon = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.gbServices.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(427, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG ĐIỀU KHIỂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.btnThanhLy);
            this.gbServices.Controls.Add(this.btnTaiSanTheChap);
            this.gbServices.Controls.Add(this.btnHopDong);
            this.gbServices.Controls.Add(this.btnDuyetGiaHan);
            this.gbServices.Controls.Add(this.btnHoSoVayVon);
            this.gbServices.Location = new System.Drawing.Point(12, 102);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(403, 367);
            this.gbServices.TabIndex = 1;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Dịch vụ:";
            // 
            // btnTaiSanTheChap
            // 
            this.btnTaiSanTheChap.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiSanTheChap.Location = new System.Drawing.Point(6, 223);
            this.btnTaiSanTheChap.Name = "btnTaiSanTheChap";
            this.btnTaiSanTheChap.Size = new System.Drawing.Size(391, 62);
            this.btnTaiSanTheChap.TabIndex = 3;
            this.btnTaiSanTheChap.Text = "Quản Lý Tài Sản Thế Chấp";
            this.btnTaiSanTheChap.UseVisualStyleBackColor = true;
            this.btnTaiSanTheChap.Click += new System.EventHandler(this.btnTaiSanTheChap_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.Location = new System.Drawing.Point(6, 155);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(391, 62);
            this.btnHopDong.TabIndex = 2;
            this.btnHopDong.Text = "Hợp Đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnDuyetGiaHan
            // 
            this.btnDuyetGiaHan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyetGiaHan.Location = new System.Drawing.Point(6, 87);
            this.btnDuyetGiaHan.Name = "btnDuyetGiaHan";
            this.btnDuyetGiaHan.Size = new System.Drawing.Size(391, 62);
            this.btnDuyetGiaHan.TabIndex = 1;
            this.btnDuyetGiaHan.Text = "Duyệt Gia Hạn Nợ";
            this.btnDuyetGiaHan.UseVisualStyleBackColor = true;
            this.btnDuyetGiaHan.Click += new System.EventHandler(this.btnDuyetGiaHan_Click);
            // 
            // btnHoSoVayVon
            // 
            this.btnHoSoVayVon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoVayVon.Location = new System.Drawing.Point(6, 19);
            this.btnHoSoVayVon.Name = "btnHoSoVayVon";
            this.btnHoSoVayVon.Size = new System.Drawing.Size(391, 62);
            this.btnHoSoVayVon.TabIndex = 0;
            this.btnHoSoVayVon.Text = "Hồ Sơ Vay Vốn";
            this.btnHoSoVayVon.UseVisualStyleBackColor = true;
            this.btnHoSoVayVon.Click += new System.EventHandler(this.btnHoSoVayVon_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátĐăngNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoátĐăngNhậpToolStripMenuItem
            // 
            this.thoátĐăngNhậpToolStripMenuItem.Name = "thoátĐăngNhậpToolStripMenuItem";
            this.thoátĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.thoátĐăngNhậpToolStripMenuItem.Text = "Thoát đăng nhập";
            this.thoátĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.thoátĐăngNhậpToolStripMenuItem_Click);
            // 
            // labelTenNV
            // 
            this.labelTenNV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTenNV.Location = new System.Drawing.Point(15, 76);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(403, 23);
            this.labelTenNV.TabIndex = 3;
            this.labelTenNV.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhLy.Location = new System.Drawing.Point(6, 291);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(391, 62);
            this.btnThanhLy.TabIndex = 4;
            this.btnThanhLy.Text = "Thanh Lý Hợp Đồng";
            this.btnThanhLy.UseVisualStyleBackColor = true;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // frmMainNganHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 481);
            this.ControlBox = false;
            this.Controls.Add(this.labelTenNV);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainNganHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Điều Khiển";
            this.gbServices.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnDuyetGiaHan;
        private System.Windows.Forms.Button btnHoSoVayVon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Button btnTaiSanTheChap;
        private System.Windows.Forms.Button btnThanhLy;
    }
}