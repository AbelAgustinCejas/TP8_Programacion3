<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursales.aspx.cs" Inherits="Vistas.AgregarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="width:200px;"></td>
                    <td>
                        <asp:HyperLink ID="hlAgregar" runat="server">Agregar Sucursales</asp:HyperLink>
                    </td>
                    <td style="width:50px;"></td>
                    <td>
                        <asp:HyperLink ID="hlListado" runat="server">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td style="width:50px;"></td>
                    <td>
                        <asp:HyperLink ID="hlEliminar" runat="server">Eliminar Sucursales</asp:HyperLink>
                    </td>
                    <td style="width:200px;"></td>
                </tr>
            </table>
        </div>
        <div>
            <h1>GRUPO N° 19 (2)<br />
            </h1>
            <h3>
                <br />
                AGREGAR SUCURSAL</h3>
        </div>
        <div>
            <table style="width:100%;">
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;">Nombre:</td>
                    <td style="width:5px;"></td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;">Descripcion:</td>
                    <td style="width:5px;"></td>
                    <td style="width:300px;">
                        <asp:TextBox ID="txtDescripcion" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;">Provincia:</td>
                    <td style="width:5px;"></td>
                    <td>
                        <asp:DropDownList ID="ddlProvincia" runat="server" Width="300px">
                            <asp:ListItem Value="0">Seleccionar</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;">Direccion:</td>
                    <td style="width:5px;"></td>
                    <td>
                        <asp:TextBox ID="txtDireccion" runat="server" Width="300px"></asp:TextBox>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;"></td>
                    <td style="width:5px;"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td style="width:5px;"></td>
                    <td style="width:80px;"></td>
                    <td style="width:5px;"></td>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
