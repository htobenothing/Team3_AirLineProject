<%@ Page Title="" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="SearchFlight.aspx.cs" Inherits="Team3_AirLineProject.view.SearchFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblFrom" runat="server" Text="From:"></asp:Label></td>
            <td>
                <asp:DropDownList ID="FromDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="FromDropDown_SelectedIndexChanged" DataTextField="startCity" DataValueField="startCity"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FromDropDown" Display="Dynamic" ErrorMessage="Please select departure city!!!!" InitialValue="0" ValidateRequestMode="Enabled" ViewStateMode="Enabled">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTo" runat="server" Text="To:"></asp:Label></td>
            <td>
                <asp:DropDownList ID="ToDropDownList" runat="server" AutoPostBack="True" DataTextField="endCity" DataValueField="endCity"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ToDropDownList" Display="Dynamic" ErrorMessage="Please select destination city!!!" InitialValue="0" ValidateRequestMode="Enabled" ViewStateMode="Enabled">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>No. Of Passenger:</td>
            <td>
                <asp:TextBox ID="passengerNoTxt" runat="server" BorderStyle="Double" ForeColor="Black"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="passengerNoTxt" ErrorMessage="Please enter number of passengers !">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="passengerNoTxt" ErrorMessage="Please enter valid passenger number!" ValidationExpression="^\d$">*</asp:RegularExpressionValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="passengerNoTxt" ErrorMessage="Please enter between 1 and 6!" MaximumValue="6" MinimumValue="1">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="DepartureLbl" runat="server" Text="Departure Date:"></asp:Label></td>
            <td>
                <asp:TextBox ID="DepDateTxt" runat="server" AutoPostBack="True" ForeColor="Black" BorderStyle="Double"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DepDateTxt" ErrorMessage="Please select date from calender!">*</asp:RequiredFieldValidator>--%>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar.png" OnClick="ImageButton1_Click" />
            </td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged1" OnDayRender="Calendar1_DayRender"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>

        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="FinfFlightBtn" runat="server" Text="Find Flight" OnClick="FinfFlightBtn_Click" BorderStyle="Solid" Font-Bold="True" /></td>

        </tr>

    </table>


</asp:Content>
