<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveReject.aspx.cs" Inherits="M3_team3.ApproveReject" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HR Portal</title>

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
                    <h2 class="welcome-title">Welcome HR</h2>
                    <p class="welcome-sub">Manage Leaves & Payroll</p>
                </div>
            </div>

            <!-- GRID LAYOUT FOR BUTTONS -->
            <div class="academic-menu-grid">

                <asp:Button ID="BtnAnnualAccidental" runat="server"
                    CssClass="menu-btn" Text="📝 Approve/reject annual/accidental leaves"
                    OnClick="Btn_AnnualAccidental" />

                <asp:Button ID="BtnUnpaid" runat="server"
                    CssClass="menu-btn" Text="💰 Approve/reject unpaid leaves"
                    OnClick="Btn_Unpaid" />

                <asp:Button ID="BtnComp" runat="server"
                    CssClass="menu-btn" Text="🔄 Approve/reject compensation leaves"
                    OnClick="Btn_Comp" />

                <asp:Button ID="BtnHrsMiss" runat="server"
                    CssClass="menu-btn" Text="⏱ Add deduction for missing hours"
                    OnClick="Btn_HrsMiss" />

                <asp:Button ID="BtnDaysMiss" runat="server"
                    CssClass="menu-btn" Text="📅 Add deduction for missing days"
                    OnClick="Btn_DaysMiss" />

                <asp:Button ID="BtnUnpaidDed" runat="server"
                    CssClass="menu-btn" Text="💸 Add deduction for unpaid leave"
                    OnClick="Btn_UnpaidDed" />

                <asp:Button ID="BtnPayroll" runat="server"
                    CssClass="menu-btn" Text="📊 Generate monthly payroll"
                    OnClick="Btn_Payroll" />

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
