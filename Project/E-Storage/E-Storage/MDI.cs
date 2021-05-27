using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace E_Storage
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path + "\\Connect"))
            {
                Login log = new Login();
                MainClass.showWindow(log, this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.showWindow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login set = new Login();
            MainClass.showWindow(set, this);
        }
    }
}