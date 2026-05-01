<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Replace_Employee.aspx.cs" Inherits="M3_team3.Replace_Employee" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Replace Employee</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label5" runat="server" 
                           Text="Replace Employee" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Employee on Leave ID"></asp:Label>
                    &nbsp;<asp:TextBox ID="Emp1" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Replacement Employee ID"></asp:Label>
                    &nbsp;<asp:TextBox ID="Emp2" runat="server"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="From Date:"></asp:Label>
                    &nbsp;<asp:TextBox ID="rep_emp_TextBox1" runat="server" TextMode="Date"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="To Date:"></asp:Label>
                    &nbsp;<asp:TextBox ID="rep_emp_TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                </div>

                <asp:Button ID="Btnreplace" runat="server" OnClick="Btn_replace" 
                            Text="Replace" CssClass="leave-btn" />
               
                <br />

                <asp:Button ID="Button2" runat="server" Text="Back" 
                            CssClass="leave-btn leave-back-btn" 
                            OnClientClick="history.go(-1); return false;" />
                 <br /><br />

 <asp:Label ID="lblMessage" runat="server" Text=" " 
            CssClass="success-message" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
