<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioTipoInsumo.aspx.cs" Inherits="Trabajo_Final.FormularioTipoDeInsumo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%-- ESTRUCTURA DEL FORMULARIO--%>


    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label for="txtIdTipoInsumo" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtIdTipoInsumo" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtNombreTipo" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombreTipo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcionTipo" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcionTipo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtEstado" class="form-label">Estado</label>
                <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
