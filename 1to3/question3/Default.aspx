<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="question3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Convert F to C:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br>
    <asp:Label ID="Label2" runat="server" Text="result?"></asp:Label>
    <br>
    <asp:Label ID="Label3" runat="server" Text="Convert C to F:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
    <br>
    <asp:Label ID="Label4" runat="server" Text="result?"></asp:Label>

    

</asp:Content>
