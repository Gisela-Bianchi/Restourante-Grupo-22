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

           .btn-containerPerfil {
            position: absolute;
            top: 20%;
            left: 20%;
            
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


        <div class="btn-containerPerfil">
         
            <% if (Session["Usuario"] != null)
            { %>
                        <h2>Datos de usuario</h2>
       
                       <center>


                        
                                                    
                            <div>   
                            <asp:Label class="text-dark" ID="lblNombre" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;"   ID="txtNombre" runat="server" ReadOnly="true" ></asp:TextBox><br />                            
                            <asp:Label class="text-dark" ID="lblApellido" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtApellido"  runat="server" ReadOnly="true"></asp:TextBox><br />      
                            <asp:Label class="text-dark" ID="lblDNI" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;"  ID="txtDNI" runat="server" ReadOnly="true"></asp:TextBox><br />
                            <asp:Label class="text-dark" ID="lblTipoUsuario" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtTipoUsuario"  runat="server" MaxLength="1" ReadOnly="true"></asp:TextBox><br /> 
                            <asp:Label class="text-dark" ID="lblEmail" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtEmail"  runat="server" MaxLength="12" ReadOnly="true"></asp:TextBox><br />     
                                                            
                                 
                            </div>
                            </center>    
            <% } %>
        </div>
   
    </div>
</asp:Content>
