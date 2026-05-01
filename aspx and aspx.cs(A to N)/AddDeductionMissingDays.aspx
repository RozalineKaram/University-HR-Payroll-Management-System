<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDeductionMissingDays.aspx.cs" Inherits="M3_team3.AddDeductionMissingDays" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Deduction - Missing Days</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <h2>Add Deduction Due to Missing Days</h2>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Employee ID:" Font-Bold="true"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtEmpID" runat="server" ></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnSubmit" runat="server" Text="Add Missing Days Deduction" CssClass="leave-btn" OnClick="btn_missingDays" />
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="leave-btn leave-back-btn" OnClick="btnBack_Click" />
                <br /><br />
                <asp:Label ID="lblMessage" runat="server" Font-Bold="true" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
