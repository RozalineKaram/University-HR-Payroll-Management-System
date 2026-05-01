<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="academic_annual_submit.aspx.cs" Inherits="M3_team3.academic_annual_submit" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Annual Leave Request</title>
      <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="leave-page-wrapper">

<form id="form1" runat="server">

    <div class="leave-card">

        <!-- Page Title -->
        <asp:Label ID="Label1" runat="server" Text="Annual Leave Request" 
                   Font-Bold="true" Font-Size="Large" CssClass="leave-title"></asp:Label>

        <br />

        <!-- Replacement ID -->
        <div class="form-group">
            <asp:Label ID="academic_submit_annual_replacement_label" runat="server" 
                       Text="Replacement ID" CssClass="leave-label"></asp:Label>
            <asp:TextBox ID="academic_submit_annual_replacement" runat="server" CssClass="leave-input"></asp:TextBox>
        </div>

        <!-- Start Date -->
        <div class="form-group">
            <asp:Label ID="academic_submit_annual_Start_date_label" runat="server" 
                       Text="Start Date" CssClass="leave-label"></asp:Label>
            <asp:TextBox ID="academic_submit_annual_Start_date" runat="server" 
                         TextMode="Date" CssClass="leave-input"></asp:TextBox>
        </div>

        <!-- End Date -->
        <div class="form-group">
            <asp:Label ID="academic_submit_annual_end_date_label" runat="server" 
                       Text="End Date" CssClass="leave-label"></asp:Label>
            <asp:TextBox ID="academic_submit_annual_end_date" runat="server" 
                         TextMode="Date" CssClass="leave-input"></asp:TextBox>
        </div>

        <!-- Submit Button -->
        <asp:Button ID="academic_Submit_annual" runat="server" 
                    Text="Submit" CssClass="leave-btn" 
                    OnClick="academic_Submit_annual_Click" />

        <br />

        <!-- Back Button -->
        <asp:Button ID="Button2" runat="server" Text="Back"
                    CssClass="leave-btn leave-back-btn"
                    OnClientClick="history.go(-1); return false;" />

        <br />
        <br />

        <br />

        <!-- Message Label -->
        <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>

    </div>

</form>

</body>
</html>
