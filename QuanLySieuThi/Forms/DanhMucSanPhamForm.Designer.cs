namespace QuanLySieuThi.Forms
{
    partial class DanhMucSanPhamForm
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
            txtTen = new TextBox();
            button1 = new Button();
            btnXoa = new Button();
            groupBox5.SuspendLayout();
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
            labelTieuDe.Size = new Size(609, 103);
            labelTieuDe.TabIndex = 19;
            labelTieuDe.Text = "THÔNG TIN LOẠI SẢN PHẨM LSP01";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTen);
            groupBox5.ForeColor = SystemColors.GrayText;
            groupBox5.Location = new Point(35, 116);
            groupBox5.Margin = new Padding(26, 13, 13, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(481, 65);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Dock = DockStyle.Top;
            txtTen.Location = new Point(4, 24);
            txtTen.Margin = new Padding(4);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(473, 27);
            txtTen.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(500, 209);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(98, 43);
            button1.TabIndex = 23;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.Snow;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(6, 209);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 43);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // DanhMucSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(609, 258);
            Controls.Add(btnXoa);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(labelTieuDe);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(625, 297);
            MinimizeBox = false;
            MinimumSize = new Size(625, 297);
            Name = "DanhMucSanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục sản phẩm";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label labelTieuDe;
        private GroupBox groupBox5;
        private TextBox txtTen;
        private Button button1;
        private Button btnXoa;
    }
}