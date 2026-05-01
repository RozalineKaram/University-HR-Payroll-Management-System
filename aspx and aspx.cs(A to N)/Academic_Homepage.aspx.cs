using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class Academic_Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Academic_emp_performance_Click(object sender, EventArgs e)
        {
            Response.Redirect("Academic_performance.aspx");
        }

        protected void Academic_emp_attendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("Academic_attendance.aspx");
        }

        protected void Academic_emp_last_month_payroll_Click(object sender, EventArgs e)
        {
            Response.Redirect("Academic_past_payroll.aspx");
        }

        protected void Academic_emp_attendence_deductions_Click(object sender, EventArgs e)
        {
            Response.Redirect("academic_attendence_deduct.aspx");
        }

        protected void Academic_emp_submit_annual_leave_Click(object sender, EventArgs e)
        {
            Response.Redirect("academic_annual_submit.aspx");
        }
        protected void Academic_emp_submit_accidental_leave_Click(object sender, EventArgs e)
        {
            Response.Redirect("accidental_leave_submission.aspx");
        }
        protected void Academic_emp_submit_medical_leave_Click(object sender, EventArgs e)
        {
            Response.Redirect("medical_leave_submission.aspx");
        }
        protected void Academic_emp_submit_compensation_leave_Click(object sender, EventArgs e)
        {
            Response.Redirect("compensation_leave_submission.aspx");
        }
        protected void Academic_emp_submit_unpaid_leave_Click(object sender, EventArgs e)
        {
            Response.Redirect("unpaid_leave_submission.aspx");
        }

        protected void Academic_emp_Leave_status_view_Click(object sender, EventArgs e)
        {
            Response.Redirect("academic_annual_acc_status.aspx");
        }
    }
}