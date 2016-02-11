<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="Team3_AirLineProject.staff.CancellBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Enter Booking ID   :"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="bookinIdTxt" runat="server" BorderStyle="Double"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="bookinIdTxt" ErrorMessage="Please enter booking ID!!!">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="bookinIdTxt" ErrorMessage="Please enter valid booking ID!!!" ValidationExpression="^[0-9]+$">*</asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
    <br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Cancel Booking" BorderStyle="Solid" Font-Bold="True" OnClick="Button1_Click" style="margin-left: 160px" Width="167px" />
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

</asp:Content>
