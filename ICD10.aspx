<%@ Page Title="ICD-10 Coder" Language="C#" MasterPageFile="~/MasterPages/FrontEnd.Master" AutoEventWireup="true" CodeBehind="ICD10.aspx.cs" Inherits="UrologyNursing.ICD10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <div class="title">
        <asp:Label ID="lblICD10" runat="server" Text="ICD-10 Coder"></asp:Label>
    </div>
    <br /><br />
    <asp:Label ID="lblDiagnosis" runat="server" Text="Diagnosis: " Font-Bold="True" ForeColor="Blue"></asp:Label><br />
    <asp:DropDownList ID="ddlICD10Code" runat="server" DataSourceID="dsConditions" DataTextField="condition" DataValueField="conditionID" ForeColor="Blue" BackColor="AliceBlue" Font-Bold="True" Font-Size="Medium" OnSelectedIndexChanged="ddlICD10Code_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="True">
        <asp:ListItem Text="--Choose a Diagnosis--" Value="-1"></asp:ListItem>
    </asp:DropDownList>
    <asp:SqlDataSource ID="dsConditions" runat="server" ConnectionString="<%$ ConnectionStrings:dbUrologyConnectionString %>" SelectCommand="SELECT [conditionID], [condition] FROM [Conditions]"></asp:SqlDataSource>
    <br /><br /><br />
    <asp:Label ID="lblCode" runat="server" Text="ICD-10 Code: " Font-Bold="True" ForeColor="Blue"></asp:Label><br />
    <asp:Label ID="lblICD10Code" runat="server" Style="text-align:center" BackColor="AliceBlue" BorderStyle="Outset" Font-Bold="True" ForeColor="Blue" Font-Size="Large" Visible="False" Width="100px"></asp:Label>
   
</asp:Content>
