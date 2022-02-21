<%@ Page Title="HCPCS Coder" Language="C#" MasterPageFile="~/MasterPages/FrontEnd.Master" AutoEventWireup="true" CodeBehind="HCPCS.aspx.cs" Inherits="UrologyNursing.HCPCS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div class="title">
        <asp:Label ID="lblHCPCS" runat="server" Text="HCPCS Coder"></asp:Label>
    </div>
    <br />
    <div style="float: left">
        <asp:Label ID="lblSupply" runat="server" Text="Supply: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:DropDownList ID="ddlSupply" runat="server" DataSourceID="dsSupplies" DataTextField="supplyName" DataValueField="supplyID" OnSelectedIndexChanged="ddlSupply_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True" BackColor="AliceBlue" ForeColor="Blue" Font-Size="Medium">
            <asp:ListItem Text="--Choose a Supply--" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="dsSupplies" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [supplyID], [supplyName], [HCPCSCode] FROM [Supplies]"></asp:SqlDataSource>
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <br /><br /><br /><br />
        <asp:Label ID="lblSupplyCode" runat="server" Text="Supply HCPCS: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:Label ID="lblSupplyHCPCS" runat="server" BackColor="AliceBlue" BorderStyle="Outset" Font-Size="Large" ForeColor="Blue" Visible="False" Width="100px" Style="text-align: center"></asp:Label>
    </div>

    <div style="float: left">
        <asp:Label ID="lblMedication" runat="server" Text="Medication: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:DropDownList ID="ddlMedication" runat="server" DataSourceID="dsMedications" DataTextField="brandMedication" DataValueField="medicationID" OnSelectedIndexChanged="ddlMedication_SelectedIndexChanged" AutoPostBack="True" AppendDataBoundItems="True" BackColor="AliceBlue" Font-Size="Medium" ForeColor="Blue">
             <asp:ListItem Text="--Choose a Medication--" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="dsMedications" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [medicationID], [brandMedication], [HCPCSCode] FROM [Medications] WHERE HCPCSCode <> '' "></asp:SqlDataSource>
        <br /><br /><br /><br />
        <asp:Label ID="lblMedicationCode" runat="server" Text="Medication HCPCS: " ForeColor="Blue" Font-Bold="True"></asp:Label><br />
        <asp:Label ID="lblMedicationHCPCS" runat="server" BackColor="AliceBlue" BorderStyle="Outset" Font-Size="Large" ForeColor="Blue" Visible="False" Width="100px" Style="text-align: center"></asp:Label>
    </div>
</asp:Content>
