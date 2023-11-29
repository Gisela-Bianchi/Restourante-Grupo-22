<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Trabajo_Final.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <style>
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }

        .card {
            width: 18rem;
            margin-bottom: 1rem;
            background-color: #333; /* Cambia el color de fondo de la tarjeta */
            color: whitesmoke; /* Cambia el color del texto en la tarjeta */
            border: 1px solid #555; /* Añade un borde a la tarjeta */
            border-radius: 8px; /* Agrega esquinas redondeadas */
        }

        .card-header {
            background-color: #555; /* Cambia el color de fondo del encabezado de la tarjeta */
            color: whitesmoke; /* Cambia el color del texto del encabezado de la tarjeta */
        }

        .list-group-item {
            background-color: #444; /* Cambia el color de fondo de los elementos de la lista */
            color: whitesmoke; /* Cambia el color del texto de los elementos de la lista */
            border: none; /* Elimina los bordes de los elementos de la lista */
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
