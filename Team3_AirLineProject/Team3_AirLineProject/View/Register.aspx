<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Team3_AirLineProject.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-card">
        <h1>Register</h1>
            <asp:TextBox runat="server" ID="txtUser" placeholder="Enter your email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valEmail1" runat="server" ControlToValidate="txtUser" ValidationExpression="^\w+@\w+?\.[a-zA-Z]{2,3}$" ErrorMessage="The Email format not correct" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br /><asp:CustomValidator ID="valEmail2" runat="server" ControlToValidate="txtUser" OnServerValidate="Userid_ServerValidate" ForeColor="Red" Display="Dynamic"></asp:CustomValidator><asp:Label runat="server" ID="labmessage" ForeColor="Red"></asp:Label>
            <asp:TextBox runat="server" TextMode="Password" ID="txtPassword" placeholder="Enter your Password"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valPassword" runat="server"  ControlToValidate="txtPassword"  ValidationExpression="^.{8,}$" ErrorMessage="Password should be at least 8 character" ForeColor="Red"></asp:RegularExpressionValidator>
            <asp:TextBox runat="server" TextMode="Password" ID="txtConfirmPassword" placeholder="Confirm Your Password" ></asp:TextBox>
            <asp:CompareValidator runat="server" ID="valConfirmPwd" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Password should be the same" ForeColor="Red"></asp:CompareValidator>
            <asp:TextBox runat="server" ID="txtPhoneNumber" placeholder="Enter your Phone Number"></asp:TextBox>
            <asp:RegularExpressionValidator ID="valPhone" runat="server" ControlToValidate="txtPhoneNumber" ValidationExpression="^\d{8}$" ErrorMessage="Telephone Number should be 8 didgits" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <asp:Button runat="server" ID="btnConfirm" text="Confirm" OnClick="btnConfirm_Click"  />
            <asp:Button runat="server" ID="btnCancel" text="Cancel"  />
    </div>

</asp:Content>
