using System;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class Academic_performance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // Hide message initially
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = false; // Reset message on each click

            if (Session["AcademicID"] == null)
            {
                lblMessage.Text = "Session expired. Please login again.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            string semester = semester_performance.Text.Trim();

            if (string.IsNullOrEmpty(semester))
            {
                lblMessage.Text = "Please enter/select a semester.";
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
                return;
            }

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM dbo.MyPerformance(@employee_ID, @period)", conn);

                cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                cmd.Parameters.AddWithValue("@period", semester);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    lblMessage.Visible = false; // Hide message if data is found
                }
                else
                {
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    lblMessage.Text = "No performance records found for the selected semester.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                }
            }
        }
    }
}
