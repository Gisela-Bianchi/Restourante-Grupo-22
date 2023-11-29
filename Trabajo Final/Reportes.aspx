<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Trabajo_Final.Reportes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>
      body {
          background-color: lightslategray; /* Puedes cambiar el color a tu preferencia */
          color: whitesmoke;
      }
  </style>
    <h1>REPORTES VARIOS</h1>
    <div>
        <h2>Total Recaudado Por Mesa</h2>
        <p>Elija el mes: </p>
        <asp:DropDownList ID="ddlMesas" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMesas_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="lblrecaudacionTotal" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>
