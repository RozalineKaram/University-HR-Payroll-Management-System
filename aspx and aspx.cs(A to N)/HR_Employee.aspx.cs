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
    public partial class HR_Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        protected void LoginButton(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int id = int.Parse(HREmpID.Text);
            String pass = HREmpPass.Text;

            SqlCommand cmd = new SqlCommand("SELECT dbo.HRLoginValidation(@employee_ID, @password)", conn);
            cmd.Parameters.Add(new SqlParameter("@employee_ID", id));
            cmd.Parameters.Add(new SqlParameter("@password", pass));

            conn.Open();
            object result = cmd.ExecuteScalar();


            if (result != null && Convert.ToBoolean(result))
            {
                Response.Redirect("ApproveReject.aspx");
            }
            else
            {
                Response.Write("Invalid Admin ID or Password");
            }

                conn.Close();
        }
        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("main_login.aspx");
        }
    }
}