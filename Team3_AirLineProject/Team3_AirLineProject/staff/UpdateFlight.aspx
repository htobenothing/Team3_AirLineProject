<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="UpdateFlight.aspx.cs" Inherits="Team3_AirLineProject.staff.UpdateFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div style="margin: auto; width: 440px; height: 440px;" class="contenthold">

        <table style="width: 100%; height: 100%;">

            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="FilghtID"></asp:Label></td>
                <td>
                    <asp:Label ID="Label9" runat="server"></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Start City"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="End City"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Start Time"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="End Time"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Total Seat NO"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Status"></asp:Label></td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="active" GroupName="status" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:RadioButton ID="RadioButton2" runat="server" Text="inactive" GroupName="status" /></td>
            </tr>


            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" CssClass="button1" /></td>
                <td>
                   <a class="button1" href="MaintainFlight.aspx">Cancel</a></td>
            </tr>

        </table>
    </div>
</asp:Content>
