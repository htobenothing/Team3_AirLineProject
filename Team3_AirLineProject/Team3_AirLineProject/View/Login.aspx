<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Team3_AirLineProject.View.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-card">
        <h1>Log-in</h1>
            <asp:TextBox runat="server" ID="txtUser" placeholder="Enter your UserID"></asp:TextBox>
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" placeholder="Enter your Password"></asp:TextBox>
            <asp:Button runat="server" ID="btnlogin" text="login" OnClick="btnlogin_Click" />
        
        <div class="login-help">
            <a href="#">Register</a> • <a href="#">Forgot Password</a>
        </div>
    </div>
</asp:Content>
