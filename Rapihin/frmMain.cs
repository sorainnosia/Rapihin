using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Rapihin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderManager manager = new FolderManager();
            int total = manager.Rapihin(AppDomain.CurrentDomain.BaseDirectory);
            if (total == 0)
            {
                MessageBox.Show("No file is moved from this process");
            }
            else
            {
                MessageBox.Show("Successfully move : " + total.ToString() + " files");
                Application.Exit();
            }
        }
    }
}
