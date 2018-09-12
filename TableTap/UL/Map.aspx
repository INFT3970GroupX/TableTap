<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="TableTap.UL.Map" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Detter er kart side
    <div class="container-fluid">
        <div class="jumbotron">
            
<h2> Choose a room or table by clicking the corresponding options in the layout below:</h2>
    <div id="holder"> 
        <ul  id="place">
            <asp:ImageMap ID="ImageMap1" runat="server" Height="220px" ImageUrl="~/Images/Room1.png"
                Width="420px">

                
            </asp:ImageMap>
        </ul>    
    </div>
    <div style="float:left;"> 
    <ul id="tableDescription">
        <li style="background:url('Images/Room1.png') no-repeat scroll 0 0 transparent;">Available Table</li>
        <li style="background:url('images/Room1.png') no-repeat scroll 0 0 transparent;">Booked Table</li>
        <li style="background:url('images/Room1.png') no-repeat scroll 0 0 transparent;">Selected Table</li>
    </ul>
    </div>
        <div style="clear:both;width:100%">
        &nbsp;           
        <asp:Button ID="bookTableBtn" runat="server" Text="Book Table" />
        </div>
        </div>

    </div>
</asp:Content>
