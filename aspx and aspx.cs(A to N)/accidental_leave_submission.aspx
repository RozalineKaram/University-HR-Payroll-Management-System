<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="accidental_leave_submission.aspx.cs" Inherits="M3_team3.accidental_leave_submission" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Accidental Leave Request</title>
       <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="form-bg">
<form id="form1" runat="server">
    <div class="leave-page-wrapper">
        <div class="leave-card">
            <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Accidental Leave Request" Font-Bold="true" Font-Size="Large" CssClass="leave-title"></asp:Label>
            
            

            <br />
            
            

            <div class="form-group">
                <asp:Label ID="acc_submission_label1" runat="server" Text="Start Date"></asp:Label>
                <asp:TextBox ID="acc_submission_TextBox1" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="acc_submission_label2" runat="server" Text="End Date"></asp:Label>
                <asp:TextBox ID="acc_submission_TextBox2" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>

            <asp:Button ID="acc_submission_Button1" runat="server" Text="Submit" CssClass="leave-btn" OnClick="acc_submission_Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Back" CssClass="leave-btn leave-back-btn" OnClientClick="history.go(-1); return false;" />

        </div>
    </div>
</form>
</body>
</html>
