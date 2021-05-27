namespace E_Storage
{
    partial class SalesReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.st_getSalesReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new E_Storage.DataSet();
            this.st_getSalesReceiptTableAdapter = new E_Storage.DataSetTableAdapters.st_getSalesReceiptTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.st_getSalesReceiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // st_getSalesReceiptBindingSource
            // 
            this.st_getSalesReceiptBindingSource.DataMember = "st_getSalesReceipt";
            this.st_getSalesReceiptBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // st_getSalesReceiptTableAdapter
            // 
            this.st_getSalesReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.st_getSalesReceiptBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_Storage.SalesReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(993, 786);
            this.reportViewer1.TabIndex = 1;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 786);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st_getSalesReceiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource st_getSalesReceiptBindingSource;
        private DataSet DataSet;
        private DataSetTableAdapters.st_getSalesReceiptTableAdapter st_getSalesReceiptTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}