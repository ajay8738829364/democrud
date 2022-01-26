using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void mdi_Load(object sender, EventArgs e)
        {
           string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path+ "\\connect"))
            {
                LoginForm lg = new LoginForm();
                mainClass.showWindow(lg, this);
            }
            else{
                frmSeting stg= new frmSeting();
                mainClass.showWindow(stg, this);
            }
        }

        private void setingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeting st = new frmSeting();
            mainClass.showWindow(st, this);
        }
    }
}
