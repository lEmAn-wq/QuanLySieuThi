namespace QuanLySieuThi.Forms
{
    partial class LyDoDoiTraForm
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
            groupBox10 = new GroupBox();
            rtxtDoiTra = new RichTextBox();
            btnXacNhan = new Button();
            groupBox10.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(rtxtDoiTra);
            groupBox10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox10.ForeColor = Color.Red;
            groupBox10.Location = new Point(49, 21);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(557, 219);
            groupBox10.TabIndex = 24;
            groupBox10.TabStop = false;
            groupBox10.Text = "Lý do đổi trả";
            // 
            // rtxtDoiTra
            // 
            rtxtDoiTra.Dock = DockStyle.Fill;
            rtxtDoiTra.Location = new Point(3, 23);
            rtxtDoiTra.Name = "rtxtDoiTra";
            rtxtDoiTra.Size = new Size(551, 193);
            rtxtDoiTra.TabIndex = 0;
            rtxtDoiTra.Text = "";
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXacNhan.BackColor = Color.MistyRose;
            btnXacNhan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.Red;
            btnXacNhan.Location = new Point(482, 261);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(121, 46);
            btnXacNhan.TabIndex = 25;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // LyDoDoiTraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 335);
            Controls.Add(btnXacNhan);
            Controls.Add(groupBox10);
            MaximizeBox = false;
            MaximumSize = new Size(675, 374);
            MinimizeBox = false;
            MinimumSize = new Size(675, 374);
            Name = "LyDoDoiTraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lý do đổi trả";
            groupBox10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox10;
        private RichTextBox rtxtDoiTra;
        private Button btnXacNhan;
    }
}