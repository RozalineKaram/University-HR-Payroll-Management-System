using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace M3_team3
{
    public partial class accidental_leave_submission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // hide message on initial load
        }

        protected void acc_submission_Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;

            if (Session["AcademicID"] == null)
            {
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.CssClass = "error-message";
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string start_date1 = acc_submission_TextBox1.Text;
            string end_date1 = acc_submission_TextBox2.Text;

            DateTime start_date, end_date;

            if (string.IsNullOrWhiteSpace(start_date1))
            {
                lblMessage.Text = "Please enter a start date.";
                lblMessage.CssClass = "error-message";
                return;
            }
            if (!DateTime.TryParse(start_date1, out start_date))
            {
                lblMessage.Text = "Please enter a valid start date format.";
                lblMessage.CssClass = "error-message";
                return;
            }

            if (string.IsNullOrWhiteSpace(end_date1))
            {
                lblMessage.Text = "Please enter an end date.";
                lblMessage.CssClass = "error-message";
                return;
            }
            if (!DateTime.TryParse(end_date1, out end_date))
            {
                lblMessage.Text = "Please enter a valid end date format.";
                lblMessage.CssClass = "error-message";
                return;
            }

            if (start_date > end_date)
            {
                lblMessage.Text = "Start date must be earlier than or equal to the end date.";
                lblMessage.CssClass = "error-message";
                return;
            }

            start_date = start_date.Date;
            end_date = end_date.Date;

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Submit_accidental", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@start_date", start_date);
                    cmd.Parameters.AddWithValue("@end_date", end_date);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Submission done successfully!";
                    lblMessage.CssClass = "success-message";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: " + ex.Message;
                lblMessage.CssClass = "error-message";
            }
        }
    }
}
