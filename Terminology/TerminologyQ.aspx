<%@ Page Title="Terminology (Q)" Language="C#" MasterPageFile="~/MasterPages/Terminology.Master" AutoEventWireup="true" CodeBehind="TerminologyQ.aspx.cs" Inherits="UrologyNursing.TerminologyQ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <asp:Label ID="lblQSearch" runat="server" Text="There are currently no 'Q' terms in the database" Visible="false" style="color: blue"></asp:Label>
    <asp:GridView ID="gvQ" runat="server" CellPadding="4" ForeColor="Blue">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="aliceblue" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="aliceblue" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
