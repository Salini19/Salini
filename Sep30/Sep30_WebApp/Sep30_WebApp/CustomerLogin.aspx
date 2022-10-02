<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerLogin.aspx.cs" Inherits="Sep30_WebApp.CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                                  
            <asp:Label runat="server" Text="Enter FirstName :" ID="lblfirstname"></asp:Label> &nbsp
            <asp:TextBox runat="server" ID="txtfirstname"></asp:TextBox>
            
            
            <br />
            <br />
            Enter LastName         :
            <asp:TextBox runat="server" ID="txtlastname"></asp:TextBox>
            <br />
            <br />
            Select your DateofBirth:
            
            <asp:Calendar runat="server" OnSelectionChanged="Unnamed3_SelectionChanged" ID="calDOB"></asp:Calendar>
            <br />
            SelectedDate :
           
            <asp:Label runat="server" ID="lbldate"></asp:Label>
            <br />
            <br />
            Enter Your City : <asp:TextBox runat="server" ID="txtcity"></asp:TextBox>
            <br />
            <br />
            Enter Your State : <asp:TextBox runat="server" ID="txtstate"></asp:TextBox>
             <br />
            <br />
            <asp:Button runat="server" Text="Submit" OnClick="Unnamed1_Click" ID="btnsubmit"></asp:Button>
            <br />
            <asp:Label runat="server" Text="Label" ID="lblsucess"></asp:Label>
            <br />
            <asp:LinkButton runat="server" Text="Click here" PostBackUrl="~/Welcome.aspx" ID="linkbutton">LinkButton</asp:LinkButton>
        </div>
    </form>
</body>

</html>
