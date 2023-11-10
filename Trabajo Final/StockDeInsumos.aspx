<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockDeInsumos.aspx.cs" Inherits="Trabajo_Final.Insumos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col">

            <asp:GridView runat="server" ID="dgvInsumos" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="TipoDeInsumo" DataField="TipoDeInsumo" />
                    <asp:BoundField HeaderText="Id" DataField="Id" />
                    <asp:BoundField HeaderText="NombreInsumo" DataField="NombreInsumo" />
                    <asp:BoundField HeaderText="CantidadStock" DataField="CantidadStock" />
                    <asp:BoundField HeaderText="PrecioUnitario" DataField="PrecioUnitario" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />

                </Columns>
            </asp:GridView>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Agregar Producto</a>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Modificar Producto</a>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Eliminar Producto</a>




        </div>
    </div>


</asp:Content>
