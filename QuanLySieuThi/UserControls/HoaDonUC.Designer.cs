namespace QuanLySieuThi
{
    partial class HoaDonUC
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
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvHoaDon = new DataGridView();
            flowLayoutPanel3 = new FlowLayoutPanel();
            txtTimKiem = new TextBox();
            groupBox3 = new GroupBox();
            cboTrangThaiDonHang = new ComboBox();
            groupBox1 = new GroupBox();
            dtpNgayBatDau = new DateTimePicker();
            groupBox2 = new GroupBox();
            dtpNgayKetThuc = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblTongTien = new Label();
            btnTinhTongTien = new Button();
            btnThongKe = new Button();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvHoaDon, 0, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.Size = new Size(938, 427);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvHoaDon, 2);
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(4, 101);
            dgvHoaDon.Margin = new Padding(4);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.Size = new Size(930, 249);
            dgvHoaDon.TabIndex = 11;
            dgvHoaDon.CellDoubleClick += dgvHoaDon_CellDoubleClick;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(txtTimKiem);
            flowLayoutPanel3.Controls.Add(groupBox3);
            flowLayoutPanel3.Controls.Add(groupBox1);
            flowLayoutPanel3.Controls.Add(groupBox2);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(4, 4);
            flowLayoutPanel3.Margin = new Padding(4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(930, 89);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(4, 57);
            txtTimKiem.Margin = new Padding(4, 53, 4, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(189, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboTrangThaiDonHang);
            groupBox3.Location = new Point(217, 10);
            groupBox3.Margin = new Padding(20, 10, 10, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(9);
            groupBox3.Size = new Size(200, 68);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Trạng thái đơn hàng";
            // 
            // cboTrangThaiDonHang
            // 
            cboTrangThaiDonHang.Dock = DockStyle.Fill;
            cboTrangThaiDonHang.FormattingEnabled = true;
            cboTrangThaiDonHang.Location = new Point(9, 29);
            cboTrangThaiDonHang.Name = "cboTrangThaiDonHang";
            cboTrangThaiDonHang.Size = new Size(182, 28);
            cboTrangThaiDonHang.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Location = new Point(477, 13);
            groupBox1.Margin = new Padding(50, 13, 10, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(201, 62);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Từ ngày:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Dock = DockStyle.Top;
            dtpNgayBatDau.Font = new Font("Segoe UI", 9F);
            dtpNgayBatDau.Location = new Point(4, 24);
            dtpNgayBatDau.Margin = new Padding(4);
            dtpNgayBatDau.MaxDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(193, 23);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox2.Controls.Add(dtpNgayKetThuc);
            groupBox2.Location = new Point(708, 13);
            groupBox2.Margin = new Padding(20, 13, 13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(209, 62);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đến ngày:";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Dock = DockStyle.Top;
            dtpNgayKetThuc.Font = new Font("Segoe UI", 9F);
            dtpNgayKetThuc.Location = new Point(4, 24);
            dtpNgayKetThuc.Margin = new Padding(4);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(201, 23);
            dtpNgayKetThuc.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(lblTongTien);
            flowLayoutPanel4.Controls.Add(btnTinhTongTien);
            flowLayoutPanel4.Controls.Add(btnThongKe);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(4, 358);
            flowLayoutPanel4.Margin = new Padding(4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(930, 65);
            flowLayoutPanel4.TabIndex = 12;
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.Location = new Point(4, 13);
            lblTongTien.Margin = new Padding(4, 13, 4, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(284, 39);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền:";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTinhTongTien
            // 
            btnTinhTongTien.Location = new Point(296, 18);
            btnTinhTongTien.Margin = new Padding(4, 18, 4, 4);
            btnTinhTongTien.Name = "btnTinhTongTien";
            btnTinhTongTien.Size = new Size(96, 31);
            btnTinhTongTien.TabIndex = 1;
            btnTinhTongTien.Text = "Tính";
            btnTinhTongTien.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(460, 18);
            btnThongKe.Margin = new Padding(64, 18, 4, 4);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(184, 31);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Tạo biểu đồ thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // HoaDonUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "HoaDonUC";
            Size = new Size(938, 427);
            Load += HoaDonUC_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvHoaDon;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private DateTimePicker dtpNgayBatDau;
        private GroupBox groupBox2;
        private DateTimePicker dtpNgayKetThuc;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label lblTongTien;
        private Button btnTinhTongTien;
        private Button btnThongKe;
        private GroupBox groupBox3;
        private ComboBox cboTrangThaiDonHang;
    }
}
