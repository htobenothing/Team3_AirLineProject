<%@ Page Title="" Language="C#" MasterPageFile="~/view/Main.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Team3_AirLineProject.admin.UpdateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >


    <div style="margin: auto; width: 650px; height: 400px;"class="contenthold">
        <table style="width: 100%; height: 100%;">
            <tr>
                <td style="width: 180px;">
                    <asp:Label ID="Label1" runat="server" Text="UserID" Font-Size="X-Large"></asp:Label></td>
                <td style="width: 180px;">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Password" Font-Size="X-Large"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="please input password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Phone No" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="please input phone NO" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="valPhone" runat="server" ControlToValidate="TextBox2" ValidationExpression="^\d{8}$" ErrorMessage="Telephone Number should be 8 didgits" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Status" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButtonList runat="server" ID="rdblStatus" RepeatDirection="Horizontal">
                        <asp:ListItem Text="active" Value="active"></asp:ListItem>
                        <asp:ListItem Text="inactive" Value="inactive"></asp:ListItem>
                    </asp:RadioButtonList></td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Role" Font-Size="X-Large"></asp:Label></td>
                <td>
                    <asp:RadioButtonList runat="server" ID="rdblRole" RepeatDirection="Horizontal">
                        <asp:ListItem Text="staff" Value="staff"></asp:ListItem>
                        <asp:ListItem Text="user" Value="user"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" CssClass="button1" /></td>
                <td><a class="button1" href="MaintainUser.aspx">Cancel</a>
                    </td>
            </tr>

        </table>
    </div>


</asp:Content>
