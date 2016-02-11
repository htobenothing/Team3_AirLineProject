<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="BookingConfirmation.aspx.cs" Inherits="Team3_AirLineProject.staff.BookingConfirmation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

    
    <table style="width: 100%;">
        <asp:Label ID="Label1" runat="server" Text="Itinerary Information" Font-Bold="True" Font-Size="XX-Large" ForeColor="#009933" Font-Underline="True"></asp:Label>

        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Booking ID"></asp:Label>
            </td>
            <td>
                <asp:Label ID="bookinfIdLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
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
            <td class="auto-style2" style="height: 20px"></td>
            <td class="auto-style3" style="height: 20px"></td>
            <td class="auto-style3" style="height: 20px"></td>
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

        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" Text="Arrival City"></asp:Label>
            </td>
            <td>
                <asp:Label ID="arrivalCityLbl" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Label ID="arrivalTimeLbl" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Booking Status"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="CONFIRMED!!"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Passenger Name"></asp:Label>
            </td>
            <td>
                <asp:Label ID="pasngrNameLbl" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Passport No."></asp:Label>
            </td>
            <td>
                <asp:Label ID="passportNoLbl" runat="server"></asp:Label>
            </td>

        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>

        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Total Price(S$)"></asp:Label>
            </td>
            <td>
                <asp:Label ID="totalPriceLbl" runat="server"></asp:Label>
            </td>

        </tr>
    </table>
    <br />

</asp:Content>
