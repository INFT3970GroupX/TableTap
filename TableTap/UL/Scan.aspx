<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="Scan.aspx.cs" Inherits="TableTap.UL.Scan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="jumbotron">
            <h1>Scanning button will go here, it opens your camera to scan</h1>
			<asp:Button id="btnReserve" Text="Reserve Table" OnClick="btnReserve_Click" runat="server" />
        </div>

    </div>
</asp:Content>
