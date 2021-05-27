namespace E_Storage
{
    partial class Categories
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
            this.statusErrLbl = new System.Windows.Forms.Label();
            this.categoryNameErrLbl = new System.Windows.Forms.Label();
            this.categoryNameTb = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.categorynameLbl = new System.Windows.Forms.Label();
            this.statusCb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftPanel.Controls.Add(this.categoryNameErrLbl);
            this.leftPanel.Controls.Add(this.categoryNameTb);
            this.leftPanel.Controls.Add(this.statusLbl);
            this.leftPanel.Controls.Add(this.categorynameLbl);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.categorynameLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusLbl, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryNameTb, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryNameErrLbl, 0);
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
            // statusErrLbl
            // 
            this.statusErrLbl.AutoSize = true;
            this.statusErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrLbl.Location = new System.Drawing.Point(89, 305);
            this.statusErrLbl.Name = "statusErrLbl";
            this.statusErrLbl.Size = new System.Drawing.Size(25, 32);
            this.statusErrLbl.TabIndex = 47;
            this.statusErrLbl.Text = "*";
            this.statusErrLbl.Visible = false;
            // 
            // categoryNameErrLbl
            // 
            this.categoryNameErrLbl.AutoSize = true;
            this.categoryNameErrLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryNameErrLbl.ForeColor = System.Drawing.Color.Salmon;
            this.categoryNameErrLbl.Location = new System.Drawing.Point(193, 203);
            this.categoryNameErrLbl.Name = "categoryNameErrLbl";
            this.categoryNameErrLbl.Size = new System.Drawing.Size(25, 32);
            this.categoryNameErrLbl.TabIndex = 46;
            this.categoryNameErrLbl.Text = "*";
            this.categoryNameErrLbl.Visible = false;
            // 
            // categoryNameTb
            // 
            this.categoryNameTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryNameTb.Location = new System.Drawing.Point(26, 238);
            this.categoryNameTb.MaxLength = 50;
            this.categoryNameTb.Name = "categoryNameTb";
            this.categoryNameTb.Size = new System.Drawing.Size(261, 38);
            this.categoryNameTb.TabIndex = 44;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLbl.ForeColor = System.Drawing.Color.White;
            this.statusLbl.Location = new System.Drawing.Point(20, 304);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(79, 32);
            this.statusLbl.TabIndex = 43;
            this.statusLbl.Text = "Status";
            // 
            // categorynameLbl
            // 
            this.categorynameLbl.AutoSize = true;
            this.categorynameLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categorynameLbl.ForeColor = System.Drawing.Color.White;
            this.categorynameLbl.Location = new System.Drawing.Point(19, 203);
            this.categorynameLbl.Name = "categorynameLbl";
            this.categorynameLbl.Size = new System.Drawing.Size(182, 32);
            this.categorynameLbl.TabIndex = 42;
            this.categorynameLbl.Text = "Category Name";
            // 
            // statusCb
            // 
            this.statusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusCb.FormattingEnabled = true;
            this.statusCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.statusCb.Location = new System.Drawing.Point(26, 340);
            this.statusCb.Name = "statusCb";
            this.statusCb.Size = new System.Drawing.Size(261, 39);
            this.statusCb.TabIndex = 48;
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
            this.categoryIDGV,
            this.categoryGV,
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
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 738);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusCb;
        protected System.Windows.Forms.Label statusErrLbl;
        protected System.Windows.Forms.Label categoryNameErrLbl;
        protected System.Windows.Forms.TextBox categoryNameTb;
        protected System.Windows.Forms.Label statusLbl;
        protected System.Windows.Forms.Label categorynameLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}