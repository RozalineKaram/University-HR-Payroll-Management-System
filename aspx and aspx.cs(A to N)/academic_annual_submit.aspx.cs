using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace M3_team3
{
    public partial class academic_annual_submit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // hide message on page load
        }

        protected void academic_Submit_annual_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["AcademicID"] == null)
                {
                    ShowMessage("Session expired. Please login again.", false);
                    return;
                }

                int employeeID = int.Parse(Session["AcademicID"].ToString());
                string replacement_IDs = academic_submit_annual_replacement.Text.Trim();
                string start_date1 = academic_submit_annual_Start_date.Text.Trim();
                string end_date1 = academic_submit_annual_end_date.Text.Trim();

                // Input validations
                if (string.IsNullOrEmpty(replacement_IDs))
                {
                    ShowMessage("Please enter a replacement ID.", false);
                    return;
                }
                if (string.IsNullOrWhiteSpace(start_date1))
                {
                    ShowMessage("Please enter a start date.", false);
                    return;
                }
                if (string.IsNullOrWhiteSpace(end_date1))
                {
                    ShowMessage("Please enter an end date.", false);
                    return;
                }

                if (!DateTime.TryParse(start_date1, out DateTime start_date))
                {
                    ShowMessage("Please enter a valid start date format.", false);
                    return;
                }
                if (!DateTime.TryParse(end_date1, out DateTime end_date))
                {
                    ShowMessage("Please enter a valid end date format.", false);
                    return;
                }

                start_date = start_date.Date;
                end_date = end_date.Date;

                if (!int.TryParse(replacement_IDs, out int replacement_ID))
                {
                    ShowMessage("Replacement ID must be a valid number.", false);
                    return;
                }

                // Database insertion
                string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Submit_annual", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@replacement_emp", replacement_ID);
                    cmd.Parameters.AddWithValue("@start_date", start_date);
                    cmd.Parameters.AddWithValue("@end_date", end_date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                ShowMessage("Submission done successfully!", true);
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, false);
            }
        }

        // Helper method to show messages
        private void ShowMessage(string message, bool success)
        {
            lblMessage.Text = message;
            lblMessage.CssClass = success ? "success-message" : "error-message";
            lblMessage.Visible = true;
        }

        // Helper method to clear form inputs after successful submission
        private void ClearForm()
        {
            academic_submit_annual_replacement.Text = "";
            academic_submit_annual_Start_date.Text = "";
            academic_submit_annual_end_date.Text = "";
        }
    }
}
