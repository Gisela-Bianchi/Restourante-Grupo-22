﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Trabajo_Final.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

        body{

            background-color:forestgreen;  
            padding:200px;
           
        }

    </style>
    <h1>Bienvenidos</h1>
   
<div class="container">
    <div class="row">
        <div class="col-5">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label"><span style="font-weight: bold;">DNI</span></label>
                <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label"><span style="font-weight: bold;">Contraseña</span></label>
                <input type="password" class="form-control" id="exampleInputPassword1">
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnAceptar_Click" runat="server" />
        </div>
        <div class="col-6">
            <img src="https://www.loleta.es/wp-content/uploads/2019/04/SLIDE-JUST-EAT-6533-copia.jpg" alt="Foto de comida" style="max-width: 100%; height: auto;">
        </div>
    </div>
</div>


         
 
</asp:Content>
