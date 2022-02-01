<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="CRUDEstatusWeb.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <strong><asp:Label ID="lblDetalles" runat="server" Text="DETALLES"></asp:Label></strong>
    <br/>
        <p>
          <a href="Index">INICIO</a>
        </p>
    <hr/>
    <asp:Label ID="lblDetallesId" runat="server" Text="Id"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server" OnTextChanged="txtID_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblDetallesNombre" runat="server" Text="Nombre"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
    <br />
    <asp:Label ID="lblDetallesclave" runat="server" Text="Clave"></asp:Label>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtClave" runat="server" OnTextChanged="txtClave_TextChanged"></asp:TextBox>

</asp:Content>
