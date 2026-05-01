<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compensation_leave_submission.aspx.cs" Inherits="M3_team3.compensation_leave_submission" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Compensation Leave Submission</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label1" runat="server" Text="Compensation Leave Request" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br />
                <br />

                <!-- Message label for success/error -->
                <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
                <br />
                <br />

                <asp:Label ID="comp_subm_Label1" runat="server" Text="Compensation Date"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="comp_subm_comp_date" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="comp_subm_Label2" runat="server" Text="Date of Original Workday"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="comp_subm_dateofogwday" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="comp_subm_Label3" runat="server" Text="Reason"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="comp_subm_reason" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="comp_subm_Label4" runat="server" Text="Replacement ID"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="comp_subm_rep_id" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Button ID="comp_subm_Button1" runat="server" Text="Submit" CssClass="leave-btn" OnClick="comp_subm_Button1_Click" />
                <br />
                <br />

                <asp:Button ID="Button2" runat="server" Text="Back" CssClass="leave-btn leave-back-btn"
                            OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
