<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="Trabajo_Final.Ingreso" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Título de tu página</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            background: url('https://i.pinimg.com/originals/9e/ea/ee/9eeaee46c11fc28e5308455013f671d2.jpg') no-repeat center center fixed;
            background-size: cover;
            display: flex;/*centra vertical y horizontalmente*/
            align-items: center;
            justify-content: center;
            height: 100vh;
        }

        #formContainer {/*contenedor adicional*/
            background-color: rgba(255, 255, 255, 0); /* Fondo semi-transparente */
            padding: 20px;
            border-radius: 10px;
            text-align: center;
        }

        h1 {
            color: #333; /* Color del texto */
        }

        .btn {
            margin: 10px;
            padding: 15px 30px;
            font-size: 18px;
            font-weight: bold; /* Texto en negrita */
            background-color: silver; /* Fondo plateado */
            border: 1px solid #999; /* Borde del botón */
            border-radius: 5px; /* Bordes redondeados */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="formContainer">
            <h1>BIENVENIDO</h1>
            <asp:Button ID="btnMozo" runat="server" Text="Ingrese Mozo" OnClick="btnMozo_Click" CssClass="btn" />
            <asp:Button ID="btnGerente" runat="server" Text="Ingrese Gerente" OnClick="btnGerente_Click" CssClass="btn" />
        </div>
    </form>
</body>
</html>
