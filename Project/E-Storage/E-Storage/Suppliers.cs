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
    public partial class Suppliers : Sample2
    {
        int edit = 0;
        int supplierID;
        short stat;
        public Suppliers()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLbl.Text = "Suppliers";
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
            if (companyTb.Text == "")
            {
                companyErrLbl.Visible = true;
            }
            else
            {
                companyErrLbl.Visible = false;
            }
            if (contactPersonTb.Text == "")
            {
                contactPersonErrLbl.Visible = true;
            }
            else
            {
                contactPersonErrLbl.Visible = false;
            }
            if (phoneTb.Text == "")
            {
                phoneErrLbl.Visible = true;
            }
            else
            {
                phoneErrLbl.Visible = false;
            }
            if (addressTb.Text == "")
            {
                addressErrLbl.Visible = true;
            }
            else
            {
                addressErrLbl.Visible = false;
            }
            if (statusCb.SelectedIndex == -1)
            {
                statusErrLbl.Visible = true;
            }
            else
            {
                statusErrLbl.Visible = false;
            }

            if (companyErrLbl.Visible || contactPersonErrLbl.Visible || phoneErrLbl.Visible || addressErrLbl.Visible || statusErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (statusCb.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusCb.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0)
                {
                    Insertion i = new Insertion();
                    i.insertSupplier(companyTb.Text, contactPersonTb.Text, phoneTb.Text, addressTb.Text, stat);
                    r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1)
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (statusCb.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusCb.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updateSupplier(supplierID, companyTb.Text, contactPersonTb.Text, phoneTb.Text, addressTb.Text, stat);
                        r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV);
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
                    d.delete(supplierID, "st_deleteSupplier", "@id");
                    r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV);
                }
            }
        }

        public override void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (searchTb.Text != "")
            {
                r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV, searchTb.Text);
            }
            else
            {
                r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, supplierIDGV, companyGV, contactPersonGV, phoneGV, addressGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["supplierIDGV"].Value.ToString());
                companyTb.Text = row.Cells["companyGV"].Value.ToString();
                contactPersonTb.Text = row.Cells["contactPersonGV"].Value.ToString();
                phoneTb.Text = row.Cells["phoneGV"].Value.ToString();
                addressTb.Text = row.Cells["addressGV"].Value.ToString();
                statusCb.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
