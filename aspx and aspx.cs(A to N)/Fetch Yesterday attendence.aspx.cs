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
    public partial class Fetch_Yesterday_attendence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM allEmployeeAttendance", conn);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
                conn.Close();

            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}