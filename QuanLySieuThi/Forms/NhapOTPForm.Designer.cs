namespace QuanLySieuThi.Forms
{
    partial class NhapOTPForm : System.Windows.Forms.Form
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
            groupBox4 = new GroupBox();
            txtMaOTP = new TextBox();
            btnOK = new Button();
            label1 = new Label();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMaOTP);
            groupBox4.Location = new Point(4, 68);
            groupBox4.Margin = new Padding(20, 10, 20, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(162, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Nhập mã OTP:";
            // 
            // txtMaOTP
            // 
            txtMaOTP.Dock = DockStyle.Top;
            txtMaOTP.Location = new Point(3, 19);
            txtMaOTP.Name = "txtMaOTP";
            txtMaOTP.Size = new Size(156, 23);
            txtMaOTP.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(180, 86);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(227, 47);
            label1.TabIndex = 7;
            label1.Text = "Mã OTP đã được gửi đến SĐT khách hàng (hiệu lực trong vòng 1 phút)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NhapOTPForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 132);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Controls.Add(groupBox4);
            MaximizeBox = false;
            MaximumSize = new Size(273, 171);
            MinimizeBox = false;
            MinimumSize = new Size(273, 171);
            Name = "NhapOTPForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác thực OTP";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private TextBox txtMaOTP;
        private Button btnOK;
        private Label label1;
    }
}