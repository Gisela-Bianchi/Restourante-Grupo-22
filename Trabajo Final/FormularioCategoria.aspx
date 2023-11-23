<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCategoria.aspx.cs" Inherits="Trabajo_Final.FormularioCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <style>
    body {
        background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
        color: whitesmoke;
    }
</style>
    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <label for="txtIdCategoria" class="form-label">Id Categoria</label>
                <asp:TextBox runat="server" ID="txtIdCategoria" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="Default.aspx"  style="margin-bottom: 10px; display: block; color : orange";>Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
