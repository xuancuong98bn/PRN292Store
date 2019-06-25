<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.Master" AutoEventWireup="true" CodeBehind="DemoFormMaster.aspx.cs" Inherits="DemoWeb.DemoFormMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RenderBody" runat="server">
    <p>
        asjdashdjkshakjd
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="RenderNavbar" runat="server">
    <tr>
        <td class="auto-style8">
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="About.aspx">About</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink3" runat="server">Excercise</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style6">
            <asp:HyperLink ID="HyperLink4" runat="server">Help</asp:HyperLink>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:HyperLink ID="HyperLink5" runat="server">Contact</asp:HyperLink>
        </td>
    </tr>
</asp:Content>
