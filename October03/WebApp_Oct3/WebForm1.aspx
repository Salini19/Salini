<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp_Oct3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Label1" runat="server" Text="Enter Userid:"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
<p>
    <asp:Label ID="Label2" runat="server" Text="Enter Password:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
</p>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Message"></asp:Label>
</asp:Content>
