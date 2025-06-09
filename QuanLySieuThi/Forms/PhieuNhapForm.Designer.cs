namespace QuanLySieuThi.Forms
{
    partial class PhieuNhapForm
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
            groupBox1 = new GroupBox();
            cboNCC = new ComboBox();
            groupBox4 = new GroupBox();
            txtSDT = new TextBox();
            groupBox2 = new GroupBox();
            txtTenNCC = new TextBox();
            groupBox5 = new GroupBox();
            txtMaNCC = new TextBox();
            btnXacNhanNCC = new Button();
            lblTongTienCacSanPham = new Label();
            btnXacNhanSP = new Button();
            txtMaSP = new TextBox();
            panel1 = new Panel();
            btnTaoPhieuNhap = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvSP_Nhap = new DataGridView();
            groupBox6 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cboPhieuNhapCart = new ComboBox();
            btnSaveCart = new Button();
            btnDeleteCart = new Button();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP_Nhap).BeginInit();
            groupBox6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox7.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(cboNCC);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(btnXacNhanNCC);
            groupBox1.Location = new Point(4, 125);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1026, 108);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp:";
            // 
            // cboNCC
            // 
            cboNCC.FormattingEnabled = true;
            cboNCC.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboNCC.Location = new Point(4, 41);
            cboNCC.Margin = new Padding(4, 13, 4, 4);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(202, 28);
            cboNCC.TabIndex = 29;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox4.Location = new Point(780, 25);
            groupBox4.Margin = new Padding(26, 13, 13, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(235, 68);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Top;
            txtSDT.Location = new Point(4, 22);
            txtSDT.Margin = new Padding(4);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(227, 25);
            txtSDT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenNCC);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(499, 25);
            groupBox2.Margin = new Padding(26, 13, 13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(257, 68);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên NCC:";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Dock = DockStyle.Top;
            txtTenNCC.Location = new Point(4, 22);
            txtTenNCC.Margin = new Padding(4);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.ReadOnly = true;
            txtTenNCC.Size = new Size(249, 25);
            txtTenNCC.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtMaNCC);
            groupBox5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox5.Location = new Point(324, 25);
            groupBox5.Margin = new Padding(26, 13, 13, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(150, 66);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mã NCC:";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Dock = DockStyle.Top;
            txtMaNCC.Location = new Point(4, 22);
            txtMaNCC.Margin = new Padding(4);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(142, 25);
            txtMaNCC.TabIndex = 0;
            // 
            // btnXacNhanNCC
            // 
            btnXacNhanNCC.BackColor = Color.Snow;
            btnXacNhanNCC.ForeColor = Color.Red;
            btnXacNhanNCC.Location = new Point(215, 40);
            btnXacNhanNCC.Margin = new Padding(13);
            btnXacNhanNCC.Name = "btnXacNhanNCC";
            btnXacNhanNCC.Size = new Size(96, 31);
            btnXacNhanNCC.TabIndex = 9;
            btnXacNhanNCC.Text = "Xác nhận";
            btnXacNhanNCC.UseVisualStyleBackColor = false;
            // 
            // lblTongTienCacSanPham
            // 
            lblTongTienCacSanPham.AutoSize = true;
            lblTongTienCacSanPham.Location = new Point(414, 20);
            lblTongTienCacSanPham.Margin = new Padding(13, 27, 13, 13);
            lblTongTienCacSanPham.Name = "lblTongTienCacSanPham";
            lblTongTienCacSanPham.Size = new Size(183, 20);
            lblTongTienCacSanPham.TabIndex = 27;
            lblTongTienCacSanPham.Text = "Tổng tiền sản phẩm: 100";
            // 
            // btnXacNhanSP
            // 
            btnXacNhanSP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXacNhanSP.AutoSize = true;
            btnXacNhanSP.BackColor = Color.Snow;
            btnXacNhanSP.ForeColor = Color.Red;
            btnXacNhanSP.Location = new Point(212, 14);
            btnXacNhanSP.Margin = new Padding(13);
            btnXacNhanSP.Name = "btnXacNhanSP";
            btnXacNhanSP.Size = new Size(96, 33);
            btnXacNhanSP.TabIndex = 26;
            btnXacNhanSP.Text = "Xác nhận";
            btnXacNhanSP.UseVisualStyleBackColor = false;
            // 
            // txtMaSP
            // 
            txtMaSP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtMaSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaSP.Location = new Point(9, 16);
            txtMaSP.Margin = new Padding(13);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.PlaceholderText = "Nhập mã SP";
            txtMaSP.Size = new Size(192, 27);
            txtMaSP.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTongTienCacSanPham);
            panel1.Controls.Add(btnXacNhanSP);
            panel1.Controls.Add(btnTaoPhieuNhap);
            panel1.Controls.Add(txtMaSP);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 55);
            panel1.TabIndex = 13;
            // 
            // btnTaoPhieuNhap
            // 
            btnTaoPhieuNhap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTaoPhieuNhap.BackColor = Color.Snow;
            btnTaoPhieuNhap.ForeColor = Color.Red;
            btnTaoPhieuNhap.Location = new Point(855, 7);
            btnTaoPhieuNhap.Margin = new Padding(4);
            btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            btnTaoPhieuNhap.Size = new Size(152, 39);
            btnTaoPhieuNhap.TabIndex = 33;
            btnTaoPhieuNhap.Text = "Tạo phiếu nhập";
            btnTaoPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvSP_Nhap, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 24);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1018, 259);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvSP_Nhap
            // 
            dgvSP_Nhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP_Nhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP_Nhap.Dock = DockStyle.Fill;
            dgvSP_Nhap.Location = new Point(4, 67);
            dgvSP_Nhap.Margin = new Padding(4);
            dgvSP_Nhap.Name = "dgvSP_Nhap";
            dgvSP_Nhap.Size = new Size(1010, 188);
            dgvSP_Nhap.TabIndex = 12;
            // 
            // groupBox6
            // 
            tableLayoutPanel1.SetColumnSpan(groupBox6, 4);
            groupBox6.Controls.Add(tableLayoutPanel2);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(4, 265);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(1026, 287);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Danh sách sản phẩm mua:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 541F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox7, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox6, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 121F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1034, 556);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(flowLayoutPanel1);
            groupBox7.Dock = DockStyle.Top;
            groupBox7.Location = new Point(4, 4);
            groupBox7.Margin = new Padding(4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(533, 89);
            groupBox7.TabIndex = 37;
            groupBox7.TabStop = false;
            groupBox7.Text = "Phiếu nhập tạm lưu:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cboPhieuNhapCart);
            flowLayoutPanel1.Controls.Add(btnSaveCart);
            flowLayoutPanel1.Controls.Add(btnDeleteCart);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 24);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(525, 61);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // cboPhieuNhapCart
            // 
            cboPhieuNhapCart.FormattingEnabled = true;
            cboPhieuNhapCart.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboPhieuNhapCart.Location = new Point(4, 13);
            cboPhieuNhapCart.Margin = new Padding(4, 13, 4, 4);
            cboPhieuNhapCart.Name = "cboPhieuNhapCart";
            cboPhieuNhapCart.Size = new Size(202, 28);
            cboPhieuNhapCart.TabIndex = 28;
            // 
            // btnSaveCart
            // 
            btnSaveCart.AutoSize = true;
            btnSaveCart.ForeColor = Color.FromArgb(255, 128, 0);
            btnSaveCart.Location = new Point(214, 4);
            btnSaveCart.Margin = new Padding(4);
            btnSaveCart.Name = "btnSaveCart";
            btnSaveCart.Size = new Size(135, 47);
            btnSaveCart.TabIndex = 26;
            btnSaveCart.Text = "Lưu phiếu nhập";
            btnSaveCart.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCart
            // 
            btnDeleteCart.AutoSize = true;
            btnDeleteCart.ForeColor = SystemColors.InfoText;
            btnDeleteCart.Location = new Point(357, 4);
            btnDeleteCart.Margin = new Padding(4);
            btnDeleteCart.Name = "btnDeleteCart";
            btnDeleteCart.Size = new Size(135, 47);
            btnDeleteCart.TabIndex = 27;
            btnDeleteCart.Text = "Xóa phiếu nhập";
            btnDeleteCart.UseVisualStyleBackColor = true;
            // 
            // PhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 556);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "PhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu nhập";
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP_Nhap).EndInit();
            groupBox6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox6;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvSP_Nhap;
        private Panel panel1;
        private Label lblTongTienCacSanPham;
        private Button btnXacNhanSP;
        private TextBox txtMaSP;
        private Button btnTaoPhieuNhap;
        private GroupBox groupBox4;
        private TextBox txtSDT;
        private GroupBox groupBox2;
        private TextBox txtTenNCC;
        private GroupBox groupBox5;
        private TextBox txtMaNCC;
        private Button btnXacNhanNCC;
        private ComboBox cboNCC;
        private GroupBox groupBox7;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cboPhieuNhapCart;
        private Button btnSaveCart;
        private Button btnDeleteCart;
    }
}