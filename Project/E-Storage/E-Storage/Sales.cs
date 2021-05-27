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
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
            base.editBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.deleteBtn.Enabled = false;
            base.searchTb.Enabled = false;
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void Sales_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Sales";
            barcodeTb.Enabled = false;
            MainClass.disable_reset(groupBox2);
        }
        Retrieval r = new Retrieval();
        string[] prodARR = new string[6];
        float GROSS = 0;
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            SalesDetails vsi = new SalesDetails();
            MainClass.showWindow(vsi, this, MDI.ActiveForm);
        }
        bool productCheck;
        private void barcodeTb_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTb.Text != "")
            {
                grossTotalTb.Text = "";
                totalDiscountTb.Text = "";
                amountGivenTb.Text = "";
                changeToGiveTb.Text = "";
                int qCount = 0, sQuant = 0, nCount = 0;
                prodARR = r.getProductsWRTBarcode1(barcodeTb.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodARR[0] == row.Cells["productIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt64(prodARR[0])));
                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), Math.Round(Convert.ToSingle(prodARR[4]),2), Convert.ToSingle(prodARR[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["productIDGV"].Value.ToString() == prodARR[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                            }
                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["productIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["discountGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(prodARR[4]) * Convert.ToSingle(row.Cells["quantityGV"].Value.ToString());
                                        row.Cells["discountGV"].Value = Math.Round(disc,2);
                                    }
                                    float tot = Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                    row.Cells["totalAmountGV"].Value = tot;
                                }
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), Math.Round(Convert.ToSingle(prodARR[4]),2), Convert.ToSingle(prodARR[3]));
                        }
                    }
                }
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    GROSS += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                }
                gtotLbl.Text = Math.Round(GROSS, 2).ToString();
                GROSS = 0;
                barcodeTb.Focus();
                barcodeTb.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                grossTotalTb.Text = "";
                totalDiscountTb.Text = "";
                amountGivenTb.Text = "";
                changeToGiveTb.Text = "";
                float gt, dis, tot;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int q = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                if (q == 1)
                {
                    gt = Convert.ToSingle(gtotLbl.Text);
                    gt = gt - Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                    gtotLbl.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
                else if (q > 1)
                {
                    q--;
                    row.Cells["quantityGV"].Value = q;
                    dis = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                    row.Cells["discountGV"].Value = dis;
                    tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perUnitPriceGV"].Value.ToString());
                    row.Cells["totalAmountGV"].Value = tot;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(item.Cells["totalAmountGV"].Value.ToString());
                    }
                    gtotLbl.Text = GROSS.ToString();
                    GROSS = 0;
                }
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double dis = 0, gross = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Math.Round(Convert.ToSingle(row.Cells["discountGV"].Value.ToString()), 0);
                    gross += Convert.ToSingle(row.Cells["totalAmountGV"].Value.ToString());
                }
                grossTotalTb.Text = Math.Round(gross, 2).ToString();
                totalDiscountTb.Text = dis.ToString();
            }
        }

        private void amountGivenTb_TextChanged(object sender, EventArgs e)
        {
            if (amountGivenTb.Text != "")
            {
                if (!rg.Match(amountGivenTb.Text).Success)
                {
                    amountGivenTb.Text = "";
                    amountGivenTb.Focus();
                }
            }
            else
            {
                changeToGiveTb.Text = "";
            }
        }

        private void amountGivenTb_Validating(object sender, CancelEventArgs e)
        {
            if (amountGivenTb.Text != "" && grossTotalTb.Text != "")
            {
                if (!(Convert.ToSingle(grossTotalTb.Text) <= Convert.ToSingle(amountGivenTb.Text)))
                {
                    amountGivenTb.Text = "";
                    changeToGiveTb.Text = "";
                    amountGivenTb.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountGivenTb.Text);
                    float amountToReturn = amountGiven - Convert.ToSingle(grossTotalTb.Text);
                    changeToGiveTb.Text = Math.Round(amountToReturn, 2).ToString();
                }
            }
        }
        Insertion i = new Insertion();
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (amountGivenTb.Text != "" && totalDiscountTb.Text != "" && grossTotalTb.Text != "" && paymentTypeCb.SelectedIndex != -1 && changeToGiveTb.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount: " + grossTotalTb.Text + "\n\tTotal Discount: " + totalDiscountTb.Text + "\n\tAmount Given: " + amountGivenTb.Text + "\n\tAmount Returned: " + changeToGiveTb.Text + "\n\nAre you sure, submit current sales?\n", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                { 
                    i.insertSales(dataGridView1, "productIDGV", "quantityGV", "perUnitPriceGV", "discountGV", Retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTotalTb.Text), Convert.ToSingle(totalDiscountTb.Text), Convert.ToSingle(amountGivenTb.Text), Convert.ToSingle(changeToGiveTb.Text), paymentTypeCb.SelectedItem.ToString());
                    barcodeTb.Enabled = false;
                    MainClass.disable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    gtotLbl.Text = "0.00";
                    SalesReport sr = new SalesReport();
                    sr.Show();
                }
            }
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            barcodeTb.Enabled = true;
            MainClass.enable_reset(groupBox2);
            grossTotalTb.Enabled = false;
            totalDiscountTb.Enabled = false;
            changeToGiveTb.Enabled = false;
        }
    }
}
