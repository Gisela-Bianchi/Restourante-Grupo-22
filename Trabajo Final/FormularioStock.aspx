<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioStock.aspx.cs" Inherits="Trabajo_Final.FormularioStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-6">

            <%--  <div class="mb-3">
                <label for="txtTipoInsumo" class="form-label">Tipo de Insumo</label>
                <asp:DropDownList ID="ddlTipoInsumo" CssClass="form-select" runat="server"></asp:DropDownList>
                  </div>--%>

            <div class="mb-3">
                <label for="txtIdInsumo" class="form-label">Id insumo</label>
                <asp:TextBox runat="server" ID="txtIdInsumo" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtNombreInsumo" class="form-label">Nombre de Insumo</label>
                <asp:TextBox runat="server" ID="txtNombreInsumo" CssClass="form-control" />

            </div>

            <div class="mb-3">
                <label for="txtCantidadStock" class="form-label">Cantidad Stock </label>
                <asp:TextBox runat="server" ID="textCantidadStock" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="textPrecioUnitario" class="form-label">Precio Unitario </label>
                <asp:TextBox runat="server" ID="textPrecioUnitario" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtIdTipo" class="form-label">Id tipo </label>
                <asp:TextBox runat="server" ID="txtIdTipo" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtNombreTipo" class="form-label">Nombre tipo </label>
                <asp:TextBox runat="server" ID="txtNombreTipo" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion tipo </label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtEstado" class="form-label">Estado </label>
                <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtIdCategoria" class="form-label">Id categoria </label>
                <asp:TextBox runat="server" ID="txtIdCategoria" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtDescripcionCategoria" class="form-label">Descripcion (categoria) </label>
                <asp:TextBox runat="server" ID="txtDescripcionCategoria" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>

        </div>
    </div>
</asp:Content>
