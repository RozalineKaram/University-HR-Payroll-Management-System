<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Academic_attendance.aspx.cs" Inherits="M3_team3.Academic_attendance" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Attendance</title>
      <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="form-bg">
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">

                <!-- Page title -->
                <asp:Label ID="Academic_attendance_label" runat="server"
                           Text="Attendance for this Month"
                           Font-Bold="true"
                           Font-Size="Large"
                           CssClass="leave-title"></asp:Label>

                <!-- GridView container -->
                <div class="leave-grid">
                    <asp:GridView ID="Academic_attendance_gridview" runat="server"
                                  CssClass="gridview"
                                  AutoGenerateColumns="true"
                                  UseAccessibleHeader="true"
                                  HeaderStyle-CssClass="gridview-header"
                                  RowStyle-CssClass="gridview-row">
                        
                    </asp:GridView>
                </div>

                <!-- Back button -->
                <asp:Button ID="Button2" runat="server"
                            Text="Back"
                            CssClass="leave-btn leave-back-btn"
                            OnClientClick="history.go(-1); return false;" />

            </div>
        </div>
    </form>
</body>
</html>
