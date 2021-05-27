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
    public partial class SalesReturnReport : Form
    {
        public SalesReturnReport()
        {
            InitializeComponent();
        }

        private void SalesReturnReport_Load(object sender, EventArgs e)
        {
            Retrieval r = new Retrieval();
            r.showSalesReturnReport(reportViewer1, "st_getSalesReceipt", "@user", Retrieval.USER_ID);
        }
    }
}
