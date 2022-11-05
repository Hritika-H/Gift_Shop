<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reviews.aspx.cs" Inherits="Reviews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       
        .auto-style1 {
            width: 100%;
            height: 186px;
        }
        .auto-style2 {
            height: 149px;
        }
        .reviewdiv{
            background-color:darkslategrey;
            color:white;
            font-size:15px;
        }
        .btn{
            color:white;
            background-color:darkslategrey;
            border:2px solid white;
            padding:10px;
            width:120px;
            height:40px;
            text-align:center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="reviewdiv">&nbsp;
        <asp:Label ID="Label1" runat="server"  Text="Share your reviews here:" ></asp:Label>&nbsp;<br />
        &nbsp;
        <asp:TextBox ID="reviewtxtbox" runat="server" Height="100px" TextMode="MultiLine" Width="200px"></asp:TextBox>&nbsp;&nbsp;<asp:Button ID="insertreviewbtn" class="btn" runat="server" Text="Share" OnClick="insertreviewbtn_Click" />
    &nbsp;<br />
        &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="reviewtxtbox" ErrorMessage="*Enter some text" ForeColor="#FFCCCC"></asp:RequiredFieldValidator>
        <br />
        </div>
    <div style="margin-left:10%;">
    <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" GridLines="Both">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><%#Eval("r_text") %></td>
                </tr>
                <tr>
                    <td><%#Eval("usrname") %></td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
        </div>
</asp:Content>

