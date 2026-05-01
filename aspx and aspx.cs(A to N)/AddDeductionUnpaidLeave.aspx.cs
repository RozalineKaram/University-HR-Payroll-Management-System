using System;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace M3_team3
{
    public partial class AddDeductionUnpaidLeave : System.Web.UI.Page
    {
        protected void btn_unpaid(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                lblMessage.Text = "Please enter Employee ID";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            int empId = Convert.ToInt32(txtEmpID.Text);
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("Deduction_unpaid", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@employee_ID", empId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    lblMessage.Text = "Unpaid leave deduction processed successfully for Employee ID: " + empId;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    txtEmpID.Text = "";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApproveReject.aspx");
        }
    }
}