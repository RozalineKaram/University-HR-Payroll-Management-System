<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEmployees.aspx.cs" Inherits="M3_team3.DepartmentEmployees" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department Employees</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" 
                           Text="Total Employees In Each Department" 
                           Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <asp:GridView ID="GridView1DE" runat="server" 
                              CssClass="leave-grid gridview" 
                              AutoGenerateColumns="true">
                </asp:GridView>
                <br />

                <asp:Button ID="Button2" runat="server" 
                            Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
