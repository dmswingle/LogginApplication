<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoggingC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
     <div class="row">
        <div>
            <label for="message">Message</label>
            <asp:RequiredFieldValidator ControlToValidate="message" Text="You must supply a message"></asp:RequiredFieldValidator>
            <input id="message" type="text" runat="server"/>
            <label for="severity">Severity</label>
            <select id="severity" runat="server">
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
            </select>
            <asp:Button runat="server" Text="Add Log" OnClick="AddLog" CausesValidation="true"/>
        </div>
         
    </div>
    <div class="row">
        <div>
            <label for="refMessage">Message</label>
            <input id="refMessage" type="text" runat="server"/>
            <label for="refSeverity">Severity</label>
            <select id="refSeverity" runat="server">
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
            </select>
            <asp:Button runat="server" Text="Get last Log" OnClick="GetLastLog" CausesValidation="false"/>
            
        </div>
    </div>
   

</asp:Content>
