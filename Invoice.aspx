<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Invoice.aspx.cs" Inherits="Invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height:500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
 &nbsp&nbsp<asp:Button ID="DownloadInvoice" runat="server" Text="Download Invoice in PDF Format" OnClick="DownloadInvoice_Click" />
    Order ID:   <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br />
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style1" border="1" style="border-style: double">
            <tr>
                <td colspan="2" style="text-align: center">Retail Invoice</td>
            </tr>
            <tr>
                <td colspan="2">OrderId:<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    <br />
                    Order Date:<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Buyer Address:<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </td>
                <td>Seller Address:<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                         <Columns>
            <asp:BoundField DataField="sno" HeaderText="S.No" />
            <asp:BoundField DataField="productid" HeaderText="Product Id" />
         
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
            <asp:BoundField DataField="price" HeaderText="Price" />
            <asp:BoundField DataField="quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
        </Columns>
                    </asp:GridView>
                 <!-- <asp:BoundField DataField="make" HeaderText="Car Make" />
            <asp:BoundField DataField="model" HeaderText="Car Model" />-->     
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">Grand Total:<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">Declaration:We declare that this invoice shows actual price of the goods described inclusive of taxes and all particulars are true and correct.<br /> Incase you find Selling price on this invoice to be more than MRP mentioned on product,Please inform us.<br />
                    <br />
                    THIS IS A COMPUTER GENERATED INVOICE AND DOES NOT REQUIRE SIGNATURE.</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

