namespace QuanLySieuThi.UserControls
{
    partial class TaoHoaDonUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboGioHangHoaDonTamLuu = new ComboBox();
            btnXoaGioHang = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            txtDiemTichLuy = new TextBox();
            groupBox4 = new GroupBox();
            txtSDT = new TextBox();
            groupBox2 = new GroupBox();
            txtTenKH = new TextBox();
            groupBox5 = new GroupBox();
            txtMaKH = new TextBox();
            txtNhapMaKH = new TextBox();
            btnXacNhanKH = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLuuGioHang = new Button();
            cboHinhThucThanhToan = new ComboBox();
            lblTongTienCacSP = new Label();
            btnXacNhanSP = new Button();
            txtNhapMaSP = new TextBox();
            dgvSP_Ban = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            lblTongTienTra = new Label();
            groupBox6 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ckboxDoiDiem = new CheckBox();
            btnLuuHD = new Button();
            lblDiemConLaiSauDoi = new Label();
            groupBox9 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP_Ban).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // cboGioHangHoaDonTamLuu
            // 
            cboGioHangHoaDonTamLuu.FormattingEnabled = true;
            cboGioHangHoaDonTamLuu.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioHangHoaDonTamLuu.Location = new Point(3, 10);
            cboGioHangHoaDonTamLuu.Margin = new Padding(3, 10, 3, 3);
            cboGioHangHoaDonTamLuu.Name = "cboGioHangHoaDonTamLuu";
            cboGioHangHoaDonTamLuu.Size = new Size(158, 25);
            cboGioHangHoaDonTamLuu.TabIndex = 28;
            // 
            // btnXoaGioHang
            // 
            btnXoaGioHang.AutoSize = true;
            btnXoaGioHang.ForeColor = Color.DarkSlateGray;
            btnXoaGioHang.Location = new Point(284, 3);
            btnXoaGioHang.Name = "btnXoaGioHang";
            btnXoaGioHang.Size = new Size(111, 35);
            btnXoaGioHang.TabIndex = 27;
            btnXoaGioHang.Text = "Xóa giỏ hàng";
            btnXoaGioHang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(txtNhapMaKH);
            groupBox1.Controls.Add(btnXacNhanKH);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 81);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtDiemTichLuy);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.GrayText;
            groupBox3.Location = new Point(785, 19);
            groupBox3.Margin = new Padding(20, 10, 10, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(133, 51);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Điểm tích lũy:";
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Dock = DockStyle.Top;
            txtDiemTichLuy.Location = new Point(3, 21);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.ReadOnly = true;
            txtDiemTichLuy.Size = new Size(127, 25);
            txtDiemTichLuy.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.ForeColor = SystemColors.GrayText;
            groupBox4.Location = new Point(624, 19);
            groupBox4.Margin = new Padding(20, 10, 10, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(142, 51);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Top;
            txtSDT.Location = new Point(3, 21);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(136, 25);
            txtSDT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenKH);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.GrayText;
            groupBox2.Location = new Point(405, 19);
            groupBox2.Margin = new Padding(20, 10, 10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 51);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên khách hàng:";
            // 
            // txtTenKH
            // 
            txtTenKH.Dock = DockStyle.Top;
            txtTenKH.Location = new Point(3, 21);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(194, 25);
            txtTenKH.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtMaKH);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox5.ForeColor = SystemColors.GrayText;
            groupBox5.Location = new Point(268, 19);
            groupBox5.Margin = new Padding(20, 10, 10, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(117, 51);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mã KH:";
            // 
            // txtMaKH
            // 
            txtMaKH.Dock = DockStyle.Top;
            txtMaKH.Location = new Point(3, 21);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(111, 25);
            txtMaKH.TabIndex = 0;
            // 
            // txtNhapMaKH
            // 
            txtNhapMaKH.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            txtNhapMaKH.Location = new Point(4, 30);
            txtNhapMaKH.Margin = new Padding(10);
            txtNhapMaKH.Name = "txtNhapMaKH";
            txtNhapMaKH.PlaceholderText = "Nhập mã KH";
            txtNhapMaKH.Size = new Size(150, 27);
            txtNhapMaKH.TabIndex = 8;
            // 
            // btnXacNhanKH
            // 
            btnXacNhanKH.BackColor = Color.Snow;
            btnXacNhanKH.ForeColor = Color.Red;
            btnXacNhanKH.Location = new Point(162, 28);
            btnXacNhanKH.Margin = new Padding(10);
            btnXacNhanKH.Name = "btnXacNhanKH";
            btnXacNhanKH.Size = new Size(83, 30);
            btnXacNhanKH.TabIndex = 9;
            btnXacNhanKH.Text = "Xác nhận";
            btnXacNhanKH.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cboGioHangHoaDonTamLuu);
            flowLayoutPanel1.Controls.Add(btnLuuGioHang);
            flowLayoutPanel1.Controls.Add(btnXoaGioHang);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 21);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(403, 48);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // btnLuuGioHang
            // 
            btnLuuGioHang.AutoSize = true;
            btnLuuGioHang.ForeColor = Color.FromArgb(255, 128, 0);
            btnLuuGioHang.Location = new Point(167, 3);
            btnLuuGioHang.Name = "btnLuuGioHang";
            btnLuuGioHang.Size = new Size(111, 35);
            btnLuuGioHang.TabIndex = 26;
            btnLuuGioHang.Text = "Lưu giỏ hàng";
            btnLuuGioHang.UseVisualStyleBackColor = true;
            // 
            // cboHinhThucThanhToan
            // 
            cboHinhThucThanhToan.Dock = DockStyle.Top;
            cboHinhThucThanhToan.FormattingEnabled = true;
            cboHinhThucThanhToan.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboHinhThucThanhToan.Location = new Point(3, 21);
            cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            cboHinhThucThanhToan.Size = new Size(248, 25);
            cboHinhThucThanhToan.TabIndex = 4;
            // 
            // lblTongTienCacSP
            // 
            lblTongTienCacSP.BorderStyle = BorderStyle.FixedSingle;
            lblTongTienCacSP.ForeColor = SystemColors.GrayText;
            lblTongTienCacSP.Location = new Point(480, 8);
            lblTongTienCacSP.Margin = new Padding(10, 20, 10, 10);
            lblTongTienCacSP.Name = "lblTongTienCacSP";
            lblTongTienCacSP.Size = new Size(380, 26);
            lblTongTienCacSP.TabIndex = 27;
            lblTongTienCacSP.Text = "Tổng tiền sản phẩm: 100";
            lblTongTienCacSP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnXacNhanSP
            // 
            btnXacNhanSP.AutoSize = true;
            btnXacNhanSP.BackColor = Color.Snow;
            btnXacNhanSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhanSP.ForeColor = Color.Red;
            btnXacNhanSP.Location = new Point(165, 5);
            btnXacNhanSP.Margin = new Padding(10);
            btnXacNhanSP.Name = "btnXacNhanSP";
            btnXacNhanSP.Size = new Size(83, 30);
            btnXacNhanSP.TabIndex = 26;
            btnXacNhanSP.Text = "Xác nhận";
            btnXacNhanSP.UseVisualStyleBackColor = false;
            btnXacNhanSP.Click += button1_Click;
            // 
            // txtNhapMaSP
            // 
            txtNhapMaSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            txtNhapMaSP.Location = new Point(7, 7);
            txtNhapMaSP.Margin = new Padding(10);
            txtNhapMaSP.Name = "txtNhapMaSP";
            txtNhapMaSP.PlaceholderText = "Nhập mã SP";
            txtNhapMaSP.Size = new Size(150, 27);
            txtNhapMaSP.TabIndex = 11;
            // 
            // dgvSP_Ban
            // 
            dgvSP_Ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP_Ban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP_Ban.Dock = DockStyle.Fill;
            dgvSP_Ban.Location = new Point(3, 50);
            dgvSP_Ban.Name = "dgvSP_Ban";
            dgvSP_Ban.Size = new Size(920, 131);
            dgvSP_Ban.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvSP_Ban, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(926, 184);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTongTienCacSP);
            panel1.Controls.Add(btnXacNhanSP);
            panel1.Controls.Add(txtNhapMaSP);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 41);
            panel1.TabIndex = 13;
            // 
            // lblTongTienTra
            // 
            lblTongTienTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTongTienTra.AutoSize = true;
            lblTongTienTra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTongTienTra.ForeColor = SystemColors.InfoText;
            lblTongTienTra.Location = new Point(594, 384);
            lblTongTienTra.Margin = new Padding(3);
            lblTongTienTra.Name = "lblTongTienTra";
            lblTongTienTra.Size = new Size(149, 40);
            lblTongTienTra.TabIndex = 28;
            lblTongTienTra.Text = "Tổng tiền phải trả: 100";
            // 
            // groupBox6
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox6, 4);
            groupBox6.Controls.Add(tableLayoutPanel2);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.Location = new Point(3, 168);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(932, 210);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách sản phẩm mua:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 361F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 292F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTongTienTra, 2, 3);
            tableLayoutPanel1.Controls.Add(groupBox6, 0, 2);
            tableLayoutPanel1.Controls.Add(ckboxDoiDiem, 0, 3);
            tableLayoutPanel1.Controls.Add(btnLuuHD, 3, 3);
            tableLayoutPanel1.Controls.Add(lblDiemConLaiSauDoi, 1, 3);
            tableLayoutPanel1.Controls.Add(groupBox9, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox7, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 87F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(938, 427);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ckboxDoiDiem
            // 
            ckboxDoiDiem.AutoSize = true;
            ckboxDoiDiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ckboxDoiDiem.ForeColor = SystemColors.InfoText;
            ckboxDoiDiem.Location = new Point(3, 384);
            ckboxDoiDiem.Name = "ckboxDoiDiem";
            ckboxDoiDiem.Size = new Size(139, 21);
            ckboxDoiDiem.TabIndex = 4;
            ckboxDoiDiem.Text = "Áp dụng đổi điểm";
            ckboxDoiDiem.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            btnLuuHD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuuHD.BackColor = Color.Snow;
            btnLuuHD.ForeColor = Color.Red;
            btnLuuHD.Location = new Point(818, 384);
            btnLuuHD.Name = "btnLuuHD";
            btnLuuHD.Size = new Size(117, 40);
            btnLuuHD.TabIndex = 33;
            btnLuuHD.Text = "Lưu hóa đơn";
            btnLuuHD.UseVisualStyleBackColor = false;
            // 
            // lblDiemConLaiSauDoi
            // 
            lblDiemConLaiSauDoi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblDiemConLaiSauDoi.AutoSize = true;
            lblDiemConLaiSauDoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDiemConLaiSauDoi.ForeColor = SystemColors.InfoText;
            lblDiemConLaiSauDoi.Location = new Point(198, 384);
            lblDiemConLaiSauDoi.Margin = new Padding(3);
            lblDiemConLaiSauDoi.Name = "lblDiemConLaiSauDoi";
            lblDiemConLaiSauDoi.Size = new Size(288, 40);
            lblDiemConLaiSauDoi.TabIndex = 30;
            lblDiemConLaiSauDoi.Text = "Số điểm còn lại khi đã áp dụng đổi điểm: 100";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cboHinhThucThanhToan);
            groupBox9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox9.ForeColor = SystemColors.HotTrack;
            groupBox9.Location = new Point(165, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(254, 61);
            groupBox9.TabIndex = 35;
            groupBox9.TabStop = false;
            groupBox9.Text = "Lựa chọn hình thức thanh toán:";
            // 
            // groupBox7
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox7, 2);
            groupBox7.Controls.Add(flowLayoutPanel1);
            groupBox7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox7.ForeColor = SystemColors.HotTrack;
            groupBox7.Location = new Point(526, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(409, 72);
            groupBox7.TabIndex = 36;
            groupBox7.TabStop = false;
            groupBox7.Text = "Hóa đơn tạm lưu:";
            // 
            // TaoHoaDonUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "TaoHoaDonUC";
            Size = new Size(938, 427);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP_Ban).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboGioHangHoaDonTamLuu;
        private Button btnXoaGioHang;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTongTienTra;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvSP_Ban;
        private Panel panel1;
        private Label lblTongTienCacSP;
        private Button btnXacNhanSP;
        private TextBox txtNhapMaSP;
        private CheckBox ckboxDoiDiem;
        private Button btnLuuHD;
        private Label lblDiemConLaiSauDoi;
        private GroupBox groupBox9;
        private ComboBox cboHinhThucThanhToan;
        private GroupBox groupBox7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLuuGioHang;
        private GroupBox groupBox3;
        private TextBox txtDiemTichLuy;
        private GroupBox groupBox4;
        private TextBox txtSDT;
        private GroupBox groupBox2;
        private TextBox txtTenKH;
        private GroupBox groupBox5;
        private TextBox txtMaKH;
        private TextBox txtNhapMaKH;
        private Button btnXacNhanKH;
    }
}
