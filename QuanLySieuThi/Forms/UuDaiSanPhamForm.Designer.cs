namespace QuanLySieuThi.Forms
{
    partial class UuDaiSanPhamForm
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
            groupBox5 = new GroupBox();
            cboLoaiUuDai = new ComboBox();
            button1 = new Button();
            txtPhanTramGiam = new TextBox();
            groupBox1 = new GroupBox();
            grboxSoTienGiam = new GroupBox();
            txtSoTienGiam = new TextBox();
            btnXoa = new Button();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            grboxSoTienGiam.SuspendLayout();
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
            labelTieuDe.Size = new Size(526, 103);
            labelTieuDe.TabIndex = 19;
            labelTieuDe.Text = "ỨNG DỤNG QUẢN LÝ SIÊU THỊ";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cboLoaiUuDai);
            groupBox5.ForeColor = SystemColors.GrayText;
            groupBox5.Location = new Point(35, 116);
            groupBox5.Margin = new Padding(26, 13, 13, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(460, 65);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Loại ưu đãi";
            // 
            // cboLoaiUuDai
            // 
            cboLoaiUuDai.Dock = DockStyle.Fill;
            cboLoaiUuDai.FormattingEnabled = true;
            cboLoaiUuDai.Items.AddRange(new object[] { "Giảm giá theo %", "Giảm giá theo số tiền" });
            cboLoaiUuDai.Location = new Point(4, 24);
            cboLoaiUuDai.Name = "cboLoaiUuDai";
            cboLoaiUuDai.Size = new Size(452, 28);
            cboLoaiUuDai.TabIndex = 0;
            cboLoaiUuDai.SelectedIndexChanged += cboLoaiUuDai_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(415, 373);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPhanTramGiam
            // 
            txtPhanTramGiam.Dock = DockStyle.Top;
            txtPhanTramGiam.Location = new Point(4, 24);
            txtPhanTramGiam.Margin = new Padding(4);
            txtPhanTramGiam.Name = "txtPhanTramGiam";
            txtPhanTramGiam.Size = new Size(452, 27);
            txtPhanTramGiam.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhanTramGiam);
            groupBox1.ForeColor = SystemColors.GrayText;
            groupBox1.Location = new Point(35, 195);
            groupBox1.Margin = new Padding(26, 13, 13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(460, 65);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phần trăm giảm:";
            // 
            // grboxSoTienGiam
            // 
            grboxSoTienGiam.Controls.Add(txtSoTienGiam);
            grboxSoTienGiam.ForeColor = SystemColors.GrayText;
            grboxSoTienGiam.Location = new Point(35, 274);
            grboxSoTienGiam.Margin = new Padding(26, 13, 13, 13);
            grboxSoTienGiam.Name = "grboxSoTienGiam";
            grboxSoTienGiam.Padding = new Padding(4);
            grboxSoTienGiam.Size = new Size(460, 65);
            grboxSoTienGiam.TabIndex = 25;
            grboxSoTienGiam.TabStop = false;
            grboxSoTienGiam.Text = "Số tiền giảm:";
            // 
            // txtSoTienGiam
            // 
            txtSoTienGiam.Dock = DockStyle.Top;
            txtSoTienGiam.Location = new Point(4, 24);
            txtSoTienGiam.Margin = new Padding(4);
            txtSoTienGiam.Name = "txtSoTienGiam";
            txtSoTienGiam.Size = new Size(452, 27);
            txtSoTienGiam.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.Snow;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(8, 373);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 43);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // UuDaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 423);
            Controls.Add(btnXoa);
            Controls.Add(grboxSoTienGiam);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(labelTieuDe);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(542, 462);
            MinimizeBox = false;
            MinimumSize = new Size(542, 462);
            Name = "UuDaiSanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ưu đãi sản phẩm";
            Load += UuDaiSanPhamForm_Load;
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grboxSoTienGiam.ResumeLayout(false);
            grboxSoTienGiam.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelTieuDe;
        private GroupBox groupBox5;
        private Button button1;
        private ComboBox cboLoaiUuDai;
        private TextBox txtPhanTramGiam;
        private GroupBox groupBox1;
        private GroupBox grboxSoTienGiam;
        private TextBox txtSoTienGiam;
        private Button btnXoa;
    }
}