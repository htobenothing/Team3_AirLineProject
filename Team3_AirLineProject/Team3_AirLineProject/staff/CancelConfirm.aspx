<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="CancelConfirm.aspx.cs" Inherits="Team3_AirLineProject.staff.CancelConfirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

    <br />
    <asp:Label ID="Label1" runat="server" Text="Booking has been cancelled!!!!" Font-Bold="True" Font-Size="XX-Large" ForeColor="Red" Font-Underline="True"></asp:Label>
    <br /><br /><br />

    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
              <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" Text="Cancellation Details :---"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Booking ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="bookinfIdLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Flight ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="flightIdLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style3"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Medium" Text="Departure Date"></asp:Label>
            </td>
            <td>
                <asp:Label ID="departuredateLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Departure City"></asp:Label>
            </td>
            <td>
                <asp:Label ID="departCityLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="departTimeLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Arrival City"></asp:Label>
            </td>
            <td>
                <asp:Label ID="arrivalCityLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="arrivalTimeLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Booking Status"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="CANCELLED!!!!" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Passenger Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="pasngrNameLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Passport No."></asp:Label>
            </td>
            <td>
                <asp:Label ID="passportNoLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Total Price(S$)"></asp:Label>
            </td>
            <td>
                <asp:Label ID="totalPriceLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
