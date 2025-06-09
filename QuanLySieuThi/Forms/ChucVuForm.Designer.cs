namespace QuanLySieuThi.Forms
{
    partial class ChucVuForm
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
            txtTenChucVu = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtLuong = new TextBox();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            labelTieuDe.Text = "THÔNG TIN CHỨC VỤ CV001";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(417, 312);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTenChucVu
            // 
            txtTenChucVu.Dock = DockStyle.Top;
            txtTenChucVu.Location = new Point(4, 24);
            txtTenChucVu.Margin = new Padding(4);
            txtTenChucVu.Name = "txtTenChucVu";
            txtTenChucVu.Size = new Size(452, 27);
            txtTenChucVu.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTenChucVu);
            groupBox1.ForeColor = SystemColors.GrayText;
            groupBox1.Location = new Point(35, 131);
            groupBox1.Margin = new Padding(26, 13, 13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(460, 65);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên chức vụ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLuong);
            groupBox2.ForeColor = SystemColors.GrayText;
            groupBox2.Location = new Point(35, 210);
            groupBox2.Margin = new Padding(26, 13, 13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(460, 65);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lương:";
            // 
            // txtLuong
            // 
            txtLuong.Dock = DockStyle.Top;
            txtLuong.Location = new Point(4, 24);
            txtLuong.Margin = new Padding(4);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(452, 27);
            txtLuong.TabIndex = 0;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.Snow;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(7, 312);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 43);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // ChucVuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 361);
            Controls.Add(btnXoa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(labelTieuDe);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(542, 400);
            MinimizeBox = false;
            MinimumSize = new Size(542, 400);
            Name = "ChucVuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chức Vụ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelTieuDe;
        private Button button1;
        private TextBox txtTenChucVu;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLuong;
        private Button btnXoa;
    }
}