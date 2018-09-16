<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HaydenTestingPage.aspx.cs" Inherits="TableTap.UL.HaydenTestingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="email" class="form-control" name="email" id="inEmail"  placeholder="Enter your Email" required="required" runat="server"/>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</body>
</html>
