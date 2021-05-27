namespace E_Storage
{
    partial class SalesReturnReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet = new E_Storage.DataSet();
            this.st_getSalesReceiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.st_getSalesReceiptTableAdapter = new E_Storage.DataSetTableAdapters.st_getSalesReceiptTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_getSalesReceiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_Storage.SalesReceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(629, 660);
            this.reportViewer1.TabIndex = 2;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // st_getSalesReceiptBindingSource
            // 
            this.st_getSalesReceiptBindingSource.DataMember = "st_getSalesReceipt";
            this.st_getSalesReceiptBindingSource.DataSource = this.DataSet;
            // 
            // st_getSalesReceiptTableAdapter
            // 
            this.st_getSalesReceiptTableAdapter.ClearBeforeFill = true;
            // 
            // SalesReturnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 660);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalesReturnReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return Report";
            this.Load += new System.EventHandler(this.SalesReturnReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_getSalesReceiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet DataSet;
        private System.Windows.Forms.BindingSource st_getSalesReceiptBindingSource;
        private DataSetTableAdapters.st_getSalesReceiptTableAdapter st_getSalesReceiptTableAdapter;
    }
}