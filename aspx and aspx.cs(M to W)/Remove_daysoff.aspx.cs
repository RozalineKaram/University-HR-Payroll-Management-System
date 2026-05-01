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
    public partial class Remove_daysoff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Btn_submit(object sender, EventArgs e)
        {
            /*String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = Int16.Parse(ID.Text);

            SqlCommand cmd = new SqlCommand(" Remove_DayOff",conn);
            cmd.Parameters.Add(new SqlParameter("@employee_ID", id));
            cmd.CommandType = CommandType.StoredProcedure;



            conn.Open();
            int rows=cmd.ExecuteNonQuery();
            lblMessage.Text = $"Success: {rows} unattended day-off records removed for Employee ID {id}.";
            lblMessage.ForeColor = System.Drawing.Color.Green;
            conn.Close();*/
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            // Validate input first
            if (!int.TryParse(ID.Text, out int id))
            {
                lblMessage.Text = "Please enter a valid Employee ID.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("Remove_DayOff", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_ID", id);  // Cleaner than new SqlParameter

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        lblMessage.Text = $"Success: {rows} unattended day-off record(s) removed for Employee ID {id}.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = $"No day-off attendance records found to remove for Employee ID {id} (maybe none existed or not their official day off).";
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