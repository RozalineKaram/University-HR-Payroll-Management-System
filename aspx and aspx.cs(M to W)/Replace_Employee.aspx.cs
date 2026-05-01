using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class Replace_Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Btn_replace(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            int emp1 = int.Parse(Emp1.Text);
            int emp2 = int.Parse(Emp2.Text);
            string from_date1 = rep_emp_TextBox1.Text;
            string to_date1 = rep_emp_TextBox2.Text;
            DateTime from;
            DateTime to;
            DateTime.TryParse(from_date1, out from);
            DateTime.TryParse(to_date1, out to);
            from = from.Date;
            to = to.Date;
            if (from > to)
            {
                lblMessage.Text = "From date cannot be after To date!";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            string connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("Replace_Employee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@emp1_ID", emp1);
                cmd.Parameters.AddWithValue("@emp2_ID", emp2);
                cmd.Parameters.AddWithValue("@from_date", from);
                cmd.Parameters.AddWithValue("@to_date", to);
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        lblMessage.Text = $"SUCCESS!<br/>Employee {emp1} is replaced by Employee {emp2}<br/>from {from:yyyy-MM-dd} to {to:yyyy-MM-dd}";
                        lblMessage.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = $"Failed!";
                        lblMessage.ForeColor = Color.Orange;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error: " + ex.Message;
                    lblMessage.ForeColor = Color.Red;
                }
            }
        }
    }
}