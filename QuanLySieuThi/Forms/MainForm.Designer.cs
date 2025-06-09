namespace QuanLySieuThi.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            quảnLýDanhMụcToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            danhMụcSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            tạoHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            btnDX = new Button();
            lblThongTinNhanVien = new Label();
            labelTieuDe = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýDanhMụcToolStripMenuItem, tạoHóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, kháchHàngToolStripMenuItem, nhàCungCấpToolStripMenuItem, sảnPhẩmToolStripMenuItem, hóaĐơnToolStripMenuItem, phiếuNhậpToolStripMenuItem });
            quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            quảnLýDanhMụcToolStripMenuItem.Size = new Size(60, 20);
            quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chứcVụToolStripMenuItem });
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(148, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(118, 22);
            chứcVụToolStripMenuItem.Text = "Chức vụ";
            chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
            // 
            // kháchHàngToolStripMenuItem
            // 
            kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            kháchHàngToolStripMenuItem.Size = new Size(148, 22);
            kháchHàngToolStripMenuItem.Text = "Khách hàng";
            kháchHàngToolStripMenuItem.Click += kháchHàngToolStripMenuItem_Click;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(148, 22);
            nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            nhàCungCấpToolStripMenuItem.Click += nhàCungCấpToolStripMenuItem_Click;
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhMụcSảnPhẩmToolStripMenuItem });
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(148, 22);
            sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // danhMụcSảnPhẩmToolStripMenuItem
            // 
            danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
            danhMụcSảnPhẩmToolStripMenuItem.Size = new Size(168, 22);
            danhMụcSảnPhẩmToolStripMenuItem.Text = "Danh mục, ưu đãi";
            danhMụcSảnPhẩmToolStripMenuItem.Click += danhMụcSảnPhẩmToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(148, 22);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            hóaĐơnToolStripMenuItem.Click += hóaĐơnToolStripMenuItem_Click;
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(148, 22);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            phiếuNhậpToolStripMenuItem.Click += phiếuNhậpToolStripMenuItem_Click;
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            tạoHóaĐơnToolStripMenuItem.Size = new Size(85, 20);
            tạoHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            tạoHóaĐơnToolStripMenuItem.Click += tạoHóaĐơnToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(944, 517);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 417);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(labelTieuDe);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 88);
            panel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDX);
            groupBox1.Controls.Add(lblThongTinNhanVien);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.ForeColor = Color.FromArgb(41, 128, 185);
            groupBox1.Location = new Point(740, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 86);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên:";
            // 
            // btnDX
            // 
            btnDX.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnDX.AutoSize = true;
            btnDX.Location = new Point(57, 56);
            btnDX.Name = "btnDX";
            btnDX.Size = new Size(75, 27);
            btnDX.TabIndex = 1;
            btnDX.Text = "Đăng xuất";
            btnDX.UseVisualStyleBackColor = true;
            // 
            // lblThongTinNhanVien
            // 
            lblThongTinNhanVien.Dock = DockStyle.Top;
            lblThongTinNhanVien.Location = new Point(3, 19);
            lblThongTinNhanVien.Name = "lblThongTinNhanVien";
            lblThongTinNhanVien.Size = new Size(190, 40);
            lblThongTinNhanVien.TabIndex = 0;
            lblThongTinNhanVien.Text = "NV001 - Huỳnh Nhật Long\r\nChức Vụ: Nhân viên bán hàng";
            lblThongTinNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTieuDe
            // 
            labelTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTieuDe.AutoSize = true;
            labelTieuDe.BackColor = Color.WhiteSmoke;
            labelTieuDe.BorderStyle = BorderStyle.Fixed3D;
            labelTieuDe.CausesValidation = false;
            labelTieuDe.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTieuDe.ForeColor = Color.FromArgb(41, 128, 185);
            labelTieuDe.Location = new Point(226, 24);
            labelTieuDe.Name = "labelTieuDe";
            labelTieuDe.Size = new Size(505, 47);
            labelTieuDe.TabIndex = 18;
            labelTieuDe.Text = "ỨNG DỤNG QUẢN LÝ SIÊU THỊ";
            labelTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 541);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý siêu thị";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        public Label labelTieuDe;
        private GroupBox groupBox1;
        private Button btnDX;
        private Label lblThongTinNhanVien;
    }
}
