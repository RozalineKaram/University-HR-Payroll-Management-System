using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class Remove_Approved_Leaves : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ID_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_submit(object sender, EventArgs e)

        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            if (!int.TryParse(ID.Text, out int id))
            {
                lblMessage.Text = "Please enter a valid Employee ID.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("Remove_Approved_Leaves", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_ID", id);  

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        lblMessage.Text = $"Success: {rows} attendance  record(s) removed for approved leaves for Employee ID {id}.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = $"No attandance records for approved leaves found to remove for Employee ID {id} .";
                        lblMessage.ForeColor = System.Drawing.Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }


        }
    
        

 
    }
}