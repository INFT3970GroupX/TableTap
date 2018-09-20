<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="TesterHeaderPage.aspx.cs" Inherits="TableTap.UL.TesterHeaderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="test1" runat="server" Text="Hayden Testing Page" OnClick="test1_Click" />
    <asp:Button ID="test2" runat="server" Text="Beau test page" OnClick="test2_Click" />
    <asp:Button ID="test3" runat="server" Text="admin home page" OnClick="test3_Click" />
    <asp:Button ID="test4" runat="server" Text="Button" OnClick="test4_Click" />
</asp:Content>

