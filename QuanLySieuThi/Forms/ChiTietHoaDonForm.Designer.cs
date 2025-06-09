namespace QuanLySieuThi.Forms
{
    partial class ChiTietHoaDonForm: System.Windows.Forms.Form
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
            dgvSanPham_Ban = new DataGridView();
            groupBox10 = new GroupBox();
            txtTrangThaiDonHang = new TextBox();
            groupBox1 = new GroupBox();
            txtMaKH = new TextBox();
            groupBox2 = new GroupBox();
            txtTenKH = new TextBox();
            txtDoiDiem = new TextBox();
            groupBox3 = new GroupBox();
            txtMaNVThuNgan = new TextBox();
            groupBox9 = new GroupBox();
            txtMaNV_HoTroDoiTra = new TextBox();
            txtTongTien = new TextBox();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox8 = new GroupBox();
            labelTieuDe = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            txtHinhThucThanhToan = new TextBox();
            groupBox7 = new GroupBox();
            txtNgayMua = new TextBox();
            groupBox11 = new GroupBox();
            txtNgayDoiTra = new TextBox();
            groupBox12 = new GroupBox();
            txtLyDoDoiTra = new TextBox();
            groupBox13 = new GroupBox();
            txtTongTienTraLai = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnDoiTra = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham_Ban).BeginInit();
            groupBox10.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox8.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox13.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham_Ban
            // 
            dgvSanPham_Ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham_Ban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham_Ban.Dock = DockStyle.Fill;
            dgvSanPham_Ban.Location = new Point(3, 23);
            dgvSanPham_Ban.Margin = new Padding(4);
            dgvSanPham_Ban.MultiSelect = false;
            dgvSanPham_Ban.Name = "dgvSanPham_Ban";
            dgvSanPham_Ban.ReadOnly = true;
            dgvSanPham_Ban.Size = new Size(998, 175);
            dgvSanPham_Ban.TabIndex = 14;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dgvSanPham_Ban);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Location = new Point(3, 337);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(1004, 201);
            groupBox10.TabIndex = 23;
            groupBox10.TabStop = false;
            groupBox10.Text = "Danh sách sản phẩm mua";
            // 
            // txtTrangThaiDonHang
            // 
            txtTrangThaiDonHang.Dock = DockStyle.Fill;
            txtTrangThaiDonHang.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTrangThaiDonHang.Location = new Point(3, 23);
            txtTrangThaiDonHang.Name = "txtTrangThaiDonHang";
            txtTrangThaiDonHang.ReadOnly = true;
            txtTrangThaiDonHang.Size = new Size(131, 27);
            txtTrangThaiDonHang.TabIndex = 0;
            txtTrangThaiDonHang.Text = "27/7/2004";
            txtTrangThaiDonHang.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Location = new Point(30, 10);
            groupBox1.Margin = new Padding(30, 10, 30, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(123, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            txtMaKH.Dock = DockStyle.Fill;
            txtMaKH.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaKH.Location = new Point(3, 23);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(117, 27);
            txtMaKH.TabIndex = 0;
            txtMaKH.Text = "NCC01";
            txtMaKH.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenKH);
            groupBox2.Location = new Point(213, 10);
            groupBox2.Margin = new Padding(30, 10, 30, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên KH";
            // 
            // txtTenKH
            // 
            txtTenKH.Dock = DockStyle.Fill;
            txtTenKH.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTenKH.Location = new Point(3, 23);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(194, 27);
            txtTenKH.TabIndex = 0;
            txtTenKH.Text = "Nhà cung cấp A";
            txtTenKH.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDoiDiem
            // 
            txtDoiDiem.Dock = DockStyle.Fill;
            txtDoiDiem.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDoiDiem.Location = new Point(3, 23);
            txtDoiDiem.Name = "txtDoiDiem";
            txtDoiDiem.ReadOnly = true;
            txtDoiDiem.Size = new Size(108, 27);
            txtDoiDiem.TabIndex = 0;
            txtDoiDiem.Text = "27/7/2004";
            txtDoiDiem.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMaNVThuNgan);
            groupBox3.Location = new Point(473, 10);
            groupBox3.Margin = new Padding(30, 10, 30, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(163, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân viên tính tiền";
            // 
            // txtMaNVThuNgan
            // 
            txtMaNVThuNgan.Dock = DockStyle.Fill;
            txtMaNVThuNgan.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaNVThuNgan.Location = new Point(3, 23);
            txtMaNVThuNgan.Name = "txtMaNVThuNgan";
            txtMaNVThuNgan.ReadOnly = true;
            txtMaNVThuNgan.Size = new Size(157, 27);
            txtMaNVThuNgan.TabIndex = 0;
            txtMaNVThuNgan.Text = "NV001";
            txtMaNVThuNgan.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtMaNV_HoTroDoiTra);
            groupBox9.Location = new Point(30, 166);
            groupBox9.Margin = new Padding(30, 10, 15, 10);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(199, 58);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Nhân viên hỗ trợ đổi trả";
            // 
            // txtMaNV_HoTroDoiTra
            // 
            txtMaNV_HoTroDoiTra.Dock = DockStyle.Fill;
            txtMaNV_HoTroDoiTra.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaNV_HoTroDoiTra.Location = new Point(3, 23);
            txtMaNV_HoTroDoiTra.Name = "txtMaNV_HoTroDoiTra";
            txtMaNV_HoTroDoiTra.ReadOnly = true;
            txtMaNV_HoTroDoiTra.Size = new Size(193, 27);
            txtMaNV_HoTroDoiTra.TabIndex = 0;
            txtMaNV_HoTroDoiTra.Text = "NV001";
            txtMaNV_HoTroDoiTra.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTongTien
            // 
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(3, 23);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(145, 27);
            txtTongTien.TabIndex = 0;
            txtTongTien.Text = "27/7/2004";
            txtTongTien.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtTongTien);
            groupBox6.Location = new Point(696, 10);
            groupBox6.Margin = new Padding(30, 10, 30, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(151, 58);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tổng tiền";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDoiDiem);
            groupBox5.Location = new Point(30, 88);
            groupBox5.Margin = new Padding(30, 10, 30, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(114, 58);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Có đổi điểm";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtTrangThaiDonHang);
            groupBox8.Location = new Point(646, 88);
            groupBox8.Margin = new Padding(30, 10, 30, 10);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(137, 58);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "Trạng thái";
            // 
            // labelTieuDe
            // 
            labelTieuDe.BackColor = Color.WhiteSmoke;
            labelTieuDe.BorderStyle = BorderStyle.Fixed3D;
            labelTieuDe.CausesValidation = false;
            labelTieuDe.Dock = DockStyle.Fill;
            labelTieuDe.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.FromArgb(41, 128, 185);
            labelTieuDe.Location = new Point(4, 0);
            labelTieuDe.Margin = new Padding(4, 0, 4, 0);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(1002, 97);
            labelTieuDe.TabIndex = 21;
            labelTieuDe.Text = "THÔNG TIN CHI TIẾT HÓA ĐƠN HD001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Controls.Add(groupBox8);
            flowLayoutPanel1.Controls.Add(groupBox9);
            flowLayoutPanel1.Controls.Add(groupBox11);
            flowLayoutPanel1.Controls.Add(groupBox12);
            flowLayoutPanel1.Controls.Add(groupBox13);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1004, 231);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtHinhThucThanhToan);
            groupBox4.Location = new Point(204, 88);
            groupBox4.Margin = new Padding(30, 10, 30, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(183, 58);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hình thức thanh toán";
            // 
            // txtHinhThucThanhToan
            // 
            txtHinhThucThanhToan.Dock = DockStyle.Fill;
            txtHinhThucThanhToan.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtHinhThucThanhToan.Location = new Point(3, 23);
            txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
            txtHinhThucThanhToan.ReadOnly = true;
            txtHinhThucThanhToan.Size = new Size(177, 27);
            txtHinhThucThanhToan.TabIndex = 0;
            txtHinhThucThanhToan.Text = "27/7/2004";
            txtHinhThucThanhToan.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtNgayMua);
            groupBox7.Location = new Point(447, 88);
            groupBox7.Margin = new Padding(30, 10, 30, 10);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(139, 58);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ngày mua";
            // 
            // txtNgayMua
            // 
            txtNgayMua.Dock = DockStyle.Fill;
            txtNgayMua.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNgayMua.Location = new Point(3, 23);
            txtNgayMua.Name = "txtNgayMua";
            txtNgayMua.ReadOnly = true;
            txtNgayMua.Size = new Size(133, 27);
            txtNgayMua.TabIndex = 0;
            txtNgayMua.Text = "27/7/2004";
            txtNgayMua.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(txtNgayDoiTra);
            groupBox11.Location = new Point(274, 166);
            groupBox11.Margin = new Padding(30, 10, 15, 10);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(163, 58);
            groupBox11.TabIndex = 11;
            groupBox11.TabStop = false;
            groupBox11.Text = "Ngày đổi trả";
            // 
            // txtNgayDoiTra
            // 
            txtNgayDoiTra.Dock = DockStyle.Fill;
            txtNgayDoiTra.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNgayDoiTra.Location = new Point(3, 23);
            txtNgayDoiTra.Name = "txtNgayDoiTra";
            txtNgayDoiTra.ReadOnly = true;
            txtNgayDoiTra.Size = new Size(157, 27);
            txtNgayDoiTra.TabIndex = 0;
            txtNgayDoiTra.Text = "27/7/2004";
            txtNgayDoiTra.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(txtLyDoDoiTra);
            groupBox12.Location = new Point(482, 166);
            groupBox12.Margin = new Padding(30, 10, 15, 10);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(243, 58);
            groupBox12.TabIndex = 12;
            groupBox12.TabStop = false;
            groupBox12.Text = "Lý do đổi trả";
            // 
            // txtLyDoDoiTra
            // 
            txtLyDoDoiTra.Dock = DockStyle.Fill;
            txtLyDoDoiTra.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtLyDoDoiTra.Location = new Point(3, 23);
            txtLyDoDoiTra.Name = "txtLyDoDoiTra";
            txtLyDoDoiTra.ReadOnly = true;
            txtLyDoDoiTra.Size = new Size(237, 27);
            txtLyDoDoiTra.TabIndex = 0;
            txtLyDoDoiTra.Text = "27/7/2004";
            txtLyDoDoiTra.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(txtTongTienTraLai);
            groupBox13.Location = new Point(770, 166);
            groupBox13.Margin = new Padding(30, 10, 15, 10);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(163, 58);
            groupBox13.TabIndex = 13;
            groupBox13.TabStop = false;
            groupBox13.Text = "Tổng tiền trả lại";
            // 
            // txtTongTienTraLai
            // 
            txtTongTienTraLai.Dock = DockStyle.Fill;
            txtTongTienTraLai.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTongTienTraLai.Location = new Point(3, 23);
            txtTongTienTraLai.Name = "txtTongTienTraLai";
            txtTongTienTraLai.ReadOnly = true;
            txtTongTienTraLai.Size = new Size(157, 27);
            txtTongTienTraLai.TabIndex = 0;
            txtTongTienTraLai.Text = "27/7/2004";
            txtTongTienTraLai.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelTieuDe, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox10, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 237F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(1010, 614);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDoiTra);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(1004, 67);
            panel1.TabIndex = 24;
            // 
            // btnDoiTra
            // 
            btnDoiTra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDoiTra.Location = new Point(879, 13);
            btnDoiTra.Name = "btnDoiTra";
            btnDoiTra.Size = new Size(121, 46);
            btnDoiTra.TabIndex = 2;
            btnDoiTra.Text = "Đổi trả";
            btnDoiTra.UseVisualStyleBackColor = true;
            // 
            // ChiTietHoaDonForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 614);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "ChiTietHoaDonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dgvSanPham_Ban).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSanPham_Ban;
        private GroupBox groupBox10;
        private TextBox txtTrangThaiDonHang;
        private GroupBox groupBox1;
        private TextBox txtMaKH;
        private GroupBox groupBox2;
        private TextBox txtTenKH;
        private TextBox txtDoiDiem;
        private GroupBox groupBox3;
        private TextBox txtMaNVThuNgan;
        private GroupBox groupBox9;
        private TextBox txtMaNV_HoTroDoiTra;
        private TextBox txtTongTien;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox8;
        public Label labelTieuDe;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnDoiTra;
        private GroupBox groupBox4;
        private TextBox txtHinhThucThanhToan;
        private GroupBox groupBox7;
        private TextBox txtNgayMua;
        private GroupBox groupBox11;
        private TextBox txtNgayDoiTra;
        private GroupBox groupBox12;
        private TextBox txtLyDoDoiTra;
        private GroupBox groupBox13;
        private TextBox txtTongTienTraLai;
    }
}