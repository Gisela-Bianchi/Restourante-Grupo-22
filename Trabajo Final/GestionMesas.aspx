<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionMesas.aspx.cs" Inherits="Trabajo_Final.GestionMesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--mesa 1  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">Mesa 1</h5>
    <p class="card-text">Gestionar la mesa 1</p>
      <%if (Session["MostrarMesa1"] != null)
          {%>
      <asp:Button ID="btnAgregarMesa1" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa1_Click" />
      <%}
          else
          { %>
      <asp:Button ID="btnEliminarMesa1" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa1_Click" />
      <%} %>
  </div>
</div>
    <!--mesa 2  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
     <h5 class="card-title">Mesa 2</h5>
    <p class="card-text">Gestionar la mesa 2</p>
       <%if (Session["MostrarMesa2"] != null)
           {%>
 <asp:Button ID="btnAgregarMesa2" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa2_Click" />
        <%}
            else
            { %>
      <asp:Button ID="btnEliminarMesa2" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa2_Click"/>
       <%} %>
  </div>
</div>
    <!--mesa 3  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
     <h5 class="card-title">Mesa 3</h5>
    <p class="card-text">Gestionar la mesa 3</p>
       <%if (Session["MostrarMesa3"] != null)
           {%>
   <asp:Button ID="btnAgregarMesa3" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa3_Click" />
        <%}
            else
            { %>
      <asp:Button ID="btnEliminarMesa3" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa3_Click" />
       <%} %>
  </div>
</div>
    <!--mesa 4  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
     <h5 class="card-title">Mesa 4</h5>
    <p class="card-text">Gestionar la mesa 4</p>
       <%if (Session["MostrarMesa4"] != null)
           {%>
   <asp:Button ID="btnAgregarMesa4" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa4_Click" />
        <%}
            else
            { %>
      <asp:Button ID="btnEliminarMesa4" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa4_Click" />
       <%} %>
  </div>
</div>
    <!--mesa 5  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">Mesa 5</h5>
    <p class="card-text">Gestionar la mesa 5</p>
       <%if (Session["MostrarMesa5"] != null)
           {%>
    <asp:Button ID="btnAgregarMesa5" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa5_Click" />
        <%}
            else
            { %>
      <asp:Button ID="btnEliminarMesa5" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa5_Click" />
       <%} %>
  </div>
</div>
    <!--mesa 6  -->
    <div class="card text-center mb-3" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">Mesa 6</h5>
    <p class="card-text">Gestionar la mesa 6</p>
       <%if (Session["MostrarMesa6"] != null)
           {%>
    <asp:Button ID="btnAgregarMesa6" CssClass="btn text-light bg-success" runat="server" Text="Agregar" OnClick="btnAgregarMesa6_Click" />
        <%}
            else
            { %>
      <asp:Button ID="btnEliminarMEsa6" CssClass="btn text-light bg-danger" runat="server" Text="Eliminar" OnClick="btnEliminarMesa6_Click" />
       <% }
           %>
  </div>
</div>






</asp:Content>