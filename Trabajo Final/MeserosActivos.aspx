<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeserosActivos.aspx.cs" Inherits="Trabajo_Final.MeserosActivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <div class="row">
       <div class="col">

           <asp:GridView runat="server" ID="dgvMeseros" CssClass="table table-dark table-bordered" AutoGenerateColumns="false">
               <Columns>
             
                   <asp:BoundField HeaderText="Id Mesero" DataField="IdMesero" />
                   <asp:BoundField HeaderText="Dni" DataField="DNI" />
                   <asp:BoundField HeaderText="Nombre" DataField="NombreMesero" />

                   <asp:BoundField HeaderText="Apellido" DataField="ApellidoMesero" />
                   <asp:BoundField HeaderText="Mesas asignadas" DataField="MesasAsignadas" />
                 

               </Columns>
           </asp:GridView>

           <a href="MeserosActivos.aspx" style="margin-bottom: 10px; display: block;">Agregar Mesero</a>
            <a href="MeserosActivos.aspx" style="margin-bottom: 10px; display: block;">Eliminar Mesero</a>

           </div>
           </div>
</asp:Content>
