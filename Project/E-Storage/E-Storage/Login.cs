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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
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
            if (usernameErrLbl.Visible || passwordErrLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error");
            }
            else
            {
                if (Retrieval.getUserDetails(usernameTb.Text, passwordTb.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);

                }
            }
        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            if (usernameTb.Text == "")
            {
                usernameErrLbl.Visible = true;
            }
            else
            {
                usernameErrLbl.Visible = false;
            }
        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {
            if (passwordTb.Text == "")
            {
                passwordErrLbl.Visible = true;
            }
            else
            {
                passwordErrLbl.Visible = false;
            }
        }
    }
}
