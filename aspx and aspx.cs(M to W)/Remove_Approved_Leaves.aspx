<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remove_Approved_Leaves.aspx.cs" Inherits="M3_team3.Remove_Approved_Leaves" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remove Approved Leaves</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label2" runat="server" 
                           Text="Remove Approved Leaves from Attendance" 
                           Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <asp:Label ID="Label1" runat="server" Text="Enter Employee ID"></asp:Label>
                &nbsp;
                <asp:TextBox ID="ID" runat="server" OnTextChanged="ID_TextChanged"></asp:TextBox>
                <br /><br />

                <asp:Button ID="Btnsubmit" runat="server" OnClick="Btn_submit" 
                            Text="Submit" CssClass="leave-btn" />
                <br /><br />


                <asp:Button ID="Button2" runat="server" 
                            Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
                 <br />
                <br />
                <asp:Label ID="lblMessage" runat="server" Text=" " 
                           CssClass="success-message" Visible="false"></asp:Label>
                <br />
               


            </div>
        </div>
    </form>
</body>
</html>
