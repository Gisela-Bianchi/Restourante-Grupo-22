<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiMesas.aspx.cs" Inherits="Trabajo_Final.Mesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row row-cols-1 row-cols-md-2 g-4">
        <%if (Session["Mesa 1"] == null)
            {  %>
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Mesa 1</h5>
        <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                    <asp:Button CssClass="btn btn-primary" ID="btnIngresar1" runat="server" Text="Ingresar" OnClick="btnIngresar1_Click" />

                </div>
            </div>
        </div>
        <%}
            else
            {  %>  
        <div class="col">
            <div class="card">
                
                <div class="card-body">
                    <asp:DropDownList ID="ddlMesa1" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtMesa1" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Button ID="btnAgregarMesa1" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa1_Click" />
                     <br />
                    <asp:GridView ID="gdvMesa1" runat="server">
                    </asp:GridView>
                    <br />
                    <asp:Label ID="totalmesa1" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnPagarmesa1" runat="server" Text="Pagar" OnClick="btnPagarmesa1_Click" />
                </div>
            </div>
        </div>


        <%} %> 
      <%if (Session["Mesa 2"] == null)
            {  %>
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Mesa 2</h5>
        <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                    <asp:Button CssClass="btn btn-primary" ID="btnIngresar2" runat="server" Text="Ingresar" OnClick="btnIngresar2_Click" />

                </div>
            </div>
        </div>
        <%}
            else
            {  %>  
        <div class="col">
            <div class="card">
                
                <div class="card-body">
                    <asp:DropDownList ID="ddlMesa2" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtMesa2" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Button ID="btnAgregarMesa2" runat="server" Text="BAgregar Cantidad" OnClick="btnAgregarMesa2_Click" />
                     <br />
                    <asp:GridView ID="gdvMesa2" runat="server"></asp:GridView>
                     <br />
                    <asp:Label ID="totalmesa2" runat="server" Text=""></asp:Label>
                    <asp:Button ID="btnPagarmesa2" runat="server" Text="Pagar" />
                </div>
            </div>
        </div>


        <%} %> 
       <%if (Session["Mesa 3"] == null)
            {  %>
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Mesa 3</h5>
        <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                    <asp:Button CssClass="btn btn-primary" ID="btnIngresar3" runat="server" Text="Ingresar" OnClick="btnIngresar3_Click" />

                </div>
            </div>
        </div>
        <%}
            else
            {  %>  
        <div class="col">
            <div class="card">
                
                <div class="card-body">
                    <asp:DropDownList ID="ddlMesa3" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtMesa3" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Button ID="btnAgregarMesa3" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa3_Click" />
                     <br />
                    <asp:GridView ID="gdvMesa3" runat="server"></asp:GridView>
                    <br />
                    <asp:Label ID="totalmesa3" runat="server" Text=""></asp:Label>
                     <asp:Button ID="btnPagarmesa3" runat="server" Text="Pagar" />
                </div>
            </div>
        </div>


        <%} %> 
         <%if (Session["Mesa 4"] == null)
            {  %>
        <div class="col">
            <div class="card">
                <img src="..." class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Mesa 4</h5>
        <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                    <asp:Button CssClass="btn btn-primary" ID="btnIngresar4" runat="server" Text="Ingresar" OnClick="btnIngresar4_Click" />

                </div>
            </div>
        </div>
        <%}
            else
            {  %>  
        <div class="col">
            <div class="card">
                
                <div class="card-body">
                    <asp:DropDownList ID="ddlMesa4" runat="server"></asp:DropDownList>
                    <asp:TextBox ID="txtMesa4" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Button ID="btnAgregarMesa4" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa4_Click" />
                    <br />
                    <asp:GridView ID="gdvMesa4" runat="server"></asp:GridView>
                    <br />
                    <asp:Label ID="totalmesa4" runat="server" Text=""></asp:Label>
                     <asp:Button ID="btnPagarmesa4" runat="server" Text="Pagar" />
                </div>
            </div>
        </div>


        <%} %> 
    </div>
</asp:Content>

