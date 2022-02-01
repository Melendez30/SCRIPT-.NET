<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUDEstatusWeb.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <br>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Label ID="txtIndice" runat="server" Text="INDICE"></asp:Label>
    <hr/>
    <asp:DropDownList ID="ddlEstatus" runat="server" OnSelectedIndexChanged="listEstatus_SelectedIndexChanged"></asp:DropDownList>
    <hr/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="txtAgregar" runat="server" Text="Agregar" OnClick="txtAgregar_Click"/>
    <asp:Button ID="txtDetalles" runat="server" Text="Detalles" OnClick="txtDetalles_Click" />
    <asp:Button ID="txtEdita" runat="server" Text="Edita" OnClick="txtEdita_Click" />
    <asp:Button ID="txtEliminar" runat="server" Text="Eliminar" OnClick="txtEliminar_Click" />
</asp:Content>
