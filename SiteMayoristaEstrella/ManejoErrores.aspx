<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManejoErrores.aspx.cs" Inherits="SiteMayoristaEstrella.ManejoErrores1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Administracion de Errores</h1>
            <h2>Ejecutar sin debub (Ctrol+F5)</h2>

            <asp:Button Text="Error a nivel pagina sin capturar con try/catch" OnClick="btnSinTryCatch_Click" ID="btnSinTryCatch" runat="server" />
            <asp:Button Text="Error a nivel pagina con capturar con try/catch" OnClick="btnConTryCatxh_Click" ID="btnConTryCatxh" runat="server" />
               <asp:Button Text="Error a nivel IIS / recurso no encontrado" OnClick="btnErrorRecursoNoEncontrado_Click" ID="btnErrorRecursoNoEncontrado" runat="server" />
            <div>   
                <asp:Label Text="" id="lblMensaje" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
