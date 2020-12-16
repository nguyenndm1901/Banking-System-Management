namespace QuanLyHeThongNganHang
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoátĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAgree = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelTenNH = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTaiSan = new System.Windows.Forms.TextBox();
            this.cbCoPhieu = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.cbMoto = new System.Windows.Forms.CheckBox();
            this.cbTraiPhieu = new System.Windows.Forms.CheckBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.cbCar = new System.Windows.Forms.CheckBox();
            this.cbSoDo = new System.Windows.Forms.CheckBox();
            this.labelSoTien = new System.Windows.Forms.Label();
            this.labelKyHan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMaHopDong = new System.Windows.Forms.Label();
            this.labelMaHoSo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátĐăngNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoátĐăngNhậpToolStripMenuItem
            // 
            this.thoátĐăngNhậpToolStripMenuItem.Name = "thoátĐăngNhậpToolStripMenuItem";
            this.thoátĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátĐăngNhậpToolStripMenuItem.Text = "Trở về";
            this.thoátĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.trởVềToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hợp Đồng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(439, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 309);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 39);
            this.textBox1.MaxLength = 2147483647;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(416, 265);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "ĐIỀU KHOẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAgree
            // 
            this.cbAgree.AutoSize = true;
            this.cbAgree.Location = new System.Drawing.Point(439, 374);
            this.cbAgree.Name = "cbAgree";
            this.cbAgree.Size = new System.Drawing.Size(172, 17);
            this.cbAgree.TabIndex = 3;
            this.cbAgree.Text = "Tôi đồng ý với điều khoản trên";
            this.cbAgree.UseVisualStyleBackColor = true;
            this.cbAgree.CheckedChanged += new System.EventHandler(this.cbAgree_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đại diện bên A:";
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(768, 370);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Tạo hợp đồng";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelTenNH
            // 
            this.labelTenNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNH.Location = new System.Drawing.Point(123, 97);
            this.labelTenNH.Name = "labelTenNH";
            this.labelTenNH.Size = new System.Drawing.Size(282, 17);
            this.labelTenNH.TabIndex = 7;
            this.labelTenNH.Text = "Ngân Hàng TMCP ANM";
            this.labelTenNH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đại diện bên B:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKH.Location = new System.Drawing.Point(123, 127);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(282, 17);
            this.labelTenKH.TabIndex = 9;
            this.labelTenKH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kỳ hạn:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số tiền vay:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaiSan);
            this.groupBox1.Controls.Add(this.cbCoPhieu);
            this.groupBox1.Controls.Add(this.cbOther);
            this.groupBox1.Controls.Add(this.cbMoto);
            this.groupBox1.Controls.Add(this.cbTraiPhieu);
            this.groupBox1.Controls.Add(this.txtOther);
            this.groupBox1.Controls.Add(this.cbCar);
            this.groupBox1.Controls.Add(this.cbSoDo);
            this.groupBox1.Location = new System.Drawing.Point(15, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài sản thế chấp";
            // 
            // txtTaiSan
            // 
            this.txtTaiSan.Location = new System.Drawing.Point(6, 153);
            this.txtTaiSan.Multiline = true;
            this.txtTaiSan.Name = "txtTaiSan";
            this.txtTaiSan.ReadOnly = true;
            this.txtTaiSan.Size = new System.Drawing.Size(406, 45);
            this.txtTaiSan.TabIndex = 11;
            // 
            // cbCoPhieu
            // 
            this.cbCoPhieu.AutoSize = true;
            this.cbCoPhieu.Location = new System.Drawing.Point(6, 130);
            this.cbCoPhieu.Name = "cbCoPhieu";
            this.cbCoPhieu.Size = new System.Drawing.Size(68, 17);
            this.cbCoPhieu.TabIndex = 10;
            this.cbCoPhieu.Text = "Cổ phiếu";
            this.cbCoPhieu.UseVisualStyleBackColor = true;
            this.cbCoPhieu.CheckedChanged += new System.EventHandler(this.cbCoPhieu_CheckedChanged);
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(144, 64);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(54, 17);
            this.cbOther.TabIndex = 5;
            this.cbOther.Text = "Khác:";
            this.cbOther.UseVisualStyleBackColor = true;
            this.cbOther.CheckedChanged += new System.EventHandler(this.cbOther_CheckedChanged);
            // 
            // cbMoto
            // 
            this.cbMoto.AutoSize = true;
            this.cbMoto.Location = new System.Drawing.Point(6, 97);
            this.cbMoto.Name = "cbMoto";
            this.cbMoto.Size = new System.Drawing.Size(61, 17);
            this.cbMoto.TabIndex = 8;
            this.cbMoto.Text = "Xe máy";
            this.cbMoto.UseVisualStyleBackColor = true;
            this.cbMoto.CheckedChanged += new System.EventHandler(this.cbMoto_CheckedChanged);
            // 
            // cbTraiPhieu
            // 
            this.cbTraiPhieu.AutoSize = true;
            this.cbTraiPhieu.Location = new System.Drawing.Point(144, 31);
            this.cbTraiPhieu.Name = "cbTraiPhieu";
            this.cbTraiPhieu.Size = new System.Drawing.Size(73, 17);
            this.cbTraiPhieu.TabIndex = 4;
            this.cbTraiPhieu.Text = "Trái phiếu";
            this.cbTraiPhieu.UseVisualStyleBackColor = true;
            this.cbTraiPhieu.CheckedChanged += new System.EventHandler(this.cbTraiPhieu_CheckedChanged);
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(204, 55);
            this.txtOther.Multiline = true;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(208, 92);
            this.txtOther.TabIndex = 6;
            this.txtOther.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
     
            // 
            // cbCar
            // 
            this.cbCar.AutoSize = true;
            this.cbCar.Location = new System.Drawing.Point(6, 64);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(60, 17);
            this.cbCar.TabIndex = 1;
            this.cbCar.Text = "Xe ô tô";
            this.cbCar.UseVisualStyleBackColor = true;
            this.cbCar.CheckedChanged += new System.EventHandler(this.cbCar_CheckedChanged);
            // 
            // cbSoDo
            // 
            this.cbSoDo.AutoSize = true;
            this.cbSoDo.Location = new System.Drawing.Point(6, 31);
            this.cbSoDo.Name = "cbSoDo";
            this.cbSoDo.Size = new System.Drawing.Size(55, 17);
            this.cbSoDo.TabIndex = 0;
            this.cbSoDo.Text = "Sổ đỏ";
            this.cbSoDo.UseVisualStyleBackColor = true;
            this.cbSoDo.CheckedChanged += new System.EventHandler(this.cbSoDo_CheckedChanged);
            // 
            // labelSoTien
            // 
            this.labelSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoTien.Location = new System.Drawing.Point(123, 158);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(282, 17);
            this.labelSoTien.TabIndex = 13;
            this.labelSoTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelKyHan
            // 
            this.labelKyHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKyHan.Location = new System.Drawing.Point(123, 188);
            this.labelKyHan.Name = "labelKyHan";
            this.labelKyHan.Size = new System.Drawing.Size(282, 17);
            this.labelKyHan.TabIndex = 14;
            this.labelKyHan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã hợp đồng:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã hồ sơ:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaHopDong
            // 
            this.labelMaHopDong.Location = new System.Drawing.Point(82, 40);
            this.labelMaHopDong.Name = "labelMaHopDong";
            this.labelMaHopDong.Size = new System.Drawing.Size(131, 18);
            this.labelMaHopDong.TabIndex = 17;
            this.labelMaHopDong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMaHoSo
            // 
            this.labelMaHoSo.Location = new System.Drawing.Point(82, 53);
            this.labelMaHoSo.Name = "labelMaHoSo";
            this.labelMaHoSo.Size = new System.Drawing.Size(131, 18);
            this.labelMaHoSo.TabIndex = 18;
            this.labelMaHoSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.labelMaHoSo);
            this.Controls.Add(this.labelMaHopDong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKyHan);
            this.Controls.Add(this.labelSoTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelTenKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTenNH);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAgree);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Hợp Đồng";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoátĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAgree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelTenNH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSoTien;
        private System.Windows.Forms.Label labelKyHan;
        private System.Windows.Forms.CheckBox cbCoPhieu;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.CheckBox cbMoto;
        private System.Windows.Forms.CheckBox cbTraiPhieu;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox cbCar;
        private System.Windows.Forms.CheckBox cbSoDo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMaHopDong;
        private System.Windows.Forms.Label labelMaHoSo;
        private System.Windows.Forms.TextBox txtTaiSan;
    }
}

