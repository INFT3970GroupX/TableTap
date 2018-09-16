<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="Map.aspx.cs" Inherits="TableTap.UL.Map" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Detter er map side
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
    <div class="container-fluid">
        <div class="jumbotron">
            <h2> Beau's table list</h2>

            <div class="form-group">
					<label for="name" class="cols-sm-2 control-label">Select Building:</label>
					<div class="cols-sm-10">
						<div class="input-group">
							<span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
							<asp:DropDownList runat="server" ID="buildingDropdown" ></asp:DropDownList>
						</div>
					</div>
			</div>

            <div class="form-group ">
					<asp:Button type="button" Text="Go to buidling" class="btn btn-primary btn-lg btn-block login-button" id="goToBuildingButton" onclick="goToBuildingButton_Click" runat="server" />
			</div>

        </div>
    </div>

</asp:Content>
