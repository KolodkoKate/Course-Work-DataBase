namespace E_Storage
{
    partial class PurchaseInvoice
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
            this.supplierErrLbl = new System.Windows.Forms.Label();
            this.supplierCb = new System.Windows.Forms.ComboBox();
            this.supplierLbl = new System.Windows.Forms.Label();
            this.quantityErrLbl = new System.Windows.Forms.Label();
            this.productErrLbl = new System.Windows.Forms.Label();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.productTb = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.barcodeErrLbl = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.barcodeLbl = new System.Windows.Forms.Label();
            this.perUnitPriceErrLbl = new System.Windows.Forms.Label();
            this.perUnitPriceTb = new System.Windows.Forms.TextBox();
            this.perUnitPrice = new System.Windows.Forms.Label();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossTotalLbl = new System.Windows.Forms.Label();
            this.gtotLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totalLbl);
            this.leftPanel.Controls.Add(this.totalAmountLbl);
            this.leftPanel.Controls.Add(this.addToCartBtn);
            this.leftPanel.Controls.Add(this.perUnitPriceErrLbl);
            this.leftPanel.Controls.Add(this.perUnitPriceTb);
            this.leftPanel.Controls.Add(this.perUnitPrice);
            this.leftPanel.Controls.Add(this.barcodeErrLbl);
            this.leftPanel.Controls.Add(this.barcodeTb);
            this.leftPanel.Controls.Add(this.barcodeLbl);
            this.leftPanel.Controls.Add(this.quantityErrLbl);
            this.leftPanel.Controls.Add(this.productErrLbl);
            this.leftPanel.Controls.Add(this.quantityTb);
            this.leftPanel.Controls.Add(this.productTb);
            this.leftPanel.Controls.Add(this.quantityLbl);
            this.leftPanel.Controls.Add(this.productLbl);
            this.leftPanel.Controls.Add(this.supplierErrLbl);
            this.leftPanel.Controls.Add(this.supplierCb);
            this.leftPanel.Controls.Add(this.supplierLbl);
            this.leftPanel.Size = new System.Drawing.Size(309, 952);
            this.leftPanel.Controls.SetChildIndex(this.supplierLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierCb, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.productErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.perUnitPrice, 0);
            this.leftPanel.Controls.SetChildIndex(this.perUnitPriceTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.perUnitPriceErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.addToCartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalAmountLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalLbl, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(892, 952);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // supplierErrLbl
            // 
            this.supplierErrLbl.AutoSize = true;
            this.supplierErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.supplierErrLbl.Location = new System.Drawing.Point(114, 166);
            this.supplierErrLbl.Name = "supplierErrLbl";
            this.supplierErrLbl.Size = new System.Drawing.Size(25, 32);
            this.supplierErrLbl.TabIndex = 49;
            this.supplierErrLbl.Text = "*";
            this.supplierErrLbl.Visible = false;
            // 
            // supplierCb
            // 
            this.supplierCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierCb.FormattingEnabled = true;
            this.supplierCb.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.supplierCb.Location = new System.Drawing.Point(24, 201);
            this.supplierCb.Name = "supplierCb";
            this.supplierCb.Size = new System.Drawing.Size(262, 39);
            this.supplierCb.TabIndex = 48;
            // 
            // supplierLbl
            // 
            this.supplierLbl.AutoSize = true;
            this.supplierLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplierLbl.ForeColor = System.Drawing.Color.White;
            this.supplierLbl.Location = new System.Drawing.Point(19, 166);
            this.supplierLbl.Name = "supplierLbl";
            this.supplierLbl.Size = new System.Drawing.Size(103, 32);
            this.supplierLbl.TabIndex = 47;
            this.supplierLbl.Text = "Supplier";
            // 
            // quantityErrLbl
            // 
            this.quantityErrLbl.AutoSize = true;
            this.quantityErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.quantityErrLbl.Location = new System.Drawing.Point(116, 557);
            this.quantityErrLbl.Name = "quantityErrLbl";
            this.quantityErrLbl.Size = new System.Drawing.Size(25, 32);
            this.quantityErrLbl.TabIndex = 55;
            this.quantityErrLbl.Text = "*";
            this.quantityErrLbl.Visible = false;
            // 
            // productErrLbl
            // 
            this.productErrLbl.AutoSize = true;
            this.productErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.productErrLbl.Location = new System.Drawing.Point(116, 368);
            this.productErrLbl.Name = "productErrLbl";
            this.productErrLbl.Size = new System.Drawing.Size(25, 32);
            this.productErrLbl.TabIndex = 54;
            this.productErrLbl.Text = "*";
            this.productErrLbl.Visible = false;
            // 
            // quantityTb
            // 
            this.quantityTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityTb.Location = new System.Drawing.Point(24, 592);
            this.quantityTb.MaxLength = 50;
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(262, 38);
            this.quantityTb.TabIndex = 53;
            this.quantityTb.TextChanged += new System.EventHandler(this.quantityTb_TextChanged);
            // 
            // productTb
            // 
            this.productTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTb.Location = new System.Drawing.Point(26, 403);
            this.productTb.MaxLength = 50;
            this.productTb.Name = "productTb";
            this.productTb.Size = new System.Drawing.Size(261, 38);
            this.productTb.TabIndex = 52;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLbl.ForeColor = System.Drawing.Color.White;
            this.quantityLbl.Location = new System.Drawing.Point(19, 557);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(107, 32);
            this.quantityLbl.TabIndex = 51;
            this.quantityLbl.Text = "Quantity";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLbl.ForeColor = System.Drawing.Color.White;
            this.productLbl.Location = new System.Drawing.Point(19, 368);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(97, 32);
            this.productLbl.TabIndex = 50;
            this.productLbl.Text = "Product";
            // 
            // barcodeErrLbl
            // 
            this.barcodeErrLbl.AutoSize = true;
            this.barcodeErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrLbl.Location = new System.Drawing.Point(116, 269);
            this.barcodeErrLbl.Name = "barcodeErrLbl";
            this.barcodeErrLbl.Size = new System.Drawing.Size(25, 32);
            this.barcodeErrLbl.TabIndex = 58;
            this.barcodeErrLbl.Text = "*";
            this.barcodeErrLbl.Visible = false;
            // 
            // barcodeTb
            // 
            this.barcodeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTb.Location = new System.Drawing.Point(25, 304);
            this.barcodeTb.MaxLength = 50;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(262, 38);
            this.barcodeTb.TabIndex = 57;
            this.barcodeTb.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTb_Validating);
            // 
            // barcodeLbl
            // 
            this.barcodeLbl.AutoSize = true;
            this.barcodeLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeLbl.ForeColor = System.Drawing.Color.White;
            this.barcodeLbl.Location = new System.Drawing.Point(20, 269);
            this.barcodeLbl.Name = "barcodeLbl";
            this.barcodeLbl.Size = new System.Drawing.Size(101, 32);
            this.barcodeLbl.TabIndex = 56;
            this.barcodeLbl.Text = "Barcode";
            // 
            // perUnitPriceErrLbl
            // 
            this.perUnitPriceErrLbl.AutoSize = true;
            this.perUnitPriceErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perUnitPriceErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.perUnitPriceErrLbl.Location = new System.Drawing.Point(168, 465);
            this.perUnitPriceErrLbl.Name = "perUnitPriceErrLbl";
            this.perUnitPriceErrLbl.Size = new System.Drawing.Size(25, 32);
            this.perUnitPriceErrLbl.TabIndex = 61;
            this.perUnitPriceErrLbl.Text = "*";
            this.perUnitPriceErrLbl.Visible = false;
            // 
            // perUnitPriceTb
            // 
            this.perUnitPriceTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perUnitPriceTb.Location = new System.Drawing.Point(26, 500);
            this.perUnitPriceTb.MaxLength = 50;
            this.perUnitPriceTb.Name = "perUnitPriceTb";
            this.perUnitPriceTb.Size = new System.Drawing.Size(261, 38);
            this.perUnitPriceTb.TabIndex = 60;
            this.perUnitPriceTb.TextChanged += new System.EventHandler(this.perUnitPriceTb_TextChanged);
            // 
            // perUnitPrice
            // 
            this.perUnitPrice.AutoSize = true;
            this.perUnitPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perUnitPrice.ForeColor = System.Drawing.Color.White;
            this.perUnitPrice.Location = new System.Drawing.Point(19, 465);
            this.perUnitPrice.Name = "perUnitPrice";
            this.perUnitPrice.Size = new System.Drawing.Size(157, 32);
            this.perUnitPrice.TabIndex = 59;
            this.perUnitPrice.Text = "Per Unit Price";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addToCartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addToCartBtn.FlatAppearance.BorderSize = 2;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToCartBtn.ForeColor = System.Drawing.Color.White;
            this.addToCartBtn.Location = new System.Drawing.Point(25, 663);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(261, 62);
            this.addToCartBtn.TabIndex = 62;
            this.addToCartBtn.Text = "ADD TO CART";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalAmountLbl.ForeColor = System.Drawing.Color.White;
            this.totalAmountLbl.Location = new System.Drawing.Point(20, 741);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(130, 28);
            this.totalAmountLbl.TabIndex = 63;
            this.totalAmountLbl.Text = "Total Amount";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(112, 781);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(81, 45);
            this.totalLbl.TabIndex = 64;
            this.totalLbl.Text = "0.00";
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
            this.perUnitPriceGV,
            this.totalAmountGV,
            this.deleteGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 733);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "Product ID";
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
            // perUnitPriceGV
            // 
            this.perUnitPriceGV.HeaderText = "Per Unit Price";
            this.perUnitPriceGV.Name = "perUnitPriceGV";
            this.perUnitPriceGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 870);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 82);
            this.panel5.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.12556F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.87444F));
            this.tableLayoutPanel2.Controls.Add(this.grossTotalLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gtotLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 82);
            this.tableLayoutPanel2.TabIndex = 67;
            // 
            // grossTotalLbl
            // 
            this.grossTotalLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossTotalLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grossTotalLbl.ForeColor = System.Drawing.Color.Black;
            this.grossTotalLbl.Location = new System.Drawing.Point(3, 0);
            this.grossTotalLbl.Name = "grossTotalLbl";
            this.grossTotalLbl.Size = new System.Drawing.Size(565, 82);
            this.grossTotalLbl.TabIndex = 65;
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
            this.gtotLbl.Size = new System.Drawing.Size(315, 82);
            this.gtotLbl.TabIndex = 66;
            this.gtotLbl.Text = "0.00";
            this.gtotLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 952);
            this.Name = "PurchaseInvoice";
            this.Text = "Purchase Invoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label supplierErrLbl;
        private System.Windows.Forms.ComboBox supplierCb;
        protected System.Windows.Forms.Label supplierLbl;
        protected System.Windows.Forms.Label quantityErrLbl;
        protected System.Windows.Forms.Label productErrLbl;
        protected System.Windows.Forms.TextBox quantityTb;
        protected System.Windows.Forms.TextBox productTb;
        protected System.Windows.Forms.Label quantityLbl;
        protected System.Windows.Forms.Label productLbl;
        protected System.Windows.Forms.Label barcodeErrLbl;
        protected System.Windows.Forms.TextBox barcodeTb;
        protected System.Windows.Forms.Label barcodeLbl;
        protected System.Windows.Forms.Label perUnitPriceErrLbl;
        protected System.Windows.Forms.TextBox perUnitPriceTb;
        protected System.Windows.Forms.Label perUnitPrice;
        protected System.Windows.Forms.Button addToCartBtn;
        protected System.Windows.Forms.Label totalLbl;
        protected System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.Label gtotLbl;
        protected System.Windows.Forms.Label grossTotalLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}