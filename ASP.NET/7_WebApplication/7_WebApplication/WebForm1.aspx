<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="WebForm1.aspx.cs" Inherits="_7_WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
         <div class="jumbotron">
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Get" Width="100" BackColor="#f9bdec" runat="server" OnClick="Button1_Click" Text="Get" />
       
    </div>

    </form>
    
</body>
</html>

