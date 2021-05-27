namespace E_Storage
{
    partial class Sales
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
            this.productNameErrLbl = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grossTotalLbl = new System.Windows.Forms.Label();
            this.gtotLbl = new System.Windows.Forms.Label();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.changeToGiveTb = new System.Windows.Forms.TextBox();
            this.changeToGiveLbl = new System.Windows.Forms.Label();
            this.amountGivenTb = new System.Windows.Forms.TextBox();
            this.amountGivenLbl = new System.Windows.Forms.Label();
            this.totalDiscountTb = new System.Windows.Forms.TextBox();
            this.grossTotalTb = new System.Windows.Forms.TextBox();
            this.paymentTypeCb = new System.Windows.Forms.ComboBox();
            this.paymentTypeLbl = new System.Windows.Forms.Label();
            this.totalDiscountLbl = new System.Windows.Forms.Label();
            this.grossTotLbl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perUnitPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.panel7);
            this.leftPanel.Size = new System.Drawing.Size(309, 952);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel7, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
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
            // productNameErrLbl
            // 
            this.productNameErrLbl.AutoSize = true;
            this.productNameErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.productNameErrLbl.Location = new System.Drawing.Point(109, 33);
            this.productNameErrLbl.Name = "productNameErrLbl";
            this.productNameErrLbl.Size = new System.Drawing.Size(25, 32);
            this.productNameErrLbl.TabIndex = 43;
            this.productNameErrLbl.Text = "*";
            this.productNameErrLbl.Visible = false;
            // 
            // barcodeTb
            // 
            this.barcodeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barcodeTb.Location = new System.Drawing.Point(23, 6);
            this.barcodeTb.MaxLength = 100;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(262, 38);
            this.barcodeTb.TabIndex = 42;
            this.barcodeTb.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTb_Validating);
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLbl.ForeColor = System.Drawing.Color.White;
            this.productNameLbl.Location = new System.Drawing.Point(17, 30);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(101, 32);
            this.productNameLbl.TabIndex = 41;
            this.productNameLbl.Text = "Barcode";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.discountGV,
            this.totalAmountGV,
            this.deleteGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 733);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 870);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 82);
            this.panel5.TabIndex = 7;
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
            // checkOutBtn
            // 
            this.checkOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkOutBtn.FlatAppearance.BorderSize = 2;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.White;
            this.checkOutBtn.Location = new System.Drawing.Point(22, 555);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(261, 62);
            this.checkOutBtn.TabIndex = 44;
            this.checkOutBtn.Text = "CHECK OUT";
            this.checkOutBtn.UseVisualStyleBackColor = false;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payBtn);
            this.groupBox2.Controls.Add(this.changeToGiveTb);
            this.groupBox2.Controls.Add(this.changeToGiveLbl);
            this.groupBox2.Controls.Add(this.amountGivenTb);
            this.groupBox2.Controls.Add(this.amountGivenLbl);
            this.groupBox2.Controls.Add(this.totalDiscountTb);
            this.groupBox2.Controls.Add(this.grossTotalTb);
            this.groupBox2.Controls.Add(this.paymentTypeCb);
            this.groupBox2.Controls.Add(this.paymentTypeLbl);
            this.groupBox2.Controls.Add(this.totalDiscountLbl);
            this.groupBox2.Controls.Add(this.grossTotLbl);
            this.groupBox2.Controls.Add(this.checkOutBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 765);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payments";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Firebrick;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(22, 683);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(261, 62);
            this.payBtn.TabIndex = 55;
            this.payBtn.Text = "PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // changeToGiveTb
            // 
            this.changeToGiveTb.Enabled = false;
            this.changeToGiveTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeToGiveTb.Location = new System.Drawing.Point(22, 458);
            this.changeToGiveTb.MaxLength = 100;
            this.changeToGiveTb.Name = "changeToGiveTb";
            this.changeToGiveTb.Size = new System.Drawing.Size(262, 38);
            this.changeToGiveTb.TabIndex = 54;
            // 
            // changeToGiveLbl
            // 
            this.changeToGiveLbl.AutoSize = true;
            this.changeToGiveLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeToGiveLbl.ForeColor = System.Drawing.Color.White;
            this.changeToGiveLbl.Location = new System.Drawing.Point(18, 425);
            this.changeToGiveLbl.Name = "changeToGiveLbl";
            this.changeToGiveLbl.Size = new System.Drawing.Size(183, 32);
            this.changeToGiveLbl.TabIndex = 53;
            this.changeToGiveLbl.Text = "Change To Give";
            // 
            // amountGivenTb
            // 
            this.amountGivenTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountGivenTb.Location = new System.Drawing.Point(23, 357);
            this.amountGivenTb.MaxLength = 100;
            this.amountGivenTb.Name = "amountGivenTb";
            this.amountGivenTb.Size = new System.Drawing.Size(262, 38);
            this.amountGivenTb.TabIndex = 52;
            this.amountGivenTb.TextChanged += new System.EventHandler(this.amountGivenTb_TextChanged);
            this.amountGivenTb.Validating += new System.ComponentModel.CancelEventHandler(this.amountGivenTb_Validating);
            // 
            // amountGivenLbl
            // 
            this.amountGivenLbl.AutoSize = true;
            this.amountGivenLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountGivenLbl.ForeColor = System.Drawing.Color.White;
            this.amountGivenLbl.Location = new System.Drawing.Point(19, 324);
            this.amountGivenLbl.Name = "amountGivenLbl";
            this.amountGivenLbl.Size = new System.Drawing.Size(169, 32);
            this.amountGivenLbl.TabIndex = 51;
            this.amountGivenLbl.Text = "Amount Given";
            // 
            // totalDiscountTb
            // 
            this.totalDiscountTb.Enabled = false;
            this.totalDiscountTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalDiscountTb.Location = new System.Drawing.Point(23, 155);
            this.totalDiscountTb.MaxLength = 100;
            this.totalDiscountTb.Name = "totalDiscountTb";
            this.totalDiscountTb.Size = new System.Drawing.Size(262, 38);
            this.totalDiscountTb.TabIndex = 50;
            // 
            // grossTotalTb
            // 
            this.grossTotalTb.Enabled = false;
            this.grossTotalTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grossTotalTb.Location = new System.Drawing.Point(23, 58);
            this.grossTotalTb.MaxLength = 100;
            this.grossTotalTb.Name = "grossTotalTb";
            this.grossTotalTb.Size = new System.Drawing.Size(262, 38);
            this.grossTotalTb.TabIndex = 43;
            // 
            // paymentTypeCb
            // 
            this.paymentTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTypeCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeCb.FormattingEnabled = true;
            this.paymentTypeCb.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.paymentTypeCb.Location = new System.Drawing.Point(23, 256);
            this.paymentTypeCb.Name = "paymentTypeCb";
            this.paymentTypeCb.Size = new System.Drawing.Size(262, 39);
            this.paymentTypeCb.TabIndex = 49;
            // 
            // paymentTypeLbl
            // 
            this.paymentTypeLbl.AutoSize = true;
            this.paymentTypeLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paymentTypeLbl.ForeColor = System.Drawing.Color.White;
            this.paymentTypeLbl.Location = new System.Drawing.Point(17, 221);
            this.paymentTypeLbl.Name = "paymentTypeLbl";
            this.paymentTypeLbl.Size = new System.Drawing.Size(165, 32);
            this.paymentTypeLbl.TabIndex = 46;
            this.paymentTypeLbl.Text = "Payment Type";
            // 
            // totalDiscountLbl
            // 
            this.totalDiscountLbl.AutoSize = true;
            this.totalDiscountLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalDiscountLbl.ForeColor = System.Drawing.Color.White;
            this.totalDiscountLbl.Location = new System.Drawing.Point(17, 120);
            this.totalDiscountLbl.Name = "totalDiscountLbl";
            this.totalDiscountLbl.Size = new System.Drawing.Size(167, 32);
            this.totalDiscountLbl.TabIndex = 45;
            this.totalDiscountLbl.Text = "Total Discount";
            // 
            // grossTotLbl
            // 
            this.grossTotLbl.AutoSize = true;
            this.grossTotLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grossTotLbl.ForeColor = System.Drawing.Color.White;
            this.grossTotLbl.Location = new System.Drawing.Point(17, 23);
            this.grossTotLbl.Name = "grossTotLbl";
            this.grossTotLbl.Size = new System.Drawing.Size(131, 32);
            this.grossTotLbl.TabIndex = 44;
            this.grossTotLbl.Text = "Gross Total";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.productNameLbl);
            this.panel6.Controls.Add(this.productNameErrLbl);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(309, 65);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.barcodeTb);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 137);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 50);
            this.panel7.TabIndex = 46;
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
            // perUnitPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.perUnitPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.perUnitPriceGV.HeaderText = "Per Unit Price";
            this.perUnitPriceGV.Name = "perUnitPriceGV";
            this.perUnitPriceGV.ReadOnly = true;
            // 
            // discountGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountGV.HeaderText = "Discount";
            this.discountGV.Name = "discountGV";
            this.discountGV.ReadOnly = true;
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
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 952);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel4.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label productNameErrLbl;
        protected System.Windows.Forms.TextBox barcodeTb;
        protected System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        protected System.Windows.Forms.Label grossTotalLbl;
        protected System.Windows.Forms.Label gtotLbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label paymentTypeLbl;
        protected System.Windows.Forms.Label totalDiscountLbl;
        protected System.Windows.Forms.Label grossTotLbl;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox paymentTypeCb;
        protected System.Windows.Forms.TextBox totalDiscountTb;
        protected System.Windows.Forms.TextBox grossTotalTb;
        private System.Windows.Forms.Button payBtn;
        protected System.Windows.Forms.TextBox changeToGiveTb;
        protected System.Windows.Forms.Label changeToGiveLbl;
        protected System.Windows.Forms.TextBox amountGivenTb;
        protected System.Windows.Forms.Label amountGivenLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perUnitPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}