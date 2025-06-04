namespace QuanLySieuThi
{
    partial class DoiMatKhauForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhauForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnDoiMK = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox5 = new GroupBox();
            textBox5 = new TextBox();
            groupBox6 = new GroupBox();
            textBox6 = new TextBox();
            groupBox7 = new GroupBox();
            textBox7 = new TextBox();
            groupBox8 = new GroupBox();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(292, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 39);
            label1.TabIndex = 12;
            label1.Text = "SUPERMARKET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnDoiMK
            // 
            btnDoiMK.AutoSize = true;
            btnDoiMK.BackColor = Color.White;
            btnDoiMK.Location = new Point(367, 356);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(88, 25);
            btnDoiMK.TabIndex = 9;
            btnDoiMK.Text = "Đổi mật khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Controls.Add(groupBox8);
            flowLayoutPanel1.Location = new Point(292, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(257, 283);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox5);
            groupBox5.ForeColor = Color.Firebrick;
            groupBox5.Location = new Point(20, 10);
            groupBox5.Margin = new Padding(20, 10, 20, 10);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 51);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên đăng nhập:";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Top;
            textBox5.Location = new Point(3, 19);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Mã nhân viên";
            textBox5.Size = new Size(194, 23);
            textBox5.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox6);
            groupBox6.ForeColor = Color.Firebrick;
            groupBox6.Location = new Point(20, 81);
            groupBox6.Margin = new Padding(20, 10, 20, 10);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(200, 51);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Mật khẩu:";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Top;
            textBox6.Location = new Point(3, 19);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Mật khẩu đang áp dụng";
            textBox6.Size = new Size(194, 23);
            textBox6.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox7);
            groupBox7.ForeColor = Color.Firebrick;
            groupBox7.Location = new Point(20, 152);
            groupBox7.Margin = new Padding(20, 10, 20, 10);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 51);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mật khẩu mới:";
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Top;
            textBox7.Location = new Point(3, 19);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Mật khẩu muốn đổi";
            textBox7.Size = new Size(194, 23);
            textBox7.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(textBox8);
            groupBox8.ForeColor = Color.Firebrick;
            groupBox8.Location = new Point(20, 223);
            groupBox8.Margin = new Padding(20, 10, 20, 10);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(200, 51);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "Nhập lại mật khẩu mới:";
            // 
            // textBox8
            // 
            textBox8.Dock = DockStyle.Top;
            textBox8.Location = new Point(3, 19);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(194, 23);
            textBox8.TabIndex = 0;
            // 
            // DoiMatKhauForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(572, 391);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDoiMK);
            MaximizeBox = false;
            MaximumSize = new Size(588, 430);
            MinimizeBox = false;
            MinimumSize = new Size(588, 430);
            Name = "DoiMatKhauForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhauForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button btnDoiMK;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox5;
        private TextBox textBox5;
        private GroupBox groupBox6;
        private TextBox textBox6;
        private GroupBox groupBox7;
        private TextBox textBox7;
        private GroupBox groupBox8;
        private TextBox textBox8;
    }
}