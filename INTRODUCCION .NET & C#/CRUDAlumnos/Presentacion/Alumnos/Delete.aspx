<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
	<h2>Eliminar Alumno</h2>        
	    <hr/>
	<h4>¿Esta seguro que desea eliminar al Alumno?</h4>   
		<br/>
	<dl class="dl-horizontal">
	
        <dt>
			id
		</dt>
        
		<dd>
			<asp:Label ID="lblidElim" runat="server" Text=""></asp:Label>
		</dd>   

		 <dt>
			Nombre
		</dt>
        
		<dd>
			<asp:Label ID="lblNomElim" runat="server" Text=""></asp:Label>
		</dd>   

		 <dt>
			Primer Apellido
		</dt>
        
		<dd>
			<asp:Label ID="lblPriApeElim" runat="server" Text=""></asp:Label>
		</dd>   

		<dt>
			Segundo Apellido
		</dt>
        
		<dd>
			<asp:Label ID="lblSegApeElim" runat="server" Text=""></asp:Label>
		</dd>  
     
			<dt>
			Fecha de Nacimiento
		</dt>
        
		<dd>
			<asp:Label ID="lblFechElim" runat="server" Text=""></asp:Label>
		</dd>  
     
			<dt>
			CURP
		</dt>

		<dd>
			<asp:Label ID="lblCurpElim" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Correo
		</dt>
        
		<dd>
			<asp:Label ID="lblCorreElim" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Telefono
		</dt>
        
		<dd>
			<asp:Label ID="lblTelElim" runat="server" Text=""></asp:Label>
		</dd>  

		<dt>
			Estado
		</dt>
        
		<dd>
			<asp:Label ID="lblEstadoElim" runat="server" Text=""></asp:Label>
		</dd> 
		
		<dt>
			Estatus
		</dt>
        
		<dd>
			<asp:Label ID="lblEstatusElim" runat="server" Text=""></asp:Label>
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		</dd>  

		</dl>
		<br>

    <div class="form-group">
		<div class="col-md-2">
			<a href="Index.aspx">Regresar a la lista</a>
		</div>
	</div>

	<div class="form-group">
		<div class="col-md-offset-2 col-md-2">
		</div>
	</div>	


    <asp:Button ID="btnGuardar" runat="server" Text="Eliminar" OnClick="Eliminar_Click" CssClass="btn btn-default"/> 

</asp:Content>


