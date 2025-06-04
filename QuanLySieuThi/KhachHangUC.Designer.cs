namespace QuanLySieuThi
{
    partial class KhachHangUC
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            txtSDT = new TextBox();
            groupBox2 = new GroupBox();
            cboGioiTinh = new ComboBox();
            groupBox4 = new GroupBox();
            btnXoa = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            txtMa = new TextBox();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            btnThem = new Button();
            btnSua = new Button();
            btnLamMoi = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtTimKiem = new TextBox();
            groupBox7 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            groupBox8 = new GroupBox();
            dateTimePicker3 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(932, 185);
            dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(260, 10);
            groupBox1.Margin = new Padding(20, 10, 20, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên khách hàng:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Họ tên đầy đủ";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Top;
            txtSDT.Location = new Point(3, 19);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(194, 23);
            txtSDT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboGioiTinh);
            groupBox2.Location = new Point(20, 81);
            groupBox2.Margin = new Padding(20, 10, 20, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 51);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Dock = DockStyle.Top;
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(3, 19);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(194, 23);
            cboGioiTinh.TabIndex = 4;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtSDT);
            groupBox4.Location = new Point(260, 81);
            groupBox4.Margin = new Padding(20, 10, 20, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 51);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số điện thoại:";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(710, 101);
            btnXoa.Margin = new Padding(20, 30, 10, 30);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(btnThem);
            flowLayoutPanel1.Controls.Add(btnSua);
            flowLayoutPanel1.Controls.Add(btnXoa);
            flowLayoutPanel1.Controls.Add(btnLamMoi);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(924, 149);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtMa);
            groupBox5.Location = new Point(20, 10);
            groupBox5.Margin = new Padding(20, 10, 20, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 51);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Mã KH:";
            // 
            // txtMa
            // 
            txtMa.Dock = DockStyle.Top;
            txtMa.Location = new Point(3, 19);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(194, 23);
            txtMa.TabIndex = 0;
            txtMa.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Location = new Point(500, 10);
            groupBox3.Margin = new Padding(20, 10, 20, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 51);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ngày sinh:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Top;
            dateTimePicker1.Location = new Point(3, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(500, 101);
            btnThem.Margin = new Padding(20, 30, 10, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(605, 101);
            btnSua.Margin = new Padding(20, 30, 10, 30);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(815, 101);
            btnLamMoi.Margin = new Padding(20, 30, 10, 30);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 930F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(938, 427);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtTimKiem);
            flowLayoutPanel2.Controls.Add(groupBox7);
            flowLayoutPanel2.Controls.Add(groupBox8);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 158);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(924, 75);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(3, 40);
            txtTimKiem.Margin = new Padding(3, 40, 3, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(148, 23);
            txtTimKiem.TabIndex = 10;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dateTimePicker2);
            groupBox7.Location = new Point(254, 10);
            groupBox7.Margin = new Padding(100, 10, 10, 10);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(190, 51);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "Từ ngày:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Top;
            dateTimePicker2.Location = new Point(3, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(184, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(dateTimePicker3);
            groupBox8.Location = new Point(484, 10);
            groupBox8.Margin = new Padding(30, 10, 10, 10);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(190, 51);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Đến ngày:";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Dock = DockStyle.Top;
            dateTimePicker3.Location = new Point(3, 19);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(184, 23);
            dateTimePicker3.TabIndex = 0;
            // 
            // KhachHangUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "KhachHangUC";
            Size = new Size(938, 427);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtTimKiem;
        private GroupBox groupBox7;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox8;
        private DateTimePicker dateTimePicker3;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboGioiTinh;
        private GroupBox groupBox5;
        private TextBox txtMa;
    }
}
