namespace QuanLySieuThi.Forms
{
    partial class DangNhapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapForm));
            groupBox1 = new GroupBox();
            txtTK = new TextBox();
            groupBox2 = new GroupBox();
            txtMK = new TextBox();
            btnDN = new Button();
            llDoiMK = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTK);
            groupBox1.ForeColor = Color.Firebrick;
            groupBox1.Location = new Point(295, 74);
            groupBox1.Margin = new Padding(20, 10, 20, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 51);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tên đăng nhập:";
            // 
            // txtTK
            // 
            txtTK.Dock = DockStyle.Top;
            txtTK.Location = new Point(3, 19);
            txtTK.Name = "txtTK";
            txtTK.PlaceholderText = "Mã nhân viên";
            txtTK.Size = new Size(194, 23);
            txtTK.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMK);
            groupBox2.ForeColor = Color.Firebrick;
            groupBox2.Location = new Point(298, 145);
            groupBox2.Margin = new Padding(20, 10, 20, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 51);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mật khẩu:";
            // 
            // txtMK
            // 
            txtMK.Dock = DockStyle.Top;
            txtMK.Location = new Point(3, 19);
            txtMK.Name = "txtMK";
            txtMK.PasswordChar = '*';
            txtMK.Size = new Size(194, 23);
            txtMK.TabIndex = 0;
            // 
            // btnDN
            // 
            btnDN.BackColor = Color.White;
            btnDN.Location = new Point(356, 238);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(75, 23);
            btnDN.TabIndex = 3;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
            // 
            // llDoiMK
            // 
            llDoiMK.AutoSize = true;
            llDoiMK.Location = new Point(420, 206);
            llDoiMK.Name = "llDoiMK";
            llDoiMK.Size = new Size(78, 15);
            llDoiMK.TabIndex = 4;
            llDoiMK.TabStop = true;
            llDoiMK.Text = "Đổi mật khẩu";
            llDoiMK.LinkClicked += llDoiMK_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(278, 11);
            label1.Name = "label1";
            label1.Size = new Size(243, 39);
            label1.TabIndex = 6;
            label1.Text = "SUPERMARKET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DangNhapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(533, 297);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(llDoiMK);
            Controls.Add(btnDN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTK;
        private GroupBox groupBox2;
        private TextBox txtMK;
        private Button btnDN;
        private LinkLabel llDoiMK;
        private PictureBox pictureBox1;
        private Label label1;
    }
}