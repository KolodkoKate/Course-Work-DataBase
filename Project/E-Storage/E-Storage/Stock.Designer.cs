namespace E_Storage
{
    partial class Stock
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
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
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
            this.productIDGV,
            this.productGV,
            this.quantityGV,
            this.barcodeGV,
            this.expiryDateGV,
            this.buyingPriceGV,
            this.sellingPriceGV,
            this.categoryGV,
            this.totalAmountGV,
            this.statusGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(892, 601);
            this.dataGridView1.TabIndex = 6;
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
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
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
            // buyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.buyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.buyingPriceGV.HeaderText = "Buying Price";
            this.buyingPriceGV.Name = "buyingPriceGV";
            this.buyingPriceGV.ReadOnly = true;
            // 
            // sellingPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.sellingPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.sellingPriceGV.HeaderText = "Selling Price";
            this.sellingPriceGV.Name = "sellingPriceGV";
            this.sellingPriceGV.ReadOnly = true;
            // 
            // categoryGV
            // 
            this.categoryGV.HeaderText = "Category";
            this.categoryGV.Name = "categoryGV";
            this.categoryGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.totalAmountGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "Stock";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}