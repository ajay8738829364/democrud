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
    public partial class frmSample2 : Sample
    {
        public frmSample2()
        {
            InitializeComponent();
        }

        private void frmSample2_Load(object sender, EventArgs e)
        {

        }

       

        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnDel_Click(object sender, EventArgs e)
        {

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
         frmHomeScreen hms = new frmHomeScreen();
            mainClass.showWindow(hms, this, mdi.ActiveForm);
        }
    }
}
