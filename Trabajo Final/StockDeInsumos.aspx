<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StockDeInsumos.aspx.cs" Inherits="Trabajo_Final.Insumos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }
    </style>

    <h1>Lista de insumos</h1>

    <div class="row">
        <div class="col-6">

            <div class="mb-3">
                <asp:Label Text="Filtrar" runat="server" />
                <asp:TextBox runat="server" ID="txtFiltro" CssClass="form-control" AutoPostBack="true" OnTextChanged="Filtro_TextChanged" />
            </div>
        </div>
    </div>


    <div class="row">
        <div class="col">

            <asp:GridView runat="server" ID="dgvInsumos" CssClass="table table-dark table-bordered" DataKeyNames="IdInsumo" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvInsumos_SelectedIndexChanged" OnPageIndexChanging="dgvInsumos_PageIndexChanging" PageSize="5">
                <Columns>


                    <asp:BoundField HeaderText="Id" DataField="IdInsumo" />
                    <asp:BoundField HeaderText="Nombre" DataField="NombreInsumo" />
                    <asp:BoundField HeaderText="Precio Unitario" DataField="PrecioUnitario" />
                    <asp:BoundField HeaderText="Cantidad Stock" DataField="CantidadStock" />

                    <asp:BoundField HeaderText="Id " DataField="Tipo.Id_TI" />

                    <asp:BoundField HeaderText="Nombre (Tipo)" DataField="Tipo.NombreTipoInsumo" />

                    <asp:BoundField HeaderText="Descripcion (Tipo)" DataField="Tipo.DescripcionTipoInsumo" />

                    <asp:BoundField HeaderText="Estado" DataField="Tipo.EstadoTipoInsumo" />

                    <asp:BoundField HeaderText="Id categoria" DataField="Descripcion.Id_Categoria" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion.Descripcion_Categoria" />
                    <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="Modificar" />

                </Columns>
            </asp:GridView>

            <a href="FormularioStock.aspx" style="margin-bottom: 10px; display: block; color: greenyellow;">Agregar Producto</a>






        </div>
    </div>


</asp:Content>
