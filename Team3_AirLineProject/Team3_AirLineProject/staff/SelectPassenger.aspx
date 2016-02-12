<%@ Page Title="" Theme="table" Language="C#" MasterPageFile="~/staff/NestedMasterStaff.master" AutoEventWireup="true" CodeBehind="SelectPassenger.aspx.cs" Inherits="Team3_AirLineProject.staff.SelectPassenger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div class="contenthold">

    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <asp:GridView ID="SelectPessengerView" runat="server" MultiSelect="true" Width="462px" SkinID="maintainTable">
        <Columns>
            <asp:TemplateField HeaderText="Select" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" >
                <ItemTemplate>
                    <asp:CheckBox ID="selectPasngrChkBox" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <RowStyle HorizontalAlign="center"></RowStyle>
    </asp:GridView>

    <asp:Button ID="BookFlightBtn" CssClass="button1" runat="server" Text="BookNow" OnClick="Button1_Click" BorderStyle="Solid" Font-Bold="True" />
    <asp:Button ID="AddPsnBtn" CssClass="button1" runat="server" Text="Add Passenger" OnClick="AddPsnBtn_Click" Font-Bold="True" />
        </div>
</asp:Content>
