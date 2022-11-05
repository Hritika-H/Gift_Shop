<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminPage .aspx.cs" Inherits="AdminPage_" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            height:600px;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
    <link href="StyleGridview.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h1 class="auto-style2">Admin Page</h1>
    <h3 class="auto-style2" style="background-color: #808080; color: #FFFFFF">Add Product</h3>
    <br />
    <table class="auto-style1" style="border-style: dashed; background-color: #666666; color: #FFFFFF;">
        <tr>
            <td>Category:</td>
            <td>
                <asp:TextBox ID="categorytb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Tags:</td>
            <td>
                <asp:TextBox ID="tagtb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Product Name:</td>
            <td>
                <asp:TextBox ID="pnametb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Description:</td>
            <td>
                <asp:TextBox ID="descript" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Image:</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Price:</td>
            <td>
                <asp:TextBox ID="pricee" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Quantity:</td>
            <td>
                <asp:TextBox ID="quanti" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="id..."></asp:Label>
                </td>
            <td>
                &nbsp;<asp:Label ID="Label4" runat="server" Text="Inserting product..."></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="addproduct" runat="server" Text="Add Product" OnClick="addproduct_Click" Height="40px" Width="263px" BackColor="#D62E35" ForeColor="White" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" CssClass="mydatagrid" runat="server">
        <HeaderStyle BackColor="#ffff66"  ForeColor="Black" />
    </asp:GridView>
    <br />

    <!--BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" /> -->
        <h3 class="auto-style2" style="background-color: #808080; color: #FFFFFF">Delete Product</h3>
<br /><div style="background-color: #666666; color: #FFFFFF">
    Enter the id of the product to delete it:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="delprod" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="delbtn" runat="server" OnClick="delbtn_Click" Text="Delete" Height="40px" Width="263px" BackColor="#D62E35" ForeColor="White"/></div>
    <br />
    <br />
    <h3 class="auto-style2" style="background-color: #808080; color: #FFFFFF">Update Product</h3>
<br /><div style="background-color: #666666; color: #FFFFFF">
    Enter the product id:&nbsp;&nbsp;
    <asp:TextBox ID="upid" runat="server"></asp:TextBox>
    &nbsp;new price:<asp:TextBox ID="upprice" runat="server"></asp:TextBox> 
    &nbsp;new quantity:<asp:TextBox ID="upquant" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="updatebtn" runat="server"  Text="Update" Height="40px" Width="263px" BackColor="#D62E35" ForeColor="White" OnClick="updatebtn_Click"/></div>
    <br />
    <br />

     <h3 class="auto-style2" style="background-color: #808080; color: #FFFFFF">Delete Review</h3>

    <asp:GridView ID="GridView2" CssClass="mydatagrid" runat="server" >
        <HeaderStyle BackColor="#ffff66"  ForeColor="Black" />
    </asp:GridView>
    <!-- BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />-->
<br /><div style="background-color: #666666; color: #FFFFFF">
    Enter the id of the review to delete it:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="reviewText" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="reviewButt" runat="server"  Text="Delete" Height="40px" Width="263px" BackColor="#D62E35" ForeColor="White" OnClick="reviewButt_Click"/></div>
    <br />
    <br />
</asp:Content>

