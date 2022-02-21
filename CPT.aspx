<%@ Page Title="CPT Coder" Language="C#" MasterPageFile="~/MasterPages/FrontEnd.Master" AutoEventWireup="true" CodeBehind="CPT.aspx.cs" Inherits="UrologyNursing.CPT" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div class="title">
        <asp:Label ID="lblCPT" runat="server" Text="CPT Coder"></asp:Label>
    </div>
    <br />
    <div style="float: left">
        <asp:Label ID="lblProcedure" runat="server" Text="Procedure: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:DropDownList ID="ddlProcedure" runat="server" DataSourceID="dsProcedure" DataTextField="procedureName" DataValueField="procedureID" OnSelectedIndexChanged="ddlProcedure_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True" Width="425px" BackColor="AliceBlue" Font-Bold="True" ForeColor="Blue" Font-Size="Small">
            <asp:ListItem Text="--Choose a Procedure--" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="dsProcedure" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [procedureID], [procedureName], [CPTCode] FROM [Surgeries]"></asp:SqlDataSource>
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <br /><br /><br /><br />
        <asp:Label ID="lblProcedureCode" runat="server" Text="CPT Code:  " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:Label ID="lblProcedureCPT" runat="server" style="text-align:center" BackColor="AliceBlue" BorderStyle="Outset" Font-Bold="True" ForeColor="Blue" Font-Size="Large" Visible="False" Width="100px"></asp:Label>
    </div>
    <div style="float: left">
        <asp:Label ID="lblImaging" runat="server" Text="Imaging: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:DropDownList ID="ddlImaging" runat="server" DataSourceID="dsImaging" DataTextField="imagingName" DataValueField="imagingID" OnSelectedIndexChanged="ddlImaging_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True" Width="425px" BackColor="AliceBlue" Font-Bold="True" ForeColor="Blue" Font-Size="Small">
            <asp:ListItem Text="--Choose Imaging--" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="dsImaging" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [imagingID], [imagingName], [CPTCode] FROM [Imaging]"></asp:SqlDataSource>
        <br /><br /><br /><br />
        <asp:Label ID="lblImagingCode" runat="server" Text="CPT Code:  " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:Label ID="lblImagingCPT" runat="server" Text="" style="text-align:center" BackColor="AliceBlue" BorderStyle="Outset" Font-Bold="True" ForeColor="Blue" Font-Size="Large" Visible="False" Width="100px"></asp:Label>
    </div>
</asp:Content>
