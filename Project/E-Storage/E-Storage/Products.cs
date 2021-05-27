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
    public partial class Products : Sample2
    {
        int edit = 0;
        Int64 productID;
        public Products()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLbl.Text = "Products";
            r.getList("st_getCategoriesList", categoryCb, "Category", "ID");
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (productNameTb.Text == "")
            {
                productNameErrLbl.Visible = true;
            }
            else
            {
                productNameErrLbl.Visible = false;
            }
            if (barcodeTb.Text == "")
            {
                barcodeErrLbl.Visible = true;
            }
            else
            {
                barcodeErrLbl.Visible = false;
            }
            if (expiryDatePkr.Value < DateTime.Now)
            {
                expiryDateErrLbl.Visible = true;
                expiryDateErrLbl.Text = "Invalid Date";
            }
            else
            {
                expiryDateErrLbl.Visible = false;
            }
            if (expiryDatePkr.Value.Date == DateTime.Now.Date)
            {
                expiryDateErrLbl.Visible = false;
            }
            if (categoryCb.SelectedIndex == -1 || categoryCb.SelectedIndex == 0)
            {
                categoryErrLbl.Visible = true;
            }
            else
            {
                categoryErrLbl.Visible = false;
            }

            if (productNameErrLbl.Visible || barcodeErrLbl.Visible || expiryDateErrLbl.Visible || categoryErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    Insertion i = new Insertion();
                    if (expiryDatePkr.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(productNameTb.Text, barcodeTb.Text, Convert.ToInt32(categoryCb.SelectedValue), null);
                    }
                    else
                    {
                        i.insertProduct(productNameTb.Text, barcodeTb.Text, Convert.ToInt32(categoryCb.SelectedValue), expiryDatePkr.Value);
                    }
                    r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (expiryDatePkr.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(productID, productNameTb.Text, barcodeTb.Text, Convert.ToInt32(categoryCb.SelectedValue), null);
                        }
                        else
                        {
                            u.updateProduct(productID, productNameTb.Text, barcodeTb.Text, Convert.ToInt32(categoryCb.SelectedValue), expiryDatePkr.Value);
                        }
                        r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(productID, "st_deleteProduct", "@id");
                    r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV);
        }

        public override void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (searchTb.Text != "")
            {
                r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV, searchTb.Text);
            }
            else
            {
                r.showProducts(dataGridView1, productIDGV, productGV, barcodeGV, expiryDateGV, categoryGV, categoryIDGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["productIDGV"].Value.ToString());
                productNameTb.Text = row.Cells["productGV"].Value.ToString();
                barcodeTb.Text = row.Cells["barcodeGV"].Value.ToString();
                if (row.Cells["expiryDateGV"].FormattedValue.ToString() == "")
                {
                    expiryDatePkr.Value = DateTime.Now;
                }
                else
                {
                    expiryDatePkr.Value = Convert.ToDateTime(row.Cells["expiryDateGV"].Value.ToString());
                }
                categoryCb.SelectedValue = row.Cells["categoryIDGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
