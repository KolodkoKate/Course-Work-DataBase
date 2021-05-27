namespace E_Storage
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expiryDateLbl = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.productNameErrLbl = new System.Windows.Forms.Label();
            this.barcodeErrLbl = new System.Windows.Forms.Label();
            this.expiryDateErrLbl = new System.Windows.Forms.Label();
            this.expiryDatePkr = new System.Windows.Forms.DateTimePicker();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.categoryErrLbl = new System.Windows.Forms.Label();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryCb);
            this.leftPanel.Controls.Add(this.categoryErrLbl);
            this.leftPanel.Controls.Add(this.categoryLbl);
            this.leftPanel.Controls.Add(this.expiryDatePkr);
            this.leftPanel.Controls.Add(this.expiryDateErrLbl);
            this.leftPanel.Controls.Add(this.barcodeErrLbl);
            this.leftPanel.Controls.Add(this.productNameErrLbl);
            this.leftPanel.Controls.Add(this.expiryDateLbl);
            this.leftPanel.Controls.Add(this.barcodeTb);
            this.leftPanel.Controls.Add(this.productNameTb);
            this.leftPanel.Controls.Add(this.barcodeLbl);
            this.leftPanel.Controls.Add(this.productNameLbl);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.productNameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productNameTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryDateLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productNameErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryDateErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryDatePkr, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryCb, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // expiryDateLbl
            // 
            this.expiryDateLbl.AutoSize = true;
            this.expiryDateLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateLbl.ForeColor = System.Drawing.Color.White;
            this.expiryDateLbl.Location = new System.Drawing.Point(20, 383);
            this.expiryDateLbl.Name = "expiryDateLbl";
            this.expiryDateLbl.Size = new System.Drawing.Size(135, 32);
            this.expiryDateLbl.TabIndex = 19;
            this.expiryDateLbl.Text = "Expiry Date";
            // 
            // barcodeTb
            // 
            this.barcodeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTb.Location = new System.Drawing.Point(26, 318);
            this.barcodeTb.MaxLength = 50;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(262, 38);
            this.barcodeTb.TabIndex = 18;
            // 
            // productNameTb
            // 
            this.productNameTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTb.Location = new System.Drawing.Point(27, 217);
            this.productNameTb.MaxLength = 50;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(261, 38);
            this.productNameTb.TabIndex = 17;
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLbl.ForeColor = System.Drawing.Color.White;
            this.barcodeLbl.Location = new System.Drawing.Point(21, 283);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(101, 32);
            this.barcodeLbl.TabIndex = 16;
            this.barcodeLbl.Text = "Barcode";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLbl.ForeColor = System.Drawing.Color.White;
            this.productNameLbl.Location = new System.Drawing.Point(20, 182);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(168, 32);
            this.productNameLbl.TabIndex = 15;
            this.productNameLbl.Text = "Product Name";
            // 
            // productNameErrLbl
            // 
            this.productNameErrLbl.AutoSize = true;
            this.productNameErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.productNameErrLbl.Location = new System.Drawing.Point(179, 182);
            this.productNameErrLbl.Name = "productNameErrLbl";
            this.productNameErrLbl.Size = new System.Drawing.Size(25, 32);
            this.productNameErrLbl.TabIndex = 40;
            this.productNameErrLbl.Text = "*";
            this.productNameErrLbl.Visible = false;
            // 
            // barcodeErrLbl
            // 
            this.barcodeErrLbl.AutoSize = true;
            this.barcodeErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrLbl.Location = new System.Drawing.Point(117, 283);
            this.barcodeErrLbl.Name = "barcodeErrLbl";
            this.barcodeErrLbl.Size = new System.Drawing.Size(25, 32);
            this.barcodeErrLbl.TabIndex = 41;
            this.barcodeErrLbl.Text = "*";
            this.barcodeErrLbl.Visible = false;
            // 
            // expiryDateErrLbl
            // 
            this.expiryDateErrLbl.AutoSize = true;
            this.expiryDateErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.expiryDateErrLbl.Location = new System.Drawing.Point(144, 383);
            this.expiryDateErrLbl.Name = "expiryDateErrLbl";
            this.expiryDateErrLbl.Size = new System.Drawing.Size(25, 32);
            this.expiryDateErrLbl.TabIndex = 42;
            this.expiryDateErrLbl.Text = "*";
            this.expiryDateErrLbl.Visible = false;
            // 
            // expiryDatePkr
            // 
            this.expiryDatePkr.CustomFormat = "";
            this.expiryDatePkr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDatePkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDatePkr.Location = new System.Drawing.Point(27, 418);
            this.expiryDatePkr.Name = "expiryDatePkr";
            this.expiryDatePkr.Size = new System.Drawing.Size(261, 38);
            this.expiryDatePkr.TabIndex = 43;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLbl.ForeColor = System.Drawing.Color.White;
            this.categoryLbl.Location = new System.Drawing.Point(21, 482);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(182, 32);
            this.categoryLbl.TabIndex = 45;
            this.categoryLbl.Text = "Select Category";
            // 
            // categoryErrLbl
            // 
            this.categoryErrLbl.AutoSize = true;
            this.categoryErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrLbl.Location = new System.Drawing.Point(195, 482);
            this.categoryErrLbl.Name = "categoryErrLbl";
            this.categoryErrLbl.Size = new System.Drawing.Size(25, 32);
            this.categoryErrLbl.TabIndex = 46;
            this.categoryErrLbl.Text = "*";
            this.categoryErrLbl.Visible = false;
            // 
            // categoryCb
            // 
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(27, 517);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(261, 39);
            this.categoryCb.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDGV,
            this.productGV,
            this.barcodeGV,
            this.expiryDateGV,
            this.categoryIDGV,
            this.categoryGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 601);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "ProductID";
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Visible = false;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryDateGV
            // 
            this.expiryDateGV.HeaderText = "Expiry Date";
            this.expiryDateGV.Name = "expiryDateGV";
            this.expiryDateGV.ReadOnly = true;
            // 
            // categoryIDGV
            // 
            this.categoryIDGV.HeaderText = "CategoryID";
            this.categoryIDGV.Name = "categoryIDGV";
            this.categoryIDGV.ReadOnly = true;
            this.categoryIDGV.Visible = false;
            // 
            // categoryGV
            // 
            this.categoryGV.HeaderText = "Category";
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label expiryDateLbl;
        protected System.Windows.Forms.TextBox barcodeTb;
        protected System.Windows.Forms.TextBox productNameTb;
        protected System.Windows.Forms.Label barcodeLbl;
        protected System.Windows.Forms.Label productNameLbl;
        protected System.Windows.Forms.Label productNameErrLbl;
        private System.Windows.Forms.DateTimePicker expiryDatePkr;
        protected System.Windows.Forms.Label expiryDateErrLbl;
        protected System.Windows.Forms.Label barcodeErrLbl;
        private System.Windows.Forms.ComboBox categoryCb;
        protected System.Windows.Forms.Label categoryErrLbl;
        protected System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
    }
}