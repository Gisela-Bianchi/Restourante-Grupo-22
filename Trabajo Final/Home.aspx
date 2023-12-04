<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Trabajo_Final.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        h1 {
            font-family: 'TuFuentePersonalizada', sans-serif;
        }

        .content-container {
            position: relative;
            text-align: center;
        }

        #background-image {
            width: 100%;
            height: auto;
            margin-right: auto;
            margin-left: auto;
            display: block;
        }

        .btn-container {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
        }

        .btn {
            background-color: black;
            color: white;
            padding: 10px 20px;
            font-size: 16px;
            transition: background-color 0.3s ease;
        }

        .btn:hover {
            background-color: #333;
        }
    </style>

    <div class="content-container">
        <h1>BIENVENIDO</h1>
        <img id="background-image" src="https://i.pinimg.com/originals/1a/45/1c/1a451c2844826c3691ee80512e9e1166.jpg" alt="Imagen de fondo" />

        <div class="btn-container">
            <asp:Button ID="btnMozo" runat="server" Text="Ingrese Mozo" OnClick="btnMozo_Click" CssClass="btn" />
            <% if (Session["Usuario"] != null && ((Dominio.Usuario)Session["Usuario"]).TipoUsuario == 2)
            { %>
                <asp:Button ID="btnGerente" runat="server" Text="Ingrese Gerente" OnClick="btnGerente_Click" CssClass="btn" />
            <% } %>
        </div>
    </div>
</asp:Content>
