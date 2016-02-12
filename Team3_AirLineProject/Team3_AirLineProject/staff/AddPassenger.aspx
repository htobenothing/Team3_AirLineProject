﻿<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="AddPassenger.aspx.cs" Inherits="Team3_AirLineProject.staff.AddPassenger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div style="margin:auto; width:400px; height:400px;" class="contenthold">
        <table style="width:100%; height:100%;" >
            <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Name" Font-Size="X-Large"></asp:Label></td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                </tr>

            <tr>
                <td> <asp:Label ID="Label2" runat="server" Text="Passport NO" Font-Size="X-Large"></asp:Label></td>
                <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
                </td>


            </tr>

            <tr>
                <td> <asp:Label ID="Label3" runat="server" Text="Date of Birth" Font-Size="X-Large"></asp:Label></td>
                <td> <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></td>
            </tr>

            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="Gender" Font-Size="X-Large"></asp:Label></td>
                <td><asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="male" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female"  /></td>
            </tr>

            <tr>
                
                <td> <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" CssClass="button1" /></td>
                <td><a class="button1" href="MaintainPassenger.aspx">Cancel</a></td>
            </tr>
        </table>


</asp:Content>
