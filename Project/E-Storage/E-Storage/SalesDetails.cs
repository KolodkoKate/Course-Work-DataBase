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
    public partial class SalesDetails : Sample
    {
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            Retrieval r = new Retrieval();
            r.showDailySales(dateTimePkr.Value, dataGridView1, saleIDGV, userGV, totalAmountGV, totalDiscountGV, amountGivenGV, amountReturnedGV, userIDGV);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["totalAmountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalAmountGV"].Value));
                row.Cells["totalDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalDiscountGV"].Value));
                row.Cells["amountGivenGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountGivenGV"].Value));
                row.Cells["amountReturnedGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amountReturnedGV"].Value));
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }
        public static int saleID = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                saleID = Convert.ToInt32(row.Cells["saleIDGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }

        private void ViewSalesInvoices_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Sales Details";
        }
    }
}
