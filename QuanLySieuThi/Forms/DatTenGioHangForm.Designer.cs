namespace QuanLySieuThi.Forms
{
    partial class DatTenGioHangForm: System.Windows.Forms.Form
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
            txtTenGioHang = new TextBox();
            btnOK = new Button();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenGioHang);
            groupBox4.Location = new Point(23, 30);
            groupBox4.Margin = new Padding(20, 10, 20, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 51);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên giỏ hàng:";
            // 
            // txtTenGioHang
            // 
            txtTenGioHang.Dock = DockStyle.Top;
            txtTenGioHang.Location = new Point(3, 19);
            txtTenGioHang.Name = "txtTenGioHang";
            txtTenGioHang.Size = new Size(194, 23);
            txtTenGioHang.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(145, 94);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // DatTenGioHangForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 132);
            Controls.Add(btnOK);
            Controls.Add(groupBox4);
            MaximizeBox = false;
            MaximumSize = new Size(273, 171);
            MinimizeBox = false;
            MinimumSize = new Size(273, 171);
            Name = "DatTenGioHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt tên giỏ hàng lưu trữ tạm thời";
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private TextBox txtTenGioHang;
        private Button btnOK;
    }
}