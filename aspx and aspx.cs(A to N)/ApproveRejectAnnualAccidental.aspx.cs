using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace M3_team3
{
    public partial class ApproveAnnualAccidental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                int requestID = int.Parse(txtRequestID.Text);
                int hrID = Convert.ToInt32(Session["HREmployeeID"]);

                SqlCommand cmd = new SqlCommand("HR_approval_an_acc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@request_ID", requestID));
                cmd.Parameters.Add(new SqlParameter("@HR_ID", hrID));

                conn.Open();
                cmd.ExecuteNonQuery();

                // Check the final status after processing
                SqlCommand checkCmd = new SqlCommand("SELECT final_approval_status FROM Leave WHERE request_ID = @request_ID", conn);
                checkCmd.Parameters.Add(new SqlParameter("@request_ID", requestID));
                string status = checkCmd.ExecuteScalar()?.ToString();

                if (status == "Approved")
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Leave request " + requestID + " has been APPROVED!";
                }
                else if (status == "Rejected")
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Leave request " + requestID + " has been REJECTED (insufficient balance or invalid conditions)!";
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Orange;
                    lblMessage.Text = "Leave request " + requestID + " is still PENDING.";
                }

                txtRequestID.Text = "";
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