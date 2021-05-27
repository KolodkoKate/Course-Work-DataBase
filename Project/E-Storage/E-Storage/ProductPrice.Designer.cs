namespace E_Storage
{
    partial class ProductPrice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.categoryErrLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
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
            // categoryCb
            // 
            this.categoryCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(24, 203);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(261, 39);
            this.categoryCb.TabIndex = 50;
            this.categoryCb.SelectedIndexChanged += new System.EventHandler(this.categoryCb_SelectedIndexChanged);
            // 
            // categoryErrLbl
            // 
            this.categoryErrLbl.AutoSize = true;
            this.categoryErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrLbl.Location = new System.Drawing.Point(119, 168);
            this.categoryErrLbl.Name = "categoryErrLbl";
            this.categoryErrLbl.Size = new System.Drawing.Size(25, 32);
            this.categoryErrLbl.TabIndex = 49;
            this.categoryErrLbl.Text = "*";
            this.categoryErrLbl.Visible = false;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryLbl.ForeColor = System.Drawing.Color.White;
            this.categoryLbl.Location = new System.Drawing.Point(18, 168);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(111, 32);
            this.categoryLbl.TabIndex = 48;
            this.categoryLbl.Text = "Category";
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
            this.selectGV,
            this.productIDGV,
            this.productGV,
            this.buyingPriceGV,
            this.profitMarginGV,
            this.discountGV,
            this.finalPriceGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 601);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // selectGV
            // 
            this.selectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectGV.HeaderText = "";
            this.selectGV.Name = "selectGV";
            this.selectGV.Width = 5;
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "ProductID";
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.Visible = false;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            // 
            // buyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.buyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.buyingPriceGV.HeaderText = "Buying Price";
            this.buyingPriceGV.Name = "buyingPriceGV";
            // 
            // profitMarginGV
            // 
            this.profitMarginGV.HeaderText = "Profit Margin %";
            this.profitMarginGV.Name = "profitMarginGV";
            // 
            // discountGV
            // 
            this.discountGV.HeaderText = "Discount %";
            this.discountGV.Name = "discountGV";
            // 
            // finalPriceGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.finalPriceGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.finalPriceGV.HeaderText = "Final Selling Price";
            this.finalPriceGV.Name = "finalPriceGV";
            this.finalPriceGV.ReadOnly = true;
            // 
            // ProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "ProductPrice";
            this.Text = "Product Price";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryCb;
        protected System.Windows.Forms.Label categoryErrLbl;
        protected System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPriceGV;
    }
}