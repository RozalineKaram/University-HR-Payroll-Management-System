<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Academic_performance.aspx.cs" Inherits="M3_team3.Academic_performance" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Performance</title>
</head>
<body class="form-bg">
    <form id="form1" runat="server">

        <div class="leave-page-wrapper">
            <div class="leave-card">

                <asp:Label ID="Label1" runat="server"
                           Text="Performance"
                           Font-Bold="true"
                           Font-Size="Large"
                           CssClass="leave-title"></asp:Label>

                <br />

                <asp:Label ID="Label2" runat="server" Text="Enter Semester"></asp:Label>
                <br /><br />

                <asp:TextBox ID="semester_performance" runat="server"></asp:TextBox>
                <br /><br />

                <!-- Message Label -->
               

                <div class="leave-grid">
                    <asp:GridView ID="GridView1" runat="server"
                                  CssClass="gridview"
                                  AutoGenerateColumns="true"
                                  UseAccessibleHeader="true"
                                  HeaderStyle-CssClass="gridview-header"
                                  RowStyle-CssClass="gridview-row">
                    </asp:GridView>
                </div>

                <asp:Button ID="Button3" runat="server"
                            OnClick="Button3_Click"
                            Text="Show"
                            CssClass="leave-btn" />

                <asp:Button ID="Button2" runat="server"
                            Text="Back"
                            CssClass="leave-btn leave-back-btn"
                            OnClientClick="history.go(-1); return false;" />

                 <br />
                <br />
                <br />

                 <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>

            </div>
        </div>

    </form>
</body>
</html>
