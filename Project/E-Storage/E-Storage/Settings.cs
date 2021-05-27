using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Storage
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCb.Checked)
            {
                if (serverTb.Text != "" && databaseTb.Text != "")
                {
                    s = "Data Source=" + serverTb.Text + ";Initial Catalog=" + databaseTb.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\Connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                if (serverTb.Text != "" && databaseTb.Text != "" && userIDTb.Text != "" && passwordTb.Text != "")
                {
                    s = "Data Source=" + serverTb.Text + ";Initial Catalog=" + databaseTb.Text + ";User ID=" + userIDTb.Text+";Password=" + passwordTb.Text + ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\Connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Succesfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
        }

        private void isCb_CheckedChanged(object sender, EventArgs e)
        {
            if (isCb.Checked)
            {
                userIDTb.Enabled = false;
                passwordTb.Enabled = false;
                userIDTb.Text = "";
                passwordTb.Text = "";
            }
            else
            {
                userIDTb.Enabled = true;
                passwordTb.Enabled = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            userLbl.Text = "Settings";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login s = new Login();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }
    }
}