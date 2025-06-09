namespace QuanLySieuThi
{
    partial class NhaCungCapUC
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
            dgvNCC = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnThem = new Button();
            txtTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNCC
            // 
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvNCC, 2);
            dgvNCC.Dock = DockStyle.Fill;
            dgvNCC.Location = new Point(4, 65);
            dgvNCC.Margin = new Padding(4);
            dgvNCC.MultiSelect = false;
            dgvNCC.Name = "dgvNCC";
            dgvNCC.ReadOnly = true;
            dgvNCC.Size = new Size(930, 358);
            dgvNCC.TabIndex = 13;
            dgvNCC.CellDoubleClick += dgvNCC_CellDoubleClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnThem, 1, 0);
            tableLayoutPanel2.Controls.Add(dgvNCC, 0, 1);
            tableLayoutPanel2.Controls.Add(txtTimKiem, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(938, 427);
            tableLayoutPanel2.TabIndex = 3;
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
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            // NhaCungCapUC
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4);
            Name = "NhaCungCapUC";
            Size = new Size(938, 427);
            Load += NhaCungCapUC_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvNCC;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtTimKiem;
        private Button btnThem;
    }
}
