<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="CRUDEstatusWeb.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <strong><asp:Label ID="labAgregar" runat="server" Text="AGREGAR"></asp:Label>
    <br />
    </strong>
        <br />
        <a href="Index">INICIO</a>
    <hr/>
    <asp:Label ID="lblid" runat="server" Text="Id"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtIdAgregar" runat="server" Width="120px"></asp:TextBox>
     <br/>
    <br/>
    <asp:Label ID="lblNom" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtNombreAgregar" runat="server" Width="129px"></asp:TextBox>
     <br/>
    <br/>
    <asp:Label ID="lblClav" runat="server" Text="Clave"></asp:Label>
    <asp:TextBox ID="txtClaveAgregar" runat="server" Width="152px"></asp:TextBox>
     <br/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
</asp:Content>
