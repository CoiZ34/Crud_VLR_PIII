<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto_Web_VLR.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <style>
        body{
            text-align:center;
            margin-top:10rem;
            font-size:2rem;
            padding-bottom:10px;
        }
        form{
            border:solid;
            margin-left:30%;
            margin-right:30%;
            padding-bottom:10px;
        }
        div{
            padding:5px;
        }
        .btn-login{
            margin-left:10%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login Form" ForeColor="#990000"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
         <div>
     <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
     <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button CssClass="btn-login" ID="Button1" runat="server" Text="Login" BackColor="#33CC33" ForeColor="White" Height="30px" Width="70px" OnClick ="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" ForeColor="White" BackColor="Red" Height="30px" Width="70px" OnClick ="Button1_Click" />
        </div>
        <div>
            <asp:Label ID="LabelMSJ" runat ="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
