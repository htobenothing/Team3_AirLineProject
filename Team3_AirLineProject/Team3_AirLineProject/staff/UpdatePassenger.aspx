<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="UpdatePassenger.aspx.cs" Inherits="Team3_AirLineProject.staff.UpdatePassenger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

    <div style="margin: auto; width: 440px; height: 340px;" class="contenthold">
        <table style="width: 100%; height: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Passport NO" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Gender" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="female" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" CssClass="button1" /></td>
                <td>
                    <a class="button1" href="MaintainPassenger.aspx">Cancel</a></td>
            </tr>

        </table>
    </div>

</asp:Content>
