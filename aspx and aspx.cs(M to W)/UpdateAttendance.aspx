<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAttendance.aspx.cs" Inherits="M3_team3.UpdateAttendance" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Attendance</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" 
                           Text="Update Attendance" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <div class="form-group">
                    <asp:Label ID="Label1UA" runat="server" Text="Employee ID"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txtEmployeeIDUA" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label2UA" runat="server" Text="Check-in Time"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txtCheckInUA" runat="server" TextMode ="Time"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label3UA" runat="server" Text="Check-out Time"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txtCheckOutUA" runat="server" TextMode ="Time"></asp:TextBox>
                </div>

                <asp:Button ID="Button1UA" runat="server" OnClick="SubmitUA" 
                            Text="Submit" CssClass="leave-btn" />
               
                <br />

                <asp:Button ID="Button2" runat="server" Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />

                 <br /><br />

 <asp:Label ID="lblMessageUA" runat="server" Text=" " 
            CssClass="success-message" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
