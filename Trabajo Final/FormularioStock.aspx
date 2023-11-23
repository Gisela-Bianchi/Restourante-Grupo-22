<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="FormularioStock.aspx.cs" Inherits="Trabajo_Final.FormularioStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <style>
            body {
                background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
                color: whitesmoke;
            }
        </style>

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

            <div class="col-md-6 mb-3">
                <label for="ddlTipo" class="form-label">Tipo:</label>
                <asp:DropDownList runat="server" ID="ddlTipo" CssClass="btn btn-outline-dark dropdown-toggle">
                </asp:DropDownList>
            </div>

            <div class="col-md-6 mb-3">
                <label for="ddlCategoria" class="form-label">Categoria:</label>
                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="btn btn-outline-dark dropdown-toggle">
                </asp:DropDownList>
            </div>


            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx">Cancelar</a>
            </div>


        </div>
    </div>


    <div class="row">
        <div class="col-6">

            <asp:UpdatePanel ID="UpDatePanel1" runat="server">
                <ContentTemplate>

                    <div class="mb-3">
                        <asp:Button Text="Eliminar" ID="btnEliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" runat="server" />
                    </div>
                    <% if (ConfirmarEliminacion)
                        { %>
                    <div class="mb-3">
                        <asp:CheckBox Text="Confirmar eliminacion" ID="ChkConfirmarEliminar" runat="server" />
                        <asp:Button Text="Eliminar" ID="btnConfirmarEliminar" OnClick="btnConfirmarEliminar_Click" CssClass="btn btn-outline-danger" runat="server" />

                    </div>
                    <% } %>
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>



    </div>
</asp:Content>
