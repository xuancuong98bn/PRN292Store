<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Example.aspx.cs" Inherits="DemoWeb.Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <h1>Caculator</h1>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>Enter a</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter b</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Operator</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>+</asp:ListItem>
                            <asp:ListItem>-</asp:ListItem>
                            <asp:ListItem>*</asp:ListItem>
                            <asp:ListItem>/</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Result</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Reset" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
