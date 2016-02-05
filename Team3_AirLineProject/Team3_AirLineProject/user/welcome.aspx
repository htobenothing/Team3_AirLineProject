<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="Team3_AirLineProject.userPage.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Hello, Nice to meet you
    <asp:Label runat="server" ID="labMessage"></asp:Label>
</asp:Content>
