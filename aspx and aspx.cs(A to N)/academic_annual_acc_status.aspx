<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="academic_annual_acc_status.aspx.cs" Inherits="M3_team3.academic_annual_acc_status" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Annual & Accidental Leave Status</title>
       <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

</head>
<body class="leave-page-wrapper">

<form id="form1" runat="server">

    <div class="leave-card">

        <!-- Page Title -->
        <asp:Label ID="status_ann_acc_label" runat="server" 
                   Text="Annual and Accidental leaves status of the current month" 
                   Font-Bold="true" Font-Size="Large" CssClass="leave-title"></asp:Label>

        <br /><br />

        <!-- GridView -->
        <div class="leave-grid">
            <asp:GridView ID="academic_annual_acc_status_GridView" runat="server"
                          CssClass="gridview"
                          AutoGenerateColumns="True"
                          UseAccessibleHeader="true"
                          HeaderStyle-CssClass="gridview-header"
                          RowStyle-CssClass="gridview-row"
                          Width="100%">
            </asp:GridView>
        </div>

        <br />

        <!-- Back Button -->
        <asp:Button ID="Button2" runat="server"
                    Text="Back"
                    CssClass="leave-btn leave-back-btn"
                    OnClientClick="history.go(-1); return false;" />

    </div>

</form>

</body>
</html>
