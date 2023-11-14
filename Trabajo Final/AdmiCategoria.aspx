<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiCategoria.aspx.cs" Inherits="Trabajo_Final.AdmiCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
     <div class="col">

         <asp:GridView runat="server" ID="dgvCategoria" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
             <Columns>
           
                 <asp:BoundField HeaderText="Id" DataField="Id_Categoria" />
                 <asp:BoundField HeaderText="Descripcion" DataField="Descripcion_Categoria" />
               

                

             </Columns>
         </asp:GridView>

         <a href="FormularioCategoria.aspx" style="margin-bottom: 10px; display: block;">Agregar Categoria</a>

         <a href="AdmiCategoria.aspx" style="margin-bottom: 10px; display: block;">Modificar Categoria</a>

         <a href="AdmiCategoria.aspx" style="margin-bottom: 10px; display: block;">Eliminar Categoria</a>


</div>
         </div>
</asp:Content>
