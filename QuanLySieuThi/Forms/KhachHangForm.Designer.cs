namespace QuanLySieuThi.Forms
{
    partial class KhachHangForm
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
            labelTieuDe = new Label();
            button1 = new Button();
            txtTenKH = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtSDT = new TextBox();
            groupBox3 = new GroupBox();
            cboGioiTinh = new ComboBox();
            groupBox4 = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            groupBox5 = new GroupBox();
            txtDiemTichLuy = new TextBox();
            groupBox6 = new GroupBox();
            txtNgayDangKyThanhVien = new TextBox();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // labelTieuDe
            // 
            labelTieuDe.BackColor = Color.WhiteSmoke;
            labelTieuDe.BorderStyle = BorderStyle.Fixed3D;
            labelTieuDe.CausesValidation = false;
            labelTieuDe.Dock = DockStyle.Top;
            labelTieuDe.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.FromArgb(41, 128, 185);
            labelTieuDe.Location = new Point(0, 0);
            labelTieuDe.Margin = new Padding(4, 0, 4, 0);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(584, 103);
            labelTieuDe.TabIndex = 19;
            labelTieuDe.Text = "THÔNG TIN KHÁCH HÀNG KH001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(478, 622);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Dock = DockStyle.Top;
            txtTenKH.Location = new Point(4, 24);
            txtTenKH.Margin = new Padding(4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(452, 27);
            txtTenKH.TabIndex = 0;
            txtTenKH.Text = "dddddd";
            txtTenKH.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.ForeColor = SystemColors.GrayText;
            groupBox1.Location = new Point(35, 131);
            groupBox1.Margin = new Padding(26, 13, 13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(460, 65);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSDT);
            groupBox2.ForeColor = SystemColors.GrayText;
            groupBox2.Location = new Point(35, 212);
            groupBox2.Margin = new Padding(26, 13, 13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(460, 65);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Top;
            txtSDT.Location = new Point(4, 24);
            txtSDT.Margin = new Padding(4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(452, 27);
            txtSDT.TabIndex = 0;
            txtSDT.Text = "dddddd";
            txtSDT.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboGioiTinh);
            groupBox3.ForeColor = SystemColors.GrayText;
            groupBox3.Location = new Point(35, 293);
            groupBox3.Margin = new Padding(26, 13, 13, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(460, 65);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Dock = DockStyle.Fill;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Location = new Point(4, 24);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(452, 28);
            cboGioiTinh.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpNgaySinh);
            groupBox4.ForeColor = SystemColors.GrayText;
            groupBox4.Location = new Point(35, 374);
            groupBox4.Margin = new Padding(26, 13, 13, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(460, 65);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Location = new Point(4, 24);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(452, 27);
            dtpNgaySinh.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtDiemTichLuy);
            groupBox5.ForeColor = SystemColors.GrayText;
            groupBox5.Location = new Point(35, 455);
            groupBox5.Margin = new Padding(26, 13, 13, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(460, 65);
            groupBox5.TabIndex = 28;
            groupBox5.TabStop = false;
            groupBox5.Text = "Điểm tích lũy:";
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Dock = DockStyle.Top;
            txtDiemTichLuy.Location = new Point(4, 24);
            txtDiemTichLuy.Margin = new Padding(4);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.ReadOnly = true;
            txtDiemTichLuy.Size = new Size(452, 27);
            txtDiemTichLuy.TabIndex = 0;
            txtDiemTichLuy.Text = "dddddd";
            txtDiemTichLuy.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtNgayDangKyThanhVien);
            groupBox6.ForeColor = SystemColors.GrayText;
            groupBox6.Location = new Point(35, 536);
            groupBox6.Margin = new Padding(26, 13, 13, 13);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(460, 65);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ngày đăng ký thành viên:";
            // 
            // txtNgayDangKyThanhVien
            // 
            txtNgayDangKyThanhVien.Dock = DockStyle.Top;
            txtNgayDangKyThanhVien.Location = new Point(4, 24);
            txtNgayDangKyThanhVien.Margin = new Padding(4);
            txtNgayDangKyThanhVien.Name = "txtNgayDangKyThanhVien";
            txtNgayDangKyThanhVien.ReadOnly = true;
            txtNgayDangKyThanhVien.Size = new Size(452, 27);
            txtNgayDangKyThanhVien.TabIndex = 0;
            txtNgayDangKyThanhVien.Text = "dddddd";
            txtNgayDangKyThanhVien.Visible = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.Snow;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(9, 622);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 43);
            btnXoa.TabIndex = 30;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // KhachHangForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 671);
            Controls.Add(btnXoa);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(labelTieuDe);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(600, 710);
            MinimizeBox = false;
            MinimumSize = new Size(600, 710);
            Name = "KhachHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách hàng";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelTieuDe;
        private Button button1;
        private TextBox txtTenKH;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cboGioiTinh;
        private DateTimePicker dtpNgaySinh;
        private GroupBox groupBox5;
        private TextBox txtDiemTichLuy;
        private GroupBox groupBox6;
        private TextBox txtNgayDangKyThanhVien;
        private Button btnXoa;
    }
}