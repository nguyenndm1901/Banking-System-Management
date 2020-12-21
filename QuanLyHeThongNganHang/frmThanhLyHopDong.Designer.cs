
namespace QuanLyHeThongNganHang
{
    partial class frmThanhLyHopDong
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMaHopDong = new System.Windows.Forms.Label();
            this.labelMaHoSo = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.labelSoTien = new System.Windows.Forms.Label();
            this.labelKyHan = new System.Windows.Forms.Label();
            this.txtTaiSan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThanhLy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(12, 153);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(766, 159);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh Lý Hợp Đồng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềToolStripMenuItem
            // 
            this.quayVềToolStripMenuItem.Name = "quayVềToolStripMenuItem";
            this.quayVềToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayVềToolStripMenuItem.Text = "Quay về";
            this.quayVềToolStripMenuItem.Click += new System.EventHandler(this.quayVềToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã hợp đồng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã hồ sơ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên khách hàng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(379, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số tiền:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(379, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kỳ hạn:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(379, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tài sản thế chấp:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaHopDong
            // 
            this.labelMaHopDong.Location = new System.Drawing.Point(118, 62);
            this.labelMaHopDong.Name = "labelMaHopDong";
            this.labelMaHopDong.Size = new System.Drawing.Size(255, 23);
            this.labelMaHopDong.TabIndex = 9;
            this.labelMaHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaHoSo
            // 
            this.labelMaHoSo.Location = new System.Drawing.Point(118, 85);
            this.labelMaHoSo.Name = "labelMaHoSo";
            this.labelMaHoSo.Size = new System.Drawing.Size(255, 23);
            this.labelMaHoSo.TabIndex = 10;
            this.labelMaHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenKH
            // 
            this.labelTenKH.Location = new System.Drawing.Point(118, 108);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(255, 23);
            this.labelTenKH.TabIndex = 11;
            this.labelTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoTien
            // 
            this.labelSoTien.Location = new System.Drawing.Point(485, 62);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(147, 23);
            this.labelSoTien.TabIndex = 12;
            this.labelSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKyHan
            // 
            this.labelKyHan.Location = new System.Drawing.Point(485, 85);
            this.labelKyHan.Name = "labelKyHan";
            this.labelKyHan.Size = new System.Drawing.Size(147, 23);
            this.labelKyHan.TabIndex = 13;
            this.labelKyHan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaiSan
            // 
            this.txtTaiSan.Location = new System.Drawing.Point(488, 111);
            this.txtTaiSan.Multiline = true;
            this.txtTaiSan.Name = "txtTaiSan";
            this.txtTaiSan.ReadOnly = true;
            this.txtTaiSan.Size = new System.Drawing.Size(290, 36);
            this.txtTaiSan.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(638, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "VNĐ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(638, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "tháng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Location = new System.Drawing.Point(661, 318);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(117, 26);
            this.btnThanhLy.TabIndex = 17;
            this.btnThanhLy.Text = "Thanh lý";
            this.btnThanhLy.UseVisualStyleBackColor = true;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // frmThanhLyHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 356);
            this.ControlBox = false;
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTaiSan);
            this.Controls.Add(this.labelKyHan);
            this.Controls.Add(this.labelSoTien);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.labelMaHoSo);
            this.Controls.Add(this.labelMaHopDong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmThanhLyHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Lý Hợp Đồng";
            this.Load += new System.EventHandler(this.frmThanhLyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMaHopDong;
        private System.Windows.Forms.Label labelMaHoSo;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label labelSoTien;
        private System.Windows.Forms.Label labelKyHan;
        private System.Windows.Forms.TextBox txtTaiSan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThanhLy;
    }
}