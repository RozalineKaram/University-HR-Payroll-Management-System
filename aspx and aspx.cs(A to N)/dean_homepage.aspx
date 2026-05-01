<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dean_homepage.aspx.cs" Inherits="M3_team3.dean_homepage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dean Portal</title>
    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>

<body class="academic-bg">
    <form id="form1" runat="server">

        <div class="academic-wrapper">
            <div class="academic-box">

                <!-- Dean Header -->
                <div class="academic-header">
                    
                    <div>
                        <h2 class="welcome-title">Welcome Dean</h2>
                        <p class="welcome-sub">Choose an action below</p>
                    </div>
                </div>

                <!-- Two Column Grid -->
                <div class="academic-menu-grid">

                    <asp:Button ID="Academic_emp_performance" CssClass="menu-btn"
                        runat="server" Text="📊 My Performance"
                        OnClick="Academic_emp_performance_Click" />

                    <asp:Button ID="Academic_emp_attendance" CssClass="menu-btn"
                        runat="server" Text="🗓 Get attendance for this month"
                        OnClick="Academic_emp_attendance_Click" />

                    <asp:Button ID="Academic_emp_last_month_payroll" CssClass="menu-btn"
                        runat="server" Text="💰 Get last month’s payroll"
                        OnClick="Academic_emp_last_month_payroll_Click" />

                    <asp:Button ID="Academic_emp_attendence_deductions" CssClass="menu-btn"
                        runat="server" Text="⚠ Get deductions due to attendance"
                        OnClick="Academic_emp_attendence_deductions_Click" />

                    <asp:Button ID="Academic_emp_submit_annual_leave" CssClass="menu-btn"
                        runat="server" Text="🌴 Submit Annual Leave"
                        OnClick="Academic_emp_submit_annual_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_accidental_leave" CssClass="menu-btn"
                        runat="server" Text="🚨 Submit Accidental Leave"
                        OnClick="Academic_emp_submit_accidental_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_medical_leave" CssClass="menu-btn"
                        runat="server" Text="🩺 Submit Medical Leave"
                        OnClick="Academic_emp_submit_medical_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_compensation_leave" CssClass="menu-btn"
                        runat="server" Text="💼 Submit Compensation Leave"
                        OnClick="Academic_emp_submit_compensation_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_unpaid_leave" CssClass="menu-btn"
                        runat="server" Text="❌ Submit Unpaid Leave"
                        OnClick="Academic_emp_submit_unpaid_leave_Click" />

                    <asp:Button ID="Button1" CssClass="menu-btn"
                        runat="server" Text="📌 View Leave Status"
                        OnClick="Academic_emp_Leave_status_view_Click" />

                    <asp:Button ID="approve_reject_unpaid" CssClass="menu-btn"
                        runat="server" Text="✔ Approve / Reject Unpaid Leaves"
                        OnClick="approve_reject_unpaid_Click" />

                    <asp:Button ID="approve_reject_annual" CssClass="menu-btn"
                        runat="server" Text="✔ Approve / Reject Annual Leaves"
                        OnClick="approve_reject_annual_Click" />

                    <asp:Button ID="evaluate_employees_in_department" CssClass="menu-btn"
                        runat="server" Text="📈 Evaluate Employees"
                        OnClick="evaluate_employees_in_department_Click" />

                </div>

                <!-- Footer Buttons -->
                <div class="footer-buttons">
                    <asp:Button ID="Button2" runat="server"
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
