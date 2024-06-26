﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCars.aspx.cs" Inherits="CarSalesAPP.AddCars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <table class="w-100">
            <tr>
                <td style="width: 181px; height: 38px">Araba Markasını Seçiniz : </td>
                <td style="height: 38px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="178px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 181px">Araba Modelini Giriniz :</td>
                <td>
                    <asp:TextBox ID="tbModel" runat="server" Width="178px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px; height: 27px">Araba Fotoğraf Linki : </td>
                <td style="height: 27px">
                    <asp:TextBox ID="tbPhoto" runat="server" Width="177px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px">Araba Yakıt Tipi Giriniz : </td>
                <td>
                    <asp:TextBox ID="tbFuelType" runat="server" Width="178px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px">Açıklama Giriniz :</td>
                <td>
                    <asp:TextBox ID="tbDescription" runat="server" Height="131px" TextMode="MultiLine" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px; height: 21px">Araç Satıcısı :</td>
                <td style="height: 21px">
                    <asp:TextBox ID="tbSeller" runat="server" Width="178px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px; height: 21px">İletişim Numarası : </td>
                <td style="height: 21px">
                    <asp:TextBox ID="tbContact" runat="server" Width="178px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px">Araç Fiyatı : </td>
                <td>
                    <asp:TextBox ID="tbPrice" runat="server" Width="178px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 181px">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="İlan Oluştur" Width="136px" />
                </td>
            </tr>
        </table>
    </form>
</asp:Content>
