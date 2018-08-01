<%@ Page MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ViewLog.aspx.cs" Inherits="testDeploy.ViewLog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Application Log</h1>
    <div>
        <asp:TextBox 
            ID="LogDisplay" 
            runat="server"  
            Height="271px" 
            ReadOnly="True" 
            Width="812px" 
            TextMode="MultiLine"
            HorizontalAlignment="Left"
            VerticalAlignment="Top" Wrap="False"
            ></asp:TextBox>
    </div>

</asp:Content>
