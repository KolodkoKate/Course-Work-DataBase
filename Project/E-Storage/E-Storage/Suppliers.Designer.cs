namespace E_Storage
{
    partial class Suppliers
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
            this.contactPersonErrLbl = new System.Windows.Forms.Label();
            this.companyErrLbl = new System.Windows.Forms.Label();
            this.contactPersonTb = new System.Windows.Forms.TextBox();
            this.companyTb = new System.Windows.Forms.TextBox();
            this.contactPersonLbl = new System.Windows.Forms.Label();
            this.companyLbl = new System.Windows.Forms.Label();
            this.addressErrLbl = new System.Windows.Forms.Label();
            this.phoneErrLbl = new System.Windows.Forms.Label();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.statusErrLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusCb);
            this.leftPanel.Controls.Add(this.statusErrLbl);
            this.leftPanel.Controls.Add(this.statusLbl);
            this.leftPanel.Controls.Add(this.addressErrLbl);
            this.leftPanel.Controls.Add(this.phoneErrLbl);
            this.leftPanel.Controls.Add(this.addressTb);
            this.leftPanel.Controls.Add(this.phoneTb);
            this.leftPanel.Controls.Add(this.addressLbl);
            this.leftPanel.Controls.Add(this.phoneLbl);
            this.leftPanel.Controls.Add(this.contactPersonErrLbl);
            this.leftPanel.Controls.Add(this.companyErrLbl);
            this.leftPanel.Controls.Add(this.contactPersonTb);
            this.leftPanel.Controls.Add(this.companyTb);
            this.leftPanel.Controls.Add(this.contactPersonLbl);
            this.leftPanel.Controls.Add(this.companyLbl);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.companyLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.companyTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.companyErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusErrLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusCb, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel2, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // contactPersonErrLbl
            // 
            this.contactPersonErrLbl.AutoSize = true;
            this.contactPersonErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactPersonErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.contactPersonErrLbl.Location = new System.Drawing.Point(179, 261);
            this.contactPersonErrLbl.Name = "contactPersonErrLbl";
            this.contactPersonErrLbl.Size = new System.Drawing.Size(25, 32);
            this.contactPersonErrLbl.TabIndex = 46;
            this.contactPersonErrLbl.Text = "*";
            this.contactPersonErrLbl.Visible = false;
            // 
            // companyErrLbl
            // 
            this.companyErrLbl.AutoSize = true;
            this.companyErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.companyErrLbl.Location = new System.Drawing.Point(120, 160);
            this.companyErrLbl.Name = "companyErrLbl";
            this.companyErrLbl.Size = new System.Drawing.Size(25, 32);
            this.companyErrLbl.TabIndex = 45;
            this.companyErrLbl.Text = "*";
            this.companyErrLbl.Visible = false;
            // 
            // contactPersonTb
            // 
            this.contactPersonTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactPersonTb.Location = new System.Drawing.Point(18, 296);
            this.contactPersonTb.MaxLength = 50;
            this.contactPersonTb.Name = "contactPersonTb";
            this.contactPersonTb.Size = new System.Drawing.Size(262, 38);
            this.contactPersonTb.TabIndex = 42;
            // 
            // companyTb
            // 
            this.companyTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyTb.Location = new System.Drawing.Point(19, 195);
            this.companyTb.MaxLength = 50;
            this.companyTb.Name = "companyTb";
            this.companyTb.Size = new System.Drawing.Size(261, 38);
            this.companyTb.TabIndex = 41;
            // 
            // contactPersonLbl
            // 
            this.contactPersonLbl.AutoSize = true;
            this.contactPersonLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactPersonLbl.ForeColor = System.Drawing.Color.White;
            this.contactPersonLbl.Location = new System.Drawing.Point(13, 261);
            this.contactPersonLbl.Name = "contactPersonLbl";
            this.contactPersonLbl.Size = new System.Drawing.Size(175, 32);
            this.contactPersonLbl.TabIndex = 44;
            this.contactPersonLbl.Text = "Contact Person";
            // 
            // companyLbl
            // 
            this.companyLbl.AutoSize = true;
            this.companyLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyLbl.ForeColor = System.Drawing.Color.White;
            this.companyLbl.Location = new System.Drawing.Point(12, 160);
            this.companyLbl.Name = "companyLbl";
            this.companyLbl.Size = new System.Drawing.Size(117, 32);
            this.companyLbl.TabIndex = 43;
            this.companyLbl.Text = "Company";
            // 
            // addressErrLbl
            // 
            this.addressErrLbl.AutoSize = true;
            this.addressErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.addressErrLbl.Location = new System.Drawing.Point(104, 454);
            this.addressErrLbl.Name = "addressErrLbl";
            this.addressErrLbl.Size = new System.Drawing.Size(25, 32);
            this.addressErrLbl.TabIndex = 52;
            this.addressErrLbl.Text = "*";
            this.addressErrLbl.Visible = false;
            // 
            // phoneErrLbl
            // 
            this.phoneErrLbl.AutoSize = true;
            this.phoneErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.phoneErrLbl.Location = new System.Drawing.Point(266, 353);
            this.phoneErrLbl.Name = "phoneErrLbl";
            this.phoneErrLbl.Size = new System.Drawing.Size(25, 32);
            this.phoneErrLbl.TabIndex = 51;
            this.phoneErrLbl.Text = "*";
            this.phoneErrLbl.Visible = false;
            // 
            // addressTb
            // 
            this.addressTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTb.Location = new System.Drawing.Point(18, 489);
            this.addressTb.MaxLength = 50;
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(262, 38);
            this.addressTb.TabIndex = 48;
            // 
            // phoneTb
            // 
            this.phoneTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTb.Location = new System.Drawing.Point(19, 388);
            this.phoneTb.MaxLength = 50;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(261, 38);
            this.phoneTb.TabIndex = 47;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLbl.ForeColor = System.Drawing.Color.White;
            this.addressLbl.Location = new System.Drawing.Point(13, 454);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(99, 32);
            this.addressLbl.TabIndex = 50;
            this.addressLbl.Text = "Address";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.ForeColor = System.Drawing.Color.White;
            this.phoneLbl.Location = new System.Drawing.Point(12, 353);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(263, 32);
            this.phoneLbl.TabIndex = 49;
            this.phoneLbl.Text = "Phone (29/33XXXXXXX)";
            // 
            // statusErrLbl
            // 
            this.statusErrLbl.AutoSize = true;
            this.statusErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrLbl.Location = new System.Drawing.Point(87, 549);
            this.statusErrLbl.Name = "statusErrLbl";
            this.statusErrLbl.Size = new System.Drawing.Size(25, 32);
            this.statusErrLbl.TabIndex = 55;
            this.statusErrLbl.Text = "*";
            this.statusErrLbl.Visible = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(13, 549);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(79, 32);
            this.statusLbl.TabIndex = 54;
            this.statusLbl.Text = "Status";
            // 
            // statusCb
            // 
            this.statusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusCb.Location = new System.Drawing.Point(19, 584);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(261, 39);
            this.statusCb.TabIndex = 56;
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
            this.supplierIDGV,
            this.companyGV,
            this.contactPersonGV,
            this.phoneGV,
            this.addressGV,
            this.statusGV});
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
            // supplierIDGV
            // 
            this.supplierIDGV.HeaderText = "SupplierID";
            this.supplierIDGV.Name = "supplierIDGV";
            this.supplierIDGV.ReadOnly = true;
            this.supplierIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // contactPersonGV
            // 
            this.contactPersonGV.HeaderText = "Contact Person";
            this.contactPersonGV.Name = "contactPersonGV";
            this.contactPersonGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "Suppliers";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Label addressErrLbl;
        protected System.Windows.Forms.Label phoneErrLbl;
        protected System.Windows.Forms.TextBox addressTb;
        protected System.Windows.Forms.TextBox phoneTb;
        protected System.Windows.Forms.Label addressLbl;
        protected System.Windows.Forms.Label phoneLbl;
        protected System.Windows.Forms.Label contactPersonErrLbl;
        protected System.Windows.Forms.Label companyErrLbl;
        protected System.Windows.Forms.TextBox contactPersonTb;
        protected System.Windows.Forms.TextBox companyTb;
        protected System.Windows.Forms.Label contactPersonLbl;
        protected System.Windows.Forms.Label companyLbl;
        protected System.Windows.Forms.Label statusErrLbl;
        protected System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}