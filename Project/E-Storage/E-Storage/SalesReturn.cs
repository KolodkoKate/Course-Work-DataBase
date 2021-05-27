using System;
using System.Collections;
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
    public partial class SalesReturn : Sample2
    {
        public SalesReturn()
        {
            InitializeComponent();
            base.editBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            base.viewBtn.Enabled = false;
            base.searchTb.Enabled = false;
            dateTimePkr.Enabled = false;
        }
        Retrieval r = new Retrieval();
        Regex rg = new Regex("^[0-9]+$");
        private void loadBtn_Click(object sender, EventArgs e)
        {
            barcodeTb.Focus();
            if (saleIDTb.Text != "")
            {
                if (rg.Match(saleIDTb.Text).Success)
                {
                    r.showSalesDataViaID(Convert.ToInt64(saleIDTb.Text), dataGridView1, saleIDGV, barcodeGV, productGV, quantityGV, productPriceGV, productDiscountGV, totalPerProductDiscountGV, perProductTotalGV, totalDiscountGV, totalAmountGV, amountGivenGV, amountReturnedGV, dateGV, userGV, payTypeGV, productIDGV);
                    if (dataGridView1.RowCount > 0)
                    {
                        dateTimePkr.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        userTb.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
                        paymentTypeTb.Text = dataGridView1.Rows[0].Cells["payTypeGV"].Value.ToString();
                    }
                }
                else
                {
                    saleIDTb.Text = "";
                    saleIDTb.Focus();
                    dateTimePkr.Value = DateTime.Now;
                    userTb.Text = "";
                    paymentTypeTb.Text = "";
                }
            }
            else
            {
                dateTimePkr.Value = DateTime.Now;
                userTb.Text = "";
                paymentTypeTb.Text = "";
            }
        }
        Insertion i = new Insertion();
        Updation u = new Updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (amountToRefundTb.Text != "" && ht.Count > 0 && saleIDTb.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure, you wanted to procced?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += i.insertReturnRefund(Convert.ToInt64(saleIDTb.Text), DateTime.Now, Retrieval.USER_ID, Convert.ToInt64(de.Key), Convert.ToInt16(de.Key), Convert.ToSingle(de.Key));
                            int currentQuantity = (int)r.getProductQuantity(Convert.ToInt64(de.Key));
                            int finalQuantity = currentQuantity - Convert.ToInt16(de.Value);
                            u.updateStock(Convert.ToInt64(de.Key), finalQuantity);
                        }
                        if (x > 0)
                        {
                            DialogResult drr = MainClass.ShowMSG("Return and Refund Successfull", "Success", "Success");
                            if (drr == DialogResult.OK)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    dataGridView1.Rows.Remove(row);
                                }
                                SalesReturnReport obj = new SalesReturnReport();
                                obj.ShowDialog();
                                MainClass.disable_reset(leftPanel);
                            }
                            x = 0;
                            ht.Clear();
                        }
                        sc.Complete();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("Please provide complete details", "Error", "Error");
            }
        }
        float amountRefund = 0;
        Hashtable ht = new Hashtable();
        private void SalesReturn_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Sales Return";
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            saleIDTb.Enabled = true;
            barcodeTb.Enabled = true;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (barcodeTb.Text != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (barcodeTb.Text == row.Cells["barcodeGV"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are you sure you want to return " + row.Cells["productGV"].Value.ToString() + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    Int64 productID = Convert.ToInt64(row.Cells["productIDGV"].Value.ToString());
                                    float productPrice = Convert.ToSingle(row.Cells["productPriceGV"].Value.ToString());
                                    int productQuantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) - 1;
                                    amountRefund += productPrice;
                                    amountToRefundTb.Text = Math.Round(amountRefund, 0).ToString();
                                    if (productQuantity == 0)
                                    {
                                        if (ht.ContainsKey(row.Cells["productIDGV"].Value))
                                        {
                                            Int64 productIDht = Convert.ToInt64(row.Cells["productIDGV"].Value.ToString());
                                            ht[productIDht] = Convert.ToInt32(ht[productIDht]) - 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["productIDGV"].Value, 1);
                                        }
                                        dataGridView1.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["quantityGV"].Value = productQuantity;
                                        row.Cells["perProductTotalGV"].Value = Convert.ToSingle(row.Cells["productPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                        if (ht.ContainsKey(row.Cells["productIDGV"].Value))
                                        {
                                            Int64 productIDht = Convert.ToInt64(row.Cells["productIDGV"].Value.ToString());
                                            ht[productIDht] = Convert.ToInt32(ht[productIDht]) + 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["productIDGV"].Value, 1);
                                        }
                                    }
                                    barcodeTb.Text = "";
                                    barcodeTb.Focus();
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
