<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchProduct.aspx.cs" Inherits="Given_Web_Example.SearchProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 115px;
        }
        .auto-style3 {
            width: 268px;
        }
        .auto-style4 {
            width: 207px;
        }
        .auto-style5 {
            width: 57px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">P<strong>roduct code:</strong></td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlCode" runat="server" Font-Bold="True" Font-Size="Medium" Height="16px" Width="225px" AutoPostBack="True" OnSelectedIndexChanged="ddlCode_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2"><strong>Product name:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server" Font-Bold="True" Font-Size="Medium" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnFilter2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" Text="Filter by Name" OnClick="btnFilter2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2"><strong>Unit:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUnit" runat="server" Font-Bold="True" Font-Size="Medium" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2"><strong>Price</strong></td>
                <td class="auto-style3">Old
                    <asp:TextBox ID="txtOld" runat="server" Font-Bold="True" Font-Size="Medium" Width="65px"></asp:TextBox>
&nbsp;--&gt;New
                    <asp:TextBox ID="txtNew" runat="server" Font-Bold="True" Font-Size="Medium" Width="68px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnFilter1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" Text="Filter by Price" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5"><strong></strong></td>
                <td class="auto-style2"><strong>Image:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtImage" runat="server" Font-Bold="True" Font-Size="Medium" Width="214px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="btnFilter0" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Small" Text="Filter by Image" OnClick="btnFilter0_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Update" OnClick="btnUpdate_Click" />
&nbsp;&nbsp;
                    <asp:Button ID="btnReset" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Text="Reset" OnClick="btnReset_Click"/>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td colspan="2">
                    <asp:GridView ID="gvProduct" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
