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
    public partial class Update_Employment_Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_submit(object sender, EventArgs e)
        {

            int empID;
            if (!int.TryParse(txtEmployeeID.Text, out empID))
            {
                lblMessage.Text = "Invalid Employee ID.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
              
                SqlCommand cmd = new SqlCommand("EXEC Update_Employment_Status @Employee_ID", conn);
                cmd.Parameters.AddWithValue("@Employee_ID", empID);
                

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        // Re-check current status
                        SqlCommand check = new SqlCommand("SELECT employment_status FROM Employee WHERE employee_id = @id", conn);
                        check.Parameters.AddWithValue("@id", empID);
                        string status = check.ExecuteScalar().ToString();

                        lblMessage.Text = $"Status updated successfully. Current status: <strong>{status}</strong>";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = $"Failed!";
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