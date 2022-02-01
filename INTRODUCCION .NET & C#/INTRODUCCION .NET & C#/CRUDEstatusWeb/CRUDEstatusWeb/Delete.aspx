<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="CRUDEstatusWeb.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <br/>
    <strong><asp:Label ID="lblEliminar" runat="server" Text="ELIMINAR"></asp:Label></strong>
      <p>
          <a href="Index">INICIO</a>
        </p>
    <hr/>
    <asp:Label ID="lbldeleteId" runat="server" Text="Id"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtIdEliminar" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombreElim" runat="server"></asp:TextBox>
    <br/>
    <asp:Label ID="lblclave" runat="server" Text="Clave"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtClaveElimi" runat="server"></asp:TextBox>
    <br/>
    &nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="eliminarBoton" runat="server" Text="Eliminar" OnClick="eliminarBoton_Click" />
</asp:Content>
