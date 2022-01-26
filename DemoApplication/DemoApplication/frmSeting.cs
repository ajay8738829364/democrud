using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace InventoryManagementSystem
{
    public partial class frmSeting : Sample
    {
        public frmSeting()
        {
            InitializeComponent();
        }

        private void frmSeting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ItCB.Checked)
            {
                if (txtSever.Text != "" && txtDB.Text != "")
                {
                    s = "Data Source=" + txtSever.Text + ";Initial Catalog=" + txtDB.Text + ";Integrated Security=true";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        LoginForm lg = new LoginForm();
                        mainClass.showWindow(lg, this, mdi.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("fill all textbox");
                }

            }
            else{
                 if (txtSever.Text != "" && txtDB.Text != "" && txtUserId.Text!="" && txtPass.Text!="")
                {
                     s = "Data Source="+txtSever.Text+";Initial Catalog="+txtDB.Text+";User Id="+txtUserId.Text+";Password="+txtPass.Text;
                     File.WriteAllText(path + "\\connect", s);
                     DialogResult dr = MessageBox.Show("success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     if (dr == DialogResult.OK)
                     {
                         LoginForm lg = new LoginForm();
                         mainClass.showWindow(lg, this, mdi.ActiveForm);
                     }
                }
                 else
                 {
                     MessageBox.Show("fill all textbox");
                 }


            }
           
        }

        private void ItCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ItCB.Checked)
            {
                txtUserId.Enabled = false;
                txtPass.Enabled = false;
                txtUserId.Text = "";
                txtPass.Text = "";
            }
            else
            {
                txtUserId.Enabled = true;
                txtPass.Enabled = true;
            }
        }
    }
}
