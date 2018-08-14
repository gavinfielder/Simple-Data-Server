<%@ Page Title="Send Data" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SendData.aspx.cs" Inherits="testDeploy.SendData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Send Data</h1>
    <p>This page allows you to send data to the server</p>
    <h2>DISCONNECTED</h2>
    <p>The data service has been disconnected as of 8/14/2018.</p>
    <div>
        ID: <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
    &nbsp; Value: <asp:TextBox ID="ValueTextBox" runat="server"></asp:TextBox> <asp:Button ID="SendButton" runat="server" Text="Send" OnClick="SendButtonClick" /> 
    </div>
    <br />
        <asp:Label ID="StatusDisplay" runat="server"></asp:Label>


    


</asp:Content>
