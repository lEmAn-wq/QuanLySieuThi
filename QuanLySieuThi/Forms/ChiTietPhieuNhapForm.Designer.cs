namespace QuanLySieuThi.Forms
{
    partial class ChiTietPhieuNhapForm: System.Windows.Forms.Form
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelTieuDe = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            txtMaNCC = new TextBox();
            groupBox2 = new GroupBox();
            txtTenNCC = new TextBox();
            groupBox3 = new GroupBox();
            txtMaNV_ThuNgan = new TextBox();
            groupBox9 = new GroupBox();
            txtMaNV_Duyet = new TextBox();
            groupBox6 = new GroupBox();
            txtTongTien = new TextBox();
            groupBox4 = new GroupBox();
            txtNgayLap = new TextBox();
            groupBox5 = new GroupBox();
            txtNgayGiaoDuKien = new TextBox();
            groupBox7 = new GroupBox();
            txtNgayGiao = new TextBox();
            groupBox8 = new GroupBox();
            txtTrangThaiPhieuNhap = new TextBox();
            groupBox10 = new GroupBox();
            dgvSP_Nhap = new DataGridView();
            panel1 = new Panel();
            btnXacNhanHuy = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP_Nhap).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.Size = new Size(979, 481);
            tableLayoutPanel1.TabIndex = 21;
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
            labelTieuDe.Size = new Size(971, 97);
            labelTieuDe.TabIndex = 21;
            labelTieuDe.Text = "THÔNG TIN CHI TIẾT PHIẾU NHẬP PN001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox9);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Controls.Add(groupBox8);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(973, 179);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaNCC);
            groupBox1.Location = new Point(30, 20);
            groupBox1.Margin = new Padding(30, 20, 30, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Dock = DockStyle.Fill;
            txtMaNCC.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaNCC.Location = new Point(3, 23);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.ReadOnly = true;
            txtMaNCC.Size = new Size(157, 27);
            txtMaNCC.TabIndex = 0;
            txtMaNCC.Text = "NCC01";
            txtMaNCC.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTenNCC);
            groupBox2.Location = new Point(253, 20);
            groupBox2.Margin = new Padding(30, 20, 30, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên NCC";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Dock = DockStyle.Fill;
            txtTenNCC.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTenNCC.Location = new Point(3, 23);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.ReadOnly = true;
            txtTenNCC.Size = new Size(214, 27);
            txtTenNCC.TabIndex = 0;
            txtTenNCC.Text = "Nhà cung cấp A";
            txtTenNCC.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMaNV_ThuNgan);
            groupBox3.Location = new Point(533, 20);
            groupBox3.Margin = new Padding(30, 20, 30, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(163, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhân viên tạo đơn";
            // 
            // txtMaNV_ThuNgan
            // 
            txtMaNV_ThuNgan.Dock = DockStyle.Fill;
            txtMaNV_ThuNgan.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaNV_ThuNgan.Location = new Point(3, 23);
            txtMaNV_ThuNgan.Name = "txtMaNV_ThuNgan";
            txtMaNV_ThuNgan.ReadOnly = true;
            txtMaNV_ThuNgan.Size = new Size(157, 27);
            txtMaNV_ThuNgan.TabIndex = 0;
            txtMaNV_ThuNgan.Text = "NV001";
            txtMaNV_ThuNgan.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtMaNV_Duyet);
            groupBox9.Location = new Point(756, 20);
            groupBox9.Margin = new Padding(30, 20, 30, 10);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(163, 58);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Nhân viên duyệt";
            // 
            // txtMaNV_Duyet
            // 
            txtMaNV_Duyet.Dock = DockStyle.Fill;
            txtMaNV_Duyet.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtMaNV_Duyet.Location = new Point(3, 23);
            txtMaNV_Duyet.Name = "txtMaNV_Duyet";
            txtMaNV_Duyet.ReadOnly = true;
            txtMaNV_Duyet.Size = new Size(157, 27);
            txtMaNV_Duyet.TabIndex = 0;
            txtMaNV_Duyet.Text = "NV001";
            txtMaNV_Duyet.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtTongTien);
            groupBox6.Location = new Point(20, 108);
            groupBox6.Margin = new Padding(20, 20, 10, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(163, 58);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(3, 23);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(157, 27);
            txtTongTien.TabIndex = 0;
            txtTongTien.Text = "27/7/2004";
            txtTongTien.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtNgayLap);
            groupBox4.Location = new Point(213, 108);
            groupBox4.Margin = new Padding(20, 20, 10, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(163, 58);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ngày lập";
            // 
            // txtNgayLap
            // 
            txtNgayLap.Dock = DockStyle.Fill;
            txtNgayLap.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNgayLap.Location = new Point(3, 23);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.ReadOnly = true;
            txtNgayLap.Size = new Size(157, 27);
            txtNgayLap.TabIndex = 0;
            txtNgayLap.Text = "27/7/2004";
            txtNgayLap.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtNgayGiaoDuKien);
            groupBox5.Location = new Point(406, 108);
            groupBox5.Margin = new Padding(20, 20, 10, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(163, 58);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ngày giao dự kiến";
            // 
            // txtNgayGiaoDuKien
            // 
            txtNgayGiaoDuKien.Dock = DockStyle.Fill;
            txtNgayGiaoDuKien.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNgayGiaoDuKien.Location = new Point(3, 23);
            txtNgayGiaoDuKien.Name = "txtNgayGiaoDuKien";
            txtNgayGiaoDuKien.ReadOnly = true;
            txtNgayGiaoDuKien.Size = new Size(157, 27);
            txtNgayGiaoDuKien.TabIndex = 0;
            txtNgayGiaoDuKien.Text = "27/7/2004";
            txtNgayGiaoDuKien.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtNgayGiao);
            groupBox7.Location = new Point(599, 108);
            groupBox7.Margin = new Padding(20, 20, 10, 10);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(163, 58);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ngày giao";
            // 
            // txtNgayGiao
            // 
            txtNgayGiao.Dock = DockStyle.Fill;
            txtNgayGiao.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNgayGiao.Location = new Point(3, 23);
            txtNgayGiao.Name = "txtNgayGiao";
            txtNgayGiao.ReadOnly = true;
            txtNgayGiao.Size = new Size(157, 27);
            txtNgayGiao.TabIndex = 0;
            txtNgayGiao.Text = "27/7/2004";
            txtNgayGiao.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtTrangThaiPhieuNhap);
            groupBox8.Location = new Point(792, 108);
            groupBox8.Margin = new Padding(20, 20, 10, 10);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(163, 58);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "Trạng thái";
            // 
            // txtTrangThaiPhieuNhap
            // 
            txtTrangThaiPhieuNhap.Dock = DockStyle.Fill;
            txtTrangThaiPhieuNhap.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTrangThaiPhieuNhap.Location = new Point(3, 23);
            txtTrangThaiPhieuNhap.Name = "txtTrangThaiPhieuNhap";
            txtTrangThaiPhieuNhap.ReadOnly = true;
            txtTrangThaiPhieuNhap.Size = new Size(157, 27);
            txtTrangThaiPhieuNhap.TabIndex = 0;
            txtTrangThaiPhieuNhap.Text = "27/7/2004";
            txtTrangThaiPhieuNhap.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(dgvSP_Nhap);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.Location = new Point(3, 285);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(973, 128);
            groupBox10.TabIndex = 23;
            groupBox10.TabStop = false;
            groupBox10.Text = "Danh sách sản phẩm nhập";
            // 
            // dgvSP_Nhap
            // 
            dgvSP_Nhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP_Nhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP_Nhap.Dock = DockStyle.Fill;
            dgvSP_Nhap.Location = new Point(3, 23);
            dgvSP_Nhap.Margin = new Padding(4);
            dgvSP_Nhap.MultiSelect = false;
            dgvSP_Nhap.Name = "dgvSP_Nhap";
            dgvSP_Nhap.ReadOnly = true;
            dgvSP_Nhap.Size = new Size(967, 102);
            dgvSP_Nhap.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXacNhanHuy);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(973, 59);
            panel1.TabIndex = 24;
            // 
            // btnXacNhanHuy
            // 
            btnXacNhanHuy.BackColor = Color.Snow;
            btnXacNhanHuy.ForeColor = Color.Red;
            btnXacNhanHuy.Location = new Point(3, 10);
            btnXacNhanHuy.Name = "btnXacNhanHuy";
            btnXacNhanHuy.Size = new Size(120, 46);
            btnXacNhanHuy.TabIndex = 1;
            btnXacNhanHuy.Text = "Xác nhận hủy";
            btnXacNhanHuy.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(816, 10);
            button1.Name = "button1";
            button1.Size = new Size(154, 46);
            button1.TabIndex = 0;
            button1.Text = "Cập nhật tồn kho";
            button1.UseVisualStyleBackColor = true;
            // 
            // ChiTietPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 481);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "ChiTietPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết phiếu nhập";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP_Nhap).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        public Label labelTieuDe;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox txtMaNCC;
        private GroupBox groupBox2;
        private TextBox txtTenNCC;
        private GroupBox groupBox3;
        private TextBox txtMaNV_ThuNgan;
        private GroupBox groupBox6;
        private TextBox txtTongTien;
        private GroupBox groupBox4;
        private TextBox txtNgayLap;
        private GroupBox groupBox5;
        private TextBox txtNgayGiaoDuKien;
        private GroupBox groupBox7;
        private TextBox txtNgayGiao;
        private GroupBox groupBox8;
        private TextBox txtTrangThaiPhieuNhap;
        private GroupBox groupBox9;
        private TextBox txtMaNV_Duyet;
        private GroupBox groupBox10;
        private DataGridView dgvSP_Nhap;
        private Panel panel1;
        private Button button1;
        private Button btnXacNhanHuy;
    }
}