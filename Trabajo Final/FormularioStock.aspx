<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioStock.aspx.cs" Inherits="Trabajo_Final.FormularioStock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="class-6">

          <%--  <div class="mb-3">
                <label for="txtTipoInsumo" class="form-label">Tipo de Insumo</label>
                <asp:DropDownList ID="ddlTipoInsumo" CssClass="form-select" runat="server"></asp:DropDownList>
                  </div>--%>

                <div class="mb-3">
                    <label for="txtId" class="form-label">Id</label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
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
                        <label for="txtdescripcion" class="form-label">Descripcion</label>
                        <asp:TextBox runat="server" TextMode="MultiLine" ID="txtdescripcion" CssClass="form-control" />
                          </div>

                        <div class="mb-3">
                            <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                            <a href="Default.aspx">Cancelar</a>
                        </div>

                    </div>
                </div>
</asp:Content>
