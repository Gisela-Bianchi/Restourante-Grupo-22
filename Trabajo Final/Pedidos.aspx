<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Trabajo_Final.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <style>
             h1 {
            color: darkred; /* Cambia el color del texto del título */
            text-align: center; /* Centra el texto del título */
            background-color:black; /* Cambia el color de fondo del título */
            padding: 10px; /* Agrega relleno alrededor del título */
            border-radius: 8px; /* Agrega esquinas redondeadas al título */
        }
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }
          #contenedor-tarjetas {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
        }
        .card {
            width: 18rem;
            margin-bottom: 1rem;
            background-color: #333; /* Cambia el color de fondo de la tarjeta */
            color: whitesmoke; /* Cambia el color del texto en la tarjeta */
            border: 1px solid #555; /* Añade un borde a la tarjeta */
            border-radius: 8px; /* Agrega esquinas redondeadas */
            overflow: hidden; 
        }

        .card-header {
            background-color: indianred; /* Cambia el color de fondo del encabezado de la tarjeta */
            color: whitesmoke; /* Cambia el color del texto del encabezado de la tarjeta */
        }
            .card-header span {
            font-size: 1.2em;
            font-weight: bold;
            color: yellow; /* Cambia el color a tu preferencia */
        }

           .list-group-item {
               background-color: #444; /* Cambia el color de fondo de los elementos de la lista */
               color: whitesmoke; /* Cambia el color del texto de los elementos de la lista */
               border: none; /* Elimina los bordes de los elementos de la lista */
           }
              .fecha-hora {
            font-size: 0.2em;
        }
            .pedido-en-curso {
            color: green;
             margin-top: 8px;
        }

        .pedido-cerrado {
            color: red;
        }
        
    </style>
    
               <h1>Lista de pedidos</h1>
    <div id="contenedor-tarjetas">
      <%
            
          List<int> numPedidos = (List<int>)Session["Cantidad de Pedidos"];

          Negocio.PedidoNegocio PedN = new Negocio.PedidoNegocio();
          List<Dominio.Insumo> NombresInsumo = new List<Dominio.Insumo>();
          int numMesa=0;
          foreach(int NP in numPedidos)
          {
              numMesa = PedN.traeNumeroMesa(NP);
              NombresInsumo = PedN.traerNombreInsumo(NP);
              DateTime horaPedido = PedN.traeHoraPedido(NP);
              bool estadoPedido = PedN.traeEstadoPedido(NP);
              bool Facturado = PedN.TraerSiEstaFacturado(NP);
              decimal Totalfacturado = PedN.TraerTotal(NP);


              %>
        <div class="card" style="width: 18rem; margin-bottom: 1rem;">
        <div class="card-header">
            <span>Mesa <%= numMesa %></span>
         
        </div>
        <ol class="list-group list-group-flush" style="list-style-type:none;">
            <% foreach (Dominio.Insumo reg in NombresInsumo) { %>
            <li class="list-group-item"><%= reg.NombreInsumo %></li>
            <% } %>
        </ol>
            <div class="card-footer">
           
       
        </div>
       <div class="card-footer">
              <span> <%= horaPedido.ToString("yyyy-MM-dd HH:mm:ss") %></span>
                <span>
         <% if (Facturado) { %>
             Facturado
         <% } else { %>
             Sin facturar
         <% } %>
     </span>
            <span class="<%= estadoPedido ? "pedido-en-curso" : "pedido-cerrado" %>">
                <%= estadoPedido ? "Pedido en curso" : "Pedido cerrado" %>

            </span>
           <div>
           <span>Total facturado: <%= Totalfacturado.ToString("C") %></span>
                </div>
        </div>
    </div>

    <%
        }
    %>
</div>
</asp:Content>