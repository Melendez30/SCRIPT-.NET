<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Agregar Alumno</h2>
    <hr />
    <div class="form-group">

        <div>
       <label for="lblNomreAgr" class="control-label col-md-2">Nombre</label>
       <asp:TextBox ID="txtNomreAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNomreAgr" Display="Dynamic" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>
        
        <div>
       <label for="lblPriApellAgr" class="control-label col-md-2">Primer Apellido</label>
       <asp:TextBox ID="txtPriApellAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPriApellAgr" Display="Dynamic" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>

        <div>
       <label for="lblSegApellAgr" class="control-label col-md-2">Segundo Apellido</label>
       <asp:TextBox ID="txtSegApellAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblFechAgr" class="control-label col-md-2">Fecha de Nacimiento</label>
       <asp:TextBox ID="txtFechAgr" TextMode="Date" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFechAgr" Display="Dynamic" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFechAgr" Display="Dynamic" ErrorMessage="FUERA DEL RANGO" ForeColor="#FF6600" MaximumValue="31-12-2000" MinimumValue="01-01-1990" Type="Date"></asp:RangeValidator>
        <br/>

        <div>
       <label for="lblCurpAgr" class="control-label col-md-2">CURP</label>
       <asp:TextBox ID="txtCurpAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCurpAgr" Display="Dynamic" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCurpAgr" Display="Dynamic" ErrorMessage="FORMATO INVALIDO" ForeColor="#FF5050" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>
        <br/>

        <div>
       <label for="lblCorrAgr" class="control-label col-md-2">Correo</label>
       <asp:TextBox ID="txtCorrAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCorrAgr" Display="Dynamic" EnableTheming="True" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>

        <div>
       <label for="lblTelAgr" class="control-label col-md-2">Teléfono</label>
       <asp:TextBox ID="txtTelAgr" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTelAgr" Display="Dynamic" ErrorMessage="CAMPO OBLIGATORIO" ForeColor="Red"></asp:RequiredFieldValidator>
        <br/>

        <div>
       <label for="lblEstAgr" class="control-label col-md-2">Estado</label>
            <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
        </div>
        <br/>

        <div>
       <label for="lblEstatusAgre" class="control-label col-md-2">Estatus</label>
            <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>
        </div>
        <br/>

    </div>
       	<br>
     <strong>
         <h4>
             <a href="Index.aspx">Inicio</a>
         </h4>
     </strong>
		<br>
		<br>
    
    <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick ="Button1_Click" CssClass = "btn btn-default"/>
</asp:Content>
