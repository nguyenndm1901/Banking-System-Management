namespace QuanLyHeThongNganHang
{
    partial class frmTaiSanTheChap
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaHopDong = new System.Windows.Forms.Label();
            this.labelMaHoSo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiSan = new System.Windows.Forms.TextBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Sản Thế Chấp";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hợp đồng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaHopDong
            // 
            this.labelMaHopDong.Location = new System.Drawing.Point(109, 98);
            this.labelMaHopDong.Name = "labelMaHopDong";
            this.labelMaHopDong.Size = new System.Drawing.Size(247, 21);
            this.labelMaHopDong.TabIndex = 2;
            this.labelMaHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaHoSo
            // 
            this.labelMaHoSo.Location = new System.Drawing.Point(109, 133);
            this.labelMaHoSo.Name = "labelMaHoSo";
            this.labelMaHoSo.Size = new System.Drawing.Size(247, 21);
            this.labelMaHoSo.TabIndex = 4;
            this.labelMaHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã hồ sơ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenKH
            // 
            this.labelTenKH.Location = new System.Drawing.Point(109, 168);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(247, 21);
            this.labelTenKH.TabIndex = 8;
            this.labelTenKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 168);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 21);
            this.label.TabIndex = 7;
            this.label.Text = "Tên khách hàng:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayVềToolStripMenuItem
            // 
            this.quayVềToolStripMenuItem.Name = "quayVềToolStripMenuItem";
            this.quayVềToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayVềToolStripMenuItem.Text = "Quay về";
            this.quayVềToolStripMenuItem.Click += new System.EventHandler(this.quayVềToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(337, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tài sản:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaiSan
            // 
            this.txtTaiSan.Location = new System.Drawing.Point(434, 99);
            this.txtTaiSan.Multiline = true;
            this.txtTaiSan.Name = "txtTaiSan";
            this.txtTaiSan.ReadOnly = true;
            this.txtTaiSan.Size = new System.Drawing.Size(332, 90);
            this.txtTaiSan.TabIndex = 11;
            // 
            // dgvView
            // 
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(24, 229);
            this.dgvView.Name = "dgvView";
            this.dgvView.Size = new System.Drawing.Size(742, 209);
            this.dgvView.TabIndex = 12;
            this.dgvView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellClick);
            // 
            // frmTaiSanTheChap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.txtTaiSan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelMaHoSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMaHopDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTaiSanTheChap";
            this.Text = "Tài Sản Thế Chấp";
            this.Load += new System.EventHandler(this.frmTaiSanTheChap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaHopDong;
        private System.Windows.Forms.Label labelMaHoSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiSan;
        private System.Windows.Forms.DataGridView dgvView;
    }
}