<%@ Page Title="" Language="C#" MasterPageFile="~/UL/Site.Master" AutoEventWireup="true" CodeBehind="AdminEditUser.aspx.cs" Inherits="TableTap.UL.AdminEditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="jumbotron">
             <div class="row main">
				
				<div class="main-login main-center">
					<form class="form-horizontal" method="post" action="#">
                        <div class="panel-heading">
	                        <div class="panel-title text-center">
	               		    <h1 class="title">Edit User</h1>
	               		    <hr />
	               	        </div>
	                    </div> 
						

						<div class="form-group ">
                            <input type="email" class="form-control" name="username" id="txbUsername" required="required" runat="server"  placeholder="Enter email"/>
							<asp:Button type="button" Text="Search" class="btn btn-primary btn-lg btn-block login-button" id="submitButton" onclick="searchButton_Click" runat="server" />
						</div>

					</form>



                    <form class="form-horizontal" method="post" action="#">
                             <input type="email" class="form-control" name="username" id="Email1" required="required" runat="server"  placeholder="Enter email"/>
                    </form>
</asp:Content>
