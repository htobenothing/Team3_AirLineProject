<%@ Page Title="" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Team3_AirLineProject.admin.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
    <div style="margin: auto; width: 600px; height: 400px;" class="contenthold">
        <table style="width: 100%; height: 100%;">
            <tr>
                <td style="width:180px;">
                    <asp:Label ID="Label1" runat="server" Text="User ID" Font-Size="X-Large"></asp:Label></td>
                <td style="width:200PX;">
                    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BorderColor="Red" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please enter UserID" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="Label6" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="please enter password" ForeColor="Red"></asp:RequiredFieldValidator></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Phone NO" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="please enter phone NO" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please input a valid phone NO" ForeColor="Red" MaximumValue="14" MinimumValue="8" Type="Integer"></asp:RangeValidator>

                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Status" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rdblStatus" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="active" Value="active"></asp:ListItem>
                        <asp:ListItem Text="inactive" Value="inactive"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Role" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButtonList ID="rdblRole" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="staff" Value="staff"></asp:ListItem>
                        <asp:ListItem Text="user" Value="user"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>

            </tr>

            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" CssClass="button1" />
                </td>
                <td><a class="button1" href="MaintainUser.aspx">Cancel</a>
                    </td>
            </tr>
            </table>
        </div>

</asp:Content>
