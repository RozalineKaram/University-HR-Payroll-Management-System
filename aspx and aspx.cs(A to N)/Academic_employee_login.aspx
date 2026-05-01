<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Academic_employee_login.aspx.cs" Inherits="M3_team3.Academic_employee_login" %>

<!DOCTYPE html>
   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
   

<body>
    <form id="form1" runat="server">
      <div class="login-wrapper">
    <div class="login-box">
        <h2>Academic Login</h2>

        <asp:Label ID="Label2" runat="server" Text="User ID"></asp:Label>
        <br />
        <asp:TextBox ID="Academic_ID" runat="server" ></asp:TextBox>

        <br />

        <asp:Label ID="Academic_IDlbl" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="Academic_Password" TextMode="Password"  runat="server"></asp:TextBox>


        <br />
        <br />


        <asp:Button ID="Academic_Login_button" runat="server" Text="Login" OnClick="Academic_login" Width="85px" />
         <br />
         <br />
                <asp:Button 
            ID="Button2" 
            runat="server" 
            Text="Back to the Main Page"
            Font-Bold="true"
            CssClass="back-button"
            OnClick="Back_Click"
        />
         <div class="note">
     <br />
     Enter your credentials to continue.</div>
    </div>
</div>
      
    </form>
</body>
</html>

