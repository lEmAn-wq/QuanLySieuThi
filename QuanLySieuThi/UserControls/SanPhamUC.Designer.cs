namespace QuanLySieuThi
{
    partial class SanPhamUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flpSanPham = new FlowLayoutPanel();
            panel1 = new Panel();
            groupBox5 = new GroupBox();
            cboSanPhamTonKho = new ComboBox();
            ckboxTatCa = new CheckBox();
            groupBox4 = new GroupBox();
            cboUuDai = new ComboBox();
            groupBox2 = new GroupBox();
            cboLoaiSanPham = new ComboBox();
            ckboxShowCheck = new CheckBox();
            groupBox1 = new GroupBox();
            cboNganhHang = new ComboBox();
            groupBox3 = new GroupBox();
            cboThuongHieu = new ComboBox();
            txtTimKiem = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnApDungGiamGia = new Button();
            btnHuyGiamGia = new Button();
            btnTaoPhieuNhap = new Button();
            btnThemSanPham = new Button();
            btnXoaSanPham = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flpSanPham, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(938, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flpSanPham
            // 
            flpSanPham.AutoScroll = true;
            flpSanPham.BorderStyle = BorderStyle.FixedSingle;
            flpSanPham.Dock = DockStyle.Fill;
            flpSanPham.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            flpSanPham.Location = new Point(4, 195);
            flpSanPham.Margin = new Padding(4);
            flpSanPham.Name = "flpSanPham";
            flpSanPham.Size = new Size(930, 228);
            flpSanPham.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(ckboxTatCa);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(ckboxShowCheck);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            panel1.Location = new Point(4, 61);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 126);
            panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboSanPhamTonKho);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox5.Location = new Point(10, 8);
            groupBox5.Margin = new Padding(26, 27, 26, 27);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(167, 68);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tình trạng tồn kho:";
            // 
            // cboSanPhamTonKho
            // 
            cboSanPhamTonKho.Dock = DockStyle.Top;
            cboSanPhamTonKho.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboSanPhamTonKho.FormattingEnabled = true;
            cboSanPhamTonKho.Items.AddRange(new object[] { "Còn hàng", "Hết hàng" });
            cboSanPhamTonKho.Location = new Point(4, 22);
            cboSanPhamTonKho.Margin = new Padding(4);
            cboSanPhamTonKho.Name = "cboSanPhamTonKho";
            cboSanPhamTonKho.Size = new Size(159, 25);
            cboSanPhamTonKho.TabIndex = 2;
            // 
            // ckboxTatCa
            // 
            ckboxTatCa.AutoSize = true;
            ckboxTatCa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ckboxTatCa.ForeColor = SystemColors.AppWorkspace;
            ckboxTatCa.Location = new Point(731, 93);
            ckboxTatCa.Margin = new Padding(4);
            ckboxTatCa.Name = "ckboxTatCa";
            ckboxTatCa.Size = new Size(82, 21);
            ckboxTatCa.TabIndex = 21;
            ckboxTatCa.Text = "Check all";
            ckboxTatCa.UseVisualStyleBackColor = true;
            ckboxTatCa.Visible = false;
            ckboxTatCa.CheckedChanged += ckboxTatCa_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboUuDai);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.Location = new Point(754, 8);
            groupBox4.Margin = new Padding(26, 27, 26, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(167, 68);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ưu đãi:";
            // 
            // cboUuDai
            // 
            cboUuDai.Dock = DockStyle.Top;
            cboUuDai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboUuDai.FormattingEnabled = true;
            cboUuDai.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboUuDai.Location = new Point(4, 22);
            cboUuDai.Margin = new Padding(4);
            cboUuDai.Name = "cboUuDai";
            cboUuDai.Size = new Size(159, 25);
            cboUuDai.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboLoaiSanPham);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(568, 8);
            groupBox2.Margin = new Padding(26, 27, 26, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(167, 68);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Dock = DockStyle.Top;
            cboLoaiSanPham.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboLoaiSanPham.Location = new Point(4, 22);
            cboLoaiSanPham.Margin = new Padding(4);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(159, 25);
            cboLoaiSanPham.TabIndex = 2;
            // 
            // ckboxShowCheck
            // 
            ckboxShowCheck.AutoSize = true;
            ckboxShowCheck.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ckboxShowCheck.ForeColor = SystemColors.AppWorkspace;
            ckboxShowCheck.Location = new Point(823, 93);
            ckboxShowCheck.Margin = new Padding(4);
            ckboxShowCheck.Name = "ckboxShowCheck";
            ckboxShowCheck.Size = new Size(98, 21);
            ckboxShowCheck.TabIndex = 18;
            ckboxShowCheck.Text = "Show check";
            ckboxShowCheck.UseVisualStyleBackColor = true;
            ckboxShowCheck.CheckedChanged += ckboxShowCheck_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNganhHang);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(382, 8);
            groupBox1.Margin = new Padding(26, 27, 26, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(167, 68);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngành hàng:";
            // 
            // cboNganhHang
            // 
            cboNganhHang.Dock = DockStyle.Top;
            cboNganhHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboNganhHang.FormattingEnabled = true;
            cboNganhHang.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboNganhHang.Location = new Point(4, 22);
            cboNganhHang.Margin = new Padding(4);
            cboNganhHang.Name = "cboNganhHang";
            cboNganhHang.Size = new Size(159, 25);
            cboNganhHang.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboThuongHieu);
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox3.Location = new Point(196, 8);
            groupBox3.Margin = new Padding(26, 27, 26, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(167, 68);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thương hiệu:";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.Dock = DockStyle.Top;
            cboThuongHieu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboThuongHieu.FormattingEnabled = true;
            cboThuongHieu.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboThuongHieu.Location = new Point(4, 22);
            cboThuongHieu.Margin = new Padding(4);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(159, 25);
            cboThuongHieu.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(3, 93);
            txtTimKiem.Margin = new Padding(4, 53, 4, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(174, 27);
            txtTimKiem.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnApDungGiamGia);
            flowLayoutPanel2.Controls.Add(btnHuyGiamGia);
            flowLayoutPanel2.Controls.Add(btnTaoPhieuNhap);
            flowLayoutPanel2.Controls.Add(btnThemSanPham);
            flowLayoutPanel2.Controls.Add(btnXoaSanPham);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            flowLayoutPanel2.Location = new Point(4, 4);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(930, 49);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnApDungGiamGia
            // 
            btnApDungGiamGia.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnApDungGiamGia.Location = new Point(4, 4);
            btnApDungGiamGia.Margin = new Padding(4);
            btnApDungGiamGia.Name = "btnApDungGiamGia";
            btnApDungGiamGia.Size = new Size(174, 31);
            btnApDungGiamGia.TabIndex = 22;
            btnApDungGiamGia.Text = "Áp dụng giảm giá";
            btnApDungGiamGia.UseVisualStyleBackColor = true;
            btnApDungGiamGia.Click += btnApDungGiamGia_Click;
            // 
            // btnHuyGiamGia
            // 
            btnHuyGiamGia.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnHuyGiamGia.Location = new Point(186, 4);
            btnHuyGiamGia.Margin = new Padding(4);
            btnHuyGiamGia.Name = "btnHuyGiamGia";
            btnHuyGiamGia.Size = new Size(174, 31);
            btnHuyGiamGia.TabIndex = 23;
            btnHuyGiamGia.Text = "Hủy bỏ giảm giá";
            btnHuyGiamGia.UseVisualStyleBackColor = true;
            btnHuyGiamGia.Click += btnHuyGiamGia_Click;
            // 
            // btnTaoPhieuNhap
            // 
            btnTaoPhieuNhap.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnTaoPhieuNhap.Location = new Point(368, 4);
            btnTaoPhieuNhap.Margin = new Padding(4);
            btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            btnTaoPhieuNhap.Size = new Size(174, 31);
            btnTaoPhieuNhap.TabIndex = 20;
            btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
            btnTaoPhieuNhap.UseVisualStyleBackColor = true;
            btnTaoPhieuNhap.Click += btnTaoPhieuNhap_Click;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnThemSanPham.Location = new Point(550, 4);
            btnThemSanPham.Margin = new Padding(4);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(174, 31);
            btnThemSanPham.TabIndex = 21;
            btnThemSanPham.Text = "Thêm sản phẩm";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += btnThemSanPham_Click;
            // 
            // btnXoaSanPham
            // 
            btnXoaSanPham.BackColor = Color.MistyRose;
            btnXoaSanPham.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnXoaSanPham.ForeColor = Color.Red;
            btnXoaSanPham.Location = new Point(732, 4);
            btnXoaSanPham.Margin = new Padding(4);
            btnXoaSanPham.Name = "btnXoaSanPham";
            btnXoaSanPham.Size = new Size(174, 31);
            btnXoaSanPham.TabIndex = 24;
            btnXoaSanPham.Text = "Xóa sản phẩm";
            btnXoaSanPham.UseVisualStyleBackColor = false;
            // 
            // SanPhamUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "SanPhamUC";
            Size = new Size(938, 427);
            Load += SanPhamUC_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flpSanPham;
        private Panel panel1;
        private Button btnApDungGiamGia;
        private Button btnThemSanPham;
        private Button btnTaoPhieuNhap;
        private CheckBox ckboxShowCheck;
        private GroupBox groupBox2;
        private ComboBox cboLoaiSanPham;
        private GroupBox groupBox1;
        private ComboBox cboNganhHang;
        private GroupBox groupBox3;
        private ComboBox cboThuongHieu;
        private TextBox txtTimKiem;
        private GroupBox groupBox4;
        private ComboBox cboUuDai;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnHuyGiamGia;
        private CheckBox ckboxTatCa;
        private Button btnXoaSanPham;
        private GroupBox groupBox5;
        private ComboBox cboSanPhamTonKho;
    }
}
