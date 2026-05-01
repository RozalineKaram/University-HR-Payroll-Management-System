<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_login.aspx.cs" Inherits="M3_team3.main_login" %>

   <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
    <link rel="stylesheet" href="style.css" />
</head>

<body>
    <form id="form1" runat="server">

        <div class="welcome-wrapper">
            <div class="welcome-box">

                <h1 class="welcome-title">Welcome to University Portal</h1>

                <p class="welcome-subtext">Please choose your department to continue</p>

                <div class="form-group">
                    <asp:RadioButtonList ID="Department_RadioButtonList1" runat="server" CssClass="pink-radio">
                        <asp:ListItem Text="Admin" Value="Admin" ></asp:ListItem>
                        <asp:ListItem Text="Academic" Value="Academic"></asp:ListItem>
                        <asp:ListItem Text="HR" Value="HR"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>

                <asp:Button 
                    ID="Button1" 
                    runat="server" 
                    Text="Continue" 
                    CssClass="welcome-button"
                    OnClick="continue_Click" />

            </div>
        </div>

    </form>
</body>
</html>
