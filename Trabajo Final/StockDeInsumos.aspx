<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockDeInsumos.aspx.cs" Inherits="Trabajo_Final.Insumos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col">

            <asp:GridView runat="server" ID="dgvInsumos" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>
              
                    <asp:BoundField HeaderText="Nombre" DataField="NombreInsumo" />
                    <asp:BoundField HeaderText="Precio Unitario" DataField="PrecioUnitario" />
                    <asp:BoundField HeaderText="Cantidad Stock" DataField="CantidadStock" />

                    <asp:BoundField HeaderText="Id (Tipo)" DataField="Tipo" />
                    <asp:BoundField HeaderText="Nombre (Tipo)" DataField="Tipo" />
                    <asp:BoundField HeaderText="Descripcion (Tipo)" DataField="Tipo" />

                    <asp:BoundField HeaderText="Estado" DataField="Tipo" />
                    <asp:BoundField HeaderText="Id (Categoria)" DataField="Descripcion" />

                </Columns>
            </asp:GridView>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Agregar Producto</a>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Modificar Producto</a>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block;">Eliminar Producto</a>




        </div>
    </div>


</asp:Content>
