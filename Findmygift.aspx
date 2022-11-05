<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Findmygift.aspx.cs" Inherits="Findmygift" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
         .fmgdiv{
            background:url(/Images/giftbox1.jpg) no-repeat;
            background-size: cover;
            height: 87vh;
        }
        .fmgtable{
             position: absolute;
            top: 30%;
            left: 30%;
            background-color:rgba(255, 255, 255, 0.72);
            width: 752px;
            color:black;
        }
        .btncss {
            width: 100%;
            background-color: #272020;
            border: 2px solid white;
            color: white;
            padding: 5px;
            font-size: 20px;
            margin: 12px 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="fmgdiv">
    <table class="fmgtable">
        
        <tr>
            <td>Select Age Group:</td>
            <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>kid</asp:ListItem>
                <asp:ListItem>teen</asp:ListItem>
                <asp:ListItem>twenties</asp:ListItem>
                <asp:ListItem>middleaged</asp:ListItem>
                <asp:ListItem>seniorcitizen</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Select Hobbies:</td>
            <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>reading</asp:ListItem>
                <asp:ListItem>art&craft</asp:ListItem>
                <asp:ListItem>writing</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Select Interests:</td>
            <td>
            <asp:DropDownList ID="DropDownList3" runat="server">
                <asp:ListItem>music</asp:ListItem>
                <asp:ListItem>sports</asp:ListItem>
                <asp:ListItem Value="harrypoter">HarryPotter</asp:ListItem>
                <asp:ListItem>animals</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>
        <asp:Button ID="Button1" runat="server" CssClass="btncss" Text="Find My Gift!!!" OnClick="Button1_Click" />
                </td>
        </tr>
    </table>
        </div>
</asp:Content>

