<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="AdmiPersonal.aspx.cs" Inherits="Trabajo_Final.AdmiPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            background-color: lightslategray;
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

    <div class="row">
        <div class="col-10">
            <div>
                <h2> Meseros </h2>
                <asp:LinkButton Text="Agregar Mozo" CssClass="black-button" ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" />
                <center>
                    <table class="table">
                        <thead>
                            <tr>
                                <th scope="col">DNI</th>
                                <th scope="col">Nombre</th>
                                <th scope="col">Apellido</th>
                              
                                <th scope="col"></th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="rptMeseros" runat="server" OnItemCommand="rptMeseros_ItemCommand">
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("DNI ") %></td>
                                        <td><%# Eval("NombreMesero") %></td>
                                        <td><%# Eval("ApellidoMesero") %></td>
                                        
                                        <td>
                                            <asp:LinkButton CssClass="btn btn-success" ID="btnEditar" OnClick="btnEditar_Click" runat="server" CommandName="editar" CommandArgument='<%# Eval("DNI") %>'>
                                                <i class="bi bi-pencil-square"></i>
                                            </asp:LinkButton>
                                        </td>
                                        <td>
                                            <asp:LinkButton CssClass="btn btn-danger" ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" CommandName="eliminar" CommandArgument='<%# Eval("DNI") %>'>
                                                <i class="bi bi-trash3-fill"></i>
                                            </asp:LinkButton>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                    <a class="btn btn-success text-light text-decoration-none" href="Home.aspx" style="margin-bottom: 2px;">Volver</a>
                </center>
            </div>
        </div>
    </div>
</asp:Content>
