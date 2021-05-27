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
    public partial class Categories : Sample2
    {
        int edit = 0;
        int categoryID;
        short stat;
        Retrieval r = new Retrieval();
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
            userLbl.Text = "Categories";
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
            if (categoryNameTb.Text == "")
            {
                categoryNameErrLbl.Visible = true;
            }
            else
            {
                categoryNameErrLbl.Visible = false;
            }
            
            if (statusCb.SelectedIndex == -1)
            {
                statusErrLbl.Visible = true;
            }
            else
            {
                statusErrLbl.Visible = false;
            }

            if (categoryNameErrLbl.Visible || statusErrLbl.Visible)
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
                    i.insertCategory(categoryNameTb.Text, stat);
                    r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV);
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
                        u.updateCategory(categoryID, categoryNameTb.Text, stat);
                        r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV);
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
                    d.delete(categoryID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV);
                }
            }
        }

        public override void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (searchTb.Text != "")
            {
                r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV, searchTb.Text);
            }
            else
            {
                r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, categoryIDGV, categoryGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                categoryID = Convert.ToInt32(row.Cells["categoryIDGV"].Value.ToString());
                categoryNameTb.Text = row.Cells["categoryGV"].Value.ToString();
                statusCb.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
