<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddtoCart.aspx.cs" Inherits="AddtoCart" %>

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
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div style="background-color:#000000;color:white;"> You have added
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

&nbsp;products to your cart&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Back to Shopping</asp:LinkButton>
    </div> <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowFooter="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="sno" HeaderText="S.No" />
            <asp:BoundField DataField="productid" HeaderText="Product Id" />
            <asp:ImageField DataImageUrlField="productimage" HeaderText="Product Image">
            </asp:ImageField>

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
                <!-- some extra fields <asp:BoundField DataField="pcategory" HeaderText="Category" />
            <asp:BoundField DataField="stag" HeaderText="Car Model" /> -->
    <br />
    <asp:Button ID="Checkoutbtn" Cssclass="genericButton" runat="server" OnClick="Checkoutbtn_Click" Text="Place Your Order" />
    
</asp:Content>

