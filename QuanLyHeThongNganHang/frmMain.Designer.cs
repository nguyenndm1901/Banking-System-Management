namespace QuanLyHeThongNganHang
{
    partial class frmMain
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHoSoVayVon = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gbServices.Controls.Add(this.button3);
            this.gbServices.Controls.Add(this.button2);
            this.gbServices.Controls.Add(this.btnHoSoVayVon);
            this.gbServices.Location = new System.Drawing.Point(12, 126);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(403, 251);
            this.gbServices.TabIndex = 1;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Dịch vụ:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(391, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản Lý Tài Sản Thế Chấp";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(391, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Hợp Đồng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnHoSoVayVon
            // 
            this.btnHoSoVayVon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoSoVayVon.Location = new System.Drawing.Point(6, 19);
            this.btnHoSoVayVon.Name = "btnHoSoVayVon";
            this.btnHoSoVayVon.Size = new System.Drawing.Size(391, 70);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 389);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHoSoVayVon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátĐăngNhậpToolStripMenuItem;
    }
}