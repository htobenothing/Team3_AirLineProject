<%@ Page Title="" Language="C#" Theme="table" MasterPageFile="~/userM/NestedMasterUser.master" AutoEventWireup="true" CodeBehind="ViewHistory.aspx.cs" Inherits="Team3_AirLineProject.userM.ViewHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" runat="server">
    <div style="width:100%">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="FromDate :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFDT" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" ImageUrl="~/images/calendar.png" OnClick="ImageButton1_Click1" />
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ToDate :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTDT" runat="server"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageUrl="~/images/calendar.png" OnClick="ImageButton2_Click1" />
                </td>
                <td>
                    <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" CssClass="button1" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" SkinID="resultTable">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>

</asp:Content>
