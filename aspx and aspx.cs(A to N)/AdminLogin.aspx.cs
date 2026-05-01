using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void LogIn(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            String adminID = "admin";        // hard-coded ID
            String adminPass = "123";        // hard-coded password

            Session["AdminLoggedIn"] = adminID;

            String enteredID = TextBox1.Text;
            String enteredPass = TextBox2.Text;
            if (enteredID == adminID && enteredPass == adminPass)
            {
                Response.Write("Log in was successful");
                Response.Redirect("AdminHome.aspx");
            }
            else
            {
                // Show an error
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
