<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="Trabajo_Final.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnMozo" runat="server" Text="IngreseMozo" OnClick="btnMozo_Click" />
            <asp:Button ID="btnGerente" runat="server" Text="IngreseGerente" OnClick="btnGerente_Click" />
        </div>
    </form>
</body>
</html>
