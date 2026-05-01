<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remove_Holidays.aspx.cs" Inherits="M3_team3.Remove_attendance" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="  " CssClass="message" ForeColor="#28a745"> </asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnremove" runat="server"  OnClick="btn_remove" Text="Remove All Holiday attendance records " Width="371px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
                        <asp:Button ID="Button2" runat="server" Text="Back" Font-Bold ="true" OnClientClick="history.go(-1); return false;" />

        </p>
    </form>
</body>
</html>
