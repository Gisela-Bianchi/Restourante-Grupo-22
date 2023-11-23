<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiTipoInsumo.aspx.cs" Inherits="Trabajo_Final.AdmiTipoInsumo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }
    </style>

    <div class="row">
        <div class="col">

            <asp:GridView runat="server" ID="dgvTipoInsumo" CssClass="table table-dark table-bordered"
                AutoGenerateColumns="false" DataKeyNames="Id_TI" OnSelectedIndexChanged="dgvTipoInsumo_SelectedIndexChanged"
                OnPageIndexChanging="dgvTipoInsumo_PageIndexChanging" AllowPaging="true" PageSize="5">
                <Columns>

                    <asp:BoundField HeaderText="Id" DataField="Id_TI" />
                    <asp:BoundField HeaderText="Nombre" DataField="NombreTipoInsumo" />
                    <asp:BoundField HeaderText="Descripcion" DataField="DescripcionTipoInsumo" />
                    <asp:BoundField HeaderText="Estado" DataField="EstadoTipoInsumo" />
                    <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="Modificar" />




                </Columns>
            </asp:GridView>

            <a href="FormularioTipoInsumo.aspx" style="margin-bottom: 10px; display: block; color : greenyellow;">Agregar Tipo de insumo</a>



        </div>
    </div>

</asp:Content>
