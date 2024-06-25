<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 766px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server" style="background-image: url('image/20498320_a8dr_05f3_210816.jpg'); " class="auto-style1">
        <asp:Label ID="Label3" runat="server" Text="firstname"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="lastname"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="username"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="confirmpassword "></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="gender"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="asd" Text="male"/>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="asd" Text="female" />
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="country"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>india</asp:ListItem>
                <asp:ListItem>russia</asp:ListItem>
                <asp:ListItem>canada</asp:ListItem>
                <asp:ListItem>usa</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="language"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="hindi" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="english" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="odia" />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="telugu" />
        </p>
        <p>
            <asp:Label ID="Label11" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label12" runat="server" Text="address"></asp:Label>
            <asp:TextBox ID="TextBox11" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label13" runat="server" Text="phonenumber"></asp:Label>
            <asp:TextBox ID="TextBox9" runat="server" TextMode="Phone"></asp:TextBox>
        </p>
&nbsp;
        <asp:Label ID="Label14" runat="server" Text="age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Height="48px" Width="114px" />
    </form>
  
        
</body>
</html>
