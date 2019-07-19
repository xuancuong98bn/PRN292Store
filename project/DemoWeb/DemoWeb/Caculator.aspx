<%@ Page Title="" Language="C#" MasterPageFile="~/master/AfterLogin.master" AutoEventWireup="true" CodeBehind="Caculator.aspx.cs" Inherits="DemoWeb.Calculator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="RenderBody" runat="server">
    <div style="margin: 0 30px; padding: 30px; box-shadow: 3px 3px 3px gray; border: solid 1px gray; border-radius: 10px">
        <h1>Caculator</h1>
        <form id="form1" runat="server">
            <div>
                <table style="width: 60%;">
                    <tr>
                        <td class="w-100" style="width: 79%">Enter a</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="w-100" style="width: 79%">Enter b</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="w-100" style="width: 79%">Operator</td>
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
                        <td class="w-100" style="width: 79%">Result</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="w-100" style="width: 79%">
                            <asp:Button ID="Button1" runat="server" Text="OK" OnClick="Button1_Click" />
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </div>
</asp:Content>
