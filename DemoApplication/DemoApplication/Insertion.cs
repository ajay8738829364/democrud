using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;
namespace InventoryManagementSystem
{
    class Insertion
    {
        public void insertUser(string name, string username, string pass, string phone, string maile)
        {
            try
            {
                 SqlCommand cmd = new SqlCommand("st_insertUser",mainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name",name);
                     cmd.Parameters.AddWithValue("@usrname",username);
                     cmd.Parameters.AddWithValue("@usrpassword",pass);
                     cmd.Parameters.AddWithValue("@usrphone",phone);
                     cmd.Parameters.AddWithValue("@usremail",maile);
                     mainClass.con.Open();
                     cmd.ExecuteNonQuery();
                     mainClass.con.Close();
                     mainClass.showMSG( "Added to the successfully..", "Success..", "success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
