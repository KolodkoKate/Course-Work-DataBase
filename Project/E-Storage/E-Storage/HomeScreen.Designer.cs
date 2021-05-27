namespace E_Storage
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productsBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.purchaseInvoiceBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.salesReturnBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.productPricingBtn = new System.Windows.Forms.Button();
            this.stockBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(309, 738);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(892, 738);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.productsBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.usersBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseInvoiceBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesReturnBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.suppliersBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.productPricingBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.categoriesBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 666);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // productsBtn
            // 
            this.productsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productsBtn.FlatAppearance.BorderSize = 2;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.Location = new System.Drawing.Point(300, 3);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(291, 160);
            this.productsBtn.TabIndex = 1;
            this.productsBtn.Text = "Products";
            this.productsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersBtn.FlatAppearance.BorderSize = 2;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBtn.Image = ((System.Drawing.Image)(resources.GetObject("usersBtn.Image")));
            this.usersBtn.Location = new System.Drawing.Point(3, 3);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(291, 160);
            this.usersBtn.TabIndex = 0;
            this.usersBtn.Text = "Users";
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // purchaseInvoiceBtn
            // 
            this.purchaseInvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseInvoiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseInvoiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseInvoiceBtn.FlatAppearance.BorderSize = 2;
            this.purchaseInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseInvoiceBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseInvoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("purchaseInvoiceBtn.Image")));
            this.purchaseInvoiceBtn.Location = new System.Drawing.Point(3, 169);
            this.purchaseInvoiceBtn.Name = "purchaseInvoiceBtn";
            this.purchaseInvoiceBtn.Size = new System.Drawing.Size(291, 160);
            this.purchaseInvoiceBtn.TabIndex = 3;
            this.purchaseInvoiceBtn.Text = "Purchase Invoice";
            this.purchaseInvoiceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.purchaseInvoiceBtn.UseVisualStyleBackColor = true;
            this.purchaseInvoiceBtn.Click += new System.EventHandler(this.purchaseInvoiceBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesBtn.FlatAppearance.BorderSize = 2;
            this.salesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesBtn.Image = ((System.Drawing.Image)(resources.GetObject("salesBtn.Image")));
            this.salesBtn.Location = new System.Drawing.Point(300, 169);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(291, 160);
            this.salesBtn.TabIndex = 9;
            this.salesBtn.Text = "Sales";
            this.salesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salesBtn.UseVisualStyleBackColor = true;
            this.salesBtn.Click += new System.EventHandler(this.salesBtn_Click);
            // 
            // salesReturnBtn
            // 
            this.salesReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesReturnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesReturnBtn.FlatAppearance.BorderSize = 2;
            this.salesReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesReturnBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("salesReturnBtn.Image")));
            this.salesReturnBtn.Location = new System.Drawing.Point(597, 335);
            this.salesReturnBtn.Name = "salesReturnBtn";
            this.salesReturnBtn.Size = new System.Drawing.Size(292, 160);
            this.salesReturnBtn.TabIndex = 8;
            this.salesReturnBtn.Text = "Sales Return";
            this.salesReturnBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.salesReturnBtn.UseVisualStyleBackColor = true;
            this.salesReturnBtn.Click += new System.EventHandler(this.salesReturnBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suppliersBtn.FlatAppearance.BorderSize = 2;
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suppliersBtn.Image = ((System.Drawing.Image)(resources.GetObject("suppliersBtn.Image")));
            this.suppliersBtn.Location = new System.Drawing.Point(3, 335);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(291, 160);
            this.suppliersBtn.TabIndex = 11;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.suppliersBtn.UseVisualStyleBackColor = true;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // productPricingBtn
            // 
            this.productPricingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productPricingBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPricingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productPricingBtn.FlatAppearance.BorderSize = 2;
            this.productPricingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productPricingBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPricingBtn.Image = ((System.Drawing.Image)(resources.GetObject("productPricingBtn.Image")));
            this.productPricingBtn.Location = new System.Drawing.Point(300, 335);
            this.productPricingBtn.Name = "productPricingBtn";
            this.productPricingBtn.Size = new System.Drawing.Size(291, 160);
            this.productPricingBtn.TabIndex = 7;
            this.productPricingBtn.Text = "Product Price";
            this.productPricingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.productPricingBtn.UseVisualStyleBackColor = true;
            this.productPricingBtn.Click += new System.EventHandler(this.productPricingBtn_Click);
            // 
            // stockBtn
            // 
            this.stockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stockBtn.FlatAppearance.BorderSize = 2;
            this.stockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stockBtn.Image = ((System.Drawing.Image)(resources.GetObject("stockBtn.Image")));
            this.stockBtn.Location = new System.Drawing.Point(597, 169);
            this.stockBtn.Name = "stockBtn";
            this.stockBtn.Size = new System.Drawing.Size(292, 160);
            this.stockBtn.TabIndex = 2;
            this.stockBtn.Text = "Stock";
            this.stockBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.stockBtn.UseVisualStyleBackColor = true;
            this.stockBtn.Click += new System.EventHandler(this.stockBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categoriesBtn.FlatAppearance.BorderSize = 2;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.Image")));
            this.categoriesBtn.Location = new System.Drawing.Point(597, 3);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(292, 160);
            this.categoriesBtn.TabIndex = 12;
            this.categoriesBtn.Text = "Categories";
            this.categoriesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button purchaseInvoiceBtn;
        private System.Windows.Forms.Button stockBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button salesReturnBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button productPricingBtn;
        private System.Windows.Forms.Button categoriesBtn;
    }
}