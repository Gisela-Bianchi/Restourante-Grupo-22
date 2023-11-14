<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiTipoInsumo.aspx.cs" Inherits="Trabajo_Final.AdmiTipoInsumo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col">

            <asp:GridView runat="server" ID="dgvTipoInsumo" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
                <Columns>

                    <asp:BoundField HeaderText="Id" DataField="Id_TI" />
                    <asp:BoundField HeaderText="Nombre" DataField="NombreTipoInsumo" />
                    <asp:BoundField HeaderText="Descripcion" DataField="DescripcionTipoInsumo" />
                    <asp:BoundField HeaderText="Estado" DataField="EstadoTipoInsumo" />




                </Columns>
            </asp:GridView>

            <a href="FormularioTipoInsumo.aspx" style="margin-bottom: 10px; display: block;">Agregar Tipo de insumo</a>

            <a href="AdmiTipoInsumo.aspx" style="margin-bottom: 10px; display: block;">Modificar Tipo de insumo</a>

            <a href="AdmiTipoInsumo.aspx" style="margin-bottom: 10px; display: block;">Eliminar Tipo de insumo</a>


        </div>
    </div>

</asp:Content>
