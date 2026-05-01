<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pres_viced_homepage.aspx.cs" Inherits="M3_team3.pres_viced_homepage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vice Dean / President Portal</title>

        <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="academic-bg">

<form id="form1" runat="server">

    <div class="academic-wrapper">

        <div class="academic-box">

            <!-- Header Section -->
            <div class="academic-header">
                
                <div>
                    <h2 class="welcome-title">Welcome President / Vice Dean </h2>
                    <p class="welcome-sub">Monitor Employee Leaves & Performance</p>
                </div>
            </div>

            <!-- GRID LAYOUT FOR BUTTONS -->
            <div class="academic-menu-grid">

                <asp:Button ID="Academic_emp_performance" runat="server"
                    CssClass="menu-btn" Text="📊 My performance"
                    OnClick="Academic_emp_performance_Click" />

                <asp:Button ID="Academic_emp_attendance" runat="server"
                    CssClass="menu-btn" Text="🗓 Get attendance for this month"
                    OnClick="Academic_emp_attendance_Click" />

                <asp:Button ID="Academic_emp_last_month_payroll" runat="server"
                    CssClass="menu-btn" Text="💰 Get last month’s payroll"
                    OnClick="Academic_emp_last_month_payroll_Click" />

                <asp:Button ID="Academic_emp_attendence_deductions" runat="server"
                    CssClass="menu-btn" Text="⚠️ Get deductions due to attendance"
                    OnClick="Academic_emp_attendence_deductions_Click" />

                <asp:Button ID="Academic_emp_submit_annual_leave" runat="server"
                    CssClass="menu-btn" Text="📝 Submit annual leave"
                    OnClick="Academic_emp_submit_annual_leave_Click" />

                <asp:Button ID="Academic_emp_submit_accidental_leave" runat="server"
                    CssClass="menu-btn" Text="🚑 Submit accidental leave"
                    OnClick="Academic_emp_submit_accidental_leave_Click" />

                <asp:Button ID="Academic_emp_submit_medical_leave" runat="server"
                    CssClass="menu-btn" Text="🏥 Submit medical leave"
                    OnClick="Academic_emp_submit_medical_leave_Click" />

                <asp:Button ID="Academic_emp_submit_compensation_leave" runat="server"
                    CssClass="menu-btn" Text="🔄 Submit compensation leave"
                    OnClick="Academic_emp_submit_compensation_leave_Click" />

                <asp:Button ID="Academic_emp_submit_unpaid_leave" runat="server"
                    CssClass="menu-btn" Text="💸 Submit unpaid leave"
                    OnClick="Academic_emp_submit_unpaid_leave_Click" />
                
                <asp:Button ID="Button1" CssClass="menu-btn"
                   runat="server" Text="📌 View Leave Status"
                   OnClick="Academic_emp_Leave_status_view_Click" />

                <asp:Button ID="approve_reject_unpaid" runat="server"
                    CssClass="menu-btn" Text="✅ Approve/reject unpaid leaves"
                    OnClick="approve_reject_unpaid_Click" />

                <asp:Button ID="approve_reject_annual" runat="server"
                    CssClass="menu-btn" Text="✅ Approve/reject annual leaves"
                    OnClick="approve_reject_annual_Click" />

            </div>

            <!-- BACK BUTTON -->
            <div class="footer-buttons">
                <asp:Button ID="ButtonBack" runat="server"
                    Text="⬅ Back"
                    CssClass="academic-back-btn"
                    OnClientClick="history.go(-1); return false;" />
                 <button type="button" class="logout-btn" onclick="window.location='main_login.aspx'">
     <i class="fa-solid fa-right-from-bracket"></i>
 </button>
            </div>

        </div>
    </div>

</form>

</body>
</html>
