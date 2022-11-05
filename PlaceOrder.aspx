<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PlaceOrder.aspx.cs" Inherits="PlaceOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style>
        .genericButton{
            color:white;
            background-color:#090e14;
            border:2px solid white;
            display:block;
            padding:10px;
            width:50%;
            text-align:center;
}</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label3"></asp:Label>
    <br />
        <asp:Label ID="Label4" runat="server" Text="Label4"></asp:Label>

    <br />
    <asp:GridView ID="CustomerDetails" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    <br /><hr /><br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowFooter="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="sno" HeaderText="S.No" />
            <asp:BoundField DataField="productid" HeaderText="Product Id" />
        
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
            <asp:BoundField DataField="scdescription" HeaderText="Description" />
            <asp:BoundField DataField="price" HeaderText="Price" />
            <asp:BoundField DataField="quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    <br />
      <!--  <asp:BoundField DataField="scmake" HeaderText="Car Make" />
            <asp:BoundField DataField="scmodel" HeaderText="Car Model" /> -->
    <asp:Button ID="finalorderbtn" CssClass="genericButton" runat="server" OnClick="finalorderbtn_Click" Text="Checkout" />
    <br />
</asp:Content>

