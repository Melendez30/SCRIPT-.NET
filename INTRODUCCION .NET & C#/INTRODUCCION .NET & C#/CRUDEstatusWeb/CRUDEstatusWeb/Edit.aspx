<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="CRUDEstatusWeb.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <strong><asp:Label ID="labAgregar" runat="server" Text="ACTUALIZAR"></asp:Label></strong>
      <p>
          <a href="Index">INICIO</a>
        </p>
    <hr/>
    <asp:Label ID="id" runat="server" Text="Id"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtidentificador" runat="server" Width="120px"></asp:TextBox>
     <br/>
    <br/>
    <asp:Label ID="nom" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server" Width="129px"></asp:TextBox>
     <br/>
    <br/>
    <asp:Label ID="clav" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClave" runat="server" Width="152px"></asp:TextBox>
     <br/>
    <br/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="guardarActualizar" runat="server" Text="Guardar" Width="87px" OnClick="guardarActualizar_Click" />
</asp:Content>
