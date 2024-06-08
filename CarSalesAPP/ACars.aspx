<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ACars.aspx.cs" Inherits="CarSalesAPP.ACarsaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Height="449px" Width="1350px">
                <Columns>
                    <asp:BoundColumn DataField="CarModel" HeaderText="Car Model" />
                    <asp:BoundColumn DataField="BrandName" HeaderText="Brand Name" />
                    <asp:BoundColumn DataField="CarPhoto" HeaderText="Car Photo" />
                    <asp:BoundColumn DataField="CarFuelType" HeaderText="Car Fuel Type" />
                    <asp:BoundColumn DataField="CarDescription" HeaderText="Car Description" />
                    <asp:BoundColumn DataField="CarSeller" HeaderText="Car Seller" />
                    <asp:BoundColumn DataField="CarContact" HeaderText="Car Contact" />
                    <asp:BoundColumn DataField="CarPrice" HeaderText="Car Price" />
                </Columns>
                <AlternatingItemStyle BackColor="White" />
                <EditItemStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#E3EAEB" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
        </div>
    </form>
</asp:Content>
