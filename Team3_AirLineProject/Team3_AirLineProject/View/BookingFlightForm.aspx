<%@ Page Title="" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="BookingFlightForm.aspx.cs" Inherits="Team3_AirLineProject.BookingFlightForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    

    <asp:GridView ID="SelectPessengerView" runat="server" MultiSelect="true" Width="462px">
        <Columns>            
        <asp:TemplateField HeaderText="Select" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" ControlStyle-BorderStyle="Solid" ControlStyle-BorderColor="Black">
                <ItemTemplate>
                    <asp:CheckBox ID="selectPasngrChkBox" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle HorizontalAlign="center"></RowStyle>
    </asp:GridView><br><br><br><br>

    <asp:Button ID="BookFlightBtn" runat="server" Text="Book Now" style="margin-left: 115px" Width="135px" OnClick="Button1_Click" BorderStyle="Solid" Font-Bold="True" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="AddPsnBtn" runat="server" Text="Add New Passenger" Width="143px" OnClick="AddPsnBtn_Click" style="margin-left: 58px" BorderStyle="Solid" Font-Bold="True" />
    </br>
    </asp:Content>
