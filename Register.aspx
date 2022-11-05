<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size:30px;
            height:50px;
            padding-top:1em;
            padding-bottom:1em;
        }
        .auto-style2 {
            width: 99%;
        }
        .auto-style5 {
            width: 186px;
            text-align: right;
            height: 40px;
        }
        .auto-style6 {
            width: 323px;
            text-align: center;
            height: 40px;
        }
        .auto-style7 {
            height: 40px;
        }
        .registerdiv{
            background:url(/Images/yellowbg.jpg) no-repeat;
            background-size: cover;
            height: 87vh;
        }
        .regtable{
             position: absolute;
            top: 30%;
            left: 30%;
            background-color:rgba(255, 255, 255, 0.72);
            width: 752px;
            color:black;
        }
        .auto-style8 {
            width: 186px;
            text-align: right;
            height: 41px;
        }
        .auto-style9 {
            width: 323px;
            text-align: center;
            height: 41px;
        }
        .auto-style10 {
            height: 41px;
        }
        .auto-style11 {
            width: 186px;
            text-align: right;
            height: 38px;
        }
        .auto-style12 {
            width: 323px;
            text-align: center;
            height: 38px;
        }
        .auto-style13 {
            height: 38px;
        }
        .auto-style14 {
            width: 186px;
            text-align: right;
            height: 44px;
        }
        .auto-style15 {
            width: 323px;
            text-align: center;
            height: 44px;
        }
        .auto-style16 {
            height: 44px;
        }
        .auto-style17 {
            width: 186px;
            text-align: right;
            height: 43px;
        }
        .auto-style18 {
            width: 323px;
            text-align: center;
            height: 43px;
        }
        .auto-style19 {
            height: 43px;
        }
        .auto-style20 {
            text-align: center;
            height: 45px;
        }
        .auto-style21 {
            width: 323px;
            text-align: center;
            height: 45px;
        }
        .auto-style22 {
            height: 45px;
        }
        .regbtncss{
            width:100%;
            background-color:#272020;
            border:2px solid white;
            color:white;
            padding:5px;
            font-size:20px;
            margin:12px 0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="registerdiv">

   
    <div class="regtable">
    <h2 class="auto-style1" style="font-family: Arial, Helvetica, sans-serif">Registration</h2>

    <table class="auto-style2">
        <tr>
            <td class="auto-style8">Name</td>
            <td class="auto-style9"><asp:TextBox ID="fullname" runat="server"></asp:TextBox>


            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="fullname" ErrorMessage="name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Contact</td>
            <td class="auto-style6">
    <asp:TextBox ID="contact" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style7">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="contact" ErrorMessage="enter a 10 digit contact no." ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">Address</td>
            <td class="auto-style12">
    <asp:TextBox ID="addr" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style13">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="addr" ErrorMessage="address is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Email</td>
            <td class="auto-style15">
    <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="enter a valid E-mail address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Username</td>
            <td class="auto-style18">
    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style19">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uname" ErrorMessage="enter a valid user name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">Password</td>
            <td class="auto-style21">
    <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style22">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwd" ErrorMessage="password length should be atleast 8 charcters" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Confirm Password</td>
            <td class="auto-style15">
    <asp:TextBox ID="c_passwd" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16">
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwd" ControlToValidate="c_passwd" ErrorMessage="password not the same" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style20" colspan="3">
    
    <asp:Button ID="registerbtn" CssClass="regbtncss" runat="server" Text="Register" OnClick="registerbtn_Click" />
            </td>
        </tr>
    </table>
    </div>
    <br />
        </div>
</asp:Content>

