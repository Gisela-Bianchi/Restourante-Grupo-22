<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trabajo_Final.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 100%;
            overflow: hidden;
            background-image: url('https://i.pinimg.com/564x/e6/80/c1/e680c193340a4939786ae1609bcc2551.jpg'); /* Ruta a tu imagen de textura de madera */
            background-color: black; /* Cambia el color de fondo en caso de que la textura no cubra toda la pantalla */
        }

        .col-6 img {
            max-width: 100%;
            height: auto;
            border: 2px solid black;
        }

        .row {
            display: flex;
            align-items: center;
            justify-content: space-between;
            height: 100vh;
        }

        .form-label {
            color: white;
        }

         
        .btn-primary {
            background-color: #c0c0c0; /* Gris claro */
            color: black; /* Color de texto negro para contrastar */
        }

        .btn-primary:hover {
            background-color: #c0c0c0; /* Cambia el color al pasar el mouse sobre el botón */
            color: black;
        }
    </style>

    <div class="container">
        <div class="row">
            <div class="col-5">
                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label"><span style="font-weight: bold;">Usuario</span></label>
                    <asp:TextBox ID="TxtNombreUsuario" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="exampleInputPassword1" class="form-label"><span style="font-weight: bold;">Contraseña</span></label>
                    <asp:TextBox ID="TxtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnAceptar_Click" runat="server" />
            </div>
            <div class="col-6">
                <img src="https://i.pinimg.com/originals/c8/26/26/c82626763f4878a55276829af7115a3e.jpg" alt="Foto de comida" style="max-width: 65%; height: auto;">
            </div>
        </div>
    </div>
</asp:Content>
