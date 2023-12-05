<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="AdmiPersonal.aspx.cs" Inherits="Trabajo_Final.AdmiPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <div class="row">
        <div class="col-4">
            <h2>Administracion</h2>
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
            </div>

            <div class="mb-3">
                <label class="form-label">Contraseña</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TxtContraseña" TextMode="Password" />
            </div>
            <div class="mb-3">
                <label class="form-label">Tipo Usuario</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="TextTipoUsuario"  />
            </div>
            <asp:Button Text="Agregar" CssClass="btn btn-success" ID="btnLogin" OnClick="btnLogin_Click" runat="server" />
            <a href="AdmiPersonal.aspx"  style="margin-bottom: 10px; display: block; color : orange";>Cancelar</a>
        </div>
    </div>

</asp:Content>

