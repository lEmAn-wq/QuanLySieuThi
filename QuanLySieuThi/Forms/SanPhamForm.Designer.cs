namespace QuanLySieuThi.Forms
{
    partial class SanPhamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnInsertPicture = new Button();
            picboxAnhSP = new PictureBox();
            labelTieuDe = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            txtTenSanPham = new TextBox();
            groupBox5 = new GroupBox();
            txtGiaBan = new TextBox();
            groupBox2 = new GroupBox();
            cboLoaiSanPham = new ComboBox();
            groupBox3 = new GroupBox();
            cboThuongHieu = new ComboBox();
            groupBox6 = new GroupBox();
            cboLoaiUuDai = new ComboBox();
            groupBox1 = new GroupBox();
            cboNganhHang = new ComboBox();
            panel1 = new Panel();
            button1 = new Button();
            btnXoa = new Button();
            groupBox7 = new GroupBox();
            txtSoLuong = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxAnhSP).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(btnInsertPicture, 0, 2);
            tableLayoutPanel1.Controls.Add(picboxAnhSP, 0, 1);
            tableLayoutPanel1.Controls.Add(labelTieuDe, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(1029, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInsertPicture
            // 
            btnInsertPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnInsertPicture.AutoSize = true;
            btnInsertPicture.Location = new Point(118, 555);
            btnInsertPicture.Margin = new Padding(4);
            btnInsertPicture.Name = "btnInsertPicture";
            btnInsertPicture.Size = new Size(174, 41);
            btnInsertPicture.TabIndex = 23;
            btnInsertPicture.Text = "Insert picture";
            btnInsertPicture.UseVisualStyleBackColor = true;
            // 
            // picboxAnhSP
            // 
            picboxAnhSP.BorderStyle = BorderStyle.FixedSingle;
            picboxAnhSP.Dock = DockStyle.Fill;
            picboxAnhSP.Image = (Image)resources.GetObject("picboxAnhSP.Image");
            picboxAnhSP.Location = new Point(4, 99);
            picboxAnhSP.Margin = new Padding(4);
            picboxAnhSP.Name = "picboxAnhSP";
            picboxAnhSP.Size = new Size(403, 448);
            picboxAnhSP.SizeMode = PictureBoxSizeMode.Zoom;
            picboxAnhSP.TabIndex = 18;
            picboxAnhSP.TabStop = false;
            // 
            // labelTieuDe
            // 
            labelTieuDe.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.SetColumnSpan(labelTieuDe, 2);
            labelTieuDe.Dock = DockStyle.Fill;
            labelTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.FromArgb(41, 128, 185);
            labelTieuDe.Location = new Point(4, 0);
            labelTieuDe.Margin = new Padding(4, 0, 4, 0);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(1021, 95);
            labelTieuDe.TabIndex = 17;
            labelTieuDe.Text = "THÔNG TIN SẢN PHẨM SP001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Location = new Point(415, 99);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(554, 448);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenSanPham);
            groupBox4.Location = new Point(26, 10);
            groupBox4.Margin = new Padding(26, 10, 26, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(495, 68);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Dock = DockStyle.Top;
            txtTenSanPham.Location = new Point(4, 24);
            txtTenSanPham.Margin = new Padding(4);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(487, 27);
            txtTenSanPham.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtGiaBan);
            groupBox5.Location = new Point(26, 98);
            groupBox5.Margin = new Padding(26, 10, 26, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(495, 68);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Dock = DockStyle.Top;
            txtGiaBan.Location = new Point(4, 24);
            txtGiaBan.Margin = new Padding(4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(487, 27);
            txtGiaBan.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboLoaiSanPham);
            groupBox2.Location = new Point(26, 362);
            groupBox2.Margin = new Padding(26, 10, 20, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(210, 68);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Dock = DockStyle.Top;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboLoaiSanPham.Location = new Point(4, 24);
            cboLoaiSanPham.Margin = new Padding(4);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(202, 28);
            cboLoaiSanPham.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboThuongHieu);
            groupBox3.Location = new Point(282, 362);
            groupBox3.Margin = new Padding(26, 10, 20, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(210, 68);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thương hiệu:";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.Dock = DockStyle.Top;
            cboThuongHieu.FormattingEnabled = true;
            cboThuongHieu.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboThuongHieu.Location = new Point(4, 24);
            cboThuongHieu.Margin = new Padding(4);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(202, 28);
            cboThuongHieu.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cboLoaiUuDai);
            groupBox6.Location = new Point(26, 274);
            groupBox6.Margin = new Padding(26, 10, 20, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(210, 68);
            groupBox6.TabIndex = 23;
            groupBox6.TabStop = false;
            groupBox6.Text = "Loại ưu đãi:";
            // 
            // cboLoaiUuDai
            // 
            cboLoaiUuDai.Dock = DockStyle.Top;
            cboLoaiUuDai.FormattingEnabled = true;
            cboLoaiUuDai.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboLoaiUuDai.Location = new Point(4, 24);
            cboLoaiUuDai.Margin = new Padding(4);
            cboLoaiUuDai.Name = "cboLoaiUuDai";
            cboLoaiUuDai.Size = new Size(202, 28);
            cboLoaiUuDai.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboNganhHang);
            groupBox1.Location = new Point(282, 274);
            groupBox1.Margin = new Padding(26, 10, 20, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(210, 68);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngành hàng:";
            // 
            // cboNganhHang
            // 
            cboNganhHang.Dock = DockStyle.Top;
            cboNganhHang.FormattingEnabled = true;
            cboNganhHang.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboNganhHang.Location = new Point(4, 24);
            cboNganhHang.Margin = new Padding(4);
            cboNganhHang.Name = "cboNganhHang";
            cboNganhHang.Size = new Size(202, 28);
            cboNganhHang.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnXoa);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(414, 554);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 43);
            panel1.TabIndex = 22;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(438, 0);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(174, 43);
            button1.TabIndex = 3;
            button1.Text = "Thay đổi";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.BackColor = Color.Snow;
            btnXoa.Dock = DockStyle.Left;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(0, 0);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(174, 43);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtSoLuong);
            groupBox7.Location = new Point(26, 186);
            groupBox7.Margin = new Padding(26, 10, 26, 10);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4);
            groupBox7.Size = new Size(495, 68);
            groupBox7.TabIndex = 24;
            groupBox7.TabStop = false;
            groupBox7.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Top;
            txtSoLuong.Location = new Point(4, 24);
            txtSoLuong.Margin = new Padding(4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(487, 27);
            txtSoLuong.TabIndex = 0;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1045, 639);
            MinimizeBox = false;
            MinimumSize = new Size(1045, 639);
            Name = "SanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxAnhSP).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Label labelTieuDe;
        private PictureBox picboxAnhSP;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox2;
        private ComboBox cboLoaiSanPham;
        private GroupBox groupBox1;
        private ComboBox cboNganhHang;
        private GroupBox groupBox3;
        private ComboBox cboThuongHieu;
        private GroupBox groupBox4;
        private TextBox txtTenSanPham;
        private GroupBox groupBox5;
        private TextBox txtGiaBan;
        private GroupBox groupBox6;
        private ComboBox cboLoaiUuDai;
        private Button btnInsert;
        private Button btn;
        private Button button2;
        private Panel panel1;
        private Button button1;
        private Button btnXoa;
        private Button btnInsertPicture;
        private GroupBox groupBox7;
        private TextBox txtSoLuong;
    }
}