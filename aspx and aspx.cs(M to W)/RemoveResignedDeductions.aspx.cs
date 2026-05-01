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
    public partial class RemoveResignedDeductions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(
                "Remove_Deductions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                int rowsAffected = cmd.ExecuteNonQuery();  // This is correct for DELETE/INSERT/UPDATE

                if (rowsAffected > 0)
                    Response.Write($"{rowsAffected} deduction(s) successfully removed from resigned employees.");
                else
                {
                    Response.Write("No deductions found");
                }
            }
            conn.Close();
        }
        
    }
}
