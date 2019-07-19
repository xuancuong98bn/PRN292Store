<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="DemoWeb.ProductDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="Code" DataSourceID="SqlDataSource1" GroupItemCount="3">
                <AlternatingItemTemplate>
                    <td runat="server" style="background-color: #FFFFFF;color: #284775;">Code:
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
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br />
                    </td>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td runat="server" />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <InsertItemTemplate>
                    <td runat="server" style="">Code:
                        <asp:TextBox ID="CodeTextBox" runat="server" Text='<%# Bind("Code") %>' />
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
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <br />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br />
                    </td>
                </InsertItemTemplate>
                <ItemTemplate>
                    <td runat="server" style="background-color: #E0FFFF;color: #333333;">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="354px" ImageUrl='<%# Bind("Image", "image/{0}") %>' OnClientClick='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Width="526px" />
                        <br />
                        <br />
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Text='<%# Bind("Name", "Name Product: {0}") %>'></asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Text='<%# Bind("Price", "Price: {0}") %>'></asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# Bind("Code", "ProductDetail.aspx?Code={0}") %>' Text='<%# Bind("Unit", "Unit: {0}") %>'></asp:HyperLink>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr id="groupPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF"></td>
                        </tr>
                    </table>
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRN292_ShoppingConnectionString %>" SelectCommand="SELECT * FROM [tblProduct] WHERE ([Code] = @Code)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="Code" QueryStringField="Code" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
