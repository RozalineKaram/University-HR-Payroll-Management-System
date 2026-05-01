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
    public partial class InitiateAttendence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("Initiate_Attendance", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int rowsAffected = cmd.ExecuteNonQuery();

                Response.Write ($"Success: Attendance records initiated for {rowsAffected} employees.");
            }
            conn.Close();
        }
       
    }
}