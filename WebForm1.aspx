<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_46.MasterPages.WebForm1" %>


<%@ MasterType VirtualPath="~/Site.Master"  %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <h1>This is WebForm1 content</h1>

    <b>Please Enter some Text</b>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Set Text" OnClick="Button1_Click" />

</asp:Content>
