<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Account.aspx.cs" Inherits="Account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleGridview.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="acclbl" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="AccGridView" CssClass="mydatagrid" ShowFooter="true" runat="server">
        <HeaderStyle BackColor="#ffff66"  ForeColor="Black" />
        <FooterStyle BackColor="#ffff66"  ForeColor="Black" />
        
    </asp:GridView>
    <!--
        <Columns>
            <asp:BoundField DataField="sno" HeaderText="S.No" />
            <asp:BoundField DataField="productid" HeaderText="Product Id" />
        
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
            <asp:BoundField DataField="scdescription" HeaderText="Description" />

            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
        </Columns>
         -->
</asp:Content>

