using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
            base.editBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            base.searchTb.Enabled = false;
        }
        Retrieval r = new Retrieval();
        int productID;
        float gt, tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
        }
        int co;
        Updation u = new Updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                Insertion i = new Insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, Retrieval.USER_ID, Convert.ToInt32(supplierCb.SelectedValue));
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString()));
                        object[] arr = r.cheackProductPriceExistance(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                        if (arr[3] != null)
                        {
                            float discountPercentage = Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToSingle(arr[3].ToString())/100;
                            float profitPercentage = Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToSingle(arr[4].ToString()) / 100;
                            float totalAmount = Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) + profitPercentage - discountPercentage;
                            u.updateProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()));
                        }
                        else
                        { 
                            i.insertProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()));
                        }
                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        } 
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice Created Successfully.", "Success", "Success");
                        MainClass.disable_reset(leftPanel);
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create purchase invoice.", "Error", "Error");
                    }
                    dataGridView1.Rows.Clear();
                    gtotLbl.Text = "0.00";
                    sc.Complete();
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLbl.Text = "Purchase Invoice";
            r.getList("st_getSuppliersList", supplierCb, "Company", "ID");
        }
        string[] prodARR = new string[4];
        private void quantityTb_TextChanged(object sender, EventArgs e)
        {
            if (quantityTb.Text != "")
            {
                if (rg.Match(quantityTb.Text).Success)
                {
                    float quantity, price, total;
                    quantity = Convert.ToSingle(quantityTb.Text);
                    price = Convert.ToSingle(perUnitPriceTb.Text);
                    total = quantity * price;
                    totalLbl.Text = total.ToString("############.##");
                }
                else
                {
                    quantityTb.SelectAll();
                }
            }
            else
            {
                totalLbl.Text = "0.00";
            }
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if (supplierCb.SelectedIndex == -1)
            {
                supplierErrLbl.Visible = true;
            }
            else
            {
                supplierErrLbl.Visible = false;
            }
            if (quantityTb.Text == "")
            {
                quantityErrLbl.Visible = true;
            }
            else
            {
                quantityErrLbl.Visible = false;
            }
            if (barcodeTb.Text == "")
            {
                barcodeErrLbl.Visible = true;
            }
            else
            {
                barcodeErrLbl.Visible = false;
            }
            if (supplierErrLbl.Visible || quantityErrLbl.Visible || barcodeErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTb.Text, quantityTb.Text, perUnitPriceTb.Text, totalLbl.Text);
                gt += Convert.ToSingle(totalLbl.Text);
                gtotLbl.Text = gt.ToString();
                productID = 0;
                productTb.Text = "";
                perUnitPriceTb.Text = "";
                barcodeTb.Text = "";
                totalLbl.Text = "0.00";
                quantityTb.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                    gtotLbl.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
                MainClass.disable(leftPanel);
            }
        }

        private void barcodeTb_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTb.Text != "")
            {
                prodARR = r.getProductsWRTBarcode(barcodeTb.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTb.Text = prodARR[1];
                string barco = prodARR[2];
                prodARR = r.getProductsWRTBarcode1(barcodeTb.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTb.Text = prodARR[1];
                string barcode = prodARR[2];
                productTb.Enabled = false;
                if (barcode != null)
                {
                    perUnitPriceTb.Focus();
                }
            }
            else
            {
                productID = 0;
                productTb.Text = "";
                perUnitPriceTb.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void perUnitPriceTb_TextChanged(object sender, EventArgs e)
        {
            if (perUnitPriceTb.Text != "")
            {
                if (!rg.Match(perUnitPriceTb.Text).Success)
                {
                    perUnitPriceTb.Text = "";
                }
            }
        }
    }
}
