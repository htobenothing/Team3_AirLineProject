<%@ Page Title="" Language="C#" MasterPageFile="~/userM/NestedMasterUser.master" AutoEventWireup="true" CodeBehind="UpdatePassenger.aspx.cs" Inherits="Team3_AirLineProject.userM.UpdatePassenger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div style="margin: auto; width: 300px; height: 200px;"  class="contenthold">
        <table style="height: 100%; width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Style="height: 22px"></asp:TextBox></td>
            </tr>

            <tr>
                <td style="height: 43px">
                    <asp:Label ID="Label2" runat="server" Text="Passport No" Font-Size="X-Large"></asp:Label></td>
                <td style="height: 43px">
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Gender" Font-Size="X-Large" Font-Strikeout="False"></asp:Label></td>

                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female" />

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="button1" OnClick="Button1_Click" Text="submit" /></td>
                <td>
                     <a class="button1" href="MaintainPassenger.aspx">Cancel</a></td>
            </tr>
        </table>
    </div>
</asp:Content>
