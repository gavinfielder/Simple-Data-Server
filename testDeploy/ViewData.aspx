<%@ Page Title="View Data" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="testDeploy.ViewData" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>View Data</h1>
    <p>This page allows you to view all the stored data.</p>
    <asp:Button ID="RefreshDataButton" runat="server" Text="Refresh" />
    <asp:Table ID="DataTable" runat="server">
    </asp:Table>

</asp:Content>

