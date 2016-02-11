<%@ Page Title="" Language="C#" MasterPageFile="~/userM/NestedMasterUser.master" AutoEventWireup="true" CodeBehind="SelectPassenger.aspx.cs" Inherits="Team3_AirLineProject.userM.SelectPassenger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">

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
    </asp:GridView>

    <asp:Button ID="BookFlightBtn" CssClass="button1" runat="server" Text="BookNow" OnClick="Button1_Click" BorderStyle="Solid" Font-Bold="True" />
    <asp:Button ID="AddPsnBtn" CssClass="button1" runat="server" Text="Add Passenger" OnClick="AddPsnBtn_Click" Font-Bold="True" />
    
</asp:Content>
