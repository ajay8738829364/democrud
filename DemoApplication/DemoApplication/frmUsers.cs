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
    public partial class frmUsers :frmSample2
    {
        Retrival r = new Retrival();
        int edit = 0;//this 0 is an indication for save operation and 1 is an indication for update operation
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            mainClass.disable(leftPanel);
            r.ShowUsers(userDataGrid, UserIdGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, statusGV);
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {
            mainClass.enable_reset(leftPanel);
        }

        public override void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "") { lblNameError.Visible = true; } else { lblNameError.Visible = false; }
            if (txtUserName.Text == "") { lblUserNameError.Visible = true; } else { lblUserNameError.Visible = false; }
            if (txtPassword.Text == "") { lblPassError.Visible = true; } else { lblPassError.Visible = false; }
            if (txtPhone.Text == "") { lblphoneError.Visible = true; } else { lblphoneError.Visible = false; }
            if (txtEmail.Text == "") { lblMailError.Visible = true; } else { lblMailError.Visible = false; }

            if (lblNameError.Visible || lblUserNameError.Visible || lblPassError.Visible || lblphoneError.Visible || lblMailError.Visible)
            {
                mainClass.showMSG("Fields with * are mandatory", "stop", "Error");// Error is the type of Message
            }
            else
            {
                if (edit == 0)//Code for save Operation
                {
                   
                    Insertion i = new Insertion();
                    i.insertUser(txtName.Text, txtUserName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text);
                    r.ShowUsers(userDataGrid, UserIdGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, statusGV);
                    mainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Code for Update Operation
                {
                    Updation ut = new Updation();
                    ut.updateUser(0, txtName.Text, txtUserName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text);
                    r.ShowUsers(userDataGrid, UserIdGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, statusGV);
              
                    mainClass.disable_reset(leftPanel);

                }
            }
        }

        public override void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
        }

      
    }
}
