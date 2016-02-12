<%@ Page Title="" Theme="table" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="FlightResult.aspx.cs" Inherits="Team3_AirLineProject.view.FlightResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function RadioCheck(rb) {
            var gv = document.getElementById("<%=flightgridView.ClientID%>");
            var rbs = gv.getElementsByTagName("input");
            var row = rb.parentNode.parentNode;
            for (var i = 0; i < rbs.length; i++) {
                if (rbs[i].type == "radio") {
                    if (rbs[i].checked && rbs[i] != rb) {
                        rbs[i].checked = false;
                        break;
                    }
                }
            }
        }
    </script>

    <asp:GridView ID="flightgridView" runat="server" SkinID="maintainTable" Width="600px" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Select" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" >
                <ItemTemplate>
                    <asp:RadioButton ID="RadioButton1" onclick="RadioCheck(this);" runat="server" />
                </ItemTemplate>

                <ControlStyle ></ControlStyle>

                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
            </asp:TemplateField>
            <asp:BoundField DataField="Flight No." HeaderText="Flight No." />
            <asp:BoundField DataField="Departure Time" HeaderText="Departure Time" />
            <asp:BoundField DataField="Arrival Time" HeaderText="Arrival Time" />
            <asp:BoundField DataField="Price" HeaderText="Price" />

        </Columns>
        <RowStyle HorizontalAlign="center"></RowStyle>
 
    </asp:GridView>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Select Passenger" OnClick="Button1_Click"  CssClass="button1" />

</asp:Content>
