<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="AddFlight.aspx.cs" Inherits="Team3_AirLineProject.staff.AddFlight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <asp:Label ID="Label1" runat="server" Text="flightID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="start city"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Solid"></asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="end city"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="start time"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="end time"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="price"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="totalSeatNo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" BorderStyle="Solid"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label8" runat="server" Text="status"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" Text="avaliable" GroupName="status" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" Text="unavaliable" GroupName="status" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="cancel" OnClick="Button2_Click" />
    <br />
    <br />
    <br />

</asp:Content>
