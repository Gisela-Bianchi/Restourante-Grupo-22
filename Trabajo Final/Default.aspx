<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trabajo_Final.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

        body{

            background-color:forestgreen;  
            padding:50px;
           
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
                <asp:TextBox ID="TxtContraseña" runat="server" TextMode="Password" ></asp:TextBox>
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnAceptar_Click" runat="server" />
        </div>
        <div class="col-6">
            <img src="https://www.loleta.es/wp-content/uploads/2019/04/SLIDE-JUST-EAT-6533-copia.jpg" alt="Foto de comida" style="max-width: 100%; height: auto;">
        </div>
    </div>
</div>


         
 
</asp:Content>
