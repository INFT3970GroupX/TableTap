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
                            <input type="email" class="form-control" name="username" id="txbUsername" runat="server"  placeholder="Enter email"/>
                            <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
							<asp:Button type="button" Text="Search" class="btn btn-primary btn-lg btn-block login-button" id="searchButton" onclick="searchButton_Click" runat="server" />

						</div>
                        
					</form>

                    <br />

                    <form class="form-horizontal" method="post" action="#">

<!-- !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  DISPLAY/EDIT TABlE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! --->                            

                    
                    <asp:Table ID="tblPrint" runat="server" BorderStyle="Solid" CellPadding="1" CellSpacing="1">
                        <asp:TableRow ID="Datatype" runat="server">
                          <asp:TableCell ID="Record" runat="server">Datatype</asp:TableCell>
                                <asp:TableCell runat="server">Record</asp:TableCell>
                        </asp:TableRow>

        
                        <asp:TableRow ID="TableRow1" runat="server">
                                <asp:TableCell ID="TableCell1" runat="server">
                                <asp:Label ID="lblLUserID" runat="server" Text="UserID"></asp:Label>
                                </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:Label ID="lblUserID" runat="server" Text="UserID"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>



                 <asp:TableRow ID="TableRow2" runat="server">

                         <asp:TableCell ID="TableCell2" runat="server">
                                   <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                          </asp:TableCell>
                            <asp:TableCell runat="server">
                                    <input type="email" class="form-control" name="username" id="Email" required="required"  runat="server"  placeholder="Enter email"/>
                           </asp:TableCell>

                </asp:TableRow>


                <asp:TableRow ID="TableRow3" runat="server">

                     <asp:TableCell ID="TableCell3" runat="server">
                         <asp:Label ID="lbl" runat="server" Text="Password"></asp:Label>
                     </asp:TableCell>
                     <asp:TableCell runat="server">
                         <input type="text" required="required" class="form-control" name="password" id="inPassword"  placeholder="Password"  runat="server"/>
                  
                    </asp:TableCell>

                </asp:TableRow>

                <asp:TableRow ID="TableRow4" runat="server">

                       <asp:TableCell ID="TableCell4" runat="server">
                           <asp:Label ID="Label2" runat="server" Text="Firstname"></asp:Label>
                       </asp:TableCell>
                      <asp:TableCell runat="server">
                           <input type="text" required="required" class="form-control" name="name" id="inFirstName"  placeholder="Firstname" runat="server"/>
                  
                       </asp:TableCell>

                 </asp:TableRow>

                  <asp:TableRow ID="TableRow5" runat="server">

                      <asp:TableCell ID="TableCell5" runat="server">
                         <asp:Label ID="Label3" runat="server" Text="Surname"></asp:Label>
                     </asp:TableCell>
                     <asp:TableCell runat="server">
                           <input type="text" required="required" class="form-control" name="name" id="inLastName"  placeholder="Surname" runat="server"/>
                  
                      </asp:TableCell>

                  </asp:TableRow>


                 <asp:TableRow ID="TableRow6" runat="server">

                       <asp:TableCell ID="TableCell6" runat="server">
                         <asp:Label ID="Label4" runat="server" Text="Administration privilege"></asp:Label>
                       </asp:TableCell>
                       <asp:TableCell runat="server">
                         <asp:CheckBox ID="chkAdmin" runat="server" />       
                      </asp:TableCell>

                 </asp:TableRow>






                 </asp:Table>
                        <br />

                        <asp:Button type="button" Text="Save" class="btn btn-primary btn-lg btn-block login-button" id="saveButton" onclick="saveButton_Click" runat="server" />
           
                        <asp:Label ID="lblSaveStatus" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </form>
                         <br />

                         <form class="form-horizontal" method="post" action="#">

                            <!--<asp:Button type="button" Text="Delete" class="btn btn-primary btn-lg btn-block login-button" ID="deleteButton" onclick="deleteButton_Click" runat="server" />-->
                             
                            

                         </form>
                         <br />
                    <asp:Button type="button" Text="Delete" class="btn btn-primary btn-lg btn-block login-button" ID="deleteButton2" onclick="deleteButton_Click" runat="server" />
                    <asp:Button type="button" Text="Cancel" class="btn btn-primary btn-lg btn-block login-button" ID="cancelButton" onclick="cancelButton_Click" runat="server" />
                    <asp:Button type="button" Text="MyButton" class="btn btn-primary btn-lg btn-block login-button" ID="Button1" onclick="myButton_Click" runat="server" />
                     
                    </div>
                 </div>
            </div>
        </div>

</asp:Content>
