<%@ Page Title="" Language="C#" MasterPageFile="~/master/Demo.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 97%;
        }

        .auto-style8 {
            width: 581px;
        }

        .auto-style9 {
            margin-left: 0px;
        }

        .auto-style10 {
            width: 124px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">
    <div style="margin: 30px; padding: 30px; box-shadow: 3px 3px 3px gray;border:solid 1px gray;border-radius:10px">
        <h1>Login</h1>
        <div>
            <form id="formLogin" runat="server">
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style10">Username&nbsp;</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="auto-style9"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">Password</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">&nbsp;</td>
                        <td class="auto-style8">
                            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="RenderNavbar" runat="server">
</asp:Content>
