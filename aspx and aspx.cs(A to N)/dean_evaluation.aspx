<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dean_evaluation.aspx.cs" Inherits="M3_team3.dean_evaluation" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dean Evaluation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label5" runat="server" Text="Dean Evaluation" Font-Bold="True" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
                <br />

                <br />

                <asp:Label ID="Label2" runat="server" Text="Rating"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Eval_Rating" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="Label3" runat="server" Text="Comments"></asp:Label>
                &nbsp;
                <asp:TextBox ID="Eval_Comments" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="Label4" runat="server" Text="Semester"></asp:Label>
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="Eval_Semester" runat="server"></asp:TextBox>
                <br />
                <br />

                <asp:Label ID="Label6" runat="server" Text="All employees in department" Font-Bold="True" Font-Size="Large"></asp:Label>
                <asp:GridView ID="employees_GridView" runat="server" OnSelectedIndexChanged="employees_GridView_SelectedIndexChanged" AutoGenerateColumns="False" CssClass="leave-grid">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" SelectText="Select" />
                        <asp:BoundField DataField="employee_id" HeaderText="Employee ID" />
                    </Columns>
                </asp:GridView>
                <br />

                <asp:Button ID="Eval_Button1" runat="server" Text="Finish Evaluation" CssClass="leave-btn" OnClick="Eval_Button1_Click" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Back" CssClass="leave-btn leave-back-btn" OnClientClick="history.go(-1); return false;" />
            </div>
        </div>
    </form>
</body>
</html>
