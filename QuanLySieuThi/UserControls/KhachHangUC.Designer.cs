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
            tableLayoutPanel2 = new TableLayoutPanel();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            dgvKH = new DataGridView();
            groupBox6 = new GroupBox();
            dtpNgayKetThuc = new DateTimePicker();
            groupBox7 = new GroupBox();
            dtpNgayBatDau = new DateTimePicker();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.1572342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8427658F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel2.Controls.Add(txtTimKiem, 0, 0);
            tableLayoutPanel2.Controls.Add(btnThem, 3, 0);
            tableLayoutPanel2.Controls.Add(dgvKH, 2, 1);
            tableLayoutPanel2.Controls.Add(groupBox6, 2, 0);
            tableLayoutPanel2.Controls.Add(groupBox7, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(938, 427);
            tableLayoutPanel2.TabIndex = 2;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(4, 42);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(171, 27);
            txtTimKiem.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.BackColor = Color.Snow;
            btnThem.ForeColor = Color.Red;
            btnThem.Location = new Point(830, 16);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 53);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvKH, 4);
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(4, 124);
            dgvKH.Margin = new Padding(4);
            dgvKH.MultiSelect = false;
            dgvKH.Name = "dgvKH";
            dgvKH.ReadOnly = true;
            dgvKH.Size = new Size(930, 299);
            dgvKH.TabIndex = 13;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox6.Controls.Add(dtpNgayKetThuc);
            groupBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            groupBox6.Location = new Point(509, 10);
            groupBox6.Margin = new Padding(10, 10, 40, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(231, 53);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Đến ngày:";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CalendarFont = new Font("Segoe UI", 9F);
            dtpNgayKetThuc.Dock = DockStyle.Top;
            dtpNgayKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayKetThuc.Location = new Point(3, 23);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(225, 23);
            dtpNgayKetThuc.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox7.Controls.Add(dtpNgayBatDau);
            groupBox7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            groupBox7.Location = new Point(255, 10);
            groupBox7.Margin = new Padding(10);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(234, 53);
            groupBox7.TabIndex = 18;
            groupBox7.TabStop = false;
            groupBox7.Text = "Từ ngày:";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Dock = DockStyle.Top;
            dtpNgayBatDau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayBatDau.Location = new Point(3, 23);
            dtpNgayBatDau.MaxDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(228, 23);
            dtpNgayBatDau.TabIndex = 0;
            dtpNgayBatDau.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // KhachHangUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "KhachHangUC";
            Size = new Size(938, 427);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvKH;
        private GroupBox groupBox6;
        private DateTimePicker dtpNgayKetThuc;
        private GroupBox groupBox7;
        private DateTimePicker dtpNgayBatDau;
        private Button btnThem;
        private TextBox txtTimKiem;
    }
}
