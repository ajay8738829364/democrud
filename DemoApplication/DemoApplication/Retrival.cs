using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem
{
    class Retrival
    {
        public   void ShowUsers(DataGridView gv, DataGridViewColumn useridgv, DataGridViewColumn namegv, DataGridViewColumn usernamegv, DataGridViewColumn passwordgv, DataGridViewColumn phonegv, DataGridViewColumn emailgv, DataGridViewColumn statusgv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDate", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
               
                sda.Fill(dt);
                useridgv.DataPropertyName = dt.Columns["ID"].ToString();
                namegv.DataPropertyName = dt.Columns["Name"].ToString();
                usernamegv.DataPropertyName = dt.Columns["UserName"].ToString();
                passwordgv.DataPropertyName = dt.Columns["Password"].ToString();
                phonegv.DataPropertyName = dt.Columns["PhoneNo"].ToString();
                emailgv.DataPropertyName = dt.Columns["E-maile"].ToString();
                statusgv.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                mainClass.showMSG(ex.Message, "Error...", "Error");
                
            }
        }
    }
}
