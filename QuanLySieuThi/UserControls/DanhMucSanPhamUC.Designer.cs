namespace QuanLySieuThi
{
    partial class DanhMucSanPhamUC
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
            groupBox4 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnThemUuDai = new Button();
            dgvUuDaiSanPham = new DataGridView();
            txtTimKiemUuDai = new TextBox();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnThemNganhHang = new Button();
            dgvNganhHang = new DataGridView();
            txtTimKiemNganhHang = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnThemLoaiSanPham = new Button();
            dgvLoaiSanPham = new DataGridView();
            txtTimKiemLoaiSanPham = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnThemThuongHieu = new Button();
            dgvThuongHieu = new DataGridView();
            txtTimKiemThuongHieu = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUuDaiSanPham).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNganhHang).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(938, 427);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tableLayoutPanel5);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.MenuHighlight;
            groupBox4.Location = new Point(473, 217);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(461, 206);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách ưu đãi:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(btnThemUuDai, 1, 0);
            tableLayoutPanel5.Controls.Add(dgvUuDaiSanPham, 0, 1);
            tableLayoutPanel5.Controls.Add(txtTimKiemUuDai, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 24);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(453, 178);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // btnThemUuDai
            // 
            btnThemUuDai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemUuDai.BackColor = Color.Snow;
            btnThemUuDai.ForeColor = Color.Red;
            btnThemUuDai.Location = new Point(345, 4);
            btnThemUuDai.Margin = new Padding(4);
            btnThemUuDai.Name = "btnThemUuDai";
            btnThemUuDai.Size = new Size(104, 53);
            btnThemUuDai.TabIndex = 17;
            btnThemUuDai.Text = "Thêm mới";
            btnThemUuDai.UseVisualStyleBackColor = false;
            btnThemUuDai.Click += btnThemUuDai_Click;
            // 
            // dgvUuDaiSanPham
            // 
            dgvUuDaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUuDaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel5.SetColumnSpan(dgvUuDaiSanPham, 2);
            dgvUuDaiSanPham.Dock = DockStyle.Fill;
            dgvUuDaiSanPham.Location = new Point(4, 65);
            dgvUuDaiSanPham.Margin = new Padding(4);
            dgvUuDaiSanPham.MultiSelect = false;
            dgvUuDaiSanPham.Name = "dgvUuDaiSanPham";
            dgvUuDaiSanPham.ReadOnly = true;
            dgvUuDaiSanPham.Size = new Size(445, 109);
            dgvUuDaiSanPham.TabIndex = 13;
            dgvUuDaiSanPham.CellDoubleClick += dgvUuDaiSanPham_CellDoubleClick;
            // 
            // txtTimKiemUuDai
            // 
            txtTimKiemUuDai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiemUuDai.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiemUuDai.Location = new Point(4, 30);
            txtTimKiemUuDai.Margin = new Padding(4);
            txtTimKiemUuDai.Name = "txtTimKiemUuDai";
            txtTimKiemUuDai.PlaceholderText = "Tìm kiếm";
            txtTimKiemUuDai.Size = new Size(157, 27);
            txtTimKiemUuDai.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.MenuHighlight;
            groupBox3.Location = new Point(4, 217);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(461, 206);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh mục ngành hàng:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnThemNganhHang, 1, 0);
            tableLayoutPanel4.Controls.Add(dgvNganhHang, 0, 1);
            tableLayoutPanel4.Controls.Add(txtTimKiemNganhHang, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 24);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(453, 178);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btnThemNganhHang
            // 
            btnThemNganhHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemNganhHang.BackColor = Color.Snow;
            btnThemNganhHang.ForeColor = Color.Red;
            btnThemNganhHang.Location = new Point(345, 4);
            btnThemNganhHang.Margin = new Padding(4);
            btnThemNganhHang.Name = "btnThemNganhHang";
            btnThemNganhHang.Size = new Size(104, 53);
            btnThemNganhHang.TabIndex = 17;
            btnThemNganhHang.Text = "Thêm mới";
            btnThemNganhHang.UseVisualStyleBackColor = false;
            btnThemNganhHang.Click += btnThemNganhHang_Click;
            // 
            // dgvNganhHang
            // 
            dgvNganhHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNganhHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel4.SetColumnSpan(dgvNganhHang, 2);
            dgvNganhHang.Dock = DockStyle.Fill;
            dgvNganhHang.Location = new Point(4, 65);
            dgvNganhHang.Margin = new Padding(4);
            dgvNganhHang.MultiSelect = false;
            dgvNganhHang.Name = "dgvNganhHang";
            dgvNganhHang.ReadOnly = true;
            dgvNganhHang.Size = new Size(445, 109);
            dgvNganhHang.TabIndex = 13;
            dgvNganhHang.CellDoubleClick += dgvNganhHang_CellDoubleClick;
            // 
            // txtTimKiemNganhHang
            // 
            txtTimKiemNganhHang.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiemNganhHang.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiemNganhHang.Location = new Point(4, 30);
            txtTimKiemNganhHang.Margin = new Padding(4);
            txtTimKiemNganhHang.Name = "txtTimKiemNganhHang";
            txtTimKiemNganhHang.PlaceholderText = "Tìm kiếm";
            txtTimKiemNganhHang.Size = new Size(157, 27);
            txtTimKiemNganhHang.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.MenuHighlight;
            groupBox2.Location = new Point(473, 4);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(461, 205);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục loại sản phẩm:";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnThemLoaiSanPham, 1, 0);
            tableLayoutPanel3.Controls.Add(dgvLoaiSanPham, 0, 1);
            tableLayoutPanel3.Controls.Add(txtTimKiemLoaiSanPham, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 24);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(453, 177);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnThemLoaiSanPham
            // 
            btnThemLoaiSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemLoaiSanPham.BackColor = Color.Snow;
            btnThemLoaiSanPham.ForeColor = Color.Red;
            btnThemLoaiSanPham.Location = new Point(345, 4);
            btnThemLoaiSanPham.Margin = new Padding(4);
            btnThemLoaiSanPham.Name = "btnThemLoaiSanPham";
            btnThemLoaiSanPham.Size = new Size(104, 53);
            btnThemLoaiSanPham.TabIndex = 17;
            btnThemLoaiSanPham.Text = "Thêm mới";
            btnThemLoaiSanPham.UseVisualStyleBackColor = false;
            btnThemLoaiSanPham.Click += btnThemLoaiSanPham_Click;
            // 
            // dgvLoaiSanPham
            // 
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel3.SetColumnSpan(dgvLoaiSanPham, 2);
            dgvLoaiSanPham.Dock = DockStyle.Fill;
            dgvLoaiSanPham.Location = new Point(4, 65);
            dgvLoaiSanPham.Margin = new Padding(4);
            dgvLoaiSanPham.MultiSelect = false;
            dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            dgvLoaiSanPham.ReadOnly = true;
            dgvLoaiSanPham.Size = new Size(445, 108);
            dgvLoaiSanPham.TabIndex = 13;
            dgvLoaiSanPham.CellDoubleClick += dgvLoaiSanPham_CellDoubleClick;
            // 
            // txtTimKiemLoaiSanPham
            // 
            txtTimKiemLoaiSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiemLoaiSanPham.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiemLoaiSanPham.Location = new Point(4, 30);
            txtTimKiemLoaiSanPham.Margin = new Padding(4);
            txtTimKiemLoaiSanPham.Name = "txtTimKiemLoaiSanPham";
            txtTimKiemLoaiSanPham.PlaceholderText = "Tìm kiếm";
            txtTimKiemLoaiSanPham.Size = new Size(157, 27);
            txtTimKiemLoaiSanPham.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.MenuHighlight;
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(461, 205);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục thương hiệu:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnThemThuongHieu, 1, 0);
            tableLayoutPanel2.Controls.Add(dgvThuongHieu, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTimKiemThuongHieu, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 24);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(453, 177);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnThemThuongHieu
            // 
            btnThemThuongHieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThemThuongHieu.BackColor = Color.Snow;
            btnThemThuongHieu.ForeColor = Color.Red;
            btnThemThuongHieu.Location = new Point(345, 4);
            btnThemThuongHieu.Margin = new Padding(4);
            btnThemThuongHieu.Name = "btnThemThuongHieu";
            btnThemThuongHieu.Size = new Size(104, 53);
            btnThemThuongHieu.TabIndex = 17;
            btnThemThuongHieu.Text = "Thêm mới";
            btnThemThuongHieu.UseVisualStyleBackColor = false;
            btnThemThuongHieu.Click += btnThemThuongHieu_Click;
            // 
            // dgvThuongHieu
            // 
            dgvThuongHieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThuongHieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvThuongHieu, 2);
            dgvThuongHieu.Dock = DockStyle.Fill;
            dgvThuongHieu.Location = new Point(4, 65);
            dgvThuongHieu.Margin = new Padding(4);
            dgvThuongHieu.MultiSelect = false;
            dgvThuongHieu.Name = "dgvThuongHieu";
            dgvThuongHieu.ReadOnly = true;
            dgvThuongHieu.Size = new Size(445, 108);
            dgvThuongHieu.TabIndex = 13;
            dgvThuongHieu.CellDoubleClick += dgvThuongHieu_CellDoubleClick;
            // 
            // txtTimKiemThuongHieu
            // 
            txtTimKiemThuongHieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiemThuongHieu.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiemThuongHieu.Location = new Point(4, 30);
            txtTimKiemThuongHieu.Margin = new Padding(4);
            txtTimKiemThuongHieu.Name = "txtTimKiemThuongHieu";
            txtTimKiemThuongHieu.PlaceholderText = "Tìm kiếm";
            txtTimKiemThuongHieu.Size = new Size(157, 27);
            txtTimKiemThuongHieu.TabIndex = 11;
            // 
            // DanhMucSanPhamUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "DanhMucSanPhamUC";
            Size = new Size(938, 427);
            Load += DanhMucSanPhamUC_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUuDaiSanPham).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNganhHang).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiSanPham).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThuongHieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtTimKiemThuongHieu;
        private DataGridView dgvThuongHieu;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnThemUuDai;
        private DataGridView dgvUuDaiSanPham;
        private TextBox txtTimKiemUuDai;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnThemNganhHang;
        private DataGridView dgvNganhHang;
        private TextBox txtTimKiemNganhHang;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnThemLoaiSanPham;
        private DataGridView dgvLoaiSanPham;
        private TextBox txtTimKiemLoaiSanPham;
        private Button btnThemThuongHieu;
    }
}
