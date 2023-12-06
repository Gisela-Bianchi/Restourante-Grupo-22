<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarMozo.aspx.cs" Inherits="Trabajo_Final.AgregarMozo" %>

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

    <h2>Agregar Mozo</h2>
       
                <center>


                        
                                                    
                            <div>   
                            <asp:Label class="text-dark" ID="lblNombre" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;"  placeholder="Nombre" ID="txtNombre" runat="server" ></asp:TextBox><br />                            
                            <asp:Label class="text-dark" ID="lblApellido" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtApellido"  placeholder="Apellido" runat="server"></asp:TextBox><br />      
                            <asp:Label class="text-dark" ID="lblDNI" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" placeholder="DNI" ID="txtDNI" runat="server" MaxLength="8" ></asp:TextBox><br />
                            <asp:Label class="text-dark" ID="lblTipoUsuario" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtTipoUsuario" placeholder="Tipo de Usuario" runat="server"></asp:TextBox><br /> 
                            <asp:Label class="text-dark" ID="lblEmail" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtEmail" placeholder="Email" runat="server" ></asp:TextBox><br />     
                            <asp:Label class="text-dark" ID="lblContra" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtContra" placeholder="Contraseña" runat="server" MaxLength="12"></asp:TextBox><br />     
                  
                            <asp:LinkButton ID="BtnAgregarMozo" runat="server" Text="Agregar Mozo" class="btn btn-secondary" OnClick="BtnAgregarMozo_Click"  OnClientClick="return confirm('¿Está seguro que desea agregar al mozo ?')"/>
                             <a class="btn btn-success text-light text-decoration-none" href="AdmiPersonal.aspx" style="margin-bottom: 2px;">Volver</a>
                                 
                                 
                            </div>
                            </center>      
                           
                           

   
</asp:Content>
