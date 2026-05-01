<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Academic_Homepage.aspx.cs" Inherits="M3_team3.Academic_Homepage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Portal</title>
       <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>

<body class="academic-bg">
    <form id="form1" runat="server">

        <div class="academic-wrapper">
            <div class="academic-box">

                <!-- Profile Header -->
                <div class="academic-header">
                   
                    <div>
                        <h2 class="welcome-title">Welcome, Academic Employee</h2>
                        <p class="welcome-sub">Choose an action below</p>
                    </div>
                </div>

                <!-- Two-Column Menu -->
                <div class="academic-menu-grid">

                    <asp:Button ID="Academic_emp_performance" CssClass="menu-btn" 
                        runat="server" Text="📊 My performance" 
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
                        runat="server" Text="🌴 Submit annual leave" 
                        OnClick="Academic_emp_submit_annual_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_accidental_leave" CssClass="menu-btn" 
                        runat="server" Text="🚨 Submit accidental Leave" 
                        OnClick="Academic_emp_submit_accidental_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_medical_leave" CssClass="menu-btn" 
                        runat="server" Text="🩺 Submit medical Leave" 
                        OnClick="Academic_emp_submit_medical_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_compensation_leave" CssClass="menu-btn" 
                        runat="server" Text="💼 Submit compensation Leave" 
                        OnClick="Academic_emp_submit_compensation_leave_Click" />

                    <asp:Button ID="Academic_emp_submit_unpaid_leave0" CssClass="menu-btn" 
                        runat="server" Text="❌ Submit unpaid Leave" 
                        OnClick="Academic_emp_submit_unpaid_leave_Click" />

                    <asp:Button ID="Button1" CssClass="menu-btn" 
                        runat="server" Text="📌 View Leave Status" 
                        OnClick="Academic_emp_Leave_status_view_Click" />

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
