﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="Scan.aspx.cs" Inherits="TableTap.UL.Scan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="jumbotron">
            <h1>Scanning button will go here, it opens your camera to scan</h1>

            <div class="booth">
                <video id="video" width="400" height="300">

                </video>
            </div>

            <script src="js/photo.js"></script>

            <asp:Button id="btnReserve" Text="Reserve Table" OnClick="btnReserve_Click" runat="server" />
            <asp:TextBox ID="textBox2" runat="server" />
        </div>

    </div>
</asp:Content>
