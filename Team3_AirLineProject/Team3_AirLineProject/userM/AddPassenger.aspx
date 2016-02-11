<%@ Page Title="" Language="C#" MasterPageFile="~/userM/NestedMasterUser.master" AutoEventWireup="true" CodeBehind="AddPassenger.aspx.cs" Inherits="Team3_AirLineProject.userM.AddPassenger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
        <asp:Label ID="Label1" runat="server" Text="name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="passport NO"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="date of birth"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="cancel" />
    <br />
    <br />

</asp:Content>
