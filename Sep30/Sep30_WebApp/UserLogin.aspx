<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Sep30_WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                <asp:Label runat="server" Text="Enter UserName :" ID="lblUSerName"></asp:Label>
            &nbsp

            <asp:TextBox runat="server" ID="txtusername"></asp:TextBox>
     
            
                   <br />
            <br />
          <asp:Label runat="server" Text="Enter Password : " ID="lblpassword"></asp:Label>
            &nbsp

            <asp:TextBox runat="server" TextMode="Password" ID="txtpassword"></asp:TextBox>
            <br />
            <asp:Label runat="server" ID="lblmessage" Visible="True" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </div>
    </form>

</body>


</html>
