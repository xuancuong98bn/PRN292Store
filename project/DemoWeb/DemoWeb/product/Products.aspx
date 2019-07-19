<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="DemoWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="Code" DataSourceID="SqlDataSource1">
                <AlternatingItemTemplate>
                    <td runat="server" style="background-color: #FFFFFF;color: #284775;">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="214px" ImageUrl='<%# Bind("Image", "image/{0}") %>' OnClientClick='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Width="304px" />
                        <br />
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Text='<%# Bind("Name", "Name Product: {0}") %>'></asp:HyperLink>
                    </td>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <td runat="server" style="background-color: #999999;">Code:
                        <asp:Label ID="CodeLabel1" runat="server" Text='<%# Eval("Code") %>' />
                        <br />
                        Name:
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                        <br />
                        Unit:
                        <asp:TextBox ID="UnitTextBox" runat="server" Text='<%# Bind("Unit") %>' />
                        <br />
                        Price:
                        <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        <br />
                        Image:
                        <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">Code:
                        <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Bind("Code") %>' />
                        <br />Name:
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                        <br />Unit:
                        <asp:TextBox ID="UnitTextBox" runat="server" Text='<%# Bind("Unit") %>' />
                        <br />Price:
                        <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
                        <br />Image:
                        <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="background-color: #E0FFFF;color: #333333;">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="214px" ImageUrl='<%# Bind("Image", "image/{0}") %>' OnClientClick='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Width="304px" />
                        <br />
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Text='<%# Bind("Name", "Name Product: {0}") %>'></asp:HyperLink>
                        <br />
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </table>
                    <div style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                    </div>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">Code:
                        <asp:Label ID="CodeLabel" runat="server" Text='<%# Eval("Code") %>' />
                        <br />
                        Name:
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                        <br />
                        Unit:
                        <asp:Label ID="UnitLabel" runat="server" Text='<%# Eval("Unit") %>' />
                        <br />
                        Price:
                        <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
                        <br />
                        Image:
                        <asp:Label ID="ImageLabel" runat="server" Text='<%# Eval("Image") %>' />
                        <br />
                    </td>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRN292_ShoppingConnectionString %>" SelectCommand="SELECT * FROM [tblProduct]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
