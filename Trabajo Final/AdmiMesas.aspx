<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdmiMesas.aspx.cs" Inherits="Trabajo_Final.Mesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <style>
        body {
            background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
            color: whitesmoke;
        }

        .Libre {
            color: green;
        }
    </style>




    <asp:UpdatePanel runat="server" UpdateMode="Conditional" ID="updatePanelMesas">
        <ContentTemplate>

            <div class="row row-cols-1 row-cols-md-2 g-4">
                <%
                    if (Session["MostrarMesa1"] == null)
                    {
                        if (Session["Mesa 1"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">

                            <h5 class="card-title">Mesa 1 - <span class="Libre">Libre</span> </h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa1" Style="margin-left: 10px;" runat="server" Text=""></asp:Label>
                            </div>


                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar1" runat="server" Text="Ingresar" OnClick="btnIngresar1_Click" />


                        </div>
                        <div class="card-body">

                            <label for="ddlAsignarMozo" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO : </label>
                            <label for="ddlAsignarNombre" class="form-label">Nombre</label>
                            <asp:DropDownList runat="server" ID="ddlAsignarNombre" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre_SelectedIndexChanged">
                            </asp:DropDownList>

                            <label for="ddlAsignarApellido" class="form-label">Apellido</label>
                            <asp:DropDownList runat="server" ID="ddlAsignarApellido" CssClass="btn btn-outline-dark dropdown-toggle">
                            </asp:DropDownList>

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
                            <asp:DropDownList ID="ddlCategoria1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria1_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos1"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa1" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa1" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa1" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa1_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa1" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa1" runat="server">
                            </asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa1" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa1" runat="server" Text="Pagar" OnClick="btnPagarmesa1_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    } %>
                <%
                    if (Session["MostrarMesa2"] == null)
                    {
                        if (Session["Mesa 2"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title">Mesa 2 - <span class="Libre">Libre</span></h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa2" runat="server" Text=""></asp:Label>
                            </div>

                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar2" runat="server" Text="Ingresar" OnClick="btnIngresar2_Click" />
                            <div class="card-body">
                                <label for="ddlAsignarMozo2" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO :</label>

                                <label for="ddlAsignarNombre2" class="form-label">Nombre</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarNombre2" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre2_SelectedIndexChanged">
                                </asp:DropDownList>

                                <label for="ddlAsignarApellido2" class="form-label">Apellido</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarApellido2" CssClass="btn btn-outline-dark dropdown-toggle">
                                </asp:DropDownList>


                            </div>
                        </div>
                    </div>
                </div>
                <%}
                    else
                    {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title text-danger">Mesa Ocupada</h5>
                            <asp:DropDownList ID="ddlCategoria2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria2_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos2"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa2" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa2" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa2" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa2_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa2" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa2" runat="server"></asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa2" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa2" runat="server" Text="Pagar" OnClick="btnPagarmesa2_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    } %>
                <%
                    if (Session["MostrarMesa3"] == null)
                    {
                        if (Session["Mesa 3"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title">Mesa 3 - <span class="Libre">Libre</span></h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa3" runat="server" Text=""></asp:Label>
                            </div>
                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar3" runat="server" Text="Ingresar" OnClick="btnIngresar3_Click" />
                            <div class="card-body">

                                <label for="ddlAsignarMozo3" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO :</label>

                                <label for="ddlAsignarNombre3" class="form-label">Nombre</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarNombre3" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre3_SelectedIndexChanged">
                                </asp:DropDownList>

                                <label for="ddlAsignarApellido3" class="form-label">Apellido</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarApellido3" CssClass="btn btn-outline-dark dropdown-toggle">
                                </asp:DropDownList>

                            </div>
                        </div>
                    </div>
                </div>
                <%}
                    else
                    {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title text-danger">Mesa Ocupada</h5>
                            <asp:DropDownList ID="ddlCategoria3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria3_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos3"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa3" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa3" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa3" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa3_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa3" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa3" runat="server"></asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa3" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa3" runat="server" Text="Pagar" OnClick="btnPagarmesa3_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    } %>
                <%
                    if (Session["MostrarMesa4"] == null)
                    {
                        if (Session["Mesa 4"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title">Mesa 4 - <span class="Libre">Libre</span></h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa4" runat="server" Text=""></asp:Label>
                            </div>
                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar4" runat="server" Text="Ingresar" OnClick="btnIngresar4_Click" />
                            <div class="card-body">
                                <label for="ddlAsignarMozo4" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO :</label>

                                <label for="ddlAsignarNombre4" class="form-label">Nombre</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarNombre4" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre4_SelectedIndexChanged">
                                </asp:DropDownList>

                                <label for="ddlAsignarApellido4" class="form-label">Apellido</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarApellido4" CssClass="btn btn-outline-dark dropdown-toggle">
                                </asp:DropDownList>

                            </div>
                        </div>
                    </div>
                </div>
                <%}
                    else
                    {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title text-danger">Mesa Ocupada</h5>
                            <asp:DropDownList ID="ddlCategoria4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria4_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos4"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa4" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa4" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa4" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa4_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa4" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa4" runat="server"></asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa4" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa4" runat="server" Text="Pagar" OnClick="btnPagarmesa4_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    } %>

                <%
                    if (Session["MostrarMesa5"] == null)
                    {
                        if (Session["Mesa 5"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title">Mesa 5 - <span class="Libre">Libre</span></h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa5" runat="server" Text=""></asp:Label>
                            </div>
                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar5" runat="server" Text="Ingresar" OnClick="btnIngresar5_Click" />
                            <div class="card-body">

                                <label for="ddlAsignarMozo5" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO :</label>

                                <label for="ddlAsignarNombre5" class="form-label">Nombre</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarNombre5" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre5_SelectedIndexChanged">
                                </asp:DropDownList>

                                <label for="ddlAsignarApellido5" class="form-label">Apellido</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarApellido5" CssClass="btn btn-outline-dark dropdown-toggle">
                                </asp:DropDownList>


                            </div>
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
                            <asp:DropDownList ID="ddlCategoria5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria5_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos5"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa5" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa5" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa5" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa5_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa5" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa5" runat="server">
                            </asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa5" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa5" runat="server" Text="Pagar" OnClick="btnPagarmesa5_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    }%>

                <%
                    if (Session["MostrarMesa6"] == null)
                    {
                        if (Session["Mesa 6"] == null)
                        {  %>
                <div class="col">
                    <div class="card">

                        <div class="card-body">
                            <h5 class="card-title">Mesa 6 - <span class="Libre">Mesa Libre</span></h5>
                            <div>
                                <asp:Label ID="lblNombreApellidoMesa6" runat="server" Text=""></asp:Label>
                            </div>
                            <img src="https://www.kroger.com/product/images/large/right/0071085937477" alt="Imagen de fondo" style="width: 300px; height: auto;" />
                            <asp:Button CssClass="btn btn-primary" ID="btnIngresar6" runat="server" Text="Ingresar" OnClick="btnIngresar6_Click" />
                            <div class="card-body">

                                <label for="ddlAsignarMozo6" class="form-label" style="color: blue; font-weight: bold;">ASIGNAR MOZO :</label>

                                <label for="ddlAsignarNombre6" class="form-label">Nombre</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarNombre6" CssClass="btn btn-outline-dark dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddlAsignarNombre6_SelectedIndexChanged">
                                </asp:DropDownList>

                                <label for="ddlAsignarApellido6" class="form-label">Apellido</label>
                                <asp:DropDownList runat="server" ID="ddlAsignarApellido6" CssClass="btn btn-outline-dark dropdown-toggle">
                                </asp:DropDownList>

                            </div>
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
                            <asp:DropDownList ID="ddlCategoria6" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCategoria6_SelectedIndexChanged"></asp:DropDownList>
                            <%if (Session["MostrarPlatos6"] != null)
                                {  %>
                            <asp:DropDownList ID="ddlMesa6" runat="server"></asp:DropDownList>
                            <asp:TextBox ID="txtMesa6" runat="server" TextMode="Number"></asp:TextBox>
                            <asp:Button ID="btnAgregarMesa6" runat="server" Text="Agregar Cantidad" OnClick="btnAgregarMesa6_Click" />
                            <br />
                            <asp:Label ID="lblErrorMesa6" runat="server" Text="" ForeColor="Red"></asp:Label>
                            <br />
                            <asp:GridView ID="gdvMesa6" runat="server">
                            </asp:GridView>
                            <br />
                            <asp:Label ID="totalmesa6" runat="server" Text=""></asp:Label>
                            <asp:Button ID="btnPagarmesa6" runat="server" Text="Pagar" OnClick="btnPagarmesa6_Click" />
                            <%} %>
                        </div>
                    </div>
                </div>


                <%}
                    } %>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

