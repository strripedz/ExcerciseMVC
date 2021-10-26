<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Excercise2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Search Book</h2>
            <p>
                Please enter book name or book ID into the search box.
            </p>
            <p>
                <asp:TextBox ID="SearchBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" onclick="ButtonSearch_Click" Text="Search" /> 
            </p>
        </div>
        <div id="resultContainer" class="col-md-4">
            <h2>Result</h2>
            <p>
                This is where the list of book will be returned
            </p>
            <p>
                <asp:Button ID="Button2" runat="server" onclick="ButtonBook_Click" Text="Search" /> 
            </p>
        </div>
    </div>

</asp:Content>
