namespace loginform
{
    partial class FormHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtTimDienThoai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDienThoai = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nupSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDienThoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDienThoai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.MaDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtTimDienThoai);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dgvDienThoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.nupSoLuong);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenDienThoai);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaDienThoai);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hoá đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(637, 265);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(218, 21);
            this.txtGiaBan.TabIndex = 29;
            this.txtGiaBan.TextChanged += new System.EventHandler(this.txtGiaBan_TextChanged);
            // 
            // txtTimDienThoai
            // 
            this.txtTimDienThoai.Location = new System.Drawing.Point(290, 145);
            this.txtTimDienThoai.Name = "txtTimDienThoai";
            this.txtTimDienThoai.Size = new System.Drawing.Size(229, 21);
            this.txtTimDienThoai.TabIndex = 26;
            this.txtTimDienThoai.TextChanged += new System.EventHandler(this.txtTimDienThoai_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(132, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tìm điện thoại";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::loginform.Properties.Resources.ry;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(776, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 60);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDienThoai
            // 
            this.dgvDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienThoai.Location = new System.Drawing.Point(14, 187);
            this.dgvDienThoai.Name = "dgvDienThoai";
            this.dgvDienThoai.RowHeadersWidth = 51;
            this.dgvDienThoai.Size = new System.Drawing.Size(505, 101);
            this.dgvDienThoai.TabIndex = 24;
            this.dgvDienThoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDienThoai_CellClick);
            this.dgvDienThoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDienThoai_CellContentClick);
            this.dgvDienThoai.SelectionChanged += new System.EventHandler(this.dgvDienThoai_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hoá đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(118, 32);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(177, 21);
            this.txtMaHoaDon.TabIndex = 14;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::loginform.Properties.Resources._1111;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Location = new System.Drawing.Point(887, 223);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 60);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::loginform.Properties.Resources.utilities_reset;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(874, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 58);
            this.btnReset.TabIndex = 25;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::loginform.Properties.Resources.aw;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(669, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 65);
            this.btnThem.TabIndex = 25;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nupSoLuong
            // 
            this.nupSoLuong.Location = new System.Drawing.Point(637, 217);
            this.nupSoLuong.Name = "nupSoLuong";
            this.nupSoLuong.Size = new System.Drawing.Size(217, 21);
            this.nupSoLuong.TabIndex = 23;
            this.nupSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSoLuong.ValueChanged += new System.EventHandler(this.nupSoLuong_ValueChanged);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(402, 80);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(204, 21);
            this.dtpNgayBan.TabIndex = 22;
            this.dtpNgayBan.ValueChanged += new System.EventHandler(this.dtpNgayBan_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ngày bán";
            // 
            // txtTenDienThoai
            // 
            this.txtTenDienThoai.Location = new System.Drawing.Point(637, 172);
            this.txtTenDienThoai.Name = "txtTenDienThoai";
            this.txtTenDienThoai.ReadOnly = true;
            this.txtTenDienThoai.Size = new System.Drawing.Size(218, 21);
            this.txtTenDienThoai.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(524, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên điện thoại";
            // 
            // txtMaDienThoai
            // 
            this.txtMaDienThoai.Location = new System.Drawing.Point(637, 128);
            this.txtMaDienThoai.Name = "txtMaDienThoai";
            this.txtMaDienThoai.ReadOnly = true;
            this.txtMaDienThoai.Size = new System.Drawing.Size(218, 21);
            this.txtMaDienThoai.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(530, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giá bán";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(118, 94);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(177, 21);
            this.txtMaKhachHang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã khách hàng";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(402, 32);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(204, 21);
            this.txtTenKhach.TabIndex = 15;
            this.txtTenKhach.TextChanged += new System.EventHandler(this.txtTenKhach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên khách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvGioHang);
            this.groupBox2.Controls.Add(this.textBoxThanhTien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 248);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Thành tiền";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDienThoai,
            this.TenDienThoai,
            this.SoLuong1,
            this.ThanhTien1});
            this.dgvGioHang.Location = new System.Drawing.Point(62, 20);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(849, 185);
            this.dgvGioHang.TabIndex = 30;
            // 
            // MaDienThoai
            // 
            this.MaDienThoai.DataPropertyName = "MaHD";
            this.MaDienThoai.HeaderText = "Mã điện thoại";
            this.MaDienThoai.Name = "MaDienThoai";
            this.MaDienThoai.Width = 200;
            // 
            // TenDienThoai
            // 
            this.TenDienThoai.DataPropertyName = "TenHang";
            this.TenDienThoai.HeaderText = "Tên điện thoại";
            this.TenDienThoai.Name = "TenDienThoai";
            this.TenDienThoai.Width = 200;
            // 
            // SoLuong1
            // 
            this.SoLuong1.DataPropertyName = "SoLuong";
            this.SoLuong1.HeaderText = "Số lượng";
            this.SoLuong1.Name = "SoLuong1";
            this.SoLuong1.Width = 200;
            // 
            // ThanhTien1
            // 
            this.ThanhTien1.DataPropertyName = "ThanhTien";
            this.ThanhTien1.HeaderText = "Thành tiền";
            this.ThanhTien1.Name = "ThanhTien1";
            this.ThanhTien1.Width = 200;
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.Location = new System.Drawing.Point(590, 211);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(338, 21);
            this.textBoxThanhTien.TabIndex = 28;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "maHD";
            this.MaHD.Name = "MaHD";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "TenHang";
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 500;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(997, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDienThoai;
        private System.Windows.Forms.NumericUpDown nupSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDienThoai;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaDienThoai;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTimDienThoai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxThanhTien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien1;
    }
}