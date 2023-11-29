<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Trabajo_Final.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style>
      body {
          background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
          color: whitesmoke;
      }
    
  </style>
    
        
      <%
          List<int> numPedidos = (List<int>)Session["Cantidad de Pedidos"];
          Negocio.PedidoNegocio PedN = new Negocio.PedidoNegocio();
          List<Dominio.Insumo> NombresInsumo = new List<Dominio.Insumo>();
          int numMesa=0;
          foreach(int NP in numPedidos)
          {
              numMesa = PedN.traeNumeroMesa(NP);
              NombresInsumo = PedN.traerNombreInsumo(NP);

              %>
    <div class="card" style="width: 18rem;margin-bottom:1rem;">
  <div class="card-header">
    Mesa <%=numMesa %>
  </div>
  <ol class="list-group list-group-flush" style="list-style-type:none;">
      <%

          foreach (Dominio.Insumo reg in NombresInsumo)
          { %>


    <li class="list-group-item"><%= reg.NombreInsumo %></li>
    

      <%} %>
  </ol>
</div>


    <%}%>

</asp:Content>
