<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddStudent.aspx.cs" Inherits="WebApplication1.AddStudent" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add Student</h1>


    <h2>Welcome</h2>
    <hr />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <h4>Input Name</h4>
    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
    <h4>Input Age</h4>
    <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox><br />
    <h4>Input Id Subject</h4>
    <asp:TextBox ID="TxtIdSubject" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" CssClass="btn-success" runat="server" OnClick="Button1_Click" Text="Save" />
    <br />

    <asp:Repeater ID="RepeaterStudents" runat="server" OnItemCommand="RepeaterStudents_ItemCommand">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>Name</td>
                    <td>Age</td>
                    <td>Id Suject</td>
                    <td>Avarage</td>
                </tr>
                <br />
        </HeaderTemplate>
        <ItemTemplate>
            <tr style="background-color: #ffffff">
                <td>
                    <tr>
                        <td><%# Eval("Name") %> </td>
                        <td><%# Eval("Age") %> </td>
                        <td><%# Eval("IdSubject") %> </td>
                        <%--<td><%# Eval("Avarage") %> </td>--%>

                        <td>
                            <%--<asp:LinkButton ID="edit" runat="server" CommandArgument='<%# Eval("IdSubject") %>' CommandName="edit">Edit</asp:LinkButton>--%>
                            <asp:HyperLink runat="server" ID="hlEdit" NavigateUrl='<%# Eval("IdStudent","~/EditStudent?id={0}") %>'>edit</asp:HyperLink>
                            <asp:LinkButton ID="delete" runat="server" CommandArgument='<%# Eval("IdStudent") %>' CommandName="delete">delete</asp:LinkButton>

                        </td>
                    </tr>
                </td>
        </ItemTemplate>
    </asp:Repeater>


</asp:Content>
