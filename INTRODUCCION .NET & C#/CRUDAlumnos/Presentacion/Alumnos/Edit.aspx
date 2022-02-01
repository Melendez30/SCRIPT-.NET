<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Editar Alumno</h2>
    <hr />
    <div class="form-group">

         <div>
       <label for="lbIdEdi" class="control-label col-md-2">ID</label>
       <asp:TextBox ID="txtdEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblNomreEdi" class="control-label col-md-2">Nombre</label>
       <asp:TextBox ID="txtNomreEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>
        
        <div>
       <label for="lblPriApellEdi" class="control-label col-md-2">Primer Apellido</label>
       <asp:TextBox ID="txtPriApellEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblSegApellEdi" class="control-label col-md-2">Segundo Apellido</label>
       <asp:TextBox ID="txtSegApellEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblFechEdi" class="control-label col-md-2">Fecha de Nacimiento</label>
       <asp:TextBox ID="txtFechEdi" TextMode="Date" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblCurpEdi" class="control-label col-md-2">CURP</label>
       <asp:TextBox ID="txtCurpEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblCorrEdi" class="control-label col-md-2">Correo</label>
       <asp:TextBox ID="txtCorrEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblTelEdi" class="control-label col-md-2">Teléfono</label>
       <asp:TextBox ID="txtTelEdi" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <br/>

        <div>
       <label for="lblEstEdi" class="control-label col-md-2">Estado</label>
            <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
        </div>
        <br/>

        <div>
       <label for="lblEstatusEdi" class="control-label col-md-2">Estatus</label>
            <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>
        </div>
        <br/>

        <div class="form-group">
                <div>
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="ButtonActualizar_Click" CssClass="btn btn-default"/> 
                </div>
            </div>

            <div class="form-group">
                <div>
                    <a href="Index.aspx">Regresar a la lista</a>
                </div>
            </div>  
        </div>
 
</asp:Content>
