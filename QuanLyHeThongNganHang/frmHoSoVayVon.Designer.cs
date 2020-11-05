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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKyHanVay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelNgayDangKy = new System.Windows.Forms.Label();
            this.labelSoTienVay = new System.Windows.Forms.Label();
            this.labelTenKH = new System.Windows.Forms.Label();
            this.dgvVayVon = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVayVon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHSVV
            // 
            this.labelHSVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHSVV.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHSVV.Location = new System.Drawing.Point(0, 24);
            this.labelHSVV.Name = "labelHSVV";
            this.labelHSVV.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelHSVV.Size = new System.Drawing.Size(623, 57);
            this.labelHSVV.TabIndex = 0;
            this.labelHSVV.Text = "Hồ Sơ Vay Vốn";
            this.labelHSVV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelKyHanVay);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelNgayDangKy);
            this.panel1.Controls.Add(this.labelSoTienVay);
            this.panel1.Controls.Add(this.labelTenKH);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 126);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Triệu VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tháng";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(440, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKyHanVay
            // 
            this.labelKyHanVay.AutoSize = true;
            this.labelKyHanVay.Location = new System.Drawing.Point(334, 79);
            this.labelKyHanVay.Name = "labelKyHanVay";
            this.labelKyHanVay.Size = new System.Drawing.Size(66, 13);
            this.labelKyHanVay.TabIndex = 4;
            this.labelKyHanVay.Text = "Kỳ Hạn Vay:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 27);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelNgayDangKy
            // 
            this.labelNgayDangKy.AutoSize = true;
            this.labelNgayDangKy.Location = new System.Drawing.Point(334, 33);
            this.labelNgayDangKy.Name = "labelNgayDangKy";
            this.labelNgayDangKy.Size = new System.Drawing.Size(79, 13);
            this.labelNgayDangKy.TabIndex = 2;
            this.labelNgayDangKy.Text = "Ngày Đăng Ký:";
            // 
            // labelSoTienVay
            // 
            this.labelSoTienVay.AutoSize = true;
            this.labelSoTienVay.Location = new System.Drawing.Point(3, 79);
            this.labelSoTienVay.Name = "labelSoTienVay";
            this.labelSoTienVay.Size = new System.Drawing.Size(68, 13);
            this.labelSoTienVay.TabIndex = 1;
            this.labelSoTienVay.Text = "Số Tiền Vay:";
            // 
            // labelTenKH
            // 
            this.labelTenKH.AutoSize = true;
            this.labelTenKH.Location = new System.Drawing.Point(3, 33);
            this.labelTenKH.Name = "labelTenKH";
            this.labelTenKH.Size = new System.Drawing.Size(92, 13);
            this.labelTenKH.TabIndex = 0;
            this.labelTenKH.Text = "Tên Khách Hàng:";
            // 
            // dgvVayVon
            // 
            this.dgvVayVon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVayVon.Location = new System.Drawing.Point(12, 216);
            this.dgvVayVon.Name = "dgvVayVon";
            this.dgvVayVon.Size = new System.Drawing.Size(599, 260);
            this.dgvVayVon.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
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
            // frmHoSoVayVon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 488);
            this.Controls.Add(this.dgvVayVon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelHSVV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoSoVayVon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hồ Sơ Vay Vốn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVayVon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHSVV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKyHanVay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelNgayDangKy;
        private System.Windows.Forms.Label labelSoTienVay;
        private System.Windows.Forms.DataGridView dgvVayVon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayVềToolStripMenuItem;
    }
}