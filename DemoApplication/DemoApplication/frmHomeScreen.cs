using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class frmHomeScreen : Sample
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void frmHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUsers u = new frmUsers();
            mainClass.showWindow(u, this, mdi.ActiveForm);
        }
    }
}
