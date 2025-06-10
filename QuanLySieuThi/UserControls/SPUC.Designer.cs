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
            picboxSanPham = new PictureBox();
            ckboxSP = new CheckBox();
            rtbInfo = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSanPham).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(picboxSanPham, 0, 0);
            tableLayoutPanel1.Controls.Add(ckboxSP, 0, 2);
            tableLayoutPanel1.Controls.Add(rtbInfo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(240, 262);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picboxSanPham
            // 
            picboxSanPham.BorderStyle = BorderStyle.FixedSingle;
            picboxSanPham.Dock = DockStyle.Fill;
            picboxSanPham.Image = (Image)resources.GetObject("picboxSanPham.Image");
            picboxSanPham.Location = new Point(3, 3);
            picboxSanPham.Name = "picboxSanPham";
            picboxSanPham.Size = new Size(234, 159);
            picboxSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picboxSanPham.TabIndex = 0;
            picboxSanPham.TabStop = false;
            picboxSanPham.DoubleClick += picboxSanPham_DoubleClick;
            // 
            // ckboxSP
            // 
            ckboxSP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ckboxSP.AutoSize = true;
            ckboxSP.Location = new Point(112, 245);
            ckboxSP.Name = "ckboxSP";
            ckboxSP.Size = new Size(15, 14);
            ckboxSP.TabIndex = 6;
            ckboxSP.UseVisualStyleBackColor = true;
            ckboxSP.Visible = false;
            // 
            // rtbInfo
            // 
            rtbInfo.Dock = DockStyle.Fill;
            rtbInfo.Location = new Point(3, 168);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.Size = new Size(234, 71);
            rtbInfo.TabIndex = 7;
            rtbInfo.Text = "";
            // 
            // SPUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(50, 30, 50, 30);
            Name = "SPUC";
            Size = new Size(240, 262);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picboxSanPham;
        public CheckBox ckboxSP;
        private RichTextBox rtbInfo;
    }
}
