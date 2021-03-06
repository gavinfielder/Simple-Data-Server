﻿<%@ Page Title="View Data" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="testDeploy.ViewData" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>View Data</h1>
    <p>This page allows you to view all the stored data.</p>
    <h2>DISCONNECTED</h2>
    <p>The data service has been disconnected as of 8/14/2018.</p>
    <asp:Button ID="RefreshDataButton" runat="server" Text="Refresh" />
    <br />
    <asp:Table ID="DataTable" runat="server" BorderStyle="Solid" CellPadding="5" CellSpacing="5" GridLines="Both">
    </asp:Table>

</asp:Content>

