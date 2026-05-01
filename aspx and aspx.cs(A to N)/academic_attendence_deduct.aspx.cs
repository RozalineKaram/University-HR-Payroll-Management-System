using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace M3_team3
{
    public partial class academic_attendence_deduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optionally hide the message on initial load
            lblMessage.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Hide the message at the start
            lblMessage.Visible = false;

            if (Session["AcademicID"] == null)
            {
                lblMessage.CssClass = "error-message";
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.Visible = true;
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string month = attendance_deduct_month.Text.Trim();

            if (string.IsNullOrEmpty(month))
            {
                lblMessage.CssClass = "error-message";
                lblMessage.Text = "Please enter/select a month.";
                lblMessage.Visible = true;
                return;
            }

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM dbo.Deductions_Attendance(@employee_ID, @month)", conn);

                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@month", month);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        attendance_deduct_GridView.DataSource = dr;
                        attendance_deduct_GridView.DataBind();
                        lblMessage.Visible = false; // Hide message if data is found
                    }
                    else
                    {
                        attendance_deduct_GridView.DataSource = null;
                        attendance_deduct_GridView.DataBind();
                        lblMessage.CssClass = "error-message";
                        lblMessage.Text = "No deductions found for the selected month.";
                        lblMessage.Visible = true;
                    }
                }
            
           
        }
    }
}
