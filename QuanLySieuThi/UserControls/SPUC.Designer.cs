namespace QuanLySieuThi
{
    partial class SPUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPUC));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblGiamGia = new Label();
            lblGiaGiam = new Label();
            lblGiaBan = new Label();
            lblSoLuongTonKho = new Label();
            picboxSanPham = new PictureBox();
            lblTenSanPham = new Label();
            ckboxSP = new CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSanPham).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblGiamGia, 0, 5);
            tableLayoutPanel1.Controls.Add(lblGiaGiam, 0, 4);
            tableLayoutPanel1.Controls.Add(lblGiaBan, 0, 3);
            tableLayoutPanel1.Controls.Add(lblSoLuongTonKho, 0, 2);
            tableLayoutPanel1.Controls.Add(picboxSanPham, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTenSanPham, 0, 1);
            tableLayoutPanel1.Controls.Add(ckboxSP, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(198, 298);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGiamGia
            // 
            lblGiamGia.Location = new Point(3, 253);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(192, 21);
            lblGiamGia.TabIndex = 5;
            lblGiamGia.Text = "Giảm giá";
            lblGiamGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGiaGiam
            // 
            lblGiaGiam.Location = new Point(3, 233);
            lblGiaGiam.Name = "lblGiaGiam";
            lblGiaGiam.Size = new Size(192, 20);
            lblGiaGiam.TabIndex = 4;
            lblGiaGiam.Text = "Giá giảm";
            lblGiaGiam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGiaBan
            // 
            lblGiaBan.Location = new Point(3, 213);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(192, 20);
            lblGiaBan.TabIndex = 3;
            lblGiaBan.Text = "Giá bán";
            lblGiaBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoLuongTonKho
            // 
            lblSoLuongTonKho.Location = new Point(3, 193);
            lblSoLuongTonKho.Name = "lblSoLuongTonKho";
            lblSoLuongTonKho.Size = new Size(192, 20);
            lblSoLuongTonKho.TabIndex = 2;
            lblSoLuongTonKho.Text = "Số lượng tồn kho";
            lblSoLuongTonKho.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picboxSanPham
            // 
            picboxSanPham.BorderStyle = BorderStyle.FixedSingle;
            picboxSanPham.Dock = DockStyle.Fill;
            picboxSanPham.Image = (Image)resources.GetObject("picboxSanPham.Image");
            picboxSanPham.Location = new Point(3, 3);
            picboxSanPham.Name = "picboxSanPham";
            picboxSanPham.Size = new Size(192, 147);
            picboxSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picboxSanPham.TabIndex = 0;
            picboxSanPham.TabStop = false;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.BorderStyle = BorderStyle.FixedSingle;
            lblTenSanPham.Location = new Point(3, 153);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(192, 40);
            lblTenSanPham.TabIndex = 1;
            lblTenSanPham.Text = "Tên";
            lblTenSanPham.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckboxSP
            // 
            ckboxSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ckboxSP.AutoSize = true;
            ckboxSP.Location = new Point(91, 281);
            ckboxSP.Name = "ckboxSP";
            ckboxSP.Size = new Size(15, 14);
            ckboxSP.TabIndex = 6;
            ckboxSP.UseVisualStyleBackColor = true;
            // 
            // SPUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(50, 30, 50, 30);
            Name = "SPUC";
            Size = new Size(198, 298);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picboxSanPham;
        private Label lblGiaGiam;
        private Label lblGiaBan;
        private Label lblSoLuongTonKho;
        private Label lblTenSanPham;
        private Label lblGiamGia;
        private CheckBox ckboxSP;
    }
}
