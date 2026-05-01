<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medical_leave_submission.aspx.cs" Inherits="M3_team3.medical_leave_submission" %>

<!DOCTYPE html>
     <link rel="stylesheet" href="style.css" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css" />
<link href="https://fonts.googleapis.com/css2?family=Quicksand:wght@300;400;500;600;700&display=swap" rel="stylesheet">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Medical Leave Request</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="leave-page-wrapper">
            <div class="leave-card">
                <asp:Label ID="Label8" runat="server" Text="Medical Leave Request" Font-Bold="true" Font-Size="Large"></asp:Label>
                <br /><br />

                <!-- Message Label -->
                <asp:Label ID="lblMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>

                <br />
                <br />

                <asp:Label ID="Label1" runat="server" Text="Start Date"></asp:Label>
                &nbsp;<asp:TextBox ID="med_sub_Start_date" runat="server" TextMode="Date"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label2" runat="server" Text="End Date"></asp:Label>
                &nbsp;
                <asp:TextBox ID="med_sub_End_date" runat="server" TextMode="Date"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label3" runat="server" Text="Medical Type"></asp:Label>
                <asp:RadioButtonList ID="Medical_type_RadioButtonList" runat="server">
                    <asp:ListItem Text="Sick" Value="sick"></asp:ListItem>
                    <asp:ListItem Text="Maternity" Value="maternity"></asp:ListItem>
                </asp:RadioButtonList>
                <br />

                <asp:Label ID="Label4" runat="server" Text="Insurance Status"></asp:Label>
                <asp:RadioButtonList ID="Insurance_status_RadioButtonList" runat="server">
                    <asp:ListItem Text="Active" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Inactive" Value="0"></asp:ListItem>
                </asp:RadioButtonList>
                <br />

                <asp:Label ID="Label5" runat="server" Text="Disability Details"></asp:Label>
                &nbsp;<asp:TextBox ID="med_sub_disability_details" runat="server"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label6" runat="server" Text="Document Description"></asp:Label>
                &nbsp;<asp:TextBox ID="med_sub_document_description" runat="server"></asp:TextBox>
                <br /><br />

                <asp:Label ID="Label7" runat="server" Text="File Name"></asp:Label>
                &nbsp;<asp:TextBox ID="med_sub_file_name" runat="server"></asp:TextBox>
                <br /><br />

                <asp:Button ID="med_sub_Button1" runat="server" Text="Submit" CssClass="leave-btn" OnClick="med_sub_Button1_Click" />
                <br /><br />

                <asp:Button ID="Button2" runat="server" Text="Back" 
                            
                            OnClientClick="history.go(-1); return false;" 
                             
                             CssClass="leave-btn leave-back-btn"  />
            </div>
        </div>
    </form>
</body>
</html>
