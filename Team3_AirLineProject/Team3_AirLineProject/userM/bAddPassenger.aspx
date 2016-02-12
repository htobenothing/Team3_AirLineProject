<%@ Page Title="" Language="C#" MasterPageFile="~/userM/NestedMasterUser.master" AutoEventWireup="true" CodeBehind="bAddPassenger.aspx.cs" Inherits="Team3_AirLineProject.userM.bAddPassenger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

    <div style="margin: auto; width: 440px; height: 440px;" class="contenthold">
        <table style="width: 100%; height: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Passport NO" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Date of Birth" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Gender" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="male" Font-Size="Large" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female" Font-Size="Large" /></td>
            </tr>

            <tr>

                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="button1" OnClick="Button1_Click" Text="submit" /></td>
                <td>
                    <a class="button1" href="SelectPassenger.aspx">Cancel</a></td>

            </tr>
        </table>
    </div>
</asp:Content>
