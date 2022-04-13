<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rubros.aspx.cs" Inherits="SiteMayoristaEstrella.Rubros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
        <h1>Rubros</h1>
            <asp:GridView ID="gridRubrosList" runat="server" OnRowDataBound="gridRubrosList_RowDataBound"
                CellPadding="4" ForeColor="#333333" GridLines="Both" AutoGenerateColumns="False">
             <AlternatingRowStyle  BackColor="White" ForeColor="#284775" />
             <Columns>
                 <asp:BoundField DataField="IdRubro" HeaderText="Código" />
                 <asp:BoundField DataField="DescripcionRubro" HeaderText="Descripción" />
             </Columns>
             <EditRowStyle BackColor="#999999" />
             <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="False" ForeColor="#333333" />
             <SortedAscendingCellStyle BackColor="#E9E7E2" />
             <SortedAscendingHeaderStyle BackColor="#506C8C" />
             <SortedDescendingCellStyle BackColor="#FFFDF8" />
             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    </div>
</asp:Content>
