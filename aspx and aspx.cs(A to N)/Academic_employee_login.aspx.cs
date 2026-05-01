using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class Academic_employee_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Academic_login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["M3_team3"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                int academicID = Int16.Parse(Academic_ID.Text);
                String password = Academic_Password.Text;

                SqlCommand cmd = new SqlCommand(
               "SELECT dbo.EmployeeLoginValidation(@employee_ID, @password)", conn);
                cmd.Parameters.AddWithValue("@employee_ID", academicID);
                cmd.Parameters.AddWithValue("@password", password);
                String query1 = @"select Count(*) from  Employee e inner join Employee_Role er  ON e.employee_id = er.emp_ID WHERE e.employee_id = @employee_ID AND er.role_name IN ('President')";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                String query2 = @"select Count(*) from  Employee e inner join Employee_Role er ON e.employee_id = er.emp_ID WHERE e.employee_id = @employee_ID AND er.role_name in  ('Dean')";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                String query3 = @"select Count(*) from  Employee e inner join Employee_Role er ON e.employee_id = er.emp_ID WHERE e.employee_id = @employee_ID AND er.role_name in  ('Vice Dean')";
                SqlCommand cmd3 = new SqlCommand(query3, conn);
                cmd1.Parameters.AddWithValue("@employee_ID", academicID);
                cmd2.Parameters.AddWithValue("@employee_ID", academicID);
                cmd3.Parameters.AddWithValue("@employee_ID", academicID);

                

                conn.Open();
                bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                int count_p = (int)cmd1.ExecuteScalar();
                int count_d = (int)cmd2.ExecuteScalar();
                int count_vd = (int)cmd3.ExecuteScalar();
                conn.Close();

                if (success)
                {
                    Session["academicID"] = academicID;
                    if (count_p > 0 || count_vd > 0)
                    {
                        Response.Redirect("pres_viced_homepage.aspx");
                    }
                    else if (count_d > 0 )
                    {
                        Response.Redirect("dean_homepage.aspx");
                    }
                    else
                    {
                        Response.Redirect("Academic_Homepage.aspx");
                    }
                }
                else
                {
                    Response.Write("Invalid Admin ID or Password");

                }
            }
            catch (Exception ex)
            {
                Response.Write("make sure you entered the inputs correctly !!");
                Response.Write(ex.Message);
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("main_login.aspx");
        }


    }
}