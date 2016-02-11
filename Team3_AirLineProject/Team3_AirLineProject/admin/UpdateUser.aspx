<%@ Page Title="" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Team3_AirLineProject.admin.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="UserID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="please input password" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="phone no"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="please input phone NO" ForeColor="Red"></asp:RequiredFieldValidator>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="valPhone" runat="server" ControlToValidate="TextBox2" ValidationExpression="^\d{8}$" ErrorMessage="Telephone Number should be 8 didgits" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
         

    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="status"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButtonList runat="server" ID="rdblStatus" RepeatDirection="Horizontal"> 
        <asp:ListItem Text="active" Value="active"></asp:ListItem>
        <asp:ListItem Text="inactive" Value="inactive"></asp:ListItem>
    </asp:RadioButtonList>
        <asp:Label ID="Label6" runat="server" Text="role"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButtonList runat="server" ID="rdblRole" RepeatDirection="Horizontal">
        <asp:ListItem Text="staff" Value="staff"></asp:ListItem>
        <asp:ListItem Text="user" Value="user"></asp:ListItem>
    </asp:RadioButtonList>

    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="cancel" />
&nbsp;
</asp:Content>
