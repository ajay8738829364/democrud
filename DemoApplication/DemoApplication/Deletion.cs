using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem
{
    class Deletion
    {
        public void delete(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.showMSG("Data deleted to the successfully..", "Success..", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.showMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
