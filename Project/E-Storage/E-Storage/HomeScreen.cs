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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
            MDI set = new MDI();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            Categories u = new Categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Products u = new Products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI m = new MDI();
            m.logoutToolStripMenuItem.Enabled = true;
            userLbl.Text = "Welcome, " + Retrieval.EMP_NAME + "!";
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            Suppliers u = new Suppliers();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void purchaseInvoiceBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stock u = new Stock();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPrice u = new ProductPrice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void salesReturnBtn_Click(object sender, EventArgs e)
        {
            SalesReturn s = new SalesReturn();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }
    }
}
