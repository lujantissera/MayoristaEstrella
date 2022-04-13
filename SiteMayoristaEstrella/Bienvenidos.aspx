<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bienvenidos.aspx.cs" Inherits="SiteMayoristaEstrella.Bienvenidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bienvenidos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Bienvenidos a .Net</h1>
            <asp:Label ID="lblBienvenidos" runat="server"  BackColor="#CC33FF" Font-Italic="True" 
                ForeColor="#FFFF99" Text="Controles html y controles de servidor ASP.NET"></asp:Label>

            <div>
                <asp:Label Text="Ingrese su nombre" runat="server" />
                <asp:TextBox ID="txtNombre" runat="server" />
            </div>


            <asp:Button Text="Mostrar" ID="btnMostrar" OnClick="btnMostrar_Click" runat="server" />
        </div>
    </form>
</body>
</html>
