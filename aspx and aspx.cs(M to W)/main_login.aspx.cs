using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class main_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void continue_Click(object sender, EventArgs e)
        {
            String choice = Department_RadioButtonList1.SelectedValue;
            if (choice == "Admin")
            {
                Response.Redirect("AdminLogin.aspx");
            }
            if (choice == "Academic")
            {
                Response.Redirect("Academic_employee_login.aspx");
            }
            if (choice == "HR")
            {
                Response.Redirect("HR_Employee.aspx");
            }
            else
            {
                Response.Write("Please select a department.");


            }

        }
    }
}