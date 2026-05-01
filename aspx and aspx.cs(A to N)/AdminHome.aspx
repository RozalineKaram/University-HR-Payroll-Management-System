<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="M3_team3.AdminHome" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Portal</title>

    <!-- Main shared CSS -->
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
                    <h2 class="welcome-title">Welcome Admin</h2>
                    <p class="welcome-sub">Manage Employees & System Settings</p>
                </div>
            </div>

            <!-- GRID LAYOUT FOR BUTTONS -->
            <div class="academic-menu-grid">

                <asp:Button ID="Button1hal" runat="server"
                    CssClass="menu-btn" Text="👥 All Employee Profiles"
                    OnClick="EmployeeProfiles" />

                <asp:Button ID="Button2hal" runat="server"
                    CssClass="menu-btn" Text="🏢 Employees Per Department"
                    OnClick="EmployeePerDepartment" />

                <asp:Button ID="Button3hal" runat="server"
                    CssClass="menu-btn" Text="❌ Rejected Medical Leaves"
                    OnClick="RejectedMedical" />

                <asp:Button ID="Button4hal" runat="server"
                    CssClass="menu-btn" Text="💼 Remove Deductions (Resigned Employees)"
                    OnClick="RemoveDeductions" />

                <asp:Button ID="Button5hal" runat="server"
                    CssClass="menu-btn" Text="🕒 Update Attendance"
                    OnClick="updateAttendance" />

                <asp:Button ID="Button6hal" runat="server"
                    CssClass="menu-btn" Text="📅 Add Official Holiday"
                    OnClick="AddHoliday" />

                <asp:Button ID="Button7hal" runat="server"
                    CssClass="menu-btn" Text="🕘 Initiate Attendance"
                    OnClick="InitiateAttendance" />

                <asp:Button ID="Btnyesterday" runat="server"
                    CssClass="menu-btn" Text="📆 Fetch Yesterday Attendance"
                    OnClick="Btn_yesterday" />

                <asp:Button ID="Btnperformance" runat="server"
                    CssClass="menu-btn" Text="📊 Performance (All Winter Semesters)"
                    OnClick="Btn_performance" />

                <asp:Button ID="Btnremoveholidays" runat="server"
                    CssClass="menu-btn" Text="🏖 Remove Attendance on Holidays"
                    OnClick="Btn_removeholidays" />

                <asp:Button ID="Btnremovedayoff" runat="server"
                    CssClass="menu-btn" Text="🚫 Remove Unattended Day Off"
                    OnClick="Btn_removedayoff" />

                <asp:Button ID="BtnremoveAL" runat="server"
                    CssClass="menu-btn" Text="📝 Remove Approved Leaves"
                    OnClick="Btn_removeAL" />

                <asp:Button ID="Btnreplace" runat="server"
                    CssClass="menu-btn" Text="🔄 Replace Employee"
                    OnClick="Btn_replaceL" />

                <asp:Button ID="Btnupdate" runat="server"
                    CssClass="menu-btn" Text="⚙ Update Employment Status"
                    OnClick="Btn_updateL" />

            </div>

            <!-- BACK + LOGOUT -->
            <div class="footer-buttons">

                <asp:Button ID="ButtonBack" runat="server"
                    Text="⬅ Back"
                    CssClass="academic-back-btn"
                    OnClientClick="history.go(-1); return false;" />

                <button type="button" class="logout-btn"
                    onclick="window.location='main_login.aspx'">
                    <i class="fa-solid fa-right-from-bracket"></i>
                </button>

            </div>

        </div>
    </div>

</form>

</body>
</html>
