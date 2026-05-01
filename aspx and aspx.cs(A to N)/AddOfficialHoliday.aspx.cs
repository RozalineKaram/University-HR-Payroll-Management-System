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
    public partial class AddOfficialHoliday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitAOH(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (conn)
            {
                if (string.IsNullOrWhiteSpace(HolidayNameAOH.Text))
                {
                    Response.Write("ERROR: Holiday name is required.");
                    conn.Close();
                    return;
                }

                if (string.IsNullOrWhiteSpace(FromAOH.Text) || !DateTime.TryParse(FromAOH.Text, out DateTime fromDate) || string.IsNullOrWhiteSpace(ToAOH.Text) || !DateTime.TryParse(ToAOH.Text, out DateTime toDate))
                {
                    Response.Write("ERROR: Please enter valid from and to dates .");
                    conn.Close();
                    return;
                }
                if (fromDate > toDate)
                {
                    Response.Write("ERROR: 'From' date cannot be after 'To' date.");
                    conn.Close();
                    return;
                }
                SqlCommand cmd2 = new SqlCommand(
                        "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Holiday') EXEC Create_Holiday",
                        conn
                    );
                cmd2.CommandType = CommandType.Text;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand("Add_Holiday", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@holiday_name", HolidayNameAOH.Text.Trim());
                cmd.Parameters.AddWithValue("@from_date", fromDate);
                cmd.Parameters.AddWithValue("@to_date", toDate);

                try
                {
                    cmd.ExecuteNonQuery();
                    Response.Write($"Holiday '{HolidayNameAOH.Text.Trim()}' successfully added from {fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd}.");
                }
                catch (SqlException ex)
                {
                    Response.Write("ERROR: " + ex.Message);
                    if (ex.Message.Contains("overlaps"))
                        Response.Write("<br/>Hint: Another holiday with the same name already overlaps these dates.");
                }
            }
            conn.Close();
        }
        
    }
}