<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOfficialHoliday.aspx.cs" Inherits="M3_team3.AddOfficialHoliday" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Official Holiday</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" Text="Add Official Holiday" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <asp:Label ID="Label1AOH" runat="server" Text="Please Enter the Holiday Name"></asp:Label>
                <asp:TextBox ID="HolidayNameAOH" runat="server"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label2AOH" runat="server" Text="Please Enter the From Date"></asp:Label>
                <asp:TextBox ID="FromAOH" runat="server" TextMode="Date"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label3AOH" runat="server" Text="Please Enter the To Date"></asp:Label>
                <asp:TextBox ID="ToAOH" runat="server" TextMode="Date"></asp:TextBox>
                <br /><br />

                <asp:Button ID="Button1AOH" runat="server" OnClick="SubmitAOH" Text="Submit" CssClass="leave-btn" />
                <br /><br />

                <asp:Button ID="Button2" runat="server" Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
