<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AUsers.aspx.cs" Inherits="CarSalesAPP.AUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="2" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Height="450px" Width="1350px">
                <Columns>
                    <asp:BoundColumn DataField="UserID" HeaderText="User ID" />
                    <asp:BoundColumn DataField="UserMail" HeaderText="User Mail" />
                    <asp:BoundColumn DataField="UserPassword" HeaderText="User Password" />
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
