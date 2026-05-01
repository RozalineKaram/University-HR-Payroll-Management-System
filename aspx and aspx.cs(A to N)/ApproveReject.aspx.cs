using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M3_team3
{
    public partial class ApproveReject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Btn_AnnualAccidental(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("ApproveRejectAnnualAccidental.aspx?hrID=" + hrID);
        }

        protected void Btn_Unpaid(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("ApproveRejectUnpaid.aspx?hrID=" + hrID);
        }

        protected void Btn_Comp(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("ApproveRejectCompensation.aspx?hrID=" + hrID);
        }

        protected void Btn_HrsMiss(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("AddDeductionMissingHours.aspx?hrID=" + hrID);
        }

        protected void Btn_DaysMiss(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("AddDeductionMissingDays.aspx?hrID=" + hrID);
        }

        protected void Btn_UnpaidDed(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("AddDeductionUnpaidLeave.aspx?hrID=" + hrID);
        }

        protected void Btn_Payroll(object sender, EventArgs e)
        {
            string hrID = Request.QueryString["hrID"];
            Response.Redirect("GenerateMonthlyPayroll.aspx?hrID=" + hrID);
        }
    }
}