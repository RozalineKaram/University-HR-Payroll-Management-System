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
    public partial class UpdateAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void SubmitUA(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            using (conn)
            {
                // ====== FULL VALIDATION – EXACTLY LIKE DR. MERVAT WANTS ======

                // 1. Employee ID empty or not number?
                if (string.IsNullOrWhiteSpace(txtEmployeeIDUA.Text))
                {
                    Response.Write("ERROR: Employee ID is required.");
                    conn.Close();
                    return;
                }

                if (!int.TryParse(txtEmployeeIDUA.Text, out int empId))
                {
                    Response.Write("ERROR: Employee ID must be a valid number.");
                    conn.Close();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCheckInUA.Text) ||
                    string.IsNullOrWhiteSpace(txtCheckOutUA.Text))
                {
                    Response.Write("ERROR: Both Check-in and Check-out times are REQUIRED. ");
                    conn.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand("Update_Attendance", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Employee_id", int.Parse(txtEmployeeIDUA.Text));

                // Both fields are guaranteed to be non-empty now → safe to parse
                cmd.Parameters.Add("@check_in_time", SqlDbType.Time).Value = TimeSpan.Parse(txtCheckInUA.Text);
                cmd.Parameters.Add("@check_out_time", SqlDbType.Time).Value = TimeSpan.Parse(txtCheckOutUA.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Write($"Attendance successfully updated for Employee ID {txtEmployeeIDUA.Text}. " +
                                   "Status: Attended");
                }
                else
                {
                    Response.Write("No attendance record found for today. " +
                                   "Make sure Initiate_Attendance was run and Employee ID is correct.");
                }
            }
            conn.Close();

        }
    }

    }
