<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProfessor.aspx.cs" Inherits="WebApplication1.AddProfessor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <title></title>

    <body>
        <h1>Add Professor</h1>

        <div>
            <h2>Welcome</h2>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <hr />
            <br />
            <h3>Input the Name</h3>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
            <h4>Input CPF</h4>
            <asp:TextBox ID="TxtCPF" runat="server"></asp:TextBox><br />
            <h4>Input the Age</h4>
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox><br />
            <br />
            <asp:LinkButton ID="SaveTeacher" runat="server" OnClick="SaveTeacher_Click" Text="Save">Save</asp:LinkButton>

            <asp:Repeater ID="RepeaterTeacher" runat="server" OnItemCommand="RepeaterTeacher_ItemCommand">
                <HeaderTemplate>
                    <table>
                        <tr>
                            <td>Name</td>
                            <td>CPF</td>
                            <td>Age</td>
                            <td>Edit</td>
                            <td>Remove</td>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Name") %> </td>
                        <td><%# Eval("CPF") %> </td>
                        <td><%# Eval("Age") %> </td>
                        <td>
                            <asp:HyperLink runat="server" ID="hlEdit" NavigateUrl='<%# Eval("techarId","~/EditProfessor?id={0}") %>'>edit</asp:HyperLink>
                            <asp:LinkButton ID="Delete" runat="server" CommandArgument='<%# Eval("techarId")%>' CommandName="delete"> Delete </asp:LinkButton>
                        </td>
                        <td></td>
                    </tr>

                </ItemTemplate>

            </asp:Repeater>
    </body>

</asp:Content>
