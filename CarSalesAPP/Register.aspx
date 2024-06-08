<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CarSalesAPP.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <asp:TextBox ID="tbMail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" style="height: 29px" Text="Kayıt Ol" />
</form>
</asp:Content>
