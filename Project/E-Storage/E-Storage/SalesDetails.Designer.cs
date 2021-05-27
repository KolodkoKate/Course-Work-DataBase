namespace E_Storage
{
    partial class SalesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDetails));
            this.dateLbl = new System.Windows.Forms.Label();
            this.dateTimePkr = new System.Windows.Forms.DateTimePicker();
            this.loadBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loadBtn);
            this.leftPanel.Controls.Add(this.dateTimePkr);
            this.leftPanel.Controls.Add(this.dateLbl);
            this.leftPanel.Size = new System.Drawing.Size(309, 738);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePkr, 0);
            this.leftPanel.Controls.SetChildIndex(this.loadBtn, 0);
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
            this.rightPanel.Size = new System.Drawing.Size(892, 738);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(19, 145);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(65, 32);
            this.dateLbl.TabIndex = 35;
            this.dateLbl.Text = "Date";
            // 
            // dateTimePkr
            // 
            this.dateTimePkr.CustomFormat = "";
            this.dateTimePkr.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePkr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePkr.Location = new System.Drawing.Point(25, 180);
            this.dateTimePkr.Name = "dateTimePkr";
            this.dateTimePkr.Size = new System.Drawing.Size(261, 38);
            this.dateTimePkr.TabIndex = 44;
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
            this.loadBtn.Location = new System.Drawing.Point(25, 253);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(261, 62);
            this.loadBtn.TabIndex = 56;
            this.loadBtn.Text = "LOAD";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
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
            this.userIDGV,
            this.userGV,
            this.totalAmountGV,
            this.totalDiscountGV,
            this.amountGivenGV,
            this.amountReturnedGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 666);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // saleIDGV
            // 
            this.saleIDGV.HeaderText = "Sale ID";
            this.saleIDGV.Name = "saleIDGV";
            this.saleIDGV.ReadOnly = true;
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "User ID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // totalDiscountGV
            // 
            this.totalDiscountGV.HeaderText = "Total Discount";
            this.totalDiscountGV.Name = "totalDiscountGV";
            this.totalDiscountGV.ReadOnly = true;
            // 
            // amountGivenGV
            // 
            this.amountGivenGV.HeaderText = "Amount Given";
            this.amountGivenGV.Name = "amountGivenGV";
            this.amountGivenGV.ReadOnly = true;
            // 
            // amountReturnedGV
            // 
            this.amountReturnedGV.HeaderText = "Amount Returned";
            this.amountReturnedGV.Name = "amountReturnedGV";
            this.amountReturnedGV.ReadOnly = true;
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
            this.backBtn.TabIndex = 4;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SalesDetails
            // 
            this.AcceptButton = this.loadBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "SalesDetails";
            this.Text = "Sales Details";
            this.Load += new System.EventHandler(this.ViewSalesInvoices_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePkr;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReturnedGV;
    }
}