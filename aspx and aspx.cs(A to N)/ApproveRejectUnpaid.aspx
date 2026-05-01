<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveRejectUnpaid.aspx.cs" Inherits="M3_team3.ApproveUnpaid" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Approve Unpaid Leaves</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" Text="Approve/Reject Unpaid Leaves" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <!-- Success/Error Message -->
                <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
                <br />
                <br />

                <asp:Label ID="Label2" runat="server" Text="Request ID"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtRequestID" runat="server"></asp:TextBox>
                <br /><br />

                <asp:Button ID="btnProcess" runat="server" Text="Submit" CssClass="leave-btn" OnClick="btnProcess_Click" />
                <br /><br />
                <asp:Button ID="btnBack" runat="server" Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
