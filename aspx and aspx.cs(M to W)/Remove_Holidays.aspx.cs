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
    public partial class Remove_attendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_remove(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(
                        "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Holiday') EXEC Create_Holiday",
                        conn
                    );
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("EXEC Remove_Holiday", conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                lblMessage.Text = $"Success: {rowsAffected} attendance records removed from holidays.";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
        }

       
    }
}