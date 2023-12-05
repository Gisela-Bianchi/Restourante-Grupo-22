<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarMozo.aspx.cs" Inherits="Trabajo_Final.ModificarMozo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <%-- ESTRUCTURA DEL FORMULARIO--%>
    <style>
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }

        .black-button {
            background-color: black;
            color: white;
            border: none;
            padding: 5px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            margin: 4px 2px;
            cursor: pointer;
        }
    </style>

    <h2>Meseros</h2>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">DNI</th>
                <th scope="col">Nombre</th>
                <th scope="col">Apellido</th>
                <th scope="col">Contraseña</th>
                <th scope="col">Acciones</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="rptMeseros" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Dni") %></td>
                        <td><%# Eval("Nombre") %></td>
                        <td><%# Eval("Apellido") %></td>
                        <td><%# Eval("Contraseña") %></td>
                        <td>
                           
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>

    <!-- Botón "Agregar Mozo" fuera de la tabla -->
    <asp:Button ID="btnModificarMozo" CssClass="black-button" runat="server" Text="Modificar" OnClick="btnModificarMozo_Click" />
    <a href="ModificarMozo.aspx" style="margin-bottom: 10px; display: block; color: orange">Cancelar</a>
</asp:Content>


