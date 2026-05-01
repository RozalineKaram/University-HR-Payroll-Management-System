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
    public partial class Academic_attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AcademicID"] == null)
            {
                Response.Write("Session expired. Please login again.");
                return;
            }

            int employeeID = int.Parse(Session["AcademicID"].ToString());
            
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {


                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM dbo.MyAttendance(@employee_ID)", conn);
                cmd.Parameters.AddWithValue("@employee_ID", employeeID);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Academic_attendance_gridview.DataSource = dr;
                Academic_attendance_gridview.DataBind();
            }
        }

    }
}