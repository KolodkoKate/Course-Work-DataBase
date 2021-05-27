using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class Users : Sample2
    {
        int edit = 0;
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        Retrieval r = new Retrieval();
        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLbl.Text = "Users";
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
            if (nameTb.Text == "")
            {
                nameErrLbl.Visible = true;
            }
            else
            {
                nameErrLbl.Visible = false;
            }
            if (usernameTb.Text == "")
            {
                usernameErrLbl.Visible = true;
            }
            else
            {
                usernameErrLbl.Visible = false;
            }
            if (passwordTb.Text == "")
            {
                passwordErrLbl.Visible = true;
            }
            else
            {
                passwordErrLbl.Visible = false;
            }
            if (phoneTb.Text == "")
            {
                phoneErrLbl.Visible = true;
            }
            else
            {
                phoneErrLbl.Visible = false;
            }
            if (emailTb.Text == "")
            {
                emailErrLbl.Visible = true;
            }
            else
            {
                emailErrLbl.Visible = false;
            }
            if (statusCb.SelectedIndex == -1)
            {
                statusErrLbl.Visible = true;
            }
            else
            {
                statusErrLbl.Visible = false;
            }
           
            if (nameErrLbl.Visible || usernameErrLbl.Visible || passwordErrLbl.Visible || phoneErrLbl.Visible || emailErrLbl.Visible || statusErrLbl.Visible)
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
                    i.insertUser(nameTb.Text, usernameTb.Text, passwordTb.Text, phoneTb.Text, emailTb.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
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
                        u.updateUser(userID, nameTb.Text, usernameTb.Text, passwordTb.Text, phoneTb.Text, emailTb.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
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
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                }
            }
        }

        public override void searchTb_TextChanged(object sender, EventArgs e)
        {
            if (searchTb.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV, searchTb.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, nameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTb.Text = row.Cells["nameGV"].Value.ToString();
                usernameTb.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTb.Text = row.Cells["passwordGV"].Value.ToString();
                phoneTb.Text = row.Cells["phoneGV"].Value.ToString();
                emailTb.Text = row.Cells["emailGV"].Value.ToString();
                statusCb.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}