using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class ProductPrice : Sample2
    {
        Retrieval r = new Retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public ProductPrice()
        {
            InitializeComponent();
            base.addBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            base.viewBtn.Enabled = false;
            base.searchTb.Enabled = false;
            r.getList("st_getCategoriesList", categoryCb, "Category", "ID");
        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Product Price";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void categoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCb.SelectedIndex != -1 && categoryCb.SelectedIndex != 0)
            {
                r.showProductsWRTCategory(Convert.ToInt32(categoryCb.SelectedValue.ToString()), dataGridView1, productIDGV, productGV, buyingPriceGV, finalPriceGV, discountGV, profitMarginGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;
                    float discountPer;
                    float finalSellingPrice = buyingPrice + amountToIncrease;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    row.Cells["finalPriceGV"].Value = finalSellingPrice - discountPer;
                }
                else
                {
                    row.Cells["finalPriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                dataGridView1.BeginEdit(true);
            }
        }
        Updation u = new Updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            int che = 0;
            if (categoryCb.SelectedIndex != -1 && categoryCb.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        che++;
                        Int64 pID;
                        float disc, pm, bp, sp;
                        pID = Convert.ToInt32(row.Cells["productIDGV"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                        sp = Convert.ToSingle(row.Cells["finalPriceGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalPriceGV"].Value.ToString());
                        }
                        u.updateProductPrice(pID, bp, sp, disc, pm);
                    }
                }
                if (che > 0)
                {
                    MainClass.ShowMSG("Product Pricing updated succcessfully...", "Success", "Success");
                    che = 0;
                }
                else
                {
                    MainClass.ShowMSG("Please select any product first...", "Error", "Error");
                    che = 0;
                }
            }
        }
    }
}
