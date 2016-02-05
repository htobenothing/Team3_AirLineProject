<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Team3_AirLineProject.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-card">
        <h1>Register</h1>
            <asp:TextBox runat="server" ID="txtUser" placeholder="Enter your email"></asp:TextBox>
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" placeholder="Enter your Password"></asp:TextBox>
            <asp:TextBox runat="server" TextMode="Password" ID="txtConfirmPassword" placeholder="Enter your Password Again"></asp:TextBox>
            <asp:TextBox runat="server" ID="txtPhoneNumber" placeholder="Enter your Phone Number"></asp:TextBox>
            <asp:Button runat="server" ID="btnConfirm" text="Confirm"  />
            <asp:Button runat="server" ID="btnCancel" text="Cancel"  />

    </div>

</asp:Content>
