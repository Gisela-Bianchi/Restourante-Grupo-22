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

   <h2>Modificar Mozo</h2>
       
                <center>


                        
                                                    
                            <div>   
                            <asp:Label class="text-dark" ID="lblNombre" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;"  placeholder="Nombre" ID="txtNombre" runat="server" ></asp:TextBox><br />                            
                            <asp:Label class="text-dark" ID="lblApellido" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtApellido"  placeholder="Apellido" runat="server"></asp:TextBox><br />      
                            <asp:Label class="text-dark" ID="lblEmail" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="txtEmail" placeholder="Email" runat="server" MaxLength="12"></asp:TextBox><br />     
                            <asp:Label class="text-dark" ID="lblContra" runat="server"></asp:Label>
                            <asp:TextBox class="form-control form-control-sm rounded" style="max-width: 500px;" ID="TextContra" placeholder="Contraseña" runat="server" MaxLength="12"></asp:TextBox><br />     
                  
                            <asp:LinkButton ID="BtnModificarMozo" runat="server" Text="Guardar Cambios" class="btn btn-secondary" OnClick="BtnModificarMozo_Click"   OnClientClick="return confirm('¿Está seguro que desea guardar los cambios ?')"/>
                            <a class="btn btn-success text-light text-decoration-none" href="AdmiPersonal.aspx" style="margin-bottom: 2px;">Volver</a>
                                 
                                 
                            </div>
                            </center>              

</asp:Content>


