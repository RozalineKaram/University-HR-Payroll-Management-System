<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="M3_team3.AdminLogin" %>

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
        <h2>Admin Login</h2>

        <asp:Label ID="Label4" runat="server" Text="Admin ID"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />

        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>


        <br />
        <br />


        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="LogIn" Width="85px" CssClass="login-button" />

        <!-- Your Back Button (now in the box) -->
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
     