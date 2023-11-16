<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiCategoria.aspx.cs" Inherits="Trabajo_Final.AdmiCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
     <div class="col">

         <asp:GridView runat="server" ID="dgvCategoria" CssClass="table table-dark table-bordered" DataKeyNames="Id_Categoria" AutoGenerateColumns="false" onSelectedIndexChanged="dgvCategoria_SelectedIndexChanged" OnPageIndexChanging="dgvCategoria_PageIndexChanging" AllowPaging="true" PageSize="5" >
             <Columns>
           
                 <asp:BoundField HeaderText="Id" DataField="Id_Categoria" />
                 <asp:BoundField HeaderText="Descripcion" DataField="Descripcion_Categoria" />
                 <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="Modificar"/>
               

                

             </Columns>
         </asp:GridView>

         <a href="FormularioCategoria.aspx" style="margin-bottom: 10px; display: block;">Agregar Categoria</a>

         <a href="AdmiCategoria.aspx" style="margin-bottom: 10px; display: block;">Eliminar Categoria</a>


</div>
         </div>
</asp:Content>
