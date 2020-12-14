
namespace QuanLyHeThongNganHang
{
    partial class frmDuyetGiaHan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKyHanMoi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelKyHanCu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelLyDo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMaHoSo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDuyet = new System.Windows.Forms.DataGridView();
            this.labelNgayDK = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.brnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duyệt Gia Hạn Nợ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềToolStripMenuItem
            // 
            this.quayVềToolStripMenuItem.Name = "quayVềToolStripMenuItem";
            this.quayVềToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayVềToolStripMenuItem.Text = "Quay về";
            this.quayVềToolStripMenuItem.Click += new System.EventHandler(this.quayVềToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaDon);
            this.groupBox1.Controls.Add(this.labelNgayDK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelKyHanMoi);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelKyHanCu);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labelLyDo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelMaHoSo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 195);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelKyHanMoi
            // 
            this.labelKyHanMoi.Location = new System.Drawing.Point(490, 154);
            this.labelKyHanMoi.Name = "labelKyHanMoi";
            this.labelKyHanMoi.Size = new System.Drawing.Size(121, 20);
            this.labelKyHanMoi.TabIndex = 13;
            this.labelKyHanMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Kỳ Hạn Mới:";
            // 
            // labelKyHanCu
            // 
            this.labelKyHanCu.Location = new System.Drawing.Point(490, 117);
            this.labelKyHanCu.Name = "labelKyHanCu";
            this.labelKyHanCu.Size = new System.Drawing.Size(121, 20);
            this.labelKyHanCu.TabIndex = 11;
            this.labelKyHanCu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(421, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Kỳ Hạn Cũ:";
            // 
            // labelLyDo
            // 
            this.labelLyDo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLyDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLyDo.Location = new System.Drawing.Point(92, 80);
            this.labelLyDo.Name = "labelLyDo";
            this.labelLyDo.Size = new System.Drawing.Size(294, 75);
            this.labelLyDo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lý Do Gia Hạn:";
            // 
            // labelMaHoSo
            // 
            this.labelMaHoSo.Location = new System.Drawing.Point(490, 45);
            this.labelMaHoSo.Name = "labelMaHoSo";
            this.labelMaHoSo.Size = new System.Drawing.Size(121, 20);
            this.labelMaHoSo.TabIndex = 7;
            this.labelMaHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã Hồ Sơ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Đơn:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.Location = new System.Drawing.Point(75, 45);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(340, 20);
            this.labelTenKH.TabIndex = 3;
            this.labelTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng:";
            // 
            // labelTenNV
            // 
            this.labelTenNV.Location = new System.Drawing.Point(75, 12);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(340, 20);
            this.labelTenNV.TabIndex = 1;
            this.labelTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân Viên: ";
            // 
            // dgvDuyet
            // 
            this.dgvDuyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyet.Location = new System.Drawing.Point(12, 298);
            this.dgvDuyet.Name = "dgvDuyet";
            this.dgvDuyet.Size = new System.Drawing.Size(647, 200);
            this.dgvDuyet.TabIndex = 3;
            this.dgvDuyet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuyet_CellClick);
            // 
            // labelNgayDK
            // 
            this.labelNgayDK.Location = new System.Drawing.Point(506, 80);
            this.labelNgayDK.Name = "labelNgayDK";
            this.labelNgayDK.Size = new System.Drawing.Size(105, 20);
            this.labelNgayDK.TabIndex = 15;
            this.labelNgayDK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày Đăng Ký:";
            // 
            // brnReject
            // 
            this.brnReject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnReject.Location = new System.Drawing.Point(568, 259);
            this.brnReject.Name = "brnReject";
            this.brnReject.Size = new System.Drawing.Size(91, 33);
            this.brnReject.TabIndex = 4;
            this.brnReject.Text = "Reject";
            this.brnReject.UseVisualStyleBackColor = true;
            this.brnReject.Click += new System.EventHandler(this.brnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(471, 259);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(91, 33);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtMaDon
            // 
            this.txtMaDon.Enabled = false;
            this.txtMaDon.Location = new System.Drawing.Point(511, 13);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(100, 20);
            this.txtMaDon.TabIndex = 16;
            // 
            // frmDuyetGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 510);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.brnReject);
            this.Controls.Add(this.dgvDuyet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDuyetGiaHan";
            this.Text = "Duyệt Gia Hạn";
            this.Load += new System.EventHandler(this.frmDuyetGiaHan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelLyDo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMaHoSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelKyHanMoi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelKyHanCu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDuyet;
        private System.Windows.Forms.Label labelNgayDK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtMaDon;
    }
}