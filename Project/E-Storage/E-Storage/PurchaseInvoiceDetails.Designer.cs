namespace E_Storage
{
    partial class PurchaseInvoiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseInvoiceDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.purchaseInvoiceCb = new System.Windows.Forms.ComboBox();
            this.purchaseInvoiceErrLbl = new System.Windows.Forms.Label();
            this.purchaseInvoiceLbl = new System.Windows.Forms.Label();
            this.datePkr = new System.Windows.Forms.DateTimePicker();
            this.dateErrLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossTotalLbl = new System.Windows.Forms.Label();
            this.gtotLbl = new System.Windows.Forms.Label();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.purchaseInvoiceCb);
            this.leftPanel.Controls.Add(this.purchaseInvoiceErrLbl);
            this.leftPanel.Controls.Add(this.purchaseInvoiceLbl);
            this.leftPanel.Controls.Add(this.datePkr);
            this.leftPanel.Controls.Add(this.dateErrLbl);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(309, 952);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.datePkr, 0);
            this.leftPanel.Controls.SetChildIndex(this.purchaseInvoiceLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.purchaseInvoiceErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.purchaseInvoiceCb, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.Add(this.tableLayoutPanel2);
            this.rightPanel.Size = new System.Drawing.Size(892, 952);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // purchaseInvoiceCb
            // 
            this.purchaseInvoiceCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.purchaseInvoiceCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseInvoiceCb.FormattingEnabled = true;
            this.purchaseInvoiceCb.Location = new System.Drawing.Point(24, 258);
            this.purchaseInvoiceCb.Name = "purchaseInvoiceCb";
            this.purchaseInvoiceCb.Size = new System.Drawing.Size(261, 39);
            this.purchaseInvoiceCb.TabIndex = 62;
            this.purchaseInvoiceCb.SelectedIndexChanged += new System.EventHandler(this.purchaseInvoiceCb_SelectedIndexChanged);
            // 
            // purchaseInvoiceErrLbl
            // 
            this.purchaseInvoiceErrLbl.AutoSize = true;
            this.purchaseInvoiceErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseInvoiceErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.purchaseInvoiceErrLbl.Location = new System.Drawing.Point(203, 223);
            this.purchaseInvoiceErrLbl.Name = "purchaseInvoiceErrLbl";
            this.purchaseInvoiceErrLbl.Size = new System.Drawing.Size(25, 32);
            this.purchaseInvoiceErrLbl.TabIndex = 61;
            this.purchaseInvoiceErrLbl.Text = "*";
            this.purchaseInvoiceErrLbl.Visible = false;
            // 
            // purchaseInvoiceLbl
            // 
            this.purchaseInvoiceLbl.AutoSize = true;
            this.purchaseInvoiceLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseInvoiceLbl.ForeColor = System.Drawing.Color.White;
            this.purchaseInvoiceLbl.Location = new System.Drawing.Point(18, 223);
            this.purchaseInvoiceLbl.Name = "purchaseInvoiceLbl";
            this.purchaseInvoiceLbl.Size = new System.Drawing.Size(193, 32);
            this.purchaseInvoiceLbl.TabIndex = 60;
            this.purchaseInvoiceLbl.Text = "Purchase Invoice";
            // 
            // datePkr
            // 
            this.datePkr.CustomFormat = "MM.yyyy";
            this.datePkr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePkr.Location = new System.Drawing.Point(24, 163);
            this.datePkr.Name = "datePkr";
            this.datePkr.ShowUpDown = true;
            this.datePkr.Size = new System.Drawing.Size(261, 38);
            this.datePkr.TabIndex = 59;
            this.datePkr.ValueChanged += new System.EventHandler(this.datePkr_ValueChanged);
            // 
            // dateErrLbl
            // 
            this.dateErrLbl.AutoSize = true;
            this.dateErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.dateErrLbl.Location = new System.Drawing.Point(75, 128);
            this.dateErrLbl.Name = "dateErrLbl";
            this.dateErrLbl.Size = new System.Drawing.Size(25, 32);
            this.dateErrLbl.TabIndex = 58;
            this.dateErrLbl.Text = "*";
            this.dateErrLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 57;
            this.label2.Text = "Date";
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(45, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.12556F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.87444F));
            this.tableLayoutPanel2.Controls.Add(this.grossTotalLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gtotLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 820);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 132);
            this.tableLayoutPanel2.TabIndex = 69;
            // 
            // grossTotalLbl
            // 
            this.grossTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossTotalLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grossTotalLbl.ForeColor = System.Drawing.Color.Black;
            this.grossTotalLbl.Location = new System.Drawing.Point(3, 0);
            this.grossTotalLbl.Name = "grossTotalLbl";
            this.grossTotalLbl.Size = new System.Drawing.Size(565, 132);
            this.grossTotalLbl.TabIndex = 69;
            this.grossTotalLbl.Text = "Gross Total";
            this.grossTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gtotLbl
            // 
            this.gtotLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtotLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gtotLbl.ForeColor = System.Drawing.Color.Black;
            this.gtotLbl.Location = new System.Drawing.Point(574, 0);
            this.gtotLbl.Name = "gtotLbl";
            this.gtotLbl.Size = new System.Drawing.Size(315, 132);
            this.gtotLbl.TabIndex = 70;
            this.gtotLbl.Text = "0.00";
            this.gtotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // totalAmountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalAmountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // perUnitPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.perUnitPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.perUnitPriceGV.HeaderText = "Per Unit Price";
            this.perUnitPriceGV.Name = "perUnitPriceGV";
            this.perUnitPriceGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "ProductID";
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Visible = false;
            // 
            // mPIDGV
            // 
            this.mPIDGV.HeaderText = "mPIDGV";
            this.mPIDGV.Name = "mPIDGV";
            this.mPIDGV.ReadOnly = true;
            this.mPIDGV.Visible = false;
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
            this.mPIDGV,
            this.productIDGV,
            this.productGV,
            this.quantityGV,
            this.perUnitPriceGV,
            this.totalAmountGV,
            this.deleteGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 748);
            this.dataGridView1.TabIndex = 71;
            // 
            // PurchaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 952);
            this.Name = "PurchaseInvoiceDetails";
            this.Text = "Purchase Invoice Details";
            this.Load += new System.EventHandler(this.PurchaseInvoiceDetails_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox purchaseInvoiceCb;
        protected System.Windows.Forms.Label purchaseInvoiceErrLbl;
        protected System.Windows.Forms.Label purchaseInvoiceLbl;
        private System.Windows.Forms.DateTimePicker datePkr;
        protected System.Windows.Forms.Label dateErrLbl;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.Label grossTotalLbl;
        protected System.Windows.Forms.Label gtotLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}