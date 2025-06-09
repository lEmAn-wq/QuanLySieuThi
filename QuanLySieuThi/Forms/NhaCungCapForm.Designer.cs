namespace QuanLySieuThi.Forms
{
    partial class NhaCungCapForm
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
            txtTenNCC = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtSDT = new TextBox();
            groupBox3 = new GroupBox();
            txtEmail = new TextBox();
            groupBox4 = new GroupBox();
            txtDiaChi = new TextBox();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            labelTieuDe.Text = "THÔNG TIN NHÀ CUNG CẤP NCC001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(478, 510);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 23;
            button1.Text = "Thay đổi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Dock = DockStyle.Top;
            txtTenNCC.Location = new Point(4, 24);
            txtTenNCC.Margin = new Padding(4);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(506, 27);
            txtTenNCC.TabIndex = 0;
            txtTenNCC.Text = "dddddd";
            txtTenNCC.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.ForeColor = SystemColors.GrayText;
            groupBox1.Location = new Point(35, 131);
            groupBox1.Margin = new Padding(26, 13, 13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(514, 65);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên nhà cung cấp:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSDT);
            groupBox2.ForeColor = SystemColors.GrayText;
            groupBox2.Location = new Point(35, 212);
            groupBox2.Margin = new Padding(26, 13, 13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(514, 65);
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
            txtSDT.Size = new Size(506, 27);
            txtSDT.TabIndex = 0;
            txtSDT.Text = "dddddd";
            txtSDT.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEmail);
            groupBox3.ForeColor = SystemColors.GrayText;
            groupBox3.Location = new Point(35, 293);
            groupBox3.Margin = new Padding(26, 13, 13, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(514, 65);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Top;
            txtEmail.Location = new Point(4, 24);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(506, 27);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "dddddd";
            txtEmail.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDiaChi);
            groupBox4.ForeColor = SystemColors.GrayText;
            groupBox4.Location = new Point(35, 374);
            groupBox4.Margin = new Padding(26, 13, 13, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(514, 65);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Top;
            txtDiaChi.Location = new Point(4, 24);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 27);
            txtDiaChi.TabIndex = 1;
            txtDiaChi.Text = "dddddd";
            txtDiaChi.Visible = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.Snow;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(13, 510);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 43);
            btnXoa.TabIndex = 28;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 561);
            Controls.Add(btnXoa);
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
            MaximumSize = new Size(600, 600);
            MinimizeBox = false;
            MinimumSize = new Size(600, 600);
            Name = "NhaCungCapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà cung cấp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelTieuDe;
        private Button button1;
        private TextBox txtTenNCC;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSDT;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Button btnXoa;
    }
}