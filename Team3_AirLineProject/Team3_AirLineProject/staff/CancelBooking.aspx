<%@ Page Title="" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="CancelBooking.aspx.cs" Inherits="Team3_AirLineProject.staff.CancellBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="contenthold">
     <table style="width:40%;">
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
                <asp:TextBox ID="bookinIdTxt" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="bookinIdTxt" ErrorMessage="Please enter booking ID!!!">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="bookinIdTxt" ErrorMessage="Please enter valid booking ID!!!" ValidationExpression="^[0-9]+$">*</asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        
    </table>
     <asp:Label ID="Label2" runat="server" ForeColor="Red" ></asp:Label>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Cancel Booking" BorderStyle="Solid" Font-Bold="True" OnClick="Button1_Click"  CssClass="button1" />
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>
</asp:Content>
