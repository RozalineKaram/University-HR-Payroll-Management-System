<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="academic_attendence_deduct.aspx.cs" Inherits="M3_team3.academic_attendence_deduct" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Deductions</title>
      <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="form-bg">
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">

                <!-- Page title -->
                <asp:Label ID="Label2" runat="server"
                           Text="Deductions"
                           Font-Bold="true"
                           Font-Size="Large"
                           CssClass="leave-title"></asp:Label>

                <!-- Month input -->
                <br />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Enter Month"></asp:Label>
                    <asp:TextBox ID="attendance_deduct_month" runat="server" CssClass="form-control"></asp:TextBox>
                </div>

                <!-- Show button -->
                <asp:Button ID="Button3" runat="server"
                            Text="Show"
                            CssClass="leave-btn"
                            OnClick="Button3_Click" />

                <!-- GridView container -->
                <br />
                <div class="leave-grid">
                    <asp:GridView ID="attendance_deduct_GridView" runat="server"
                                  CssClass="gridview"
                                  AutoGenerateColumns="true"
                                  UseAccessibleHeader="true"
                                  HeaderStyle-CssClass="gridview-header"
                                  RowStyle-CssClass="gridview-row">
                       
                    </asp:GridView>
                </div>

                <!-- Back button -->
                <br />
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
