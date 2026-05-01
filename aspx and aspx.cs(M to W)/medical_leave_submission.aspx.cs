using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace M3_team3
{
    public partial class medical_leave_submission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void med_sub_Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // hide message initially

            if (Session["AcademicID"] == null)
            {
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string start_date1 = med_sub_Start_date.Text;
            string end_date1 = med_sub_End_date.Text;
            string medical_type = Medical_type_RadioButtonList.SelectedValue;
            string insurance_status = Insurance_status_RadioButtonList.SelectedValue;
            string disability_details = med_sub_disability_details.Text;
            string document_description = med_sub_document_description.Text;
            string file_name = med_sub_file_name.Text;

            // Validations
            if (string.IsNullOrWhiteSpace(medical_type))
            {
                ShowError("Please select the medical type.");
                return;
            }
            if (string.IsNullOrWhiteSpace(insurance_status))
            {
                ShowError("Please select the insurance status.");
                return;
            }
            if (string.IsNullOrWhiteSpace(disability_details))
            {
                ShowError("Please enter the disability details.");
                return;
            }
            if (string.IsNullOrWhiteSpace(document_description))
            {
                ShowError("Please enter the document description.");
                return;
            }
            if (string.IsNullOrWhiteSpace(file_name))
            {
                ShowError("Please enter the file name.");
                return;
            }

            DateTime start_date;
            if (!DateTime.TryParse(start_date1, out start_date))
            {
                ShowError("Please enter a valid start date.");
                return;
            }

            DateTime end_date;
            if (!DateTime.TryParse(end_date1, out end_date))
            {
                ShowError("Please enter a valid end date.");
                return;
            }

            if (start_date > end_date)
            {
                ShowError("Start date must be earlier than or equal to the end date.");
                return;
            }

            start_date = start_date.Date;
            end_date = end_date.Date;

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Submit_medical", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@start_date", start_date);
                    cmd.Parameters.AddWithValue("@end_date", end_date);
                    cmd.Parameters.AddWithValue("@medical_type", medical_type);
                    cmd.Parameters.AddWithValue("@insurance_status", insurance_status);
                    cmd.Parameters.AddWithValue("@disability_details", disability_details);
                    cmd.Parameters.AddWithValue("@document_description", document_description);
                    cmd.Parameters.AddWithValue("@file_name", file_name);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                lblMessage.Text = "Submission done successfully!";
                lblMessage.CssClass = "success-message";
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                ShowError("An error occurred: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblMessage.Text = message;
            lblMessage.CssClass = "error-message";
            lblMessage.Visible = true;
        }
    }
}
