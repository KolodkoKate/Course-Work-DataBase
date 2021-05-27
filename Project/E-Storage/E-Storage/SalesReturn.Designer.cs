namespace E_Storage
{
    partial class SalesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPerProductDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProductTotalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleIDTb = new System.Windows.Forms.TextBox();
            this.saleIDLbl = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.userTb = new System.Windows.Forms.TextBox();
            this.userLb = new System.Windows.Forms.Label();
            this.paymentTypeTb = new System.Windows.Forms.TextBox();
            this.paymentTypeLbl = new System.Windows.Forms.Label();
            this.dateTimePkr = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.amountToRefundTb = new System.Windows.Forms.TextBox();
            this.amountToRefundLbl = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.batcodeLbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
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
            this.leftPanel.Controls.Add(this.returnBtn);
            this.leftPanel.Controls.Add(this.saleIDLbl);
            this.leftPanel.Controls.Add(this.barcodeTb);
            this.leftPanel.Controls.Add(this.batcodeLbl);
            this.leftPanel.Controls.Add(this.amountToRefundTb);
            this.leftPanel.Controls.Add(this.amountToRefundLbl);
            this.leftPanel.Controls.Add(this.dateTimePkr);
            this.leftPanel.Controls.Add(this.dateLbl);
            this.leftPanel.Controls.Add(this.paymentTypeTb);
            this.leftPanel.Controls.Add(this.paymentTypeLbl);
            this.leftPanel.Controls.Add(this.userTb);
            this.leftPanel.Controls.Add(this.userLb);
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.saleIDTb);
            this.leftPanel.Size = new System.Drawing.Size(309, 947);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.saleIDTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.userLb, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.paymentTypeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.paymentTypeTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePkr, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountToRefundLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountToRefundTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.batcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.saleIDLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.returnBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(892, 947);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
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
            this.saleIDGV,
            this.barcodeGV,
            this.productGV,
            this.quantityGV,
            this.productPriceGV,
            this.productDiscountGV,
            this.totalPerProductDiscountGV,
            this.perProductTotalGV,
            this.totalDiscountGV,
            this.totalAmountGV,
            this.amountGivenGV,
            this.amountReturnedGV,
            this.dateGV,
            this.userGV,
            this.payTypeGV,
            this.productIDGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 810);
            this.dataGridView1.TabIndex = 7;
            // 
            // saleIDGV
            // 
            this.saleIDGV.HeaderText = "Sale ID";
            this.saleIDGV.Name = "saleIDGV";
            this.saleIDGV.ReadOnly = true;
            this.saleIDGV.Visible = false;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // productPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.productPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productPriceGV.HeaderText = "Product Price";
            this.productPriceGV.Name = "productPriceGV";
            this.productPriceGV.ReadOnly = true;
            // 
            // productDiscountGV
            // 
            this.productDiscountGV.HeaderText = "Product Discount";
            this.productDiscountGV.Name = "productDiscountGV";
            this.productDiscountGV.ReadOnly = true;
            this.productDiscountGV.Visible = false;
            // 
            // totalPerProductDiscountGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.totalPerProductDiscountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalPerProductDiscountGV.HeaderText = "Total Per Product Discount";
            this.totalPerProductDiscountGV.Name = "totalPerProductDiscountGV";
            this.totalPerProductDiscountGV.ReadOnly = true;
            this.totalPerProductDiscountGV.Visible = false;
            // 
            // perProductTotalGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.perProductTotalGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perProductTotalGV.HeaderText = "Per Product Total";
            this.perProductTotalGV.Name = "perProductTotalGV";
            this.perProductTotalGV.ReadOnly = true;
            // 
            // totalDiscountGV
            // 
            this.totalDiscountGV.HeaderText = "Total Discount";
            this.totalDiscountGV.Name = "totalDiscountGV";
            this.totalDiscountGV.ReadOnly = true;
            this.totalDiscountGV.Visible = false;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            // 
            // amountGivenGV
            // 
            this.amountGivenGV.HeaderText = "Amount Given";
            this.amountGivenGV.Name = "amountGivenGV";
            this.amountGivenGV.ReadOnly = true;
            this.amountGivenGV.Visible = false;
            // 
            // amountReturnedGV
            // 
            this.amountReturnedGV.HeaderText = "Amount Returned";
            this.amountReturnedGV.Name = "amountReturnedGV";
            this.amountReturnedGV.ReadOnly = true;
            this.amountReturnedGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            this.dateGV.Visible = false;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            this.userGV.Visible = false;
            // 
            // payTypeGV
            // 
            this.payTypeGV.HeaderText = "Pay Type";
            this.payTypeGV.Name = "payTypeGV";
            this.payTypeGV.ReadOnly = true;
            this.payTypeGV.Visible = false;
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "ProductID";
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Visible = false;
            // 
            // saleIDTb
            // 
            this.saleIDTb.Enabled = false;
            this.saleIDTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleIDTb.Location = new System.Drawing.Point(22, 181);
            this.saleIDTb.MaxLength = 100;
            this.saleIDTb.Name = "saleIDTb";
            this.saleIDTb.Size = new System.Drawing.Size(262, 38);
            this.saleIDTb.TabIndex = 45;
            // 
            // saleIDLbl
            // 
            this.saleIDLbl.AutoSize = true;
            this.saleIDLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleIDLbl.ForeColor = System.Drawing.Color.White;
            this.saleIDLbl.Location = new System.Drawing.Point(16, 146);
            this.saleIDLbl.Name = "saleIDLbl";
            this.saleIDLbl.Size = new System.Drawing.Size(99, 32);
            this.saleIDLbl.TabIndex = 46;
            this.saleIDLbl.Text = "Sales ID";
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loadBtn.FlatAppearance.BorderSize = 2;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(22, 263);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(261, 62);
            this.loadBtn.TabIndex = 57;
            this.loadBtn.Text = "LOAD";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // userTb
            // 
            this.userTb.Enabled = false;
            this.userTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTb.Location = new System.Drawing.Point(22, 459);
            this.userTb.MaxLength = 100;
            this.userTb.Name = "userTb";
            this.userTb.Size = new System.Drawing.Size(262, 38);
            this.userTb.TabIndex = 58;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLb.ForeColor = System.Drawing.Color.White;
            this.userLb.Location = new System.Drawing.Point(16, 424);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(62, 32);
            this.userLb.TabIndex = 59;
            this.userLb.Text = "User";
            // 
            // paymentTypeTb
            // 
            this.paymentTypeTb.Enabled = false;
            this.paymentTypeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeTb.Location = new System.Drawing.Point(21, 546);
            this.paymentTypeTb.MaxLength = 100;
            this.paymentTypeTb.Name = "paymentTypeTb";
            this.paymentTypeTb.Size = new System.Drawing.Size(262, 38);
            this.paymentTypeTb.TabIndex = 60;
            // 
            // paymentTypeLbl
            // 
            this.paymentTypeLbl.AutoSize = true;
            this.paymentTypeLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeLbl.ForeColor = System.Drawing.Color.White;
            this.paymentTypeLbl.Location = new System.Drawing.Point(15, 511);
            this.paymentTypeLbl.Name = "paymentTypeLbl";
            this.paymentTypeLbl.Size = new System.Drawing.Size(165, 32);
            this.paymentTypeLbl.TabIndex = 61;
            this.paymentTypeLbl.Text = "Payment Type";
            // 
            // dateTimePkr
            // 
            this.dateTimePkr.CustomFormat = "";
            this.dateTimePkr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePkr.Location = new System.Drawing.Point(22, 374);
            this.dateTimePkr.Name = "dateTimePkr";
            this.dateTimePkr.Size = new System.Drawing.Size(261, 38);
            this.dateTimePkr.TabIndex = 63;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(16, 339);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(65, 32);
            this.dateLbl.TabIndex = 62;
            this.dateLbl.Text = "Date";
            // 
            // amountToRefundTb
            // 
            this.amountToRefundTb.Enabled = false;
            this.amountToRefundTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountToRefundTb.Location = new System.Drawing.Point(21, 833);
            this.amountToRefundTb.MaxLength = 100;
            this.amountToRefundTb.Name = "amountToRefundTb";
            this.amountToRefundTb.Size = new System.Drawing.Size(262, 38);
            this.amountToRefundTb.TabIndex = 66;
            // 
            // amountToRefundLbl
            // 
            this.amountToRefundLbl.AutoSize = true;
            this.amountToRefundLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountToRefundLbl.ForeColor = System.Drawing.Color.White;
            this.amountToRefundLbl.Location = new System.Drawing.Point(15, 798);
            this.amountToRefundLbl.Name = "amountToRefundLbl";
            this.amountToRefundLbl.Size = new System.Drawing.Size(216, 32);
            this.amountToRefundLbl.TabIndex = 67;
            this.amountToRefundLbl.Text = "Amount To Refund";
            // 
            // barcodeTb
            // 
            this.barcodeTb.Enabled = false;
            this.barcodeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTb.Location = new System.Drawing.Point(22, 633);
            this.barcodeTb.MaxLength = 100;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(262, 38);
            this.barcodeTb.TabIndex = 68;
            // 
            // batcodeLbl
            // 
            this.batcodeLbl.AutoSize = true;
            this.batcodeLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batcodeLbl.ForeColor = System.Drawing.Color.White;
            this.batcodeLbl.Location = new System.Drawing.Point(16, 598);
            this.batcodeLbl.Name = "batcodeLbl";
            this.batcodeLbl.Size = new System.Drawing.Size(101, 32);
            this.batcodeLbl.TabIndex = 69;
            this.batcodeLbl.Text = "Barcode";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnBtn.FlatAppearance.BorderSize = 2;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(23, 717);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(261, 62);
            this.returnBtn.TabIndex = 70;
            this.returnBtn.Text = "RETURN";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // SalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 947);
            this.Name = "SalesReturn";
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.SalesReturn_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.TextBox saleIDTb;
        protected System.Windows.Forms.Label saleIDLbl;
        private System.Windows.Forms.Button loadBtn;
        protected System.Windows.Forms.TextBox paymentTypeTb;
        protected System.Windows.Forms.Label paymentTypeLbl;
        protected System.Windows.Forms.TextBox userTb;
        protected System.Windows.Forms.Label userLb;
        private System.Windows.Forms.DateTimePicker dateTimePkr;
        private System.Windows.Forms.Label dateLbl;
        protected System.Windows.Forms.TextBox amountToRefundTb;
        protected System.Windows.Forms.Label amountToRefundLbl;
        protected System.Windows.Forms.TextBox barcodeTb;
        protected System.Windows.Forms.Label batcodeLbl;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPerProductDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProductTotalGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReturnedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
    }
}