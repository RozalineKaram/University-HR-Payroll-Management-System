using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace M3_team3
{
    public partial class dean_evaluation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int deanID = int.Parse(Session["AcademicID"].ToString());
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"select e.employee_id from employee e where e.dept_name = (select dept_name from employee where employee_id = @deanid ) and e.employee_id <> @deanid ";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@deanid", deanID);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                employees_GridView.DataSource = dt;
                employees_GridView.DataBind();
                conn.Close();
            }
        }
        protected void employees_GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Store the selected employee ID into ViewState
            ViewState["SelectedEmployee"] = employees_GridView.SelectedRow.Cells[1].Text;
        }

        protected void Eval_Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            try
            {
                if (Session["AcademicID"] == null)
                {
                    lblMessage.Text = "Session expired. Please login again.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }

                string ratings = Eval_Rating.Text;
                string comments = Eval_Comments.Text;
                string semester = Eval_Semester.Text;

                if (string.IsNullOrEmpty(ratings))
                {
                    lblMessage.Text = "Please enter a rating.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }
                if (string.IsNullOrWhiteSpace(comments))
                {
                    lblMessage.Text = "Please enter comment/s.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }
                if (string.IsNullOrWhiteSpace(semester))
                {
                    lblMessage.Text = "Please enter the semester.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }
                if (semester.Length != 3)
                {
                    lblMessage.Text = "Invalid semester format.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }

                if (ViewState["SelectedEmployee"] == null)
                {
                    lblMessage.Text = "Please select an employee to evaluate.";
                    lblMessage.CssClass = "error-message";
                    lblMessage.Visible = true;
                    return;
                }

                string employeeIDs = ViewState["SelectedEmployee"].ToString();
                int rating = int.Parse(ratings);
                int employeeID = int.Parse(employeeIDs);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Dean_andHR_Evaluation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@employee_ID", employeeID);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@comment", comments);
                    cmd.Parameters.AddWithValue("@semester", semester);

                    conn.Open();
                    cmd.ExecuteNonQuery(); // Make sure the procedure actually executes
                    conn.Close();
                }

                lblMessage.Text = "Evaluation finished successfully!";
                lblMessage.CssClass = "success-message";
                lblMessage.Visible = true;

                // Optionally clear the fields
                Eval_Rating.Text = "";
                Eval_Comments.Text = "";
                Eval_Semester.Text = "";
                ViewState["SelectedEmployee"] = null;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: " + ex.Message;
                lblMessage.CssClass = "error-message";
                lblMessage.Visible = true;
            }
        }

    }
}