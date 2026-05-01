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
    public partial class compensation_leave_submission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void comp_subm_Button1_Click(object sender, EventArgs e)
        {
            // Hide the message label initially
            lblMessage.Visible = false;

            if (Session["AcademicID"] == null)
            {
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string comp_date1 = comp_subm_comp_date.Text;
            string date_of_og_workday1 = comp_subm_dateofogwday.Text;
            string reason = comp_subm_reason.Text;
            int replacement_ID;

            if (!int.TryParse(comp_subm_rep_id.Text, out replacement_ID) || replacement_ID <= 0)
            {
                lblMessage.Text = "Please enter a valid replacement ID.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(reason))
            {
                lblMessage.Text = "Please enter a reason.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            DateTime comp_date;
            if (string.IsNullOrWhiteSpace(comp_date1) || !DateTime.TryParse(comp_date1, out comp_date))
            {
                lblMessage.Text = "Please enter a valid compensation date.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            DateTime date_of_og_workday;
            if (string.IsNullOrWhiteSpace(date_of_og_workday1) || !DateTime.TryParse(date_of_og_workday1, out date_of_og_workday))
            {
                lblMessage.Text = "Please enter a valid date of original workday.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            if (date_of_og_workday >= comp_date)
            {
                lblMessage.Text = "Cannot compensate an upcoming day. Choose a valid date.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            comp_date = comp_date.Date;
            date_of_og_workday = date_of_og_workday.Date;

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Submit_compensation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@compensation_date", comp_date);
                    cmd.Parameters.AddWithValue("@reason", reason);
                    cmd.Parameters.AddWithValue("@date_of_original_workday", date_of_og_workday);
                    cmd.Parameters.AddWithValue("@replacement_emp", replacement_ID);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Submission done successfully!";
                    lblMessage.CssClass = "success-message";
                    lblMessage.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
            }
        }
    }
}
