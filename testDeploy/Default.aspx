<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="testDeploy._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Simple Data Server</h1>
    <p>This web app handles a persistent data source which stores an ID, a floating-point value, and a timestamp.</p>
    
    <p>I am building this as an educational tool. My learning goals for this project are:</p>
    <ul><li>ASP.Net</li>
        <li>SignalR (coming soon)</li>
        <li>SQL Server (coming soon)</li>
        <li>WCF (potentially coming soon)</li>
        <li>Deployment on AWS using EC2, Elastic Beanstalk, and AWS toolkit for Visual Studio</li>
    </ul>

    <p><a href="https://github.com/gavinfielder/Simple-Data-Server">View on GitHub</a></p>

    <h2>Getting Started</h2>
    <p>To start, you can send data using the <a runat="server" href="~/SendData">Send Data</a> page. You can view existing records with the <a runat="server" href="~/ViewData">View Data</a> page.</p>
    <h2>Current System</h2>
    <ul><li>Current data model: RAM only (data is not persistent). WIP</li></ul>





    <!---
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
        --->

</asp:Content>
