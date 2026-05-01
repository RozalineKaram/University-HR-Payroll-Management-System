<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unpaid_leave_submission.aspx.cs" Inherits="M3_team3.unpaid_leave_submission" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unpaid Leave Request</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" Text="Unpaid Leave Request" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>


                <br />
                <br />


                <asp:Label ID="unpaid_sub_Label1" runat="server" Text="Start Date"></asp:Label>
                &nbsp;<asp:TextBox ID="unpaid_sub_Start_date" runat="server" TextMode="Date"></asp:TextBox>

                <br />
                <br />

                <asp:Label ID="unpaid_sub_Label2" runat="server" Text="End Date"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="unpaid_sub_End_date" runat="server" TextMode="Date"></asp:TextBox>

                <br />
                <br />

                <asp:Label ID="unpaid_sub_Label3" runat="server" Text="Document Description"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="unpaid_sub_document_description" runat="server"></asp:TextBox>

                <br />
                <br />

                <asp:Label ID="unpaid_sub_Label4" runat="server" Text="File Name"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="unpaid_sub_file_name" runat="server"></asp:TextBox>

                <!-- Label for messages -->
                <br />
                <br />
                
                <asp:Button ID="unpaid_sub_Button1" runat="server" Text="Submit" CssClass="leave-btn" OnClick="unpaid_sub_Button1_Click" />
                <br />

                <br />

                <asp:Button ID="Button2" runat="server" Text="Back"  CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
