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
    public partial class unpaid_leave_submission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void unpaid_sub_Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // hide message initially

            if (Session["AcademicID"] == null)
            {
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.Visible = true;
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string start_date1 = unpaid_sub_Start_date.Text;
            string end_date1 = unpaid_sub_End_date.Text;
            string document_description = unpaid_sub_document_description.Text;
            string file_name = unpaid_sub_file_name.Text;

            if (string.IsNullOrEmpty(document_description))
            {
                lblMessage.Text = "Please enter the document description.";
                lblMessage.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(file_name))
            {
                lblMessage.Text = "Please enter the file name.";
                lblMessage.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(start_date1))
            {
                lblMessage.Text = "Please enter a start date.";
                lblMessage.Visible = true;
                return;
            }

            DateTime start_date;
            if (!DateTime.TryParse(start_date1, out start_date))
            {
                lblMessage.Text = "Please enter a valid start date format.";
                lblMessage.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(end_date1))
            {
                lblMessage.Text = "Please enter an end date.";
                lblMessage.Visible = true;
                return;
            }

            DateTime end_date;
            if (!DateTime.TryParse(end_date1, out end_date))
            {
                lblMessage.Text = "Please enter a valid end date format.";
                lblMessage.Visible = true;
                return;
            }

            if (start_date > end_date)
            {
                lblMessage.Text = "Start date must be earlier than or equal to the end date.";
                lblMessage.Visible = true;
                return;
            }

            start_date = start_date.Date;
            end_date = end_date.Date;

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("Submit_unpaid", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                cmd.Parameters.AddWithValue("@start_date", start_date);
                cmd.Parameters.AddWithValue("@end_date", end_date);
                cmd.Parameters.AddWithValue("@document_description", document_description);
                cmd.Parameters.AddWithValue("@file_name", file_name);

                conn.Open();
                cmd.ExecuteNonQuery(); // execute the procedure
                conn.Close();

                lblMessage.Text = "Submission done successfully!";
                lblMessage.CssClass = "success-message"; // optional styling
                lblMessage.Visible = true;
            }
        }
    }
}
