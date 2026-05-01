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
    public partial class DepartmentEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM NoEmployeeDept", conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridView1DE.DataSource = dt;
                GridView1DE.DataBind();
                conn.Close();
            }
        }
        
    }
}