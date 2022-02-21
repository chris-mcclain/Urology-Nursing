<%@ Page Title="Global Days" Language="C#" MasterPageFile="~/MasterPages/FrontEnd.Master" AutoEventWireup="true" CodeBehind="GlobalDays.aspx.cs" Inherits="UrologyNursing.GlobalDays" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div class="title">
        <asp:Label ID="lblGlobalDays" runat="server" Text="Global Days"></asp:Label>
    </div>
    <br />
    <asp:Label ID="lblProcedure" runat="server" Text="Procedure: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
    <asp:DropDownList ID="ddlProcedure" runat="server" DataSourceID="dsProcedure" DataTextField="procedureName" DataValueField="procedureID" OnSelectedIndexChanged="ddlProcedure_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True" Width="425px" BackColor="AliceBlue" Font-Bold="True" ForeColor="Blue" Font-Size="Small">
        <asp:ListItem Text="--Choose a Procedure--" Value="-1"></asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="dsProcedure" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [procedureID], [procedureName], [CPTCode] FROM [Surgeries]"></asp:SqlDataSource>
    <br /><br /><br /><br />
    <asp:Label ID="lblGlobalLabel" runat="server" Text="Global Days:  " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
    <asp:Label ID="lblGlobalNumber" runat="server" style="text-align:center" BackColor="AliceBlue" BorderStyle="Outset" Font-Bold="True" ForeColor="Blue" Font-Size="Large" Visible="False" Width="100px"></asp:Label>
</asp:Content>
