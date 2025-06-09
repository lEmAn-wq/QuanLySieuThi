namespace QuanLySieuThi.UserControls
{
    partial class ChucVuUC
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnThem = new Button();
            dgvChucVu = new DataGridView();
            txtTimKiem = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnThem, 1, 0);
            tableLayoutPanel2.Controls.Add(dgvChucVu, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTimKiem, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(938, 427);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.BackColor = Color.Snow;
            btnThem.ForeColor = Color.Red;
            btnThem.Location = new Point(830, 4);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 53);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvChucVu
            // 
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvChucVu, 2);
            dgvChucVu.Dock = DockStyle.Fill;
            dgvChucVu.Location = new Point(4, 65);
            dgvChucVu.Margin = new Padding(4);
            dgvChucVu.MultiSelect = false;
            dgvChucVu.Name = "dgvChucVu";
            dgvChucVu.ReadOnly = true;
            dgvChucVu.Size = new Size(930, 358);
            dgvChucVu.TabIndex = 13;
            dgvChucVu.CellDoubleClick += dgvChucVu_CellDoubleClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTimKiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(4, 30);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm";
            txtTimKiem.Size = new Size(226, 27);
            txtTimKiem.TabIndex = 11;
            // 
            // ChucVuUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "ChucVuUC";
            Size = new Size(938, 427);
            Load += ChucVuUC_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChucVu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvChucVu;
        private TextBox txtTimKiem;
        private Button btnThem;
    }
}
