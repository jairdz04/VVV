<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VentaVirtualDeVehiculos.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
          You are not logged in. Click the Login link to sign in. 
       </AnonymousTemplate>  
            <LoggedInTemplate>
                <span style="color: rgb(42, 42, 42); font-family: 'Segoe UI', 'Lucida Grande', Verdana, Arial, Helvetica, sans-serif; font-size: 13px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 18px; orphans: auto; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">Ya ha iniciado sesión. Bienvenido.</span>
            </LoggedInTemplate>
        </asp:LoginView>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Web/MembersPages/Members.aspx">Solo para miembros</asp:HyperLink>
    <div>
    
    </div>
        <asp:LoginName ID="LoginName1" runat="server" />
    </form>
</body>
</html>
