<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class = "form-horizontal">
    	<h2>Datos del Alumno</h2>         
		<br/>
	<dl class="dl-horizontal">
	
        <dt>
			id
		</dt>
        
		<dd>
			<asp:Label ID="lblid" runat="server" Text=""></asp:Label>
		</dd>   

		 <dt>
			Nombre
		</dt>
        
		<dd>
			<asp:Label ID="lblNom" runat="server" Text=""></asp:Label>
		</dd>   

		 <dt>
			Primer Apellido
		</dt>
        
		<dd>
			<asp:Label ID="lblPriApe" runat="server" Text=""></asp:Label>
		</dd>   

		<dt>
			Segundo Apellido
		</dt>
        
		<dd>
			<asp:Label ID="lblSegApe" runat="server" Text=""></asp:Label>
		</dd>  
     
			<dt>
			Fecha de Nacimiento
		</dt>
        
		<dd>
			<asp:Label ID="lblFech" runat="server" Text=""></asp:Label>
		</dd>  
     
			<dt>
			CURP
		</dt>

		<dd>
			<asp:Label ID="lblCurp" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Correo
		</dt>
        
		<dd>
			<asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Telefono
		</dt>
        
		<dd>
			<asp:Label ID="lblTel" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Estado
		</dt>
        
		<dd>
			<asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>
		</dd> 
		
		<dt>
			Estatus
		</dt>
        
		<dd>
			<asp:Label ID="lblEstatus" runat="server" Text=""></asp:Label>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		</dd>  
     
    </dl>
		<div class="form-group">
		<div class="col-md-2">
			<a href="Index.aspx">Regresar a la lista</a>
		</div>
	</div>
	<div class="form-group">
		<div class="col-md-offset-2 col-md-2">
		</div>
	</div>	
</div>
  
</asp:Content>


