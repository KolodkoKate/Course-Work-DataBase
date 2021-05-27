using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            Retrieval r = new Retrieval();
            if (SalesDetails.saleID == 0)
            {
                r.showSalesReport(reportViewer1, "st_getSalesReceipt", "@user", Retrieval.USER_ID);
            }
            else
            {
                r.showSalesReport(reportViewer1, "st_getSalesReceiptWRTSalesID", "@saleID", SalesDetails.saleID);
                SalesDetails.saleID = 0;
            }
        }
    }
}
