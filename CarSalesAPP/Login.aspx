<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarSalesAPP.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:TextBox ID="tbMail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnLogin" runat="server" OnClick="btnRegister_Click" style="height: 29px" Text="Giriş Yap" />
</form>
</asp:Content>
