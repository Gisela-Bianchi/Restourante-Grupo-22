<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdministradorMesas.aspx.cs" Inherits="Trabajo_Final.AdministradorMesas" %>
<!----<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%
        Negocio.MesaNegocio MN = new Negocio.MesaNegocio();
        List<int> ListaMesas = MN.CantMesas();
       
    %>
    <div class="row row-cols-1 row-cols-md-2 g-4">
        <%  
            foreach(int NumeroMesa in ListaMesas)
            {

                string NombreSession = $"Mesa {NumeroMesa}";
                if (Session[NombreSession] == null)
                {
                    string numeromesastring = NumeroMesa.ToString();     %>
        <div class="col">
            <div class="card">

                <div class="card-body">
                    <h5 class="card-title">Mesa <%=NumeroMesa %> - <span class="text-success">Mesa Libre</span></h5>
                    <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                    <asp:Button CssClass="btn btn-primary" ID="btnAgregar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" CommandArgument='<%=numeromesastring%>' />
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <%}
            else
            {
        %>
        <div class="col">
            <div class="card">

                <div class="card-body">
                    <h5 class="card-title text-danger">Mesa Ocupada</h5>
                    <asp:DropDownList ID="ddlCategoria" runat="server" AutoPostBack="True" ></asp:DropDownList>
                    <%
                        string MostrarPlato = $"MostrarPlatos{NumeroMesa}";
                        if (Session[MostrarPlato] != null)
                        {  %>
                    <asp:DropDownList ID="ddlMesa" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtMesa" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Button ID="btnAgregarMesa" runat="server" Text="Agregar Cantidad" />
                    <br />
                    <asp:Label ID="lblErrorMesa" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <br />
                    <asp:GridView ID="gdvMesa" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="totalmesa" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnPagarmesa" runat="server" Text="Pagar" />
                    <%} %>
                </div>
            </div>
        </div>


        <%} %>

        <%
            }
        %>
        </div>
</asp:Content>
--->
