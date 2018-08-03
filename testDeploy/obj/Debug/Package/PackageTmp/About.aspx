<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="testDeploy.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>About</h2>
    <ul>
        <li>Written in C# using Visual Studio</li>
        <li>Author Gavin Fielder, August 2018</li>
    </ul>
    <h3>Current System Configuration</h3>
    <ul>
        <li>Data layer: Microsoft SQL Server Express 14.00.3015.40.v1 deployed on Amazon RDS</li>
        <li>Website and WCF service deployed on Amazon EC2.</li>
    </ul>
    <h3>Design</h3>
    <p>The design uses a non-scaffolded MVC. Interfaces are used for easy extensibility.</p>

    <asp:Image ID="Image1" runat="server" Height="424px" ImageUrl="https://i.imgur.com/QHEfSOq.png" Width="861px" />
    
</asp:Content>
