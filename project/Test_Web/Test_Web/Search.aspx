<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Test_Web.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;<table class="auto-style1">
                <tr>
                    <td>Detail name:</td>
                    <td>
                        <asp:TextBox ID="txtDetailName" runat="server" Width="319px" AutoPostBack="True" OnTextChanged="txtDetailName_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Master </td>
                    <td>
                        <asp:DropDownList ID="dropMaster" runat="server" Height="16px" Width="325px" AutoPostBack="True" OnSelectedIndexChanged="dropMaster_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" Text="Filter" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
