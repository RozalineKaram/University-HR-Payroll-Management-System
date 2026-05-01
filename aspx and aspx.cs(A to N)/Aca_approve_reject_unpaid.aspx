<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aca_approve_reject_unpaid.aspx.cs" Inherits="M3_team3.Aca_approve_reject_unpaid" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unpaid Leave Requests</title>
    <link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="style.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
</head>

<body class="form-bg">
<form id="form1" runat="server">

    <div class="leave-page-wrapper">
        <div class="leave-card">
            <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>

            <!-- Page Title -->
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"
                       Text="All unpaid leave requests" Font-Bold="true" Font-Size="Large"
                       CssClass="leave-title"></asp:Label>
             <br />
            <!-- GridView container -->
            <div class="leave-grid">
                <asp:GridView ID="unpaids_GridView1" runat="server"
                    CssClass="gridview"
                    AutoGenerateColumns="False"
                    UseAccessibleHeader="true"
                    HeaderStyle-CssClass="gridview-header"
                    RowStyle-CssClass="gridview-row"
                    OnSelectedIndexChanged="unpaids_GridView_SelectedIndexChanged">
                    
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" SelectText="Select" 
                            ItemStyle-CssClass="leave-select-button"/>
                        <asp:BoundField DataField="request_id" HeaderText="Request ID" />
                       
                    </Columns>
                </asp:GridView>
            </div>

            <!-- Action buttons -->
            <asp:Button ID="update_ul" runat="server"
                        CssClass="leave-btn"
                        OnClick="update_leave_Click"
                        Text="Update Leave" />

            <asp:Button ID="Button1" runat="server"
                        Text="Back"
                        CssClass="leave-btn leave-back-btn"
                        OnClientClick="history.go(-1); return false;" />

        </div>
    </div>

</form>
</body>
</html>
