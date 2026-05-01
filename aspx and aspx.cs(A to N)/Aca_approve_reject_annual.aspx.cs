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
    public partial class Aca_approve_reject_annual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"select al.request_ID, al.replacement_emp from Annual_Leave al ";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                annuals_GridView1.DataSource = dt;
                annuals_GridView1.DataBind();
                conn.Close();
            }

        }
        protected void annual_GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["Selectedrequest"] = annuals_GridView1.SelectedRow.Cells[1].Text;

            ViewState["Selectedrep_emp"] = annuals_GridView1.SelectedRow.Cells[2].Text;

            lblMessage.Text = "You have selected request ID " + ViewState["Selectedrequest"];
            lblMessage.Visible = true;

        }
        protected void update_leave_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            try
            {
                if (Session["AcademicID"] == null)
                {
                    lblMessage.Text = "Session expired. Please login again.";
                    lblMessage.Visible = true;
                    return;
                }

                int employeeID = int.Parse(Session["AcademicID"].ToString());
                string requestids = ViewState["Selectedrequest"]?.ToString();
                string rep_empids = ViewState["Selectedrep_emp"]?.ToString();

                if (string.IsNullOrEmpty(requestids) || string.IsNullOrEmpty(rep_empids))
                {
                    lblMessage.Text = "Please select a request to update.";
                    lblMessage.Visible = true;
                    return;
                }

                int requestID = int.Parse(requestids);
                int rep_empid = int.Parse(rep_empids);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("Upperboard_approve_annual", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@request_ID", requestID);
                    cmd.Parameters.AddWithValue("@upperboard_ID", employeeID);
                    cmd.Parameters.AddWithValue("@replacement_ID", rep_empid);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    lblMessage.Text = "Request updated successfully!";
                    lblMessage.Visible = true;

                    conn.Close();
                }
            }
            catch (Exception)
            {
                lblMessage.Text = "An error occurred. Please try again.";
                lblMessage.Visible = true;
            }
        }



    }
}