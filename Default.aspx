<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Zadatak1PB.Zadatak1PB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Zadatak br. 1</title>
    <style type="text/css">
        #forma {
            height: 150px;
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="forma" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblPlaca" align="right" Text="Neto plaća:" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPlaca" align="left" value="6700.00" AutoPostBack="True" OnTextChanged="Promjena" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblDani" align="left" Text="Broj radnih dana:" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDani" align="right" value="22" AutoPostBack="True" OnTextChanged="Promjena" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblZarada" Text="Iznos zarade:" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtZarada" value="1264.00" AutoPostBack="True" OnTextChanged="Promjena" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
            <hr />
        <asp:Label ID="lblRjesenje" runat="server"></asp:Label>
    </form>
</body>
</html>
