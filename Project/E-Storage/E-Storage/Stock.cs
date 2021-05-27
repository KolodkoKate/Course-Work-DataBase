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
    public partial class Stock : Sample2
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Stock";
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
        }

        public override void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (searchTb.Text != "")
            {
                r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, buyingPriceGV, sellingPriceGV, categoryGV, quantityGV, statusGV, totalAmountGV, searchTb.Text);
            }
            else
            {
                r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, buyingPriceGV, sellingPriceGV, categoryGV, quantityGV, statusGV, totalAmountGV);
            }
        }
        Retrieval r = new Retrieval();
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, buyingPriceGV, sellingPriceGV, categoryGV, quantityGV, statusGV, totalAmountGV);
        }
    }
}
