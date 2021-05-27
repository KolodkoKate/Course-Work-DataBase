using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class PurchaseInvoiceDetails : Sample
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void datePkr_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInvoiceCb, "Company", "ID", "@month", datePkr.Value.Month, "@year", datePkr.Value.Year);
        }

        public void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Purchase Invoice Details";
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseInvoiceCb, "Company", "ID", "@month", datePkr.Value.Month, "@year", datePkr.Value.Year);
        }

        private void purchaseInvoiceCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (purchaseInvoiceCb.SelectedIndex != -1 && purchaseInvoiceCb.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purchaseInvoiceCb.SelectedValue.ToString()), dataGridView1, mPIDGV, productIDGV, productGV, quantityGV, perUnitPriceGV, totalAmountGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                gtotLbl.Text = gt.ToString();
                gt = 0;
            }
        }
    }
}
