using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace M3_team3
{
    public partial class ApproveCompensation : System.Web.UI.Page
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

                SqlCommand cmd = new SqlCommand("HR_approval_comp", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@request_ID", requestID));
                cmd.Parameters.Add(new SqlParameter("@HR_ID", hrID));

                conn.Open();
                cmd.ExecuteNonQuery();

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Compensation leave processed successfully!";
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