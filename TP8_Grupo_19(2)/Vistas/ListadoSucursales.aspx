<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 364px;
        }
        .auto-style3 {
            width: 428px;
        }
        .auto-style4 {
            width: 268px;
        }
        .auto-style5 {
            width: 260px;
        }
        .auto-style6 {
            width: 98px;
        }
        .auto-style7 {
            width: 172px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="hlAgregar" runat="server" NavigateUrl="~/AgregarSucursales.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td class="auto-style3">
                    <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td>
                    <asp:HyperLink ID="hlEliminar" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
            </tr>
        </table>
    <h3>
    <br />
        LISTADO DE SUCURSALES</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Busqueda ingrese Id sucursal: </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtBusqueda" runat="server" Width="252px"></asp:TextBox>
                </td>
                <td class="auto-style6">

<asp:RegularExpressionValidator
ID="revEdad"
    runat="server"
    ControlToValidate="txtBusqueda"
    ValidationExpression="^\d+$"
    ErrorMessage="Ingrese solo números"></asp:RegularExpressionValidator>                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" />
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="rfvSucursal" runat="server" ControlToValidate="txtBusqueda" ErrorMessage="Ingrese sucursal"></asp:RequiredFieldValidator>
        <br />
        <asp:GridView ID="gvSucursales" runat="server" Height="291px" Width="965px">
        </asp:GridView>
    </form>
    </body>
</html>
