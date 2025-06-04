namespace QuanLySieuThi
{
    partial class DanhMucSanPhamUC
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            cboDanhMucSanPham = new ComboBox();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(938, 427);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboDanhMucSanPham);
            groupBox2.Location = new Point(20, 20);
            groupBox2.Margin = new Padding(20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 51);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục sản phẩm:";
            // 
            // cboDanhMucSanPham
            // 
            cboDanhMucSanPham.Dock = DockStyle.Top;
            cboDanhMucSanPham.FormattingEnabled = true;
            cboDanhMucSanPham.Items.AddRange(new object[] { "Loại sản phẩm", "Thương hiệu", "Ngành hàng", "Ưu đãi" });
            cboDanhMucSanPham.Location = new Point(3, 19);
            cboDanhMucSanPham.Name = "cboDanhMucSanPham";
            cboDanhMucSanPham.Size = new Size(194, 23);
            cboDanhMucSanPham.TabIndex = 2;
            cboDanhMucSanPham.SelectedIndexChanged += cboDanhMucSanPham_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 324);
            panel1.TabIndex = 15;
            // 
            // DanhMucSanPhamUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DanhMucSanPhamUC";
            Size = new Size(938, 427);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private ComboBox cboDanhMucSanPham;
        private Panel panel1;
    }
}
