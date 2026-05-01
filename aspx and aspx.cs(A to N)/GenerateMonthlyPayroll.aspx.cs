using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace M3_team3
{
    public partial class GenerateMonthlyPayroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                int employeeID = int.Parse(txtEmployeeID.Text);
                DateTime fromDate = DateTime.Parse(txtFromDate.Text);
                DateTime toDate = DateTime.Parse(txtToDate.Text);

                SqlCommand cmd = new SqlCommand("Add_Payroll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@employee_ID", employeeID));
                cmd.Parameters.Add(new SqlParameter("@from", fromDate));
                cmd.Parameters.Add(new SqlParameter("@to", toDate));

                conn.Open();
                cmd.ExecuteNonQuery();

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Payroll generated successfully for Employee ID: " + employeeID;

                txtEmployeeID.Text = "";
                txtFromDate.Text = "";
                txtToDate.Text = "";
            }
            catch (FormatException)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: Please enter valid Employee ID and dates.";
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApproveReject.aspx");
        }
    }
}