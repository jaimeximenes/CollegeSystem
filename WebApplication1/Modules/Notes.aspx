<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Notes.aspx.cs" Inherits="WebApplication1.Notes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add Notes</h1>


    <h2>Welcome</h2>
    <hr />
    <asp:TextBox ID="txtNote4" runat="server"></asp:TextBox><br />

    <h4>Input Note 1</h4>
    <br />
    <asp:TextBox ID="txtNote1" runat="server"></asp:TextBox><br />
    <h4>Input Note 2</h4>
    <br />
    <asp:TextBox ID="txtNote2" runat="server"></asp:TextBox><br />
    <h4>Input Note 3</h4>
    <br />
    <asp:TextBox ID="txtNote3" runat="server"></asp:TextBox><br />
    <h4>Input Note 4</h4>
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    <asp:Repeater ID="RepeaterNotes" OnItemCommand="RepeaterNotes_ItemCommand" runat="server">
        <HeaderTemplate>
            <table>
                <tr>
                    <td>Name</td>
                    <td>Note 1</td>
                    <%-- <td>Note 2</td>
                        <td>Note 3</td>
                        <td>Note 4</td>--%>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Name") %> </td>
                    <td><%# DataBinder.Eval(Container.DataItem, "Note1") %> </td>


                    <%-- <td><%# Eval("Name") %> </td>
                        <td><%# Eval("Note1") %> </td>--%>
                    <%--<td><%# Eval("Note3") %> </td>
                            <td><%# Eval("Note4") %> </td>
                            <td><%# Eval("Avarage") %> </td>--%>
                    <td>
                        <asp:LinkButton ID="edit" runat="server" CommandArgument='<%# Eval("Idsubjects") %>' CommandName="edit">Editar Notas</asp:LinkButton>
                        <asp:LinkButton ID="delet" runat="server" CommandArgument='<%# Eval("IdSubjects") %>' CommandName="delet">Delet</asp:LinkButton>

                    </td>

                </td>
                
        </ItemTemplate>
    </asp:Repeater>

    <br />
    <h4>Input Id Professor</h4>
    <asp:TextBox ID="txtIdProfessor" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" CssClass="btn-success" runat="server" Text="Save" />
    <br />

    </body>
    </html>

</asp:Content>
